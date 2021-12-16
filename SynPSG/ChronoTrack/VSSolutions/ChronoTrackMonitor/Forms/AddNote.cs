using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChronoTrackMonitor.Forms
{
    public partial class AddNote : Form
    {
        public AddNote(ChronoTrackMonitor.ChronoTrackWS.Project prj)
        {
            InitializeComponent();
            projectBindingSource.DataSource = prj;
        }

        public string Description
        { get { return txtProjectText.Text; } }

        public string Note
        { get { return txtProjectNote.Text; } }

        private void catch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
