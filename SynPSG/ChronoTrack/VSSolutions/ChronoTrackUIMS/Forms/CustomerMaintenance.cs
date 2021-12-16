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
    public partial class CustomerMaintenance : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

        /// <summary>
        /// default constructor.  Accespts the intergop reference
        /// </summary>
        /// <param name="i"></param>
        public CustomerMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }
        /// <summary>
        /// pass in the data tables
        /// </summary>
        /// <param name="customers"></param>
        /// <param name="contacts"></param>
        public void SetDataSource(DataTable customers, DataTable contacts)
        {
//            customerBindingSource.DataSource = customers;
//            contactBindingSource.DataSource = contacts;
//            if (customers.Rows.Count == 0)
//            {
//                customerBindingSource.AddNew();
//            }
//            else
//            {
//                DataRow row = customers.Rows[0];
//                lastCustomerID = row[1].ToString();
//            }
        }

        /// <summary>
        /// force the combos to default
        /// </summary>
        public void DefaultCombos()
        {
//            if (techCombo.Value == null)
//            {
//                interop.DebugMessage("setting default combo values");
//                DataTable dt = (DataTable)contactBindingSource.DataSource;
//                if (dt.Rows.Count != 0)
//                {
//                    techCombo.Rows[0].Selected = true;
//                    legalCombo.Rows[0].Selected = true;
//                }
//            }
        }

        /// <summary>
        /// allow access to the current customer ID
        /// </summary>
        public string CustomerID
        {
            get { return "";}// lastCustomerID; }
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
//            txtCustomerID.Focus();
        }

    }
}
