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
    public partial class ProjectCreate : Form
    {
        //need a copy of the interop object
        private SynInterop interop;
        private bool closing;

        public ProjectCreate(SynInterop i)
        {
            InitializeComponent();
            interop = i;
            closing = false;
        }

        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param>Binding source</param>
        public void SetDataSource(DataTable project, DataTable customer, DataTable user)
        {
            //assign passed binding source
            customerBindingSource.DataSource = customer;
            projectBindingSource.DataSource = project;
            leadBindingSource.DataSource = user;
            coordBindingSource.DataSource = user;
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            //set some defaults
            comboCustomer.Focus();
        }

        public string CustomerID
        {
            get
            {
                string cID="";
                if (comboCustomer.SelectedRow != null)
                {
                    cID = comboCustomer.SelectedRow.Cells["Customer_id"].Text;
                }
                return cID;
            }
        }

        public void SetContactTable(DataTable contact)
        {
            contactBindingSource.DataSource = contact;
        }

        public string ContactID
        {
            get
            {
                string cID = "";
                if (comboContact.SelectedRow != null)
                {
                    cID = comboContact.SelectedRow.Cells["Contact_id"].Text;
                }
                return cID;
            }
        }

        public void SetLocationTable(DataTable location)
        {
            locationBindingSource.DataSource = location;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)projectBindingSource.DataSource;
            DataRow row= dt.Rows[0];


            if (ChronoTrackNetUICommon.Generic.Handles_Save(interop, this, projectBindingSource))
            {
                closing = true;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Cancel(interop, this, projectBindingSource))
            {
                closing = true;
                Close();
            }
        }

        private void dateEnd_Validating(object sender, CancelEventArgs e)
        {
            if ((DateTime) dateEnd.Value < (DateTime) dateStart.Value)
            {
                errorProvider.SetError(dateEnd, "End date mustbe after the start date");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dateEnd, "");
                e.Cancel = false;
            }
        }

        private void dateStart_Validated(object sender, EventArgs e)
        {
        }

        private void comboCustomer_RowSelected(object sender, Infragistics.Win.UltraWinGrid.RowSelectedEventArgs e)
        {
            if (!closing)
            {
                interop.SendMenuSignal("LDCONT");
                comboContact.Enabled = true;
            }
        }

        private void comboContact_RowSelected(object sender, Infragistics.Win.UltraWinGrid.RowSelectedEventArgs e)
        {
            if (!closing)
            {
                interop.SendMenuSignal("LDLOCN");
                comboLocation.Enabled = true;
            }
        }
    }
}
