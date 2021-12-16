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
    public partial class Options : Form//DevExpress.XtraEditors.XtraForm
    {
        //need a copy of the interop object
        private SynInterop interop;

        public Options(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        public string UserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public int DisplayTransactionViewer
        {
            get
            {
                if (chkDisplayTransactionViewer.Checked)
                    return 1;
                else
                    return 0;
            }
            set
            {
                interop.DebugMessage(string.Concat("value sent to DisplayTransactionViewer is :", value.ToString()));
                if (value == 0)
                    chkDisplayTransactionViewer.Checked = false;
                else
                    chkDisplayTransactionViewer.Checked = true;
            }
        }

        public int DefaultViewState
        {
            get { return comboDefaultView.SelectedIndex + 1; }
            set { if (value > 0 && value < 4) comboDefaultView.SelectedIndex = value - 1; }
        }

        public int HistoryMonths
        {
            get { return (int)intHistoryToLoad.Value; }
            set { if (value > 0 && value < 12)intHistoryToLoad.Value = value; }
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            txtUserName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Cancel(interop, this))
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("MB_COMMIT");
        }
    }
}