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
    public partial class ProjectCreate : Form
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
            //assign passed binding source
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
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
