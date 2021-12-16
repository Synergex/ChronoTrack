using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SynPSGNetCore.Interop;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrintingLinks;
using System.Diagnostics;

namespace ChronoTrackNetUIDX.Forms
{
    public partial class UserMaintenance : Form//DevExpress.XtraEditors.XtraForm
    {
        //need a copy of the interop object
        private SynInterop interop;

        public UserMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param>Binding source</param>
        public void SetDataSource(DataTable user, DataTable country, DataTable state)
        {
            interop.DebugMessage("binding UI data source");
            countryBindingSource.DataSource = country;
            stateBindingSource.DataSource = state;
            userBindingSource.DataSource = user;
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Cancel(interop, this, userBindingSource))
                Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.Generic.Handles_Save(interop, this, userBindingSource))
                Close();
        }

        private void btnCountryMnt_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("CountryMnt");
        }

        private void btnStateMnt_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("StateMnt");
        }

        private void layoutViewField_colCountry_id_1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("changed");
        }

        private void layoutView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            //is it the country field thats changed
            if (layoutView1.FocusedColumn.Name == "colCountry_id")
            {
                //yes, check if we are uk
                if (e.Value.ToString() == "GB")
                {
                    //yes, UK, so modify state and zip
                    colState.Visible = false;
                }
                else
                {
                    //No,so modify to allow
                    colState.Visible = true;
                }
            }
            e.Valid = true;
        }

        private void layoutView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "imageColumn" && e.IsGetData)
            {
                try
                {
                    LayoutView view = sender as LayoutView;

                    Image img;

                    pictureName = (string)view.GetRowCellValue(e.RowHandle, "Picture_file");

                    if (System.IO.File.Exists(string.Concat("C:\\Development\\SynPSG\\ChronoTrack\\dat\\", pictureName)))
                    {
                        img = Image.FromFile(string.Concat("C:\\Development\\SynPSG\\ChronoTrack\\dat\\", pictureName));
                    }
                    else
                    {
                        img = Image.FromFile("C:\\Development\\SynPSG\\ChronoTrack\\dat\\NoPhotoAvailable.jpg");
                    }

                    e.Value = img;
                }
                catch
                {
                }
            }

        }

        private string pictureName = "";

        private void btnExport_Click(object sender, EventArgs e)
        {
            Process viewIt;
            userGridControl.ExportToPdf(@"C:\UserReport.pdf");
            viewIt = new Process();
            viewIt.StartInfo.FileName = @"C:\UserReport.pdf";
            viewIt.Start();


        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "toolDelete":
                    if (MessageBox.Show("Delete user?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        layoutView1.DeleteRow(layoutView1.FocusedRowHandle);
                    }
                    break;
                case "toolAdd":
                    layoutView1.AddNewRow();
                    break;
                default:
                    break;
            }
        }
    }
}