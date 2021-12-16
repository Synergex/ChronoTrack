using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynPSGNetCore.Interop;
using DevExpress.XtraGrid.Views;

namespace ChronoTrackNetUIDX.Forms
{
    public partial class ProjectMaint : Form
    {
        SynInterop interop;
        public ProjectMaint(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        public void SetDataSource(DataTable prj
            , DataTable prjTask, DataTable prjActivity, DataTable pjAttachment, DataTable prjFee
            , DataTable prjExp, DataTable prjNote, DataTable feeSource, DataTable userSource
            , DataTable expSource)
        {
            projectBindingSource.DataSource = prj;
            projectnoteDTBindingSource.DataSource = prjNote;
            projectconsultantDTBindingSource.DataSource = prjFee;
            projectexpenseDTBindingSource.DataSource = prjExp;

            feetypeDTBindingSource.DataSource = feeSource;
            userDTBindingSource.DataSource = userSource;
            MessageBox.Show(userSource.Rows[0][0].ToString());
            expensetypeDTBindingSource.DataSource = expSource;

        }

        public void SetFocus()
        {
            txtID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("MB_COMMIT");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("MB_CANCEL");
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)projectBindingSource.DataSource;
            int pID = int.Parse(dt.Rows[0][1].ToString());
            ProjectMaintNewNote frm = new ProjectMaintNewNote(pID, (DataTable)projectnoteDTBindingSource.DataSource);
            frm.ShowDialog(this);
        }

        private void gridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataTable dt = (DataTable)projectBindingSource.DataSource;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["Project_id"], int.Parse(dt.Rows[0][1].ToString()));

        }

        private void gridView3_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataTable dt = (DataTable)projectBindingSource.DataSource;
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["Project_id"], int.Parse(dt.Rows[0][1].ToString()));

        }

        private void DescriptionEditor_Enter(object sender, EventArgs e)
        {

        }

        private void DescriptionEditor_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            e.Cancel = false;
            MessageBox.Show(e.OldValue.ToString());
        }

        private void repositoryItemTextEdit1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("leave");
        }

    }
}
