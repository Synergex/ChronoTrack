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
    public partial class UserMaintenance : Form
    {
            //need a copy of the interop object
            private SynInterop interop;

            //need some location fields
            Point zipUSLabelPoint;
            Point zipUSEditPoint;
            Point zipUKLabelPoint;
            Point zipUKEditPoint;

        public UserMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;
            
            zipUSLabelPoint = new Point(labelZip.Location.X, comboState.Location.Y+4);
            zipUSEditPoint = new Point(txtZip.Location.X, comboState.Location.Y);
            zipUKLabelPoint = new Point(labelZip.Location.X, txtAddressFour.Location.Y+4);
            zipUKEditPoint = new Point(txtZip.Location.X, txtAddressFour.Location.Y);
        }

        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param>Binding source</param>
        public void SetDataSource(DataTable user, DataTable country, DataTable state)
        {
            interop.DebugMessage("binding UI data source");
            //assign passed binding source
            userBindingSource.DataSource = user;

            countryBindingSource.DataSource = country;
            stateBindingSource.DataSource = state;

            if (user.Rows.Count == 0)
                userBindingSource.AddNew();
            
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            txtUserID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Save(interop, this, userBindingSource))
                Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Cancel(interop, this, userBindingSource))
                Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //set some UI defaults
            txtUserID.Focus();
            refreshImage();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            interop.DebugMessage("Search button clicked");

        }

        private void txtPictureFile_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            openFileDialog.FileName = txtPictureFile.Text;
            openFileDialog.ShowDialog(this);
            txtPictureFile.Text = openFileDialog.FileName;
        }

        private void btnStateMnt_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("StateMnt");
        }

        private void btnCountryMnt_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("CountryMnt");
        }

        private void txtUserID_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserID.TextLength == 0)
            {
                errorProvider.SetError(txtUserID, "Invalid USER ID");
                txtUserID.Focus();
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUserID, "");
                e.Cancel = false;
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.TextLength < 5)
            {
                errorProvider.SetError(txtPassword, "Invalid password");
                txtPassword.Focus();
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, "");
                e.Cancel = false;
            }

        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.TextLength == 0)
            {
                errorProvider.SetError(txtFirstName, "First name required.");
                txtFirstName.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.TextLength == 0)
            {
                errorProvider.SetError(txtLastName, "Last name required.");
                txtLastName.Focus();
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLastName, "");
                e.Cancel = false;
            }
        }

        private void txtZip_Validating(object sender, CancelEventArgs e)
        {
            if (txtZip.TextLength == 0)
            {
                errorProvider.SetError(txtZip, "Invalid Zip code");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtZip, "");
                e.Cancel = false;
            }
        }

        private void txtAddressOne_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddressOne.TextLength == 0)
            {
                errorProvider.SetError(txtAddressOne, "Invalid address");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAddressOne, "");
                e.Cancel = false;
            }
        }

        private void comboCountry_ValueChanged(object sender, EventArgs e)
        {
            formatDisplay();
        }

        private void formatDisplay()
        {
            //based on the country change formatting, etc
            Infragistics.Win.UltraWinGrid.UltraGridRow row = comboCountry.SelectedRow;
            if (row != null)
            {
                switch (row.Cells["Country_id"].Text)
                {
                    case "UK":
                        txtOfficePhoneUS.Visible = false;
                        txtMobilePhoneUS.Visible = false;
                        txtOfficePhoneUK.Visible = true;
                        txtMobilePhoneUK.Visible = true;
                        labelState.Visible = false;
                        comboState.Visible = false;
                        labelZip.Location = zipUKLabelPoint;
                        txtZip.Location = zipUKEditPoint;
                        btnStateMnt.Visible = false;
                        labelZip.Text = "Post code";
                        break;
                    case "US":
                        txtOfficePhoneUS.Visible = true;
                        txtMobilePhoneUS.Visible = true;
                        txtOfficePhoneUK.Visible = false;
                        txtMobilePhoneUK.Visible = false;
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

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            interop.DebugMessage("loosing user id focus");
        }

        private void userBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            txtUserID.Focus();
        }

        private void txtPictureFile_Validated(object sender, EventArgs e)
        {
            refreshImage();
        }

        private void refreshImage()
        {
            //when the picture file is validated, attempt to load the picture
            try
            {
                pictureBox.ImageLocation = txtPictureFile.Text;
                pictureBox.Load();
            }
            catch
            {
            }
        }
        private void userBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            refreshImage();
        }

    }
}
