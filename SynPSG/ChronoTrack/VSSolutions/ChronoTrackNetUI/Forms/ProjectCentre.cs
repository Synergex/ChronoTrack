using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynPSGNetCore.Interop;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinDataSource;
using System.Diagnostics;

namespace ChronoTrackNetUI.Forms
{
    public partial class ProjectCentre : Form
    {
        SynInterop interop;
        int pID;
        int counter = 999;
        string currentUser;

        public ProjectCentre(SynInterop i)
        {
            InitializeComponent();
            interop = i;

            feeGroupBox.Dock = DockStyle.Fill;
            feeGrid.Dock = DockStyle.Fill;

            expenseGroupBox.Dock = DockStyle.Fill;
            expenseGrid.Dock = DockStyle.Fill;

            noteGrid.Dock = DockStyle.Fill;
            notesGroupBox.Dock = DockStyle.Fill;

            projectViewGrid.Dock = DockStyle.Fill;
            taskGroupBox.Dock = DockStyle.Fill;
        }

        public void SetDataSource(DataTable prj
            , DataTable prjTask, DataTable prjActivity, DataTable prjAttachment, DataTable prjFee
            , DataTable prjExp, DataTable prjNote
            , DataTable customer
            , DataTable customerLocation
            , DataTable customerContact
            , DataTable taskType
            , DataTable feeSource, DataTable userSource
            , DataTable expSource, string user)
        {
            //store project ID away
            pID = int.Parse(prj.Rows[0][1].ToString());
            currentUser = user;

            userbindingSource.DataSource = userSource;
            expensetypeBindingSource.DataSource = expSource;
            feeTypeBindingSource.DataSource = feeSource;
            projectBindingSource.DataSource = prj;
            prj.BeginInit();
            prj.Rows[0]["Modified_by"] = currentUser;
            prj.Rows[0]["Modified_date"] = DateTime.Now;

            projectconsultantBindingSource.DataSource = prjFee;
            projectexpnseBindingSource.DataSource = prjExp;
            projectNoteBindingSource.DataSource = prjNote;

            customerBindingSource.DataSource=customer;
            customerLocationbindingSource.DataSource = customerLocation;
            customerContactBindingSource.DataSource = customerContact;
            TaskTypeBindingSource.DataSource = taskType;

            //sort out the task/activity/atachment links
            DataSet projectView = new DataSet("ProjectView");
            projectView.Tables.Add(prjTask);
            projectView.Tables.Add(prjActivity);
            projectView.Relations.Add("taskToActivity", projectView.Tables["ProjectTask"].Columns["Task_id"], projectView.Tables["ProjectActivity"].Columns["Task_id"]);
            projectView.Tables.Add(prjAttachment);
            projectView.Relations.Add("taskToAttachment", projectView.Tables["ProjectTask"].Columns["Task_id"], projectView.Tables["ProjectAttachment"].Columns["Task_id"]);

            //assign to the grid
            projectViewGrid.DataSource = projectView;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Synergygrfa"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Synergygrfa"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Project_id"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Project_id"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Task_id"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Task_id"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Replication_key"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Replication_key"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Created_by"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Created_date"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[0].Columns["modified_by"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[0].Columns["modified_date"].Hidden = true;

        
            projectViewGrid.DisplayLayout.Bands[1].Columns["Synergygrfa"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Synergygrfa"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Project_id"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Project_id"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Task_id"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Task_id"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Activity_id"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Activity_id"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Replication_key"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Replication_key"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;

            projectViewGrid.DisplayLayout.Bands[2].Columns["Synergygrfa"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Synergygrfa"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Project_id"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Project_id"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Task_id"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Task_id"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Attachment_id"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Attachment_id"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Doc_type"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Doc_type"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Replication_key"].Hidden = true;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Replication_key"].ExcludeFromColumnChooser = ExcludeFromColumnChooser.True;

            //populate te currency tab
            ultraDataSource1.Rows.SetCount(2);

            UltraDataRow row;

            row = ultraDataSource1.Rows[0];
            row["code"] = "UKP";
            row["description"] = "UK Pounds";

            row = ultraDataSource1.Rows[1];
            row["code"] = "USD";
            row["description"] = "US Dollars";

            //populate the project status combo table
            ultraDataSource2.Rows.SetCount(6);

            row = ultraDataSource2.Rows[0];
            row["code"] = 0;
            row["description"] = "Created";
            
            row = ultraDataSource2.Rows[1];
            row["code"] = 1;
            row["description"] = "Quoted";
            
            row = ultraDataSource2.Rows[2];
            row["code"] = 2;
            row["description"] = "Signed";
            
            row = ultraDataSource2.Rows[3];
            row["code"] = 3;
            row["description"] = "Implementation";
            
            row = ultraDataSource2.Rows[4];
            row["code"] = 4;
            row["description"] = "Post-project";
            
            row = ultraDataSource2.Rows[5];
            row["code"] = 5;
            row["description"] = "Completed";
            
            string fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\ProjectViewGrid.xml");
            if (System.IO.File.Exists(fileName))
                projectViewGrid.DisplayLayout.LoadFromXml(fileName);

            //reassign so we get the buttons back!
            projectViewGrid.DisplayLayout.Bands[2].Columns["Filespec"].EditorControl = this.attachFileSpec;

            fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\feeGrid.xml");
            if (System.IO.File.Exists(fileName))
                feeGrid.DisplayLayout.LoadFromXml(fileName);

            fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\expenseGrid.xml");
            if (System.IO.File.Exists(fileName))
                expenseGrid.DisplayLayout.LoadFromXml(fileName);

            fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\noteGrid.xml");
            if (System.IO.File.Exists(fileName))
                noteGrid.DisplayLayout.LoadFromXml(fileName);

            //assign editor controls
            assignBandZeroEditors();
            assignBandOneEditors();
            assignBandTwoEditors();
        }

        public void SetFocus()
        {
            projectViewGrid.Focus();
        }

        private void assignBandZeroEditors()
        {
            projectViewGrid.DisplayLayout.Bands[0].Columns["Task_type"].EditorControl = this.taskTaskTypeCombo;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Description"].EditorControl = this.taskDescription;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Description"].Header.Caption = "Activity Description";
            projectViewGrid.DisplayLayout.Bands[0].Columns["Assigned_to"].EditorControl = this.taskAssignedToCombo;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Start_date"].EditorControl = this.taskStartDate;
            projectViewGrid.DisplayLayout.Bands[0].Columns["End_date"].EditorControl = this.taskEndDate;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Location"].EditorControl = this.taskLocation;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Billable_hours"].EditorControl = this.taskBillableHours;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Completed"].EditorControl = this.taskCompleted;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Text"].EditorControl = this.taskText;
            projectViewGrid.DisplayLayout.Bands[0].Columns["Created_by"].EditorControl = this.taskCreatedByCombo;
            projectViewGrid.DisplayLayout.Bands[0].Columns["modified_by"].EditorControl = this.taskModifiedByCombo;
        }
        private void assignBandOneEditors()
        {
            projectViewGrid.DisplayLayout.Bands[1].Columns["Description"].EditorControl = this.activityDescription;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Description"].Header.Caption = "Activity";
            projectViewGrid.DisplayLayout.Bands[1].Columns["Start_date"].EditorControl = this.activityStartDate;
            projectViewGrid.DisplayLayout.Bands[1].Columns["End_date"].EditorControl = this.activityEndDate;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Created_by"].EditorControl = this.activityCreateByCombo;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Created_date"].EditorControl = this.activityCreatedDate;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Modified_by"].EditorControl = this.activityModifiedBy;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Modified_date"].EditorControl = this.activityModifiedDate;
            projectViewGrid.DisplayLayout.Bands[1].Columns["Text"].EditorControl = this.activityText;
        }

        private void assignBandTwoEditors()
        {
            projectViewGrid.DisplayLayout.Bands[2].Columns["Description"].EditorControl = this.attachDescription;
            projectViewGrid.DisplayLayout.Bands[2].Columns["Description"].Header.Caption = "Attachment";
            projectViewGrid.DisplayLayout.Bands[2].Columns["Filespec"].EditorControl = this.attachFileSpec;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\ProjectViewGrid.xml");
            projectViewGrid.DisplayLayout.SaveAsXml(fileName);

            fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\FeeGrid.xml");
            feeGrid.DisplayLayout.SaveAsXml(fileName);

            fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\ExpenseGrid.xml");
            expenseGrid.DisplayLayout.SaveAsXml(fileName);

            fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\NoteGrid.xml");
            noteGrid.DisplayLayout.SaveAsXml(fileName);

            interop.SendMenuSignal("MB_COMMIT");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("MB_CANCEL");
        }

        private void projectViewGrid_BeforeRowActivate(object sender, Infragistics.Win.UltraWinGrid.RowEventArgs e)
        {
            if (e.Row.IsAddRow)
            {
                string taskID;

                //set defaults
                switch (e.Row.Band.ToString())
                {
                    case "taskToActivity":
                        e.Row.Cells["Synergygrfa"].Value = "";
                        e.Row.Cells["Project_id"].Value = pID;

                        taskID = e.Row.ParentRow.Cells["Task_id"].Value.ToString();

                        e.Row.Cells["Task_id"].Value = int.Parse(taskID);
                        e.Row.Cells["Activity_id"].Value = counter;
                        counter += 1;
                        e.Row.Cells["Replication_key"].Value = counter.ToString();
                        counter += 1;
                        e.Row.Cells["Created_by"].Value = currentUser;
                        e.Row.Cells["Modified_by"].Value = currentUser;
                        e.Row.Cells["Start_Date"].Value = DateTime.Now;
                        e.Row.Cells["End_Date"].Value = DateTime.Now;
                        e.Row.Cells["Created_Date"].Value = DateTime.Now;
                        e.Row.Cells["Modified_Date"].Value = DateTime.Now;
                        break;
                    case "taskToAttachment":
                        e.Row.Cells["Synergygrfa"].Value = "";
                        e.Row.Cells["Project_id"].Value = pID;

                        taskID = e.Row.ParentRow.Cells["Task_id"].Value.ToString();

                        e.Row.Cells["Task_id"].Value = int.Parse(taskID);
                        e.Row.Cells["Attachment_id"].Value = counter;
                        counter += 1;
                        e.Row.Cells["Doc_type"].Value = 1;
                        e.Row.Cells["Replication_key"].Value = counter.ToString();
                        counter += 1;
                        break;
                    default:
                        e.Row.Cells["Synergygrfa"].Value = "";
                        e.Row.Cells["Project_id"].Value = pID;

                        //get count of rows
                        int taskCount = e.Row.ParentCollection.Count;
                        
                        e.Row.Cells["Task_id"].Value = taskCount;
                        e.Row.Cells["Assigned_to"].Value = currentUser;
                        e.Row.Cells["Created_by"].Value = currentUser;
                        e.Row.Cells["Modified_by"].Value = currentUser;
                        e.Row.Cells["Start_Date"].Value = DateTime.Now;
                        e.Row.Cells["End_Date"].Value = DateTime.Now;
                        e.Row.Cells["Created_Date"].Value = DateTime.Now;
                        e.Row.Cells["Modified_Date"].Value = DateTime.Now;
                        e.Row.Cells["Completed"].Value = false;
                        e.Row.Cells["Replication_key"].Value = counter.ToString();
                        counter += 1;
                        break;
                }

            }
        }

        private void attachFileSpec_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            string fileName = projectViewGrid.ActiveRow.Cells["Filespec"].Value.ToString();
            switch (e.Button.Key)
            {
                case "find":
                    openFileDialog.FileName = fileName;
                    openFileDialog.ShowDialog(this);
                    projectViewGrid.ActiveRow.Cells["Filespec"].Value = openFileDialog.FileName;
                    break;
                case "open":
                    try
                    {
                        Process viewIt;
                        viewIt = new Process();
                        viewIt.StartInfo.FileName = @fileName;
                        viewIt.Start();

                    }
                    catch
                    {
                        MessageBox.Show("There is no associated program for this file extension.");
                    }
                    break;
                default:
                    break;
            }

        }

        private void feeGrid_BeforeRowActivate(object sender, RowEventArgs e)
        {
            if (e.Row.IsAddRow)
            {
                e.Row.Cells["Synergygrfa"].Value = "";
                e.Row.Cells["Project_id"].Value = pID;
                e.Row.Cells["Replication_key"].Value = counter.ToString();
                counter += 1;
            }
        }


        private void expenseGrid_BeforeRowActivate(object sender, RowEventArgs e)
        {
            if (e.Row.IsAddRow)
            {
                e.Row.Cells["Synergygrfa"].Value = "";
                e.Row.Cells["Project_id"].Value = pID;
                e.Row.Cells["Expense_id"].Value = counter;
                counter += 1;
                e.Row.Cells["Expense_date"].Value = DateTime.Now;
                e.Row.Cells["Currency_code"].Value = "US";
                e.Row.Cells["Expensed_by"].Value = currentUser;
                e.Row.Cells["Entered_by"].Value = currentUser;
                e.Row.Cells["Entered_date"].Value = DateTime.Now;
                e.Row.Cells["Modified_by"].Value = currentUser;
                e.Row.Cells["Modified_date"].Value = DateTime.Now;
                e.Row.Cells["Is_estimate"].Value = false;
                e.Row.Cells["Replication_key"].Value = counter.ToString();
                counter += 1;
            }
        }

        private void noteGrid_BeforeRowActivate(object sender, RowEventArgs e)
        {
            if (e.Row.IsAddRow)
            {
                e.Row.Cells["Synergygrfa"].Value = "";
                e.Row.Cells["Project_id"].Value = pID;
                e.Row.Cells["Note_id"].Value = counter;
                counter += 1;
                e.Row.Cells["Created_by"].Value = currentUser;
                e.Row.Cells["Created_date"].Value = DateTime.Now;
                e.Row.Cells["Modified_by"].Value = currentUser;
                e.Row.Cells["Modified_date"].Value = DateTime.Now;
                e.Row.Cells["Replication_key"].Value = counter.ToString();
                counter += 1;
            }
        }

        private void expenseMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "toolExpenseDelete":
                    expenseGrid.ActiveRow.Delete(true);
                    break;
                case "toolExpensePicker":
                    expenseGrid.ShowColumnChooser(false);
                    break;
                case "toolExpenseResetGrid":
                    string fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\ExpenseGrid.xml");
                    if (System.IO.File.Exists(fileName))
                        System.IO.File.Delete(fileName);
                    break;
                default:
                    break;
            }
        }

        private void feeMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "toolFeeDelete":
                    feeGrid.ActiveRow.Delete(true);
                    break;
                case "toolFeePicker":
                    feeGrid.ShowColumnChooser(false);
                    break;
                case "toolFeeResetGrid":
                    string fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\FeeGrid.xml");
                    if (System.IO.File.Exists(fileName))
                        System.IO.File.Delete(fileName);
                    break;
                default:
                    break;
            }
        }

        private void noteMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "toolNoteDelete":
                    noteGrid.ActiveRow.Delete(true);
                    break;
                case "toolNotePicker":
                    noteGrid.ShowColumnChooser(false);
                    break;
                case "toolNoteResetGrid":
                    string fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\NoteGrid.xml");
                    if (System.IO.File.Exists(fileName))
                        System.IO.File.Delete(fileName);
                    break;
                default:
                    break;
            }
        }
        
        private void projectMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "toolProjectDelete":
                    projectViewGrid.ActiveRow.Delete(true);
                    break;
                case "toolProjectPicker":
                    projectViewGrid.ShowColumnChooser(false);
                    break;
                case "toolProjectResetGrid":
                    string fileName = string.Concat(Environment.GetEnvironmentVariable("USERPROFILE"), "\\ProjectViewGrid.xml");
                    if (System.IO.File.Exists(fileName))
                        System.IO.File.Delete(fileName);                    
                    break;
                default:
                    break;
            }
        }

        private void prevent_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            if (panelCustomer.Visible == false)
            {
                panelCustomer.Visible = true;
                btnCustomerDetails.Text = "Hide customer details";
            }
            else
            {
                panelCustomer.Visible = false;
                btnCustomerDetails.Text = "Show customer details";
            }

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnCustomerDetails.Enabled = true;
            panelCustomer.Visible = false;
            projectViewGrid.Focus();
        }

        private void txtCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtContactPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboContact_RowSelected(object sender, RowSelectedEventArgs e)
        {
            UltraGridRow row = comboContact.SelectedRow;

            if (row != null)
            {
                txtContactPhone.Text = row.Cells["Office_phone"].Text;
                txtContactMobile.Text = row.Cells["Mobile_phone"].Text;
            }
        }

        private void txtContactMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
