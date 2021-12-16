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
    public partial class UserMaintenance : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

        public UserMaintenance(SynInterop i)
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
//            interop.DebugMessage("binding UI data source");
//            //assign passed binding source
//            userBindingSource.DataSource = user;
//
//            countryBindingSource.DataSource = country;
//            stateBindingSource.DataSource = state;
//
//            if (user.Rows.Count == 0)
//                userBindingSource.AddNew();

        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
//            txtUserID.Focus();
        }
    }
}
