using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynPSGNetCore.Interop;

namespace ChronoTrackNetUIMS.Forms
{
    public partial class Login : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

        public Login(SynInterop i)
        {
            InitializeComponent();
            interop = i;
            this.Focus();
            txtUserName.Focus();
        }

        /// <summary>
        /// expose the user name
        /// </summary>
        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; txtPassword.Focus(); }
        }

        /// <summary>
        /// expose the password
        /// </summary>
        public string Password
        {
            get { return txtPassword.Text; }
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            if (txtUserName.TextLength == 0)
                txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("LOGIN");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("CANCEL");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("CHEAT");
        }
    }
}
