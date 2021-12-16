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
    public partial class StateMaintenance : Form//DevExpress.XtraEditors.XtraForm
    {
        SynInterop interop;

        /// <summary>
        /// default constructor
        /// </summary>
        /// <remarks>
        /// pass in the synergy interop class
        /// </remarks>
        /// <param name="i">Synergy interop class</param>
        public StateMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param>Binding source</param>
        public void SetDataSource(DataTable state)
        {
            //assign passed binding source
            stateBindingSource.DataSource = state;
            if (state.Rows.Count == 0)
                stateBindingSource.AddNew();
            txtCode.Focus();
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            txtCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Save(interop, this, stateBindingSource))
                Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Cancel(interop, this, stateBindingSource))
                Close();
        }
    }
}