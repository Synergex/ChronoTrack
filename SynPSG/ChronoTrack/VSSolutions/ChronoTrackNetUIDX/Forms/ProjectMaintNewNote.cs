using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChronoTrackNetUIDX.Forms
{
    public partial class ProjectMaintNewNote : Form
    {
        DataTable mNotes;
        int pID;

        public ProjectMaintNewNote(int projectID, DataTable notes)
        {
            InitializeComponent();
            pID = projectID;
            mNotes = notes;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataRow row = mNotes.NewRow();
            row[1] = pID;
            row[2] = 999;
            row[3] = txtDescription.Text;
            row[4] = "";
            row[5] = DateTime.Now;
            row[6] = "";
            row[7] = DateTime.Now;
            row[8] = txtDetails.Text;
            mNotes.Rows.Add(row);
            this.Close();
        }
    }
}
