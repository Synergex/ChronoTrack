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
    public partial class CountryMaintenance : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

        public CountryMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param>Binding source</param>
        public void SetDataSource(DataTable country)
        {
            //assign passed binding source
            countryBindingSource.DataSource = country;
            if (country.Rows.Count == 0)
                countryBindingSource.AddNew();
            txtID.Focus();
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            txtID.Focus();
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            if (txtID.TextLength == 0)
            {
                errorProvider.SetError(txtID, "Invalid code");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtID, "");
                e.Cancel = false;
            }

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.TextLength == 0)
            {
                errorProvider.SetError(txtName, "Invalid country name");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtName, "");
                e.Cancel = false;
            }

        }

        private void txtCurrencyCode_Validating(object sender, CancelEventArgs e)
        {
            if (txtCurrencyCode.TextLength == 0)
            {
                errorProvider.SetError(txtCurrencyCode, "Invalid currency code");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCurrencyCode, "");
                e.Cancel = false;
            }

        }

        private void countryBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            txtID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Save(interop, this, countryBindingSource))
                Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Cancel(interop, this, countryBindingSource))
                Close();
        }

    }
}
