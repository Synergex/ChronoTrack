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
    public partial class CustomerLocationMaintenance : Form//DevExpress.XtraEditors.XtraForm
    {
        //need a copy of the interop object
        private SynInterop interop;

        //hold the current customer ID
//        private string custID;
//        private DataTable locationTable;

        //need some location fields
//        Point zipUSLabelPoint;
//        Point zipUSEditPoint;
//        Point zipUKLabelPoint;
//        Point zipUKEditPoint;

        /// <summary>
        /// default constructor
        /// </summary>
        /// <param name="i"></param>
        public CustomerLocationMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;

/*            zipUSLabelPoint = new Point(labelZip.Location.X, comboState.Location.Y + 4);
            zipUSEditPoint = new Point(txtZip.Location.X, comboState.Location.Y);
            zipUKLabelPoint = new Point(labelZip.Location.X, txtAddress4.Location.Y + 4);
            zipUKEditPoint = new Point(txtZip.Location.X, txtAddress4.Location.Y);
  */
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

        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
        }
    }
}