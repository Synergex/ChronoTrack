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
    public partial class CustomerLocationMaintenance : Form
    {
        //need a copy of the interop object
        private SynInterop interop;
        
        //hold the current customer ID
        private string custID;
        private DataTable locationTable;

        //need some location fields
        Point zipUSLabelPoint;
        Point zipUSEditPoint;
        Point zipUKLabelPoint;
        Point zipUKEditPoint;

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="i"></param>
        public CustomerLocationMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;
            interop.DebugMessage(string.Concat(this.Text, " Default constructor "));

            zipUSLabelPoint = new Point(labelZip.Location.X, comboState.Location.Y + 4);
            zipUSEditPoint = new Point(txtZip.Location.X, comboState.Location.Y);
            zipUKLabelPoint = new Point(labelZip.Location.X, txtAddress4.Location.Y + 4);
            zipUKEditPoint = new Point(txtZip.Location.X, txtAddress4.Location.Y);
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
            interop.DebugMessage(string.Concat(this.Text, " SetDataTable"));

            toolStripLabel1.Text = string.Concat("Customer ID : ", customerID);
            custID = customerID;
            locationTable = locations;
            locationBindingSource.DataSource = locationTable;
            countryBindingSource.DataSource = country;
            stateBindingSource.DataSource = state;
            if (locationTable.Rows.Count == 0)
            {
                interop.DebugMessage(string.Concat(this.Text, " forcing AddNew - no rows in location table"));

                locationBindingSource.AddNew();
            }
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            txtDescription.Focus();
        }

        private void comboCountry_ValueChanged(object sender, EventArgs e)
        {
            formatDisplay();
        }
        private void formatDisplay()
        {
            interop.DebugMessage(string.Concat(this.Text, " formatDisplay()"));
            //based on the country change formatting, etc
            Infragistics.Win.UltraWinGrid.UltraGridRow row = comboCountry.SelectedRow;
            if (row != null)
            {
                switch (row.Cells["Country_id"].Text)
                {
                    case "UK":
                        labelState.Visible = false;
                        comboState.Visible = false;
                        labelZip.Location = zipUKLabelPoint;
                        txtZip.Location = zipUKEditPoint;
                        btnStateMnt.Visible = false;
                        labelZip.Text = "Post code";
                        break;
                    case "US":
                        labelState.Visible = true;
                        comboState.Visible = true;
                        btnStateMnt.Visible = true;
                        labelZip.Location = zipUSLabelPoint;
                        txtZip.Location = zipUSEditPoint;
                        labelZip.Text = "Zip code";
                        break;
                    default:
                        break;
                }
            }
        }
        private void doValidation(bool addingNew)
        {
            interop.DebugMessage(string.Concat(this.Text, " doValidation()"));

            //perform form validdation first
            if (!this.ValidateChildren(ValidationConstraints.Enabled))
                return;

            //attempt to complete the edit, if OK we can continue
            try
            {
                locationBindingSource.EndEdit();
                if (addingNew)
                {
                    locationBindingSource.AddNew();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void setDefaults()
        {
            interop.DebugMessage(string.Concat(this.Text, " setDefaults()"));

            DataRowView row = (DataRowView)locationBindingSource.Current;
            if (row.IsNew)
            {
                interop.DebugMessage(string.Concat(this.Text, " creating a new row, setting defaults"));
                row["Customer_id"] = custID;
                //how many items are in the table
                int i = locationTable.Rows.Count;
                i++;
                row["Location_id"] = i;
                row["Country_id"] = "UK";
                txtDescription.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Cancel(interop, this, locationBindingSource))
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Save(interop, this, locationBindingSource))
                Close();
        }

        private void bindingNavigator_Click(object sender, EventArgs e)
        {
            doValidation(false);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            doValidation(true);
        }

        private void locationBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            setDefaults();
        }

        private void locationBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            txtDescription.Focus();
        }
    }
}   
