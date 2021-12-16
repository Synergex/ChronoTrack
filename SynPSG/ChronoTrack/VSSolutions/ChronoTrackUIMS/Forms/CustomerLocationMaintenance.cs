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
    public partial class CustomerLocationMaintenance : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="i"></param>
        public CustomerLocationMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }
        /// <summary>
        /// assign the requred data to the form
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="locations"></param>
        /// <param name="country"></param>
        /// <param name="state"></param>
        public void setDataSource(string customerID, DataTable locations, DataTable country, DataTable state)
        {
//            interop.DebugMessage(string.Concat(this.Text, " SetDataTable"));
//
//            toolStripLabel1.Text = string.Concat("Customer ID : ", customerID);
//            custID = customerID;
//            locationTable = locations;
//            locationBindingSource.DataSource = locationTable;
//            countryBindingSource.DataSource = country;
//            stateBindingSource.DataSource = state;
//            if (locationTable.Rows.Count == 0)
//            {
//                interop.DebugMessage(string.Concat(this.Text, " forcing AddNew - no rows in location table"));
//
//                locationBindingSource.AddNew();
//            }
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
//            txtDescription.Focus();
        }
    }
}
