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
    public partial class CustomerContactMaintenance : Form
    {
        //need a copy of the interop object
        private SynInterop interop;
        private string custID;
        private DataTable contactTable;
        private bool canceling = false;


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
            toolStripLabel1.Text = string.Concat("Customer ID : ", customerID);
            custID = customerID;
            contactTable = contacts;
            contactBindingSource.DataSource = contactTable;
            locationBindingSource.DataSource = location;
            if (contactTable.Rows.Count == 0)
                contactBindingSource.AddNew();
        }
        /// <summary>
        /// expose the current customer ID
        /// </summary>
        public string CustomerID
        {
            get { return custID; }
        }

        /// <summary>
        /// force the combos to default
        /// </summary>
        public void DefaultCombos()
        {
            if (comboLocation.Value == null)
            {
                interop.DebugMessage("setting default combo values");
                DataTable dt = (DataTable)locationBindingSource.DataSource;
                if (dt.Rows.Count != 0)
                {
                    comboLocation.Rows[0].Selected = true;
                }
            }
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            txtFirstName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Cancel(interop, this, contactBindingSource))
            {
                canceling = true;
                Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Save(interop, this, contactBindingSource))
                Close();
        }

        private void txtPictureFile_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            openFileDialog.FileName = txtPictureFile.Text;
            openFileDialog.ShowDialog(this);
            txtPictureFile.Text = openFileDialog.FileName;

        }

        private void doValidation(bool addingNew)
        {
            //perform form validdation first
            if (!this.ValidateChildren(ValidationConstraints.Enabled))
                return;

            //attempt to complete the edit, if OK we can continue
            try
            {
                contactBindingSource.EndEdit();
                if (addingNew)
                {
                    contactBindingSource.AddNew();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void setDefaults()
        {
            DataRowView row = (DataRowView)contactBindingSource.Current;
            if (row.IsNew)
            {
                row["Customer_id"] = custID;
                txtFirstName.Focus();
            }
        }

        private void bindingNavigator_Click(object sender, EventArgs e)
        {
            doValidation(false);
        }

        private void contactBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            setDefaults();
        }

        private void contactBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
//            doValidation(true);
        }

        private void comboLocation_Enter(object sender, EventArgs e)
        {
            if (!canceling && comboLocation.Rows.Count == 0)
            {
                interop.SendMenuSignal("LOCTNMNT");
            }
        }

        private void btnLocationMaint_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("LOCTNMNT");
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.TextLength == 0)
            {
                errorProvider.SetError(txtFirstName, "Name required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtFirstName, "");
                e.Cancel = false;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.TextLength == 0)
            {
                errorProvider.SetError(txtLastName, "Name required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLastName, "");
                e.Cancel = false;
            }
        }

    }
}
