using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynPSGNetCore.Interop;

namespace ChronoTrackNetUI.Forms
{
    public partial class PasswordMaint : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="i"></param>
        public PasswordMaint(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// set the reqired focus on the form
        /// </summary>
        /// <returns></returns>
        public void SetFocus()
        {
            txtNew.Focus(); 
            txtConfirm.SelectAll();
        }

        /// <summary>
        /// allow access to the new password
        /// </summary>
        public string NewPassword
        {
            get { return txtNew.Text; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("MB_CANCEL");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CancelEventArgs ev = new CancelEventArgs();
            confirm(ref ev);
            if (ev.Cancel) return;
            interop.SendMenuSignal("MB_COMMIT");
        }

        private void txtNew_Validating(object sender, CancelEventArgs e)
        {
            if (txtNew.TextLength < 6)
            {
                errorProvider.SetError(txtNew, "Password must be at least 6 characters");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNew, "");
                e.Cancel = false;
            }
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            confirm(ref e);
        }

        private void confirm(ref CancelEventArgs e)
        {
            if (txtNew.Text != txtConfirm.Text)
            {
                errorProvider.SetError(txtConfirm, "Passwords do not match");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtConfirm, ""); 
                e.Cancel = false;
            }
        }
    }
}
