namespace ChronoTrackNetUI.Forms
{
    partial class FeeTypeMaintenance
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Fee_type", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Synergygrfa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Fee_type_id");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Description", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Has_units");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Replication_key");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Changed");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ToPDF");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("toExcel");
            Infragistics.Win.UltraWinToolbars.PopupMenuTool popupMenuTool1 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("exportMenu");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool3 = new Infragistics.Win.UltraWinToolbars.ButtonTool("toExcel");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool4 = new Infragistics.Win.UltraWinToolbars.ButtonTool("ToPDF");
            this.numType = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.feetypeDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDscription = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraSpellChecker = new Infragistics.Win.UltraWinSpellChecker.UltraSpellChecker(this.components);
            this.checkHasUnits = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.ultraGrid1 = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panelButton = new System.Windows.Forms.Panel();
            this.ultraDropDownButton1 = new Infragistics.Win.Misc.UltraDropDownButton();
            this.btnSave = new Infragistics.Win.Misc.UltraButton();
            this.btnCancel = new Infragistics.Win.Misc.UltraButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.ultraGridDocumentExporter1 = new Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter(this.components);
            this.ultraGridExcelExporter1 = new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(this.components);
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ultraToolbarsManager1 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feetypeDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDscription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraSpellChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // numType
            // 
            this.numType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feetypeDTBindingSource, "Fee_type_id", true));
            this.numType.Location = new System.Drawing.Point(230, 108);
            this.numType.MaskInput = "99";
            this.numType.MaxValue = 99;
            this.numType.MinValue = 0;
            this.numType.Name = "numType";
            this.numType.PromptChar = '*';
            this.numType.Size = new System.Drawing.Size(22, 21);
            this.numType.TabIndex = 3;
            this.numType.Visible = false;
            // 
            // feetypeDTBindingSource
            // 
            this.feetypeDTBindingSource.DataSource = typeof(ChronoTrack.Fee_type);
            // 
            // txtDscription
            // 
            this.txtDscription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feetypeDTBindingSource, "Description", true));
            this.txtDscription.Location = new System.Drawing.Point(274, 133);
            this.txtDscription.MaxLength = 35;
            this.txtDscription.Name = "txtDscription";
            this.txtDscription.Size = new System.Drawing.Size(100, 24);
            this.txtDscription.SpellChecker = this.ultraSpellChecker;
            this.txtDscription.TabIndex = 4;
            this.txtDscription.Text = "ultraTextEditor1";
            this.txtDscription.Visible = false;
            // 
            // ultraSpellChecker
            // 
            this.ultraSpellChecker.ContainingControl = this;
            // 
            // checkHasUnits
            // 
            this.checkHasUnits.DataBindings.Add(new System.Windows.Forms.Binding("CheckedValue", this.feetypeDTBindingSource, "Has_units", true));
            this.checkHasUnits.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.feetypeDTBindingSource, "Has_units", true));
            this.checkHasUnits.Location = new System.Drawing.Point(100, 156);
            this.checkHasUnits.Name = "checkHasUnits";
            this.checkHasUnits.Size = new System.Drawing.Size(16, 20);
            this.checkHasUnits.TabIndex = 2;
            this.checkHasUnits.Visible = false;
            // 
            // ultraGrid1
            // 
            this.ultraGrid1.DataSource = this.feetypeDTBindingSource;
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ultraGrid1.DisplayLayout.Appearance = appearance1;
            this.ultraGrid1.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 144;
            ultraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn2.EditorControl = this.numType;
            ultraGridColumn2.Header.Caption = "Fee ID";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.PromptChar = ' ';
            ultraGridColumn2.Width = 54;
            ultraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn3.EditorControl = this.txtDscription;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 294;
            ultraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn4.DefaultCellValue = "True";
            ultraGridColumn4.EditorControl = this.checkHasUnits;
            ultraGridColumn4.Header.Caption = "Has units?";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.PromptChar = ' ';
            ultraGridColumn4.Width = 89;
            ultraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 26;
            ultraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn6.Width = 27;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6});
            this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.ultraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.ultraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.ultraGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.ultraGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.ultraGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            this.ultraGrid1.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            this.ultraGrid1.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.None;
            this.ultraGrid1.DisplayLayout.Override.AllowColSwapping = Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            this.ultraGrid1.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid1.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.ultraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.ultraGrid1.DisplayLayout.Override.CellAppearance = appearance8;
            this.ultraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.ultraGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.ultraGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.ultraGrid1.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.ultraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.ultraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            this.ultraGrid1.DisplayLayout.Override.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.Never;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.ultraGrid1.DisplayLayout.Override.RowAppearance = appearance11;
            this.ultraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.ultraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.ultraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultraGrid1.Location = new System.Drawing.Point(0, 0);
            this.ultraGrid1.Name = "ultraGrid1";
            this.ultraGrid1.Size = new System.Drawing.Size(456, 102);
            this.ultraGrid1.TabIndex = 0;
            this.ultraGrid1.Text = "ultraGrid1";
            this.ultraGrid1.UpdateMode = Infragistics.Win.UltraWinGrid.UpdateMode.OnUpdate;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.ultraLabel1);
            this.panelButton.Controls.Add(this.ultraDropDownButton1);
            this.panelButton.Controls.Add(this.btnSave);
            this.panelButton.Controls.Add(this.btnCancel);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 222);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(493, 23);
            this.panelButton.TabIndex = 1;
            // 
            // ultraDropDownButton1
            // 
            this.ultraDropDownButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ultraDropDownButton1.Location = new System.Drawing.Point(0, 0);
            this.ultraDropDownButton1.Name = "ultraDropDownButton1";
            this.ultraDropDownButton1.PopupItemKey = "exportMenu";
            this.ultraDropDownButton1.PopupItemProvider = this.ultraToolbarsManager1;
            this.ultraDropDownButton1.Size = new System.Drawing.Size(68, 23);
            this.ultraDropDownButton1.TabIndex = 2;
            this.ultraDropDownButton1.Text = "Export";
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(343, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(418, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.checkHasUnits);
            this.panelMain.Controls.Add(this.txtDscription);
            this.panelMain.Controls.Add(this.ultraGrid1);
            this.panelMain.Controls.Add(this.numType);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(493, 222);
            this.panelMain.TabIndex = 0;
            // 
            // _FeeTypeMaintenance_Toolbars_Dock_Area_Left
            // 
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 0);
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Left.Name = "_FeeTypeMaintenance_Toolbars_Dock_Area_Left";
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(0, 245);
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _FeeTypeMaintenance_Toolbars_Dock_Area_Right
            // 
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(493, 0);
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Right.Name = "_FeeTypeMaintenance_Toolbars_Dock_Area_Right";
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(0, 245);
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _FeeTypeMaintenance_Toolbars_Dock_Area_Top
            // 
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Top.Name = "_FeeTypeMaintenance_Toolbars_Dock_Area_Top";
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(493, 0);
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _FeeTypeMaintenance_Toolbars_Dock_Area_Bottom
            // 
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 245);
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Bottom.Name = "_FeeTypeMaintenance_Toolbars_Dock_Area_Bottom";
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(493, 0);
            this._FeeTypeMaintenance_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraLabel1.Location = new System.Drawing.Point(68, 0);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(275, 23);
            this.ultraLabel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 26);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolDelete
            // 
            this.toolDelete.Image = global::ChronoTrackNetUI.Properties.Resources.Delete;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(158, 22);
            this.toolDelete.Text = "Delete fee item";
            // 
            // ultraToolbarsManager1
            // 
            this.ultraToolbarsManager1.DesignerFlags = 1;
            this.ultraToolbarsManager1.DockWithinContainer = this;
            this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
            buttonTool1.SharedProps.Caption = "To PDF";
            buttonTool2.SharedProps.Caption = "To Excel";
            popupMenuTool1.SharedProps.Caption = "Export";
            popupMenuTool1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool3,
            buttonTool4});
            this.ultraToolbarsManager1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool1,
            buttonTool2,
            popupMenuTool1});
            this.ultraToolbarsManager1.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
            // 
            // FeeTypeMaintenance
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(493, 245);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this._FeeTypeMaintenance_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._FeeTypeMaintenance_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._FeeTypeMaintenance_Toolbars_Dock_Area_Top);
            this.Controls.Add(this._FeeTypeMaintenance_Toolbars_Dock_Area_Bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FeeTypeMaintenance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FeeTypeMaintenance";
            ((System.ComponentModel.ISupportInitialize)(this.numType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feetypeDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDscription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraSpellChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid1)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid1;
        private System.Windows.Forms.Panel panelButton;
        private Infragistics.Win.Misc.UltraButton btnSave;
        private Infragistics.Win.Misc.UltraButton btnCancel;
        private System.Windows.Forms.Panel panelMain;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor checkHasUnits;
        private System.Windows.Forms.BindingSource feetypeDTBindingSource;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDscription;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor numType;
        private Infragistics.Win.UltraWinSpellChecker.UltraSpellChecker ultraSpellChecker;
        private Infragistics.Win.Misc.UltraDropDownButton ultraDropDownButton1;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _FeeTypeMaintenance_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager ultraToolbarsManager1;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _FeeTypeMaintenance_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _FeeTypeMaintenance_Toolbars_Dock_Area_Top;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _FeeTypeMaintenance_Toolbars_Dock_Area_Bottom;
        private Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter ultraGridDocumentExporter1;
        private Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter ultraGridExcelExporter1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolDelete;
    }
}