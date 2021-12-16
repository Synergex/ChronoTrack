using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynPSGNetCore.Interop;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinSchedule;

namespace ChronoTrackNetUI.Forms
{
    public partial class ProjectView : Form
    {
        private SynInterop interop;
        private DataSet ganttDataSet;
        private Infragistics.Win.Appearance weekendApperance = new Infragistics.Win.Appearance();
        private Infragistics.Win.Appearance none = new Infragistics.Win.Appearance();
        private Infragistics.Win.Appearance projectWork = new Infragistics.Win.Appearance();
        private Infragistics.Win.Appearance requestWork = new Infragistics.Win.Appearance();

        private OwnersDataBinding owners;

        private DataTable userTable;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="i"></param>
        public ProjectView(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// set the required data sources
        /// </summary>
        /// <param name="user"></param>
        /// <param name="gantt"></param>
        public void SetDataSource(DataTable user, DataTable gantt)
        {

            userTable = user;

            buildUserList();

            ganttDataSet = new DataSet("GanttData");
            ganttDataSet.Tables.Add(user);
            ganttDataSet.Tables.Add(gantt);

            DataRelation keyRel = new DataRelation("Keys", user.Columns["User_id"], gantt.Columns["User_id"], false);
            ganttDataSet.Relations.Add(keyRel);

            ganttGridViewer.DataSource = ganttDataSet;

            //hide the required columns from the user table (band 0)
            ganttGridViewer.DisplayLayout.Bands[0].Columns["User_id"].Hidden = true;
            ganttGridViewer.DisplayLayout.Bands[0].Columns["Picture_file"].Hidden = true;
            ganttGridViewer.DisplayLayout.Bands[0].Columns["Visible"].Hidden = true;
            ganttGridViewer.DisplayLayout.Bands[0].Columns["Is_consultant"].Hidden = true;

            //hide the requried columns from the gantt view (band 1)
            ganttGridViewer.DisplayLayout.Bands[1].Columns["User_id"].Hidden = true;
            ganttGridViewer.DisplayLayout.Bands[1].Columns["Project_id"].Hidden = true;
            ganttGridViewer.DisplayLayout.Bands[1].Columns["Project_type"].Hidden = true;
            ganttGridViewer.DisplayLayout.Bands[1].Columns["Start_date"].Hidden = true;
            ganttGridViewer.DisplayLayout.Bands[1].Columns["End_date"].Hidden = true;
            ganttGridViewer.DisplayLayout.Bands[1].Columns["Outbound_travel_days"].Hidden = true;
            ganttGridViewer.DisplayLayout.Bands[1].Columns["Inbound_travel_days"].Hidden = true;

            ganttGridViewer.DisplayLayout.UseFixedHeaders = true;

            ganttGridViewer.DisplayLayout.Bands[0].Override.FixedHeaderIndicator = FixedHeaderIndicator.None;
            ganttGridViewer.DisplayLayout.Bands[1].Override.FixedHeaderIndicator = FixedHeaderIndicator.None;

            ganttGridViewer.DisplayLayout.Bands[0].Columns["Full_name"].Header.Fixed = true;
            ganttGridViewer.DisplayLayout.Bands[1].Columns["Description"].Header.Fixed = true;

            //sort column sizing
            ganttGridViewer.DisplayLayout.Bands[1].Columns[3].MinWidth = 200;

            //define colours
            weekendApperance.BackColor = Color.Bisque;
            projectWork.BackColor = Color.Red;
            requestWork.BackColor = Color.Blue;

            comboGanttMonth.SelectedIndex = DateTime.Today.Month;

            //define and load the calander details

            calendarInfo.Owners.UnassignedOwner.Visible = false;

            //need an owners binding source
            owners = this.calendarInfo.DataBindingsForOwners;
            owners.KeyMember = "User_id";
            owners.NameMember = "Full_name";
            owners.VisibleMember = "Visible";
            owners.SetDataBinding(ganttDataSet, "User");

            //now process the project/request as appointments
            AppointmentsDataBinding appointments = this.calendarInfo.DataBindingsForAppointments;
            appointments.DataKeyMember = "Project_id";
            appointments.StartDateTimeMember = "Start_date";
            appointments.EndDateTimeMember = "End_date";
            appointments.SubjectMember = "Description";
            appointments.OwnerKeyMember = "User_id";
            appointments.SetDataBinding(ganttDataSet, "GanttView");

        }

        /// <summary>
        /// allow synergy to set the focus
        /// </summary>
        public void SetFocus(int setView)
        {
            panelChart.Visible = true;
            switch (setView)
            {
                case 1: //gantt chart view
                    panelSelect.Visible = false;
                    panelCalendar.Visible = false;
                    ganttGridViewer.Dock = DockStyle.Fill;
                    panelCalendar.Visible = false;
                    panelGanttView.Dock = DockStyle.Fill;
                    panelGanttView.Visible = true;
                    ganttGridViewer.Focus();
                    break;
                case 2: //day view
                    panelSelect.Visible = true;
                    panelGanttView.Visible = false;
                    weekView.Visible = false;
                    monthView.Visible = false;
                    dayView.Dock = DockStyle.Fill;
                    dayView.Visible = true;
                    panelCalendar.Dock = DockStyle.Fill;
                    panelCalendar.Visible = true;
                    dayView.Focus();
                    break;
                case 3: //week view
                    panelSelect.Visible = true;
                    panelGanttView.Visible = false;
                    dayView.Visible = false;
                    monthView.Visible = false;
                    weekView.Dock = DockStyle.Fill;
                    weekView.Visible = true;
                    panelCalendar.Dock = DockStyle.Fill;
                    panelCalendar.Visible = true;
                    weekView.Focus();
                    break;
                case 4: //month view
                    panelSelect.Visible = true;
                    panelGanttView.Visible = false;
                    dayView.Visible = false;
                    weekView.Visible = false;
                    monthView.Dock = DockStyle.Fill;
                    monthView.Visible = true;
                    panelCalendar.Dock = DockStyle.Fill;
                    panelCalendar.Visible = true;
                    monthView.Focus();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Refresh the form data
        /// </summary>
        public void RefreshFormData()
        {
            clearGantt();
            setDayColour();
            fillGantt();
        }

        public string ProjectNumber
        {
            get
            {
                string projID = "";
                if (calendarInfo.SelectedAppointments.Count == 1)
                {
                    projID = calendarInfo.SelectedAppointments[0].DataKey.ToString();
                }
                return projID;
            }
        }

        private void setDayColour()
        {
            //first work out how many days to show
            int currentMonth = comboGanttMonth.SelectedIndex;
            ganttGridViewer.DisplayLayout.Bands[1].Columns[36].Hidden = false;
            ganttGridViewer.DisplayLayout.Bands[1].Columns[37].Hidden = false;
            ganttGridViewer.DisplayLayout.Bands[1].Columns[38].Hidden = false;

            switch (currentMonth)
            {
                case 2:
                    //check leap year!
                    ganttGridViewer.DisplayLayout.Bands[1].Columns[36].Hidden = true;
                    ganttGridViewer.DisplayLayout.Bands[1].Columns[37].Hidden = true;
                    ganttGridViewer.DisplayLayout.Bands[1].Columns[38].Hidden = true;
                    break;
                    //hide 31
                case 4:
                case 6:
                case 9:
                case 11:
                    //only show 30 days
                    ganttGridViewer.DisplayLayout.Bands[1].Columns[38].Hidden = true;
                    break;
                default:
                    //show all 31 days
                    break;
            }

            for (int i = 8; i < ganttGridViewer.DisplayLayout.Bands[1].Columns.Count; i++)
            {
                ganttGridViewer.DisplayLayout.Bands[1].Columns[i].Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center;
                ganttGridViewer.DisplayLayout.Bands[1].Columns[i].MinWidth = 25;
                ganttGridViewer.DisplayLayout.Bands[1].Columns[i].MaxLength = 25;
            }

            //work out what days are what
            DateTime d = new DateTime(DateTime.Today.Year, currentMonth, 1);
            for (int i = 0; i < 31; i++)
            {
                DateTime whichDate = d.AddDays(i);
                if (whichDate.Month != currentMonth) break;
                switch (whichDate.DayOfWeek)
                {
                    case System.DayOfWeek.Saturday:
                        colorAllRows(whichDate.Day);
                        break;
                    case System.DayOfWeek.Sunday:
                        colorAllRows(whichDate.Day);
                        break;
                }
            }
        }

        private void fillGantt()
        {
            DataTable gantt = ganttDataSet.Tables["GanttView"];
            
            ganttGridViewer.Rows.CollapseAll(true);

            int currentMonth = comboGanttMonth.SelectedIndex;

            //Now work through the gantt view table and colour the 
            //grid accordingly
            foreach (DataRow row in gantt.Rows)
            {
                string userID = row["User_id"].ToString();
                int projectID = int.Parse(row["Project_id"].ToString());
                DateTime startDate = (DateTime)row["Start_date"];
                DateTime endDate = (DateTime)row["End_date"];
                Infragistics.Win.Appearance app;
                //check we have current month!!
                if (startDate.Month == currentMonth || endDate.Month == currentMonth)
                {
                    switch (int.Parse(row["Project_type"].ToString()))
                    {
                        case 1:
                            app = projectWork;
                            break;
                        case 2:
                            app = requestWork;
                            break;
                        default:
                            app = none;
                            break;
                    }
                    setProjectVisible(userID, projectID, startDate, endDate, app);
                }
            }

            ganttGridViewer.Rows.ExpandAll(true);
        }
        
        private void colorAllRows(int cellNumber)
        {
            for (int ii = 0; ii < ganttGridViewer.Rows.Count; ii++)
            {
                for (int ij = 0; ij < ganttGridViewer.Rows[ii].ChildBands[0].Rows.Count; ij++)
                {
                    ganttGridViewer.Rows[ii].ChildBands[0].Rows[ij].Cells[cellNumber + 7].Appearance = weekendApperance;
                }
            }
        }

        private void setProjectVisible(string userID, int projectID, DateTime startDate, DateTime endDate, Infragistics.Win.Appearance projectColour)
        {
            for (int ii = 0; ii < ganttGridViewer.Rows.Count; ii++)
            {
                if (ganttGridViewer.Rows[ii].Cells["User_ID"].Value.ToString() == userID)
                {
                    for (int ij = 0; ij < ganttGridViewer.Rows[ii].ChildBands[0].Rows.Count; ij++)
                    {
                        if (int.Parse(ganttGridViewer.Rows[ii].ChildBands[0].Rows[ij].Cells["Project_id"].Value.ToString()) == projectID)
                        {
                            int sDay = startDate.Day;
                            int eDay = endDate.Day;
                            for (int ik = sDay; ik <= eDay; ik++)
                            {
                                ganttGridViewer.Rows[ii].ChildBands[0].Rows[ij].Cells[ik + 7].Appearance = projectColour;
                                ganttGridViewer.Rows[ii].ChildBands[0].Rows[ij].Cells[ik + 7].ToolTipText = "This is a project";
                            }
                        }
                    }
                }
            }
        }

        private void clearGantt()
        {
            for (int ii = 0; ii < ganttGridViewer.Rows.Count; ii++)
            {
                for (int ij = 0; ij < ganttGridViewer.Rows[ii].ChildBands[0].Rows.Count; ij++)
                {
                    for (int ik = 0; ik < ganttGridViewer.Rows[ii].ChildBands[0].Rows[ij].Cells.Count; ik++)
                    {
                        ganttGridViewer.Rows[ii].ChildBands[0].Rows[ij].Cells[ik].Appearance = none;
                    }
                }
            }
        }

        private void buildUserList()
        {
            //add users to the user list
            userList.Items.Clear();
            bool isConsultant;

            foreach (DataRow userRow in userTable.Rows)
            {
                isConsultant = (bool)userRow["Is_consultant"];
                if (chkShowConsultants.Checked == false || (chkShowConsultants.Checked == true &&
                     isConsultant == true))
                    userList.Items.Add(userRow["Full_name"].ToString(), (bool)userRow["Visible"]);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("MB_CANCEL");
        }

        private void navigationToolbar_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            switch (e.Tool.Key)
            {
                case "mnuDayView":
                    SetFocus(2);
                    break;

                case "mnuViewWeek":
                    SetFocus(3);
                    break;

                case "mnuViewMonth":
                    SetFocus(4);
                    break;

                case "mnuViewGantt":
                    SetFocus(1);
                    break;
                case "mnuClose":
                    interop.SendMenuSignal("MB_CANCEL");
                    break;
                case "mnuNewProject":
                    interop.SendMenuSignal("NEWPRJ");
                    break;
                case "mnuNewRequest":
                    interop.SendMenuSignal("NEWRES");
                    break;
                case "mnuExpand":
                    interop.SendMenuSignal("EXPAND");
                    break;
                case "mnuAssignFees":
                    interop.SendMenuSignal("NEWFEE");
                    break;
                case "mnuAddNotes":
                    interop.SendMenuSignal("NEWNOTE");
                    break;
                case "mnuExpenses":
                    interop.SendMenuSignal("NEWEXP");
                    break;
                case "mnuAttachments":
                    interop.SendMenuSignal("NEWATT");
                    break;

            }

        }

        private void userList_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void userList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            userList.SelectedIndex = e.Index;
            object item = userList.SelectedItem;
            bool visible;
            if (e.NewValue == CheckState.Unchecked)
            {
                visible = false;   
            }
            else
            {
                visible = true;
            }
            foreach (DataRow oRow in userTable.Rows)
            {
                if (oRow["Full_name"].ToString() == item.ToString())
                    oRow["Visible"]=visible;
            }
        }

        private void chkShowConsultants_CheckedChanged(object sender, EventArgs e)
        {
            buildUserList();
        }

        private void comboGanttMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearGantt();
            setDayColour();
            fillGantt();
        }

    }
}
