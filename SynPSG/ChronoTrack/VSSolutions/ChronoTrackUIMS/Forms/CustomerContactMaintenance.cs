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
    public partial class CustomerContactMaintenance : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="i"></param>
        public CustomerContactMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }
        /// <summary>
        /// set for data
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="contacts"></param>
        public void setDataTable(string customerID, DataTable contacts, DataTable location)
        {
//            toolStripLabel1.Text = string.Concat("Customer ID : ", customerID);
//            custID = customerID;
//            contactTable = contacts;
//            contactBindingSource.DataSource = contactTable;
//            locationBindingSource.DataSource = location;
//            if (contactTable.Rows.Count == 0)
//                contactBindingSource.AddNew();
        }
        /// <summary>
        /// expose the current customer ID
        /// </summary>
        public string CustomerID
        {
            get { return "";}// custID; }
        }

        /// <summary>
        /// force the combos to default
        /// </summary>
        public void DefaultCombos()
        {
//            if (comboLocation.Value == null)
//            {
//                interop.DebugMessage("setting default combo values");
//                DataTable dt = (DataTable)locationBindingSource.DataSource;
//                if (dt.Rows.Count != 0)
//                {
//                    comboLocation.Rows[0].Selected = true;
//                }
//            }
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
//            txtFirstName.Focus();
        }

    }
}
