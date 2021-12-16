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
    public partial class FeeTypeMaintenance : Form//DevExpress.XtraEditors.XtraForm
    {
        //need a copy of the interop object
        private SynInterop interop;

        public FeeTypeMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }
        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param>Binding source</param>
        public void SetDataSource(DataTable feeType)
        {
            interop.DebugMessage("binding UI data source");
            //assign passed data table
//            feetypeDTBindingSource.DataSource = feeType;
        }
    }
}