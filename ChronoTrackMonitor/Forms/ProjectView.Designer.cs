namespace ChronoTrackMonitor.Forms
{
    partial class ProjectView
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
            this.projectcombinedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectGridControl = new DevExpress.XtraGrid.GridControl();
            this.projectViewerOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolProjectViewAddNote = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colProject_id = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colCustomer_name = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colCustomer_location = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colCustomer_contact = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colContact_phone = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colStart_date = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colEnd_date = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colCurrent_status = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colConsultant_full_name = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colCoordinator_full_name = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.colText = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.Item1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Item11 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Item12 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Item13 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Item14 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Item15 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Item16 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Item17 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Item18 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Item19 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.item2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutViewField_colConsultant_full_name = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colCoordinator_full_name = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            ((System.ComponentModel.ISupportInitialize)(this.projectcombinedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectGridControl)).BeginInit();
            this.projectViewerOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colConsultant_full_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCoordinator_full_name)).BeginInit();
            this.SuspendLayout();
            // 
            // projectcombinedBindingSource
            // 
            this.projectcombinedBindingSource.DataSource = typeof(ChronoTrackMonitor.ChronoTrackWS.Project_combined);
            // 
            // projectGridControl
            // 
            this.projectGridControl.ContextMenuStrip = this.projectViewerOptions;
            this.projectGridControl.DataSource = this.projectcombinedBindingSource;
            this.projectGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectGridControl.Location = new System.Drawing.Point(0, 0);
            this.projectGridControl.MainView = this.layoutView1;
            this.projectGridControl.Name = "projectGridControl";
            this.projectGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.projectGridControl.Size = new System.Drawing.Size(625, 483);
            this.projectGridControl.TabIndex = 0;
            this.projectGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // projectViewerOptions
            // 
            this.projectViewerOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolProjectViewAddNote});
            this.projectViewerOptions.Name = "projectViewerOptions";
            this.projectViewerOptions.Size = new System.Drawing.Size(130, 26);
            this.projectViewerOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.projectViewerOptions_ItemClicked);
            // 
            // toolProjectViewAddNote
            // 
            this.toolProjectViewAddNote.Image = global::ChronoTrackMonitor.Properties.Resources.Note_Add;
            this.toolProjectViewAddNote.Name = "toolProjectViewAddNote";
            this.toolProjectViewAddNote.Size = new System.Drawing.Size(129, 22);
            this.toolProjectViewAddNote.Text = "Add note";
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.CardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.layoutView1.Appearance.CardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.layoutView1.Appearance.CardCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutView1.Appearance.CardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.CardCaption.Options.UseBorderColor = true;
            this.layoutView1.Appearance.CardCaption.Options.UseForeColor = true;
            this.layoutView1.Appearance.FieldCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.layoutView1.Appearance.FieldCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.layoutView1.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutView1.Appearance.FieldCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.FieldCaption.Options.UseBorderColor = true;
            this.layoutView1.Appearance.FieldCaption.Options.UseForeColor = true;
            this.layoutView1.Appearance.FieldValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.layoutView1.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.layoutView1.Appearance.FieldValue.Options.UseBackColor = true;
            this.layoutView1.Appearance.FieldValue.Options.UseForeColor = true;
            this.layoutView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.layoutView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.layoutView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.layoutView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.layoutView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.layoutView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.layoutView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.layoutView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.layoutView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.layoutView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.layoutView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.layoutView1.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.layoutView1.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.layoutView1.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White;
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.layoutView1.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.layoutView1.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.layoutView1.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.layoutView1.Appearance.HideSelectionCardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.HideSelectionCardCaption.Options.UseBorderColor = true;
            this.layoutView1.Appearance.HideSelectionCardCaption.Options.UseForeColor = true;
            this.layoutView1.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
            this.layoutView1.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutView1.Appearance.SelectedCardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.SelectedCardCaption.Options.UseForeColor = true;
            this.layoutView1.Appearance.SeparatorLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.layoutView1.Appearance.SeparatorLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.layoutView1.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.layoutView1.Appearance.SeparatorLine.Options.UseBorderColor = true;
            this.layoutView1.Appearance.ViewBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.layoutView1.Appearance.ViewBackground.BackColor2 = System.Drawing.Color.White;
            this.layoutView1.Appearance.ViewBackground.Options.UseBackColor = true;
            this.layoutView1.CardMinSize = new System.Drawing.Size(435, 360);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colProject_id,
            this.colCustomer_name,
            this.colCustomer_location,
            this.colCustomer_contact,
            this.colContact_phone,
            this.colDescription,
            this.colStart_date,
            this.colEnd_date,
            this.colCurrent_status,
            this.colConsultant_full_name,
            this.colCoordinator_full_name,
            this.colText});
            this.layoutView1.GridControl = this.projectGridControl;
            this.layoutView1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colConsultant_full_name,
            this.layoutViewField_colCoordinator_full_name});
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsCarouselMode.BottomCardAlphaLevel = 2F;
            this.layoutView1.OptionsView.ShowCardExpandButton = false;
            this.layoutView1.OptionsView.ShowCardFieldBorders = true;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colProject_id
            // 
            this.colProject_id.Caption = "Project ID";
            this.colProject_id.ColumnEdit = this.repositoryItemTextEdit1;
            this.colProject_id.FieldName = "Project_id";
            this.colProject_id.LayoutViewField = this.Item19;
            this.colProject_id.Name = "colProject_id";
            // 
            // colCustomer_name
            // 
            this.colCustomer_name.Caption = "Customer";
            this.colCustomer_name.FieldName = "Customer_name";
            this.colCustomer_name.LayoutViewField = this.Item1;
            this.colCustomer_name.Name = "colCustomer_name";
            // 
            // colCustomer_location
            // 
            this.colCustomer_location.Caption = "Location";
            this.colCustomer_location.FieldName = "Customer_location";
            this.colCustomer_location.LayoutViewField = this.Item11;
            this.colCustomer_location.Name = "colCustomer_location";
            // 
            // colCustomer_contact
            // 
            this.colCustomer_contact.Caption = "Contact";
            this.colCustomer_contact.FieldName = "Customer_contact";
            this.colCustomer_contact.LayoutViewField = this.Item12;
            this.colCustomer_contact.Name = "colCustomer_contact";
            // 
            // colContact_phone
            // 
            this.colContact_phone.Caption = "Phone";
            this.colContact_phone.FieldName = "Contact_phone";
            this.colContact_phone.LayoutViewField = this.Item13;
            this.colContact_phone.Name = "colContact_phone";
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Task";
            this.colDescription.FieldName = "Description";
            this.colDescription.LayoutViewField = this.Item14;
            this.colDescription.Name = "colDescription";
            // 
            // colStart_date
            // 
            this.colStart_date.Caption = "Start";
            this.colStart_date.FieldName = "Start_date";
            this.colStart_date.LayoutViewField = this.Item15;
            this.colStart_date.Name = "colStart_date";
            // 
            // colEnd_date
            // 
            this.colEnd_date.Caption = "End";
            this.colEnd_date.FieldName = "End_date";
            this.colEnd_date.LayoutViewField = this.Item16;
            this.colEnd_date.Name = "colEnd_date";
            // 
            // colCurrent_status
            // 
            this.colCurrent_status.Caption = "Status";
            this.colCurrent_status.FieldName = "Current_status";
            this.colCurrent_status.LayoutViewField = this.Item17;
            this.colCurrent_status.Name = "colCurrent_status";
            // 
            // colConsultant_full_name
            // 
            this.colConsultant_full_name.Caption = "Consultant_full_name";
            this.colConsultant_full_name.FieldName = "Consultant_full_name";
            this.colConsultant_full_name.LayoutViewField = this.layoutViewField_colConsultant_full_name;
            this.colConsultant_full_name.Name = "colConsultant_full_name";
            // 
            // colCoordinator_full_name
            // 
            this.colCoordinator_full_name.Caption = "Coordinator_full_name";
            this.colCoordinator_full_name.FieldName = "Coordinator_full_name";
            this.colCoordinator_full_name.LayoutViewField = this.layoutViewField_colCoordinator_full_name;
            this.colCoordinator_full_name.Name = "colCoordinator_full_name";
            // 
            // colText
            // 
            this.colText.Caption = "Details";
            this.colText.FieldName = "Text";
            this.colText.LayoutViewField = this.Item18;
            this.colText.Name = "colText";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.MaxLength = 8;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.ReadOnly = true;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "layoutViewTemplateCard";
            this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Item1,
            this.Item11,
            this.Item12,
            this.Item13,
            this.Item14,
            this.Item15,
            this.Item16,
            this.Item17,
            this.Item18,
            this.Item19,
            this.item2});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // Item1
            // 
            this.Item1.EditorPreferredWidth = 365;
            this.Item1.Location = new System.Drawing.Point(0, 27);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(433, 27);
            this.Item1.TextLocation = DevExpress.Utils.Locations.Left;
            this.Item1.TextSize = new System.Drawing.Size(52, 20);
            // 
            // Item11
            // 
            this.Item11.EditorPreferredWidth = 365;
            this.Item11.Location = new System.Drawing.Point(0, 54);
            this.Item11.Name = "Item11";
            this.Item11.Size = new System.Drawing.Size(433, 27);
            this.Item11.TextLocation = DevExpress.Utils.Locations.Left;
            this.Item11.TextSize = new System.Drawing.Size(52, 20);
            // 
            // Item12
            // 
            this.Item12.EditorPreferredWidth = 365;
            this.Item12.Location = new System.Drawing.Point(0, 81);
            this.Item12.Name = "Item12";
            this.Item12.Size = new System.Drawing.Size(433, 27);
            this.Item12.TextLocation = DevExpress.Utils.Locations.Left;
            this.Item12.TextSize = new System.Drawing.Size(52, 20);
            // 
            // Item13
            // 
            this.Item13.EditorPreferredWidth = 365;
            this.Item13.Location = new System.Drawing.Point(0, 108);
            this.Item13.Name = "Item13";
            this.Item13.Size = new System.Drawing.Size(433, 27);
            this.Item13.TextLocation = DevExpress.Utils.Locations.Left;
            this.Item13.TextSize = new System.Drawing.Size(52, 20);
            // 
            // Item14
            // 
            this.Item14.EditorPreferredWidth = 365;
            this.Item14.Location = new System.Drawing.Point(0, 135);
            this.Item14.Name = "Item14";
            this.Item14.Size = new System.Drawing.Size(433, 27);
            this.Item14.TextLocation = DevExpress.Utils.Locations.Left;
            this.Item14.TextSize = new System.Drawing.Size(52, 20);
            // 
            // Item15
            // 
            this.Item15.EditorPreferredWidth = 365;
            this.Item15.Location = new System.Drawing.Point(0, 162);
            this.Item15.Name = "Item15";
            this.Item15.Size = new System.Drawing.Size(433, 27);
            this.Item15.TextLocation = DevExpress.Utils.Locations.Left;
            this.Item15.TextSize = new System.Drawing.Size(52, 20);
            // 
            // Item16
            // 
            this.Item16.EditorPreferredWidth = 365;
            this.Item16.Location = new System.Drawing.Point(0, 189);
            this.Item16.Name = "Item16";
            this.Item16.Size = new System.Drawing.Size(433, 27);
            this.Item16.TextLocation = DevExpress.Utils.Locations.Left;
            this.Item16.TextSize = new System.Drawing.Size(52, 20);
            // 
            // Item17
            // 
            this.Item17.EditorPreferredWidth = 365;
            this.Item17.Location = new System.Drawing.Point(0, 216);
            this.Item17.Name = "Item17";
            this.Item17.Size = new System.Drawing.Size(433, 27);
            this.Item17.TextLocation = DevExpress.Utils.Locations.Left;
            this.Item17.TextSize = new System.Drawing.Size(52, 20);
            // 
            // Item18
            // 
            this.Item18.EditorPreferredWidth = 367;
            this.Item18.Location = new System.Drawing.Point(0, 243);
            this.Item18.MaxSize = new System.Drawing.Size(0, 27);
            this.Item18.MinSize = new System.Drawing.Size(86, 27);
            this.Item18.Name = "Item18";
            this.Item18.Size = new System.Drawing.Size(433, 96);
            this.Item18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Item18.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.Item18.TextLocation = DevExpress.Utils.Locations.Left;
            this.Item18.TextSize = new System.Drawing.Size(50, 100);
            // 
            // Item19
            // 
            this.Item19.EditorPreferredWidth = 214;
            this.Item19.Location = new System.Drawing.Point(0, 0);
            this.Item19.MaxSize = new System.Drawing.Size(282, 27);
            this.Item19.MinSize = new System.Drawing.Size(282, 27);
            this.Item19.Name = "Item19";
            this.Item19.Size = new System.Drawing.Size(282, 27);
            this.Item19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Item19.TextLocation = DevExpress.Utils.Locations.Left;
            this.Item19.TextSize = new System.Drawing.Size(52, 20);
            // 
            // item2
            // 
            this.item2.CustomizationFormText = "item2";
            this.item2.Location = new System.Drawing.Point(282, 0);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(151, 27);
            this.item2.Text = "item2";
            this.item2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutViewField_colConsultant_full_name
            // 
            this.layoutViewField_colConsultant_full_name.EditorPreferredWidth = 78;
            this.layoutViewField_colConsultant_full_name.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colConsultant_full_name.Name = "layoutViewField_colConsultant_full_name";
            this.layoutViewField_colConsultant_full_name.Size = new System.Drawing.Size(433, 270);
            this.layoutViewField_colConsultant_full_name.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colConsultant_full_name.TextSize = new System.Drawing.Size(113, 20);
            // 
            // layoutViewField_colCoordinator_full_name
            // 
            this.layoutViewField_colCoordinator_full_name.EditorPreferredWidth = 78;
            this.layoutViewField_colCoordinator_full_name.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colCoordinator_full_name.Name = "layoutViewField_colCoordinator_full_name";
            this.layoutViewField_colCoordinator_full_name.Size = new System.Drawing.Size(433, 270);
            this.layoutViewField_colCoordinator_full_name.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutViewField_colCoordinator_full_name.TextSize = new System.Drawing.Size(113, 20);
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 483);
            this.Controls.Add(this.projectGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project viewer";
            ((System.ComponentModel.ISupportInitialize)(this.projectcombinedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectGridControl)).EndInit();
            this.projectViewerOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colConsultant_full_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCoordinator_full_name)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource projectcombinedBindingSource;
        private DevExpress.XtraGrid.GridControl projectGridControl;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colProject_id;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCustomer_name;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCustomer_location;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCustomer_contact;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colContact_phone;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDescription;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colStart_date;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colEnd_date;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCurrent_status;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colConsultant_full_name;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colCoordinator_full_name;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colText;
        private System.Windows.Forms.ContextMenuStrip projectViewerOptions;
        private System.Windows.Forms.ToolStripMenuItem toolProjectViewAddNote;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField Item19;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField Item1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField Item11;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField Item12;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField Item13;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField Item14;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField Item15;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField Item16;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField Item17;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colConsultant_full_name;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCoordinator_full_name;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField Item18;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.EmptySpaceItem item2;

    }
}