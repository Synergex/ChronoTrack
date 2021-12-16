namespace LicensingDashboard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView3 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel4 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView4 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel5 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView5 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel6 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView6 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.lOGIN_AUDITTableAdapter = new LicensingDashboard.DataSet1TableAdapters.LOGIN_AUDITTableAdapter();
            this.lOGINAUDITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new LicensingDashboard.DataSet1();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.RefreshDataButton = new DevExpress.XtraEditors.SimpleButton();
            this.LowerDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.UpperDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINAUDITBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView6)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.lOGIN_AUDITTableAdapter;
            this.chartControl1.DataSource = this.lOGINAUDITBindingSource;
            xyDiagram1.AxisX.DateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.MonthAndDay;
            xyDiagram1.AxisX.Label.Angle = 45;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(12, 52);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Solstice";
            series1.ArgumentDataMember = "LOGIN_TIME";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.DataFilters.ClearAndAddRange(new DevExpress.XtraCharts.DataFilter[] {
            new DevExpress.XtraCharts.DataFilter("APPLICATION", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "RUN9")});
            pointSeriesLabel1.LineVisible = true;
            pointSeriesLabel1.Visible = false;
            series1.Label = pointSeriesLabel1;
            series1.Name = "runtime";
            series1.SummaryFunction = "AVERAGE([CONCURRENT_USERS])";
            series1.View = splineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pointSeriesLabel2.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = pointSeriesLabel2;
            this.chartControl1.SeriesTemplate.View = splineSeriesView2;
            this.chartControl1.Size = new System.Drawing.Size(855, 197);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // lOGIN_AUDITTableAdapter
            // 
            this.lOGIN_AUDITTableAdapter.ClearBeforeFill = true;
            // 
            // lOGINAUDITBindingSource
            // 
            this.lOGINAUDITBindingSource.DataMember = "LOGIN_AUDIT";
            this.lOGINAUDITBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(54, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Date Range";
            // 
            // RefreshDataButton
            // 
            this.RefreshDataButton.Location = new System.Drawing.Point(632, 13);
            this.RefreshDataButton.Name = "RefreshDataButton";
            this.RefreshDataButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshDataButton.TabIndex = 4;
            this.RefreshDataButton.Text = "Refresh";
            this.RefreshDataButton.Click += new System.EventHandler(this.RefreshDataButton_Click);
            // 
            // LowerDateEdit
            // 
            this.LowerDateEdit.EditValue = null;
            this.LowerDateEdit.Location = new System.Drawing.Point(166, 16);
            this.LowerDateEdit.Name = "LowerDateEdit";
            this.LowerDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LowerDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.LowerDateEdit.Size = new System.Drawing.Size(100, 20);
            this.LowerDateEdit.TabIndex = 5;
            // 
            // UpperDateEdit
            // 
            this.UpperDateEdit.EditValue = null;
            this.UpperDateEdit.Location = new System.Drawing.Point(315, 16);
            this.UpperDateEdit.Name = "UpperDateEdit";
            this.UpperDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UpperDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.UpperDateEdit.Size = new System.Drawing.Size(100, 20);
            this.UpperDateEdit.TabIndex = 6;
            // 
            // chartControl2
            // 
            this.chartControl2.DataAdapter = this.lOGIN_AUDITTableAdapter;
            this.chartControl2.DataSource = this.lOGINAUDITBindingSource;
            xyDiagram2.AxisX.DateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.MonthAndDay;
            xyDiagram2.AxisX.Label.Angle = 45;
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram2;
            this.chartControl2.Location = new System.Drawing.Point(12, 458);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.PaletteName = "Solstice";
            series2.ArgumentDataMember = "LOGIN_TIME";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series2.DataFilters.ClearAndAddRange(new DevExpress.XtraCharts.DataFilter[] {
            new DevExpress.XtraCharts.DataFilter("APPLICATION", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "ODBC_9")});
            pointSeriesLabel3.LineVisible = true;
            pointSeriesLabel3.Visible = false;
            series2.Label = pointSeriesLabel3;
            series2.Name = "odbc";
            series2.SummaryFunction = "AVERAGE([CONCURRENT_USERS])";
            series2.View = splineSeriesView3;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            pointSeriesLabel4.LineVisible = true;
            this.chartControl2.SeriesTemplate.Label = pointSeriesLabel4;
            this.chartControl2.SeriesTemplate.View = splineSeriesView4;
            this.chartControl2.Size = new System.Drawing.Size(855, 197);
            this.chartControl2.TabIndex = 7;
            chartTitle2.Text = "";
            this.chartControl2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // chartControl3
            // 
            this.chartControl3.DataAdapter = this.lOGIN_AUDITTableAdapter;
            this.chartControl3.DataSource = this.lOGINAUDITBindingSource;
            xyDiagram3.AxisX.DateTimeOptions.Format = DevExpress.XtraCharts.DateTimeFormat.MonthAndDay;
            xyDiagram3.AxisX.Label.Angle = 45;
            xyDiagram3.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram3.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram3.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl3.Diagram = xyDiagram3;
            this.chartControl3.Location = new System.Drawing.Point(12, 255);
            this.chartControl3.Name = "chartControl3";
            this.chartControl3.PaletteName = "Solstice";
            series3.ArgumentDataMember = "LOGIN_TIME";
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series3.DataFilters.ClearAndAddRange(new DevExpress.XtraCharts.DataFilter[] {
            new DevExpress.XtraCharts.DataFilter("APPLICATION", "System.String", DevExpress.XtraCharts.DataFilterCondition.Equal, "XFSP9")});
            pointSeriesLabel5.LineVisible = true;
            pointSeriesLabel5.Visible = false;
            series3.Label = pointSeriesLabel5;
            series3.Name = "xfServerPlus";
            series3.SummaryFunction = "AVERAGE([CONCURRENT_USERS])";
            series3.View = splineSeriesView5;
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            pointSeriesLabel6.LineVisible = true;
            this.chartControl3.SeriesTemplate.Label = pointSeriesLabel6;
            this.chartControl3.SeriesTemplate.View = splineSeriesView6;
            this.chartControl3.Size = new System.Drawing.Size(855, 197);
            this.chartControl3.TabIndex = 8;
            chartTitle3.Text = "";
            this.chartControl3.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 656);
            this.Controls.Add(this.chartControl3);
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.UpperDateEdit);
            this.Controls.Add(this.LowerDateEdit);
            this.Controls.Add(this.RefreshDataButton);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form1";
            this.Text = "License Usage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINAUDITBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowerDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private LicensingDashboard.DataSet1TableAdapters.LOGIN_AUDITTableAdapter lOGIN_AUDITTableAdapter;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource lOGINAUDITBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton RefreshDataButton;
        private DevExpress.XtraEditors.DateEdit LowerDateEdit;
        private DevExpress.XtraEditors.DateEdit UpperDateEdit;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl3;
    }
}

