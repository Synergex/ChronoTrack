using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SynPSGNetCore.Interop;

namespace ChronoTrackNetUIDX.Forms
{
    public partial class PasswordMaint : Form//DevExpress.XtraEditors.XtraForm
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
//            txtNew.Focus();
  //          txtConfirm.SelectAll();
        }

        /// <summary>
        /// allow access to the new password
        /// </summary>
        public string NewPassword
        {
            get { return "";}// txtNew.Text; }
        }

    }
}