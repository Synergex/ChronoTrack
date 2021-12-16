using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Policy;
using System.Reflection;
using SynPSGNetCore.Interop;

namespace ChronoTrackNetUIDX.Forms
{
    public partial class About : Form//DevExpress.XtraEditors.XtraForm
    {
        private SynInterop interop;

        public About(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            btnClose.Focus();
        }

        public string TKVersion
        {
            set { labelTKVersion.Text = value; }
        }

        public string DBLVersion
        {
            set { labelDBLVersion.Text = value; }
        }

        public string AppVersion
        {
            set { labelChronoTrackVersion.Text = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("MB_CANCEL");
        }

        private void About_Load(object sender, EventArgs e)
        {
            //put the assembly information into the list
            AppDomain currentDomain = AppDomain.CurrentDomain;
            //provide the current applicaiton domain evidence for the assembly
            Evidence asEvidence = currentDomain.Evidence;

            Assembly[] assemblies = currentDomain.GetAssemblies();

            //create the data table to bind to the grid
            DataTable assemblyTable = new DataTable("AssemblyInfo");
            DataColumn col;
            col = new DataColumn("AssemblyName");
            col.Caption = "Name";
            col.ReadOnly = true;
            col.DataType = typeof(System.String);
            assemblyTable.Columns.Add(col);

            col = new DataColumn("VersionNumber");
            col.Caption = "Version";
            col.ReadOnly = true;
            col.DataType = typeof(System.String);
            assemblyTable.Columns.Add(col);

            //load the grid
            foreach (Assembly asDetails in assemblies)
            {
                DataRow row = assemblyTable.NewRow();
                row[0] = asDetails.GetName().Name;
                row[1] = asDetails.GetName().Version.ToString();
                assemblyTable.Rows.Add(row);
            }
            gridControl1.DataSource = assemblyTable;

        }
    }
}