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
    public partial class CustomerMaintenance : Form
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
            toolTipControl.ToolTipTitle = this.Text;
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
            if (techCombo.Value == null)
            {
                interop.DebugMessage("setting default combo values");
                DataTable dt = (DataTable)contactBindingSource.DataSource;
                if (dt.Rows.Count != 0)
                {
                    techCombo.Rows[0].Selected = true;
                    legalCombo.Rows[0].Selected = true;
                }
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
                canceling=false;
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

        private void techCombo_Enter(object sender, EventArgs e)
        {
            if (!canceling && techCombo.Rows.Count == 0)
            {
                interop.SendMenuSignal("CNTCTMNT");
            }
        }

        private void legalCombo_Enter(object sender, EventArgs e)
        {
            if (!canceling && techCombo.Rows.Count == 0)
            {
                interop.SendMenuSignal("CNTCTMNT");
            }
        }

        private void customerBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (!canceling)
                assignContactTable();
        }

        private void techCombo_RowSelected(object sender, Infragistics.Win.UltraWinGrid.RowSelectedEventArgs e)
        {
            formatToolTip(techCombo, e.Row);
        }

        private void legalCombo_RowSelected(object sender, Infragistics.Win.UltraWinGrid.RowSelectedEventArgs e)
        {
            formatToolTip(legalCombo, e.Row);
        }

        private void formatToolTip(Control c, Infragistics.Win.UltraWinGrid.UltraGridRow row)
        {
            if (row != null)
            {
                string p1 = row.Cells["Office_phone"].Value.ToString();
                string p2 = row.Cells["Mobile_phone"].Value.ToString();
                string s = string.Concat("Contact : ", row.Cells["First_name"].Value.ToString(),
                    " ", row.Cells["Last_name"].Value.ToString(), "\n",
                    "Office phone : ", p1, "\n",
                    "Mobile phone : ", p2, "\n",
                    "Email : ", row.Cells["Email"].Value.ToString());
                toolTipControl.SetToolTip(c, s);
            }

        }

        private void txtCustomerID_Validating(object sender, CancelEventArgs e)
        {
            if (txtCustomerID.TextLength == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtCustomerID, "Invalid ID");
            }
            else
            {
                errorProvider.SetError(txtCustomerID, "");
                e.Cancel = false;
            }
        }

        private void txtCustomer_Validating(object sender, CancelEventArgs e)
        {
            if (txtCustomer.TextLength == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(txtCustomer, "Invalid name");
            }
            else
            {
                errorProvider.SetError(txtCustomer, "");
                e.Cancel = false;
            }
        }
    }
}