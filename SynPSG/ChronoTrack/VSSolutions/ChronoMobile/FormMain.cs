using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Status;

namespace ChronoMobile
{
    public partial class FormMain : Form
    {

        private SystemState orientationWatcher;

        private int mCurrentProjects;
        private int mNewProjects;
        private int mOldProjects;
        Font mDrawFont = new Font("Tahoma", 8, FontStyle.Bold);
        SolidBrush mDrawBrush = new SolidBrush(Color.RoyalBlue);

        public FormMain()
        {
            InitializeComponent();

            orientationWatcher = new SystemState(SystemProperty.DisplayRotation);
            orientationWatcher.Changed += new ChangeEventHandler(orientationWatcher_Changed);

        }

        void orientationWatcher_Changed(object sender, ChangeEventArgs args)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblErrorMsg.Visible = false;
            lblConnecting.Visible = true;
            lblConnecting.Text = "Connecting ";
            lblConnecting.Refresh();
            pbConnect.Visible = true;
            pbConnect.Value = 25;
            pbConnect.Refresh();
            Program.ws = new SessionRemoteService();
            lblConnecting.Text = "Validating ";
            lblConnecting.Refresh();
            pbConnect.Value = 50;
            Program.userResponse = Program.ws.ValidateUser(txtUsername.Text, txtPassword.Text);
            if (Program.userResponse.CallStatus == true)
            {
                Program.userName = txtUsername.Text;
                Program.password = txtPassword.Text;

                lblConnecting.Text = "Loading projects ";
                lblConnecting.Refresh();
                pbConnect.Value = 75;
                Program.combinedProjectView = new ChronoMobile.ChronoTrackWS.ProjectSummaryResponse();

                Program.combinedProjectView = Program.ws.ProjectSummary(Program.userName.ToUpper(), new DateTime(1900,1,1));
                Program.projects = Program.ws.Projects("", new DateTime(1900,1,1), Program.userName.ToUpper(), ChronoTrackWS.ProjectStatus.All);

                lblConnecting.Text = "Complete ";
                lblConnecting.Refresh();
                pbConnect.Value = 100;

                panelLogin.Hide();
                lblConnecting.Visible = false;
                pbConnect.Visible = false;
                txtPassword.Text = "";

                lblSummary.Text = "Welcome, " + Program.userName;

                mCurrentProjects = 0;
                mNewProjects = 0;
                mOldProjects = 0;

                foreach (DataRow row in Program.projects.ProjectDataTable.Rows)
                {
                    switch ((Program.ProjectViewStatus)row["Current_status"])
                    {
                        case Program.ProjectViewStatus.New: { mNewProjects += 1; break; }
                        case Program.ProjectViewStatus.Old: { mOldProjects += 1; break; }
                        default: { mCurrentProjects += 1; break; }
                    }
                    
                }

                mitemLogout.Text = "Log out";
                mitemOptions.Text = "Options";

                if (mCurrentProjects == 0 && mNewProjects > 0)
                {
                    Program.currentListStatus = Program.ProjectViewStatus.New;
                    pictureNew.BackColor = Color.Navy;
                }
                else
                {
                    Program.currentListStatus = Program.ProjectViewStatus.Current;
                    pictureCurrent.BackColor = Color.Navy;
                }
                loadProjectList();
                panelSummary.Show();

            }
            else
            {
                lblConnecting.Visible = false;
                pbConnect.Visible = false;
                lblErrorMsg.Text = "Login failed.";
                lblErrorMsg.Visible = true;
            }


        }

        private void StartUp_Load(object sender, EventArgs e)
        {
            lblErrorMsg.Visible = false;
            lblConnecting.Visible = false;
            pbConnect.Visible = false;
            pbConnect.Value = 0;
            panelSummary.Visible = false;
            mitemLogout.Text = "Exit";
            mitemOptions.Text = "";
            mitemOptions.Enabled = false;

//            txtUsername.Text = "tod phillips";
//            txtPassword.Text = "p@ssw0rd";
        }

        private void pictureCurrent_Click(object sender, EventArgs e)
        {
            if (Program.currentListStatus != Program.ProjectViewStatus.Current)
            {
                if (Program.currentListStatus == Program.ProjectViewStatus.New)
                { pictureNew.BackColor = Color.White; }
                else
                { pictureComplete.BackColor = Color.White; }
                Program.currentListStatus = Program.ProjectViewStatus.Current;
                pictureCurrent.BackColor = Color.Navy;
                loadProjectList();
            }
        }

        private void pictureComplete_Click(object sender, EventArgs e)
        {
            if (Program.currentListStatus != Program.ProjectViewStatus.Old)
            {
                if (Program.currentListStatus == Program.ProjectViewStatus.Current)
                { pictureCurrent.BackColor = Color.White; }
                else
                { pictureNew.BackColor = Color.White; }
                Program.currentListStatus = Program.ProjectViewStatus.Old;
                pictureComplete.BackColor = Color.Navy;
                loadProjectList();
            }
        }

        private void pictureNew_Click(object sender, EventArgs e)
        {
            if (Program.currentListStatus != Program.ProjectViewStatus.Old)
            {
                if (Program.currentListStatus == Program.ProjectViewStatus.Current)
                { pictureCurrent.BackColor = Color.White; }
                else
                { pictureComplete.BackColor = Color.White; }
                Program.currentListStatus = Program.ProjectViewStatus.New;
                pictureNew.BackColor = Color.Navy;
                loadProjectList();
            }
        }

        private void loadProjectList()
        {
            listProjects.Items.Clear();
            string descAndDate = "";
            int projStatus = -1;
            int projCount = 0;
            int projIndex = -1;
            bool addProject;
            foreach (DataRow row in Program.projects.ProjectDataTable.Rows)
            {
                projIndex += 1;
                addProject = true;
                projStatus = (int)row["Current_status"];
                switch (Program.currentListStatus)
                {
                    case (Program.ProjectViewStatus.New): { if (projStatus != 0) addProject = false; break; }
                    case (Program.ProjectViewStatus.Old): { if (projStatus != 5) addProject = false; break; }
                }
                if (addProject)
                {
                    projCount += 1;
                    descAndDate = (string)row["Description"];
                    if (((DateTime)row["Start_date"]) == null || ((DateTime)row["Start_date"]).Year == 1900)
                    {
                        descAndDate += " (TBD)";
                    }
                    else
                    {
                        descAndDate += " (" + ((DateTime)row["Start_date"]).ToShortDateString() + ")";
                    }
                    listProjects.Items.Add(new ProjectListItem(descAndDate, projIndex));
                }
            }
            if (projCount == 0)
            {
                listProjects.Items.Add("No " + Program.currentListStatus.ToString() + " projects found.");
                listProjects.Enabled = false;
                mitemOptions.Enabled = false;
            }
            else
            {
                listProjects.Enabled = true;
                mitemOptions.Enabled = true;
                listProjects.SelectedIndex = 0;
                listProjects.Focus();
            }
        }

        private void pictureNew_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(mNewProjects.ToString(), mDrawFont, mDrawBrush, 32, 32);
        }

        private void pictureCurrent_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(mCurrentProjects.ToString(), mDrawFont, mDrawBrush, 32, 32);
        }

        private void pictureComplete_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(mOldProjects.ToString(), mDrawFont, mDrawBrush, 32, 32);
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            switch (mitemLogout.Text)
            {
                case ("Exit"): 
                    { 
                        if (Program.ws != null)
                        {
                            Program.ws.Disconnect();
                        }
                        this.Close();
                        break; 
                    }
                case ("Log out"):
                    {
                        if (Program.ws != null)
                        {
                            Program.ws.Disconnect();
                            Program.ws.Dispose();
                        }
                        mitemLogout.Text = "Exit";
                        mitemOptions.Text = "";
                        mitemOptions.Enabled = false;
                        panelSummary.Hide();
                        panelLogin.Show();
                        txtPassword.Focus();
                        break;
                    }
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
        }

        private void listProjects_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.selectedProjectIndex = ((ProjectListItem)listProjects.SelectedItem).ItemValue;
            FormProjectSummary formSummary = new FormProjectSummary();
            formSummary.ShowDialog();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            Program.selectedProjectIndex = ((ProjectListItem)listProjects.SelectedItem).ItemValue;
            FormProjectSummary formSummary = new FormProjectSummary();
            formSummary.ShowDialog();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Program.selectedProjectIndex = ((ProjectListItem)listProjects.SelectedItem).ItemValue;
            FormProjectNotes formNotes = new FormProjectNotes();
            formNotes.ShowDialog();
        }

        private void FormMain_Closing(object sender, CancelEventArgs e)
        {
            if (Program.ws != null)
            {
                Program.ws.Disconnect();
            }
        }
    }
}