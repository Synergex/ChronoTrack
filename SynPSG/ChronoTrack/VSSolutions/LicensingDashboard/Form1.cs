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

namespace LicensingDashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lOGIN_AUDITTableAdapter.Fill(this.dataSet1.LOGIN_AUDIT);

            this.UpperDateEdit.DateTime = new DateTime(2009, 04, 30);
            this.LowerDateEdit.DateTime = new DateTime(2009, 04, 01);
            
            refreshData();
        }

        private void refreshData()
        {
            resetChartSeries(chartControl1);
            resetChartSeries(chartControl2);
            resetChartSeries(chartControl3);
        }

        private void resetChartSeries(DevExpress.XtraCharts.ChartControl chartControlX)
        {
            // same day, switch alignment to hour
            if (this.LowerDateEdit.EditValue == this.UpperDateEdit.EditValue)
            {
                ((DevExpress.XtraCharts.XYDiagram)chartControlX.Diagram).AxisX.DateTimeGridAlignment = DevExpress.XtraCharts.DateTimeMeasurementUnit.Hour;
                ((DevExpress.XtraCharts.XYDiagram)chartControlX.Diagram).AxisX.DateTimeMeasureUnit = DevExpress.XtraCharts.DateTimeMeasurementUnit.Hour;
            }
            else
            {
                ((DevExpress.XtraCharts.XYDiagram)chartControlX.Diagram).AxisX.DateTimeGridAlignment = DevExpress.XtraCharts.DateTimeMeasurementUnit.Day;
                ((DevExpress.XtraCharts.XYDiagram)chartControlX.Diagram).AxisX.DateTimeMeasureUnit = DevExpress.XtraCharts.DateTimeMeasurementUnit.Day;
            }

            foreach (Series series in chartControlX.Series)
            {
                DateTime fromDt = (DateTime)this.LowerDateEdit.DateTime;
                DateTime toDt = (DateTime)this.UpperDateEdit.DateTime.AddDays(1);

                series.DataFilters.Clear();
                series.DataFiltersConjunctionMode = ConjunctionTypes.And;
                if (series.Name == "runtime")
                {
                    series.DataFilters.Add("APPLICATION", "System.String", DataFilterCondition.Equal, "RUN9");
                    series.DataFilters.Add("LOGIN_TIME", "System.DateTime", DataFilterCondition.GreaterThanOrEqual, fromDt);
                    series.DataFilters.Add("LOGIN_TIME", "System.DateTime", DataFilterCondition.LessThan, toDt);
                }
                else if (series.Name == "xfServerPlus")
                {
                    series.DataFilters.Add("APPLICATION", "System.String", DataFilterCondition.Equal, "XFSP9");
                    series.DataFilters.Add("LOGIN_TIME", "System.DateTime", DataFilterCondition.GreaterThanOrEqual, fromDt);
                    series.DataFilters.Add("LOGIN_TIME", "System.DateTime", DataFilterCondition.LessThan, toDt);
                }
                else if (series.Name == "odbc")
                {
                    series.DataFilters.Add("APPLICATION", "System.String", DataFilterCondition.Equal, "ODBC_9");
                    series.DataFilters.Add("LOGIN_TIME", "System.DateTime", DataFilterCondition.GreaterThanOrEqual, fromDt);
                    series.DataFilters.Add("LOGIN_TIME", "System.DateTime", DataFilterCondition.LessThan, toDt);
                }
            }

            chartControlX.RefreshData();
        }

        private void RefreshDataButton_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
