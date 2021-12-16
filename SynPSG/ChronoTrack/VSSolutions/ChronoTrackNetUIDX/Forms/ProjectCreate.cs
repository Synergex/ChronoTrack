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
    public partial class ProjectCreate : Form//DevExpress.XtraEditors.XtraForm
    {
        //need a copy of the interop object
        private SynInterop interop;

        public ProjectCreate(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param>Binding source</param>
        public void SetDataSource(DataTable project, DataTable customer, DataTable user)
        {
/*            //assign passed binding source
            customerBindingSource.DataSource = customer;
            projectBindingSource.DataSource = project;
            leadBindingSource.DataSource = user;
            coordBindingSource.DataSource = user;*/
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            //set some defaults
/*            comboCustomer.SelectedIndex = 0;   //first
            comboLead.SelectedIndex = 0;
            comboCoordinator.SelectedIndex = 0;
            comboCustomer.Focus();*/
        }
        public string CustomerID
        {
            get
            {
                string cID = "";
                return cID;
            }
        }

        public void SetContactTable(DataTable contact)
        {
        }

        public string ContactID
        {
            get
            {
                string cID = "";
                return cID;
            }
        }

        public void SetLocationTable(DataTable location)
        {
        }


    }
}