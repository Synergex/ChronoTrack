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
    public partial class CustomerContactMaintenance : Form//DevExpress.XtraEditors.XtraForm
    {
        //need a copy of the interop object
        private SynInterop interop;
//        private string custID;
//        private DataTable contactTable;
//        private bool canceling = false;


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
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            txtFirstName.Focus();
        }
    }
}