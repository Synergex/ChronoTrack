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
    public partial class CustomerMaintenance : Form//DevExpress.XtraEditors.XtraForm
    {
        //need a copy of the interop object
        private SynInterop interop;

        //remember last/current customer ID
        private string lastCustomerID = "";

        //singal we are canceling to prevent call backs to Synergy
        private bool canceling = false;

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
            customerBindingSource.DataSource = customers;
            contactBindingSource.DataSource = contacts;
            if (customers.Rows.Count == 0)
            {
                customerBindingSource.AddNew();
            }
            else
            {
                DataRow row = customers.Rows[0];
                lastCustomerID = row[1].ToString();
            }
        }

        /// <summary>
        /// force the combos to default
        /// </summary>
        public void DefaultCombos()
        {
            if (comboTechnical.EditValue==null)
            {
                interop.DebugMessage("setting default combo values");
                DataTable dt = (DataTable)contactBindingSource.DataSource;
            } 
        }

        /// <summary>
        /// allow access to the current customer ID
        /// </summary>
        public string CustomerID
        {
            get { return lastCustomerID; }
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            txtCustomerID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //store the current customer ID value becuase the .CancelEdit()
            //call below will clear the contents of the field
            string tmp = lastCustomerID;
            interop.DebugMessage(txtCustomerID.Text);
            canceling = true;

            if (ChronoTrackNetUICommon.Generic.Handles_Cancel(interop, this))
            {
                lastCustomerID = tmp;
                Close();
            }
            else
                canceling = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Save(interop, this, customerBindingSource))
                Close();
        }

        private void txtCustomerID_Validated(object sender, EventArgs e)
        {
            //when the customer ID is validated we need to re-build
            //the contacts combo boxes...
            assignContactTable();
        }

        private void assignContactTable()
        {
            if (lastCustomerID != txtCustomerID.Text)
            {
                interop.DebugMessage(string.Concat("assignContactTable", " : ", txtCustomerID.Text));
                interop.SendMenuSignal("LOADCNTCS");
                lastCustomerID = txtCustomerID.Text;
            }
        }

        private void btnContactMnt_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("CNTCTMNT");
        }

        private void customerBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            txtCustomerID.Text = "";
            txtCustomerID.Focus();
        }

        private void comboTechnical_Enter(object sender, EventArgs e)
        {
            if (!canceling && comboTechnical.EditValue == null)
                interop.SendMenuSignal("CNTCTMNT");
        }

        private void comboLegal_Enter(object sender, EventArgs e)
        {
            if (!canceling && comboLegal.EditValue == null)
                interop.SendMenuSignal("CNTCTMNT");
        }

        private void customerBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (!canceling)
                assignContactTable();
        }
    }
}