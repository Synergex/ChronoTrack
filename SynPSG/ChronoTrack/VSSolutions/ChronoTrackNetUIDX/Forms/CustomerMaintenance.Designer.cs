namespace ChronoTrackNetUIDX.Forms
{
    partial class CustomerMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMaintenance));
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataNavigator = new DevExpress.XtraEditors.DataNavigator();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.comboTechnical = new DevExpress.XtraEditors.LookUpEdit();
            this.comboLegal = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnContactMnt1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnContactMnt2 = new DevExpress.XtraEditors.SimpleButton();
            this.toolTipController = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTechnical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboLegal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(ChronoTrack.Customer);
            this.customerBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.customerBindingSource_AddingNew);
            this.customerBindingSource.CurrentItemChanged += new System.EventHandler(this.customerBindingSource_CurrentItemChanged);
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(ChronoTrack.Customer_contact);
            // 
            // dataNavigator
            // 
            this.dataNavigator.Buttons.CancelEdit.Visible = false;
            this.dataNavigator.Buttons.EndEdit.Visible = false;
            this.dataNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataNavigator.Name = "dataNavigator";
            this.dataNavigator.Size = new System.Drawing.Size(488, 24);
            this.dataNavigator.TabIndex = 0;
            this.dataNavigator.Text = "dataNavigator1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Customer ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Company";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(265, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Current contract";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Technical Contact";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 129);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(64, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Legal contact";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Customer_id", true));
            this.txtCustomerID.Location = new System.Drawing.Point(107, 39);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerID.Properties.MaxLength = 10;
            this.txtCustomerID.Size = new System.Drawing.Size(127, 20);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.Validated += new System.EventHandler(this.txtCustomerID_Validated);
            // 
            // txtCustomer
            // 
            this.txtCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Company", true));
            this.txtCustomer.Location = new System.Drawing.Point(107, 65);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.MaxLength = 40;
            this.txtCustomer.Size = new System.Drawing.Size(292, 20);
            this.txtCustomer.TabIndex = 1;
            // 
            // comboTechnical
            // 
            this.comboTechnical.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Tech_contact_id", true));
            this.comboTechnical.Location = new System.Drawing.Point(107, 91);
            this.comboTechnical.Name = "comboTechnical";
            this.comboTechnical.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboTechnical.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Synergygrfa", "Synergygrfa", 79, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Customer_id", "Customer_id", 66, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Contact_id", "Contact_id", 58, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("First_name", "First", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Last_name", "Last", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Title", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Current_location", "Current_location", 86, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Office_phone", "Phone #", 71, DevExpress.Utils.FormatType.Custom, "(9) 999 999 9999", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mobile_phone", "Mobile_phone", 72, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "Email", 30, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Picture_file", "Picture_file", 59, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Changed", "Changed", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None)});
            this.comboTechnical.Properties.DataSource = this.contactBindingSource;
            this.comboTechnical.Properties.DisplayMember = "First_name";
            this.comboTechnical.Properties.ValueMember = "Contact_id";
            this.comboTechnical.Size = new System.Drawing.Size(292, 20);
            this.comboTechnical.TabIndex = 2;
            this.comboTechnical.Enter += new System.EventHandler(this.comboTechnical_Enter);
            // 
            // comboLegal
            // 
            this.comboLegal.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Legal_contact_id", true));
            this.comboLegal.Location = new System.Drawing.Point(107, 126);
            this.comboLegal.Name = "comboLegal";
            this.comboLegal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboLegal.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Synergygrfa", "Synergygrfa", 79, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Customer_id", "Customer_id", 66, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Contact_id", "Contact_id", 58, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("First_name", "First", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Last_name", "Last", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Title", "Title", 26, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Current_location", "Current_location", 86, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Office_phone", "Phone #", 71, DevExpress.Utils.FormatType.Custom, "(9) 999 999 9999", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Mobile_phone", "Mobile_phone", 72, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "Email", 30, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Picture_file", "Picture_file", 59, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Changed", "Changed", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None)});
            this.comboLegal.Properties.DataSource = this.contactBindingSource;
            this.comboLegal.Properties.DisplayMember = "First_name";
            this.comboLegal.Properties.ValueMember = "Contact_id";
            this.comboLegal.Size = new System.Drawing.Size(292, 20);
            this.comboLegal.TabIndex = 3;
            this.comboLegal.Enter += new System.EventHandler(this.comboLegal_Enter);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.customerBindingSource, "Current_contract", true));
            this.textEdit1.Location = new System.Drawing.Point(351, 39);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 10;
            this.textEdit1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(295, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(376, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnContactMnt1
            // 
            this.btnContactMnt1.Image = ((System.Drawing.Image)(resources.GetObject("btnContactMnt1.Image")));
            this.btnContactMnt1.Location = new System.Drawing.Point(414, 81);
            this.btnContactMnt1.Name = "btnContactMnt1";
            this.btnContactMnt1.Size = new System.Drawing.Size(37, 30);
            this.btnContactMnt1.TabIndex = 13;
            this.btnContactMnt1.Click += new System.EventHandler(this.btnContactMnt_Click);
            // 
            // btnContactMnt2
            // 
            this.btnContactMnt2.Image = ((System.Drawing.Image)(resources.GetObject("btnContactMnt2.Image")));
            this.btnContactMnt2.Location = new System.Drawing.Point(414, 117);
            this.btnContactMnt2.Name = "btnContactMnt2";
            this.btnContactMnt2.Size = new System.Drawing.Size(37, 29);
            this.btnContactMnt2.TabIndex = 14;
            this.btnContactMnt2.Click += new System.EventHandler(this.btnContactMnt_Click);
            // 
            // CustomerMaintenance
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(488, 227);
            this.Controls.Add(this.btnContactMnt2);
            this.Controls.Add(this.btnContactMnt1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.comboLegal);
            this.Controls.Add(this.comboTechnical);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dataNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMaintenance";
            this.Text = "Customer maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboTechnical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboLegal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private DevExpress.XtraEditors.DataNavigator dataNavigator;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCustomerID;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.LookUpEdit comboTechnical;
        private DevExpress.XtraEditors.LookUpEdit comboLegal;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnContactMnt1;
        private DevExpress.XtraEditors.SimpleButton btnContactMnt2;
        private DevExpress.Utils.ToolTipController toolTipController;
    }
}