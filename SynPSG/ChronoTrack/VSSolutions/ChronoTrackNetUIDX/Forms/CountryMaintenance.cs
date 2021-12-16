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
    public partial class CountryMaintenance : Form//DevExpress.XtraEditors.XtraForm
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