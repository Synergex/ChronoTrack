using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ChronoTrackMonitor.Forms
{
    public partial class ProjectView : DevExpress.XtraEditors.XtraForm
    {
        ChronoTrackWS.RemoteService mConnection;

        public ProjectView(ChronoTrackWS.RemoteService connection, DataTable table)
        {
            InitializeComponent();
            mConnection = connection;
            projectGridControl.DataSource = table;
        }

        private void projectViewerOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "toolProjectViewAddNote":
                    ChronoTrackWS.Project prj = new ChronoTrackMonitor.ChronoTrackWS.Project();
                    int[] handle = layoutView1.GetSelectedRows();
                    prj.Project_id = (int)layoutView1.GetRowCellValue(handle[0], "Project_id");
                    prj.Description = (string)layoutView1.GetRowCellValue(handle[0], "Description");
                    AddNote frm = new AddNote(prj);
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        //save te new note
                        mConnection.CreateProjectNote(prj.Project_id, frm.Description, frm.Note);
                    }
                    
                    break;
                default:
                    break;
            }

        }
    }
}