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
    public partial class FormProjectNotes : Form
    {
        private int mProjectId = 0;

        public FormProjectNotes()
        {
            InitializeComponent();
        }

        private void FormProjectNotes_Load(object sender, EventArgs e)
        {
            mitemCancel.Text = "Back";

            DataRow infoRow = Program.combinedProjectView.ProjectDataTableCombined.Rows[Program.selectedProjectIndex];
            lblDescription.Text = infoRow["Description"].ToString();
            lblCompany.Text = infoRow["Customer_name"].ToString();

            DataRow sumRow = Program.projects.ProjectDataTable.Rows[Program.selectedProjectIndex];
            mProjectId = Convert.ToInt32(sumRow["Project_id"]);


            Program.notes = Program.ws.ProjectNotes(mProjectId);
            if (Program.notes.ProjectNotesDataTable.Rows.Count == 0)
            {
                listNotes.Items.Add("No notes have been added for this project.");
            }
            else
            {
                foreach (DataRow note in Program.notes.ProjectNotesDataTable.Rows)
                {
                    listNotes.Items.Add(new ProjectListItem(
                        (string)note["Description"] + " (" +
                        ((DateTime)note["Created_date"]).ToShortDateString() +
                        ")",
                        Convert.ToInt32(note["Note_id"])));
                }
                listNotes.SelectedIndex = 0;
            }
        }

        private void listNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            showNoteBody((string)Program.notes.ProjectNotesDataTable.Rows[listNotes.SelectedIndex]["Text"]);
        }

        private void showNoteBody(string body)
        {
            txtNote.Text = body;
        }

        private void mitemAdd_Click(object sender, EventArgs e)
        {
            switch (mitemAdd.Text)
            {
                case "Add":
                    {
                        listNotes.Hide();
                        txtNote.Text = "";
                        txtNote.ReadOnly = false;
                        txtDescription.Text = "";
                        txtDescription.Show();
                        mitemCancel.Text = "Cancel";
                        mitemAdd.Text = "Submit";
                        txtDescription.Focus();
                        break;
                    }
                case "Submit":
                    {
                        if (txtDescription.Text.Length > 0)
                        {
                            ChronoTrackWS.BaseResponse resp = Program.ws.CreateProjectNote(mProjectId, txtDescription.Text, txtNote.Text);
                            if (resp.CallStatus == false)
                            {
                                MessageBox.Show("Unable to update project note. Please try again", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                                return;
                            }
                        }
                        Program.notes = Program.ws.ProjectNotes(mProjectId);
                        txtNote.ReadOnly = true;
                        listNotes.Items.Add(new ProjectListItem(txtDescription.Text + " (" + DateTime.Today.ToShortDateString() + ")", Program.notes.ProjectNotesDataTable.Rows.Count));
                        listNotes.SelectedIndex = (Program.notes.ProjectNotesDataTable.Rows.Count - 1);
                        listNotes.Show();
                        txtDescription.Hide();
                        mitemAdd.Text = "Add";
                        mitemCancel.Text = "Back";
                        listNotes.Focus();
                        break;
                    }
            }
        }

        private void mitemCancel_Click(object sender, EventArgs e)
        {
            switch (mitemCancel.Text)
            {
                case "Cancel":
                    {
                        txtDescription.Hide();
                        txtDescription.Text = "";
                        listNotes.Show();
                        mitemCancel.Text = "Back";
                        txtNote.ReadOnly = true;
                        showNoteBody((string)Program.notes.ProjectNotesDataTable.Rows[listNotes.SelectedIndex]["Text"]);
                        listNotes.Focus();
                        break;
                    }
                case "Back":
                    {
                        this.Close();
                        break;
                    }
            }
        }
    }
}