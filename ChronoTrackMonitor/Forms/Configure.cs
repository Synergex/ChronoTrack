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
    public partial class Configure : Form
    {
        public Configure()
        {
            InitializeComponent();
        }

        private void Configure_Load(object sender, EventArgs e)
        {
            txtHost.Text = Properties.Settings.Default.HostName.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HostName = txtHost.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
