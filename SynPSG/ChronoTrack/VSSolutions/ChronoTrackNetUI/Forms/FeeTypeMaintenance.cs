using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynPSGNetCore.Interop;
using System.Diagnostics;

namespace ChronoTrackNetUI.Forms
{
    public partial class FeeTypeMaintenance : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

        public FeeTypeMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;
            ultraGrid1.Dock = DockStyle.Fill;
        }
        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param>Binding source</param>
        public void SetDataSource(DataTable feeType)
        {
            interop.DebugMessage("binding UI data source");
            //assign passed data table
            feetypeDTBindingSource.DataSource = feeType;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Cancel(interop, this, feetypeDTBindingSource))
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Save(interop, this, feetypeDTBindingSource))
                Close();
        }

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            ultraLabel1.Text = "Exporting, please wait....";
            this.Update();

            Process viewIt;
            switch (e.Tool.Key)
            {
                case "toExcel":    // ButtonTool
                    // Place code here
                    ultraGridExcelExporter1.Export(ultraGrid1, @"C:\FeeReport.xlsx", Infragistics.Excel.WorkbookFormat.Excel2007);
                    viewIt = new Process();
                    viewIt.StartInfo.FileName = @"C:\FeeReport.xlsx";
                    viewIt.Start();
                    break;

                case "ToPDF":    // ButtonTool
                    // Place code here
                    ultraGridDocumentExporter1.Export(ultraGrid1, @"C:\FeeReport.pdf", Infragistics.Win.UltraWinGrid.DocumentExport.GridExportFileFormat.PDF);
                    viewIt = new Process();
                    viewIt.StartInfo.FileName = @"C:\FeeReport.pdf";
                    viewIt.Start();
                    break;
            }
            ultraLabel1.Text = "";
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ultraGrid1.ActiveRow.Delete(true);
        }
    }
}
