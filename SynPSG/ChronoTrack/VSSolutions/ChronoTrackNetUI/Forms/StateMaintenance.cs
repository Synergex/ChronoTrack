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
    public partial class StateMaintenance : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

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

        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            if (txtCode.TextLength == 0)
            {
                errorProvider.SetError(txtCode, "Invalid code");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCode, "");
                e.Cancel = false;
            }

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.TextLength == 0)
            {
                errorProvider.SetError(txtName, "Invalid name");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtName, "");
                e.Cancel = false;
            }
        }

        private void stateBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            txtCode.Focus();
        }

    }
}
