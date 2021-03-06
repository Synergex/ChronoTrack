namespace ODBCdashboard
{
    partial class ODBCform
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
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions2 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel4 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions3 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel1 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.PiePointOptions piePointOptions1 = new DevExpress.XtraCharts.PiePointOptions();
            DevExpress.XtraCharts.PiePointOptions piePointOptions2 = new DevExpress.XtraCharts.PiePointOptions();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel2 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView2 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            this.ProjectSummaryGridControl = new DevExpress.XtraGrid.GridControl();
            this.pROJSUMMARYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectSummaryDS = new ODBCdashboard.ProjectSummaryDS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLEAD_CONSULTANT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOMPANY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOCDESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPROJECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTART_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEND_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCURRENT_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pROJSUMMARYTableAdapter = new ODBCdashboard.ProjectSummaryDSTableAdapters.PROJSUMMARYTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FeesChartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pROJHOURSTableAdapter = new ODBCdashboard.ProjHoursTableAdapters.PROJHOURSTableAdapter();
            this.pROJFEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projFees = new ODBCdashboard.ProjFees();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.HoursChartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.ExpensesChartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pROJEXPENSESTableAdapter = new ODBCdashboard.ProjExpDSTableAdapters.PROJEXPENSESTableAdapter();
            this.pROJEXPENSESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projExpDS = new ODBCdashboard.ProjExpDS();
            this.pROJHOURSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projHours = new ODBCdashboard.ProjHours();
            this.pROJFEESTableAdapter = new ODBCdashboard.ProjFeesTableAdapters.PROJFEESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSummaryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJSUMMARYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSummaryDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeesChartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJFEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projFees)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursChartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesChartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEXPENSESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projExpDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJHOURSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projHours)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectSummaryGridControl
            // 
            this.ProjectSummaryGridControl.DataSource = this.pROJSUMMARYBindingSource;
            this.ProjectSummaryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectSummaryGridControl.Location = new System.Drawing.Point(0, 0);
            this.ProjectSummaryGridControl.MainView = this.gridView1;
            this.ProjectSummaryGridControl.Name = "ProjectSummaryGridControl";
            this.ProjectSummaryGridControl.Size = new System.Drawing.Size(984, 395);
            this.ProjectSummaryGridControl.TabIndex = 0;
            this.ProjectSummaryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pROJSUMMARYBindingSource
            // 
            this.pROJSUMMARYBindingSource.DataMember = "PROJSUMMARY";
            this.pROJSUMMARYBindingSource.DataSource = this.projectSummaryDS;
            // 
            // projectSummaryDS
            // 
            this.projectSummaryDS.DataSetName = "ProjectSummaryDS";
            this.projectSummaryDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLEAD_CONSULTANT,
            this.colCOMPANY,
            this.colLOCDESC,
            this.colPROJECT_ID,
            this.colSTART_DATE,
            this.colEND_DATE,
            this.colCURRENT_STATUS,
            this.colDESCRIPTION,
            this.colTEXT});
            this.gridView1.GridControl = this.ProjectSummaryGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colLEAD_CONSULTANT
            // 
            this.colLEAD_CONSULTANT.Caption = "Lead Consultant";
            this.colLEAD_CONSULTANT.FieldName = "LEAD_CONSULTANT";
            this.colLEAD_CONSULTANT.Name = "colLEAD_CONSULTANT";
            this.colLEAD_CONSULTANT.Visible = true;
            this.colLEAD_CONSULTANT.VisibleIndex = 0;
            this.colLEAD_CONSULTANT.Width = 88;
            // 
            // colCOMPANY
            // 
            this.colCOMPANY.Caption = "Company";
            this.colCOMPANY.FieldName = "COMPANY";
            this.colCOMPANY.Name = "colCOMPANY";
            this.colCOMPANY.Visible = true;
            this.colCOMPANY.VisibleIndex = 1;
            this.colCOMPANY.Width = 125;
            // 
            // colLOCDESC
            // 
            this.colLOCDESC.Caption = "Location";
            this.colLOCDESC.FieldName = "LOCDESC";
            this.colLOCDESC.Name = "colLOCDESC";
            this.colLOCDESC.Visible = true;
            this.colLOCDESC.VisibleIndex = 2;
            this.colLOCDESC.Width = 111;
            // 
            // colPROJECT_ID
            // 
            this.colPROJECT_ID.Caption = "Project";
            this.colPROJECT_ID.FieldName = "PROJECT_ID";
            this.colPROJECT_ID.Name = "colPROJECT_ID";
            this.colPROJECT_ID.Visible = true;
            this.colPROJECT_ID.VisibleIndex = 3;
            this.colPROJECT_ID.Width = 59;
            // 
            // colSTART_DATE
            // 
            this.colSTART_DATE.Caption = "Start Date";
            this.colSTART_DATE.FieldName = "START_DATE";
            this.colSTART_DATE.Name = "colSTART_DATE";
            this.colSTART_DATE.Visible = true;
            this.colSTART_DATE.VisibleIndex = 4;
            this.colSTART_DATE.Width = 88;
            // 
            // colEND_DATE
            // 
            this.colEND_DATE.Caption = "End Date";
            this.colEND_DATE.FieldName = "END_DATE";
            this.colEND_DATE.Name = "colEND_DATE";
            this.colEND_DATE.Visible = true;
            this.colEND_DATE.VisibleIndex = 5;
            this.colEND_DATE.Width = 88;
            // 
            // colCURRENT_STATUS
            // 
            this.colCURRENT_STATUS.Caption = "CURRENT_STATUS";
            this.colCURRENT_STATUS.FieldName = "CURRENT_STATUS";
            this.colCURRENT_STATUS.Name = "colCURRENT_STATUS";
            this.colCURRENT_STATUS.Width = 88;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "Overview";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 6;
            this.colDESCRIPTION.Width = 88;
            // 
            // colTEXT
            // 
            this.colTEXT.Caption = "Notes";
            this.colTEXT.FieldName = "TEXT";
            this.colTEXT.Name = "colTEXT";
            this.colTEXT.Visible = true;
            this.colTEXT.VisibleIndex = 7;
            this.colTEXT.Width = 88;
            // 
            // pROJSUMMARYTableAdapter
            // 
            this.pROJSUMMARYTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProjectSummaryGridControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 395);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 328);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitContainer1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 315);
            this.panel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FeesChartControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(984, 315);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 2;
            // 
            // FeesChartControl1
            // 
            this.FeesChartControl1.DataAdapter = this.pROJHOURSTableAdapter;
            this.FeesChartControl1.DataSource = this.pROJFEESBindingSource;
            xyDiagram1.AxisX.Label.Angle = 45;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.FeesChartControl1.Diagram = xyDiagram1;
            this.FeesChartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeesChartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.FeesChartControl1.Legend.Visible = false;
            this.FeesChartControl1.Location = new System.Drawing.Point(0, 0);
            this.FeesChartControl1.Name = "FeesChartControl1";
            series1.ArgumentDataMember = "ASSIGNED_TO";
            sideBySideBarSeriesLabel1.LineVisible = true;
            sideBySideBarSeriesLabel1.Visible = false;
            series1.Label = sideBySideBarSeriesLabel1;
            series1.Name = "Amount";
            series1.SummaryFunction = "SUM([BILLABLEAMT])";
            this.FeesChartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel2.LineVisible = true;
            this.FeesChartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel2;
            pointOptions1.PointView = DevExpress.XtraCharts.PointView.Argument;
            this.FeesChartControl1.SeriesTemplate.LegendPointOptions = pointOptions1;
            this.FeesChartControl1.SeriesTemplate.SynchronizePointOptions = false;
            this.FeesChartControl1.Size = new System.Drawing.Size(328, 315);
            this.FeesChartControl1.TabIndex = 2;
            chartTitle1.Text = "Billable Amounts";
            this.FeesChartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // pROJHOURSTableAdapter
            // 
            this.pROJHOURSTableAdapter.ClearBeforeFill = true;
            // 
            // pROJFEESBindingSource
            // 
            this.pROJFEESBindingSource.DataMember = "PROJFEES";
            this.pROJFEESBindingSource.DataSource = this.projFees;
            // 
            // projFees
            // 
            this.projFees.DataSetName = "ProjFees";
            this.projFees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.HoursChartControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ExpensesChartControl1);
            this.splitContainer2.Size = new System.Drawing.Size(652, 315);
            this.splitContainer2.SplitterDistance = 317;
            this.splitContainer2.TabIndex = 1;
            // 
            // HoursChartControl1
            // 
            this.HoursChartControl1.DataAdapter = this.pROJHOURSTableAdapter;
            this.HoursChartControl1.DataSource = this.pROJFEESBindingSource;
            xyDiagram2.AxisX.Label.Angle = 45;
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.HoursChartControl1.Diagram = xyDiagram2;
            this.HoursChartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoursChartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.HoursChartControl1.Legend.Visible = false;
            this.HoursChartControl1.Location = new System.Drawing.Point(0, 0);
            this.HoursChartControl1.Name = "HoursChartControl1";
            series2.ArgumentDataMember = "ASSIGNED_TO";
            sideBySideBarSeriesLabel3.LineVisible = true;
            sideBySideBarSeriesLabel3.Visible = false;
            series2.Label = sideBySideBarSeriesLabel3;
            pointOptions2.PointView = DevExpress.XtraCharts.PointView.Argument;
            series2.LegendPointOptions = pointOptions2;
            series2.Name = "Hours";
            series2.SummaryFunction = "SUM([BILLABLE_HOURS])";
            series2.SynchronizePointOptions = false;
            this.HoursChartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            sideBySideBarSeriesLabel4.LineVisible = true;
            this.HoursChartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel4;
            pointOptions3.PointView = DevExpress.XtraCharts.PointView.Argument;
            this.HoursChartControl1.SeriesTemplate.LegendPointOptions = pointOptions3;
            this.HoursChartControl1.SeriesTemplate.SynchronizePointOptions = false;
            this.HoursChartControl1.Size = new System.Drawing.Size(317, 315);
            this.HoursChartControl1.TabIndex = 3;
            chartTitle2.Text = "Billable Hours";
            this.HoursChartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // ExpensesChartControl1
            // 
            this.ExpensesChartControl1.DataAdapter = this.pROJEXPENSESTableAdapter;
            this.ExpensesChartControl1.DataSource = this.pROJEXPENSESBindingSource;
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            this.ExpensesChartControl1.Diagram = simpleDiagram3D1;
            this.ExpensesChartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpensesChartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.ExpensesChartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.ExpensesChartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.ExpensesChartControl1.Legend.EquallySpacedItems = false;
            this.ExpensesChartControl1.Location = new System.Drawing.Point(0, 0);
            this.ExpensesChartControl1.Name = "ExpensesChartControl1";
            series3.ArgumentDataMember = "EXPENSED_BY";
            pie3DSeriesLabel1.LineVisible = true;
            series3.Label = pie3DSeriesLabel1;
            piePointOptions1.PercentOptions.PercentageAccuracy = 4;
            piePointOptions1.PercentOptions.ValueAsPercent = false;
            piePointOptions1.PointView = DevExpress.XtraCharts.PointView.Argument;
            piePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
            series3.LegendPointOptions = piePointOptions1;
            series3.Name = "Series 1";
            piePointOptions2.PercentOptions.ValueAsPercent = false;
            series3.PointOptions = piePointOptions2;
            series3.SummaryFunction = "SUM([EXPAMT])";
            series3.SynchronizePointOptions = false;
            series3.View = pie3DSeriesView1;
            this.ExpensesChartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            pie3DSeriesLabel2.LineVisible = true;
            this.ExpensesChartControl1.SeriesTemplate.Label = pie3DSeriesLabel2;
            this.ExpensesChartControl1.SeriesTemplate.View = pie3DSeriesView2;
            this.ExpensesChartControl1.Size = new System.Drawing.Size(331, 315);
            this.ExpensesChartControl1.TabIndex = 1;
            chartTitle3.Text = "Expenses";
            this.ExpensesChartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // pROJEXPENSESTableAdapter
            // 
            this.pROJEXPENSESTableAdapter.ClearBeforeFill = true;
            // 
            // pROJEXPENSESBindingSource
            // 
            this.pROJEXPENSESBindingSource.DataMember = "PROJEXPENSES";
            this.pROJEXPENSESBindingSource.DataSource = this.projExpDS;
            // 
            // projExpDS
            // 
            this.projExpDS.DataSetName = "ProjExpDS";
            this.projExpDS.EnforceConstraints = false;
            this.projExpDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJHOURSBindingSource
            // 
            this.pROJHOURSBindingSource.DataMember = "PROJHOURS";
            this.pROJHOURSBindingSource.DataSource = this.projHours;
            // 
            // projHours
            // 
            this.projHours.DataSetName = "ProjHours";
            this.projHours.EnforceConstraints = false;
            this.projHours.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROJFEESTableAdapter
            // 
            this.pROJFEESTableAdapter.ClearBeforeFill = true;
            // 
            // ODBCform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 714);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ODBCform";
            this.Text = "ODBCform";
            this.Load += new System.EventHandler(this.ODBCform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectSummaryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJSUMMARYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSummaryDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeesChartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJFEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projFees)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursChartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesChartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJEXPENSESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projExpDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROJHOURSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ProjectSummaryGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ProjectSummaryDS projectSummaryDS;
        private System.Windows.Forms.BindingSource pROJSUMMARYBindingSource;
        private ODBCdashboard.ProjectSummaryDSTableAdapters.PROJSUMMARYTableAdapter pROJSUMMARYTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCOMPANY;
        private DevExpress.XtraGrid.Columns.GridColumn colPROJECT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colSTART_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colEND_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colCURRENT_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colLEAD_CONSULTANT;
        private DevExpress.XtraGrid.Columns.GridColumn colTEXT;
        private DevExpress.XtraGrid.Columns.GridColumn colLOCDESC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ODBCdashboard.ProjExpDSTableAdapters.PROJEXPENSESTableAdapter pROJEXPENSESTableAdapter;
        private ProjExpDS projExpDS;
        private System.Windows.Forms.BindingSource pROJEXPENSESBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraCharts.ChartControl FeesChartControl1;
        private ODBCdashboard.ProjHoursTableAdapters.PROJHOURSTableAdapter pROJHOURSTableAdapter;
        private ProjHours projHours;
        private System.Windows.Forms.BindingSource pROJHOURSBindingSource;
        private ProjFees projFees;
        private System.Windows.Forms.BindingSource pROJFEESBindingSource;
        private ODBCdashboard.ProjFeesTableAdapters.PROJFEESTableAdapter pROJFEESTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraCharts.ChartControl HoursChartControl1;
        private DevExpress.XtraCharts.ChartControl ExpensesChartControl1;

    }
}