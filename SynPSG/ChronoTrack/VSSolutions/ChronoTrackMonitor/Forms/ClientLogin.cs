using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ChronoTrackMonitor.Forms
{
    public partial class ClientLogin : DevExpress.XtraEditors.XtraForm
    {
        public ClientLogin()
        {
            InitializeComponent();
        }

        public string UserName
        { get { return txtUsername.Text; } }

        public string Password
        { get { return txtPassword.Text; } }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}