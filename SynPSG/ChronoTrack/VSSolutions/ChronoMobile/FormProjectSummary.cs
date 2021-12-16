using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChronoMobile
{
    public partial class FormProjectSummary : Form
    {
        public FormProjectSummary()
        {
            InitializeComponent();
        }

        private void FormProjectSummary_Load(object sender, EventArgs e)
        {
            DataRow sumRow = Program.projects.ProjectDataTable.Rows[Program.selectedProjectIndex];
            txtDescription.Text = (string)sumRow["Description"];
            txtDates.Text = ((DateTime)sumRow["Start_date"]).ToShortDateString() + " - " + ((DateTime)sumRow["End_date"]).ToShortDateString();
            txtStatus.Text = ((ChronoTrackWS.ProjectStatus)sumRow["Current_status"]).ToString();
            txtProjectId.Text = ((int)sumRow["Project_id"]).ToString();
            txtCoordinator.Text = (string)sumRow["Coordinator"];
            txtLocation.Text = ((int)sumRow["Work_location_id"]).ToString();

//            DataRow sumRow = Program.combinedProjectView.ProjectDataTableCombined.Rows[Program.selectedProjectIndex];
//            txtContact.Text = (string)sumRow["Customer_contact"];
//            txtCoordinator.Text = (string)sumRow["Coordinator_full_name"];
//            txtDescription.Text = (string)sumRow["Description"];
//            txtCustomer.Text = (string)sumRow["Customer_name"];
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            FormProjectNotes formNotes = new FormProjectNotes();
            formNotes.ShowDialog();
        }
    }
}