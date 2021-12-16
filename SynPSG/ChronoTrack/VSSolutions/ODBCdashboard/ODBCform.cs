using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;


namespace ODBCdashboard
{
    public partial class ODBCform : Form
    {
        private Boolean debugMode = false;

        public ODBCform()
        {
            InitializeComponent();
        }

        private void ODBCform_Load(object sender, EventArgs e)
        {
            this.pROJSUMMARYTableAdapter.Fill(this.projectSummaryDS.PROJSUMMARY);
            this.pROJEXPENSESTableAdapter.Fill(this.projExpDS.PROJEXPENSES);
            this.pROJHOURSTableAdapter.Fill(this.projHours.PROJHOURS);
            this.pROJFEESTableAdapter.Fill(this.projFees.PROJFEES);
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            filterData();
        }

        private void filterData()
        {
            //copy to local field
            GridView view = gridView1;

            //getcurrent row handle
            int hdl = view.FocusedRowHandle;

            //need an array list
            ArrayList rowsSelected = new ArrayList();

            //fill the array with project ID's
            getChildRows(view, hdl, rowsSelected);

            foreach (Series series in ExpensesChartControl1.Series)
            {
                series.DataFilters.Clear();
                series.DataFiltersConjunctionMode = ConjunctionTypes.Or;
                foreach (Int32 item in rowsSelected)
                {
                    series.DataFilters.Add("PROJECT_ID", "System.Int32", DataFilterCondition.Equal, item);
                }
            }
            ExpensesChartControl1.RefreshData();

            foreach (Series series in FeesChartControl1.Series)
            {
                series.DataFilters.Clear();
                series.DataFiltersConjunctionMode = ConjunctionTypes.Or;
                foreach (Int32 item in rowsSelected)
                {
                    series.DataFilters.Add("PROJECT_ID", "System.Int32", DataFilterCondition.Equal, item);
                }
            }
            FeesChartControl1.RefreshData();

            foreach (Series series in HoursChartControl1.Series)
            {
                series.DataFilters.Clear();
                series.DataFiltersConjunctionMode = ConjunctionTypes.Or;
                foreach (Int32 item in rowsSelected)
                {
                    series.DataFilters.Add("PROJECT_ID", "System.Int32", DataFilterCondition.Equal, item);
                }
            }
            HoursChartControl1.RefreshData();

            if (debugMode == true)
            {
                foreach (Series series in FeesChartControl1.Series)
                {
                    foreach (SeriesPoint points in series.Points)
                    {
                        foreach (double item in points.Values)
                        {
                            MessageBox.Show("Series "+series.Name+" Point "+item.ToString());
                        }
                    }
                }
            }
        }

        private void getChildRows(GridView view, int rowHandle, ArrayList childRows)
        {
            if (!view.IsGroupRow(rowHandle))
            {
                //not a group, so get individual project
                DataRow row = view.GetDataRow(view.FocusedRowHandle);
                if (row != null)
                {
                    object obj = row["Project_id"];
                    if (obj != null)
                        childRows.Add(obj);
                }
            }
            else
            {
                //get number of child rows in group
                int childCount = view.GetChildRowCount(rowHandle);

                for (int i = 0; i < childCount; i++)
                {
                    int childHdl = view.GetChildRowHandle(rowHandle, i);
                    if (view.IsGroupRow(childHdl))
                        getChildRows(view, childHdl, childRows);
                    else
                    {
                        DataRow row = view.GetDataRow(childHdl);
                        if (row != null)
                        {
                            object obj = row["Project_id"];
                            if (obj != null)
                                childRows.Add(obj);
                        }
                    }
                }
            }
            if (debugMode == true)
            {
                foreach (Int32 item in childRows)
                {
                    MessageBox.Show("Project_ID "+item.ToString());
                }
            }
        }
    }
}
