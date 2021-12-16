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
    public partial class UserView : Form//DevExpress.XtraEditors.XtraForm
    {
        //need a copy of the interop object
        private SynInterop interop;

        public UserView(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param>Binding source</param>
        public void SetDataSource(DataTable user, DataTable country, DataTable state)
        {
/*            interop.DebugMessage("binding UI data source");
            //assign passed binding source
            userBindingSource.DataSource = user;

            countryBindingSource.DataSource = country;
            stateBindingSource.DataSource = state;

            if (user.Rows.Count == 0)
                userBindingSource.AddNew();
            */
        }
    }
}