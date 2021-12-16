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
    public partial class ProjectView : Form//DevExpress.XtraEditors.XtraForm
    {
        private SynInterop interop;
        private DataSet ganttDataSet;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="i"></param>
        public ProjectView(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// set the required data sources
        /// </summary>
        /// <param name="user"></param>
        /// <param name="gantt"></param>
        public void SetDataSource(DataTable user, DataTable gantt)
        {
            ganttDataSet = new DataSet("GanttData");
            ganttDataSet.Tables.Add(user);
            ganttDataSet.Tables.Add(gantt);

            DataRelation keyRel = new DataRelation("Keys", user.Columns["User_id"], gantt.Columns["User_id"], false);
            ganttDataSet.Relations.Add(keyRel);

        }

                /// <summary>
        /// allow synergy to set the focus
        /// </summary>
        public void SetFocus(int setView)
        {
        }

        public void RefreshFormData()
        {
        }
    }
}