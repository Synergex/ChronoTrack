namespace ChronoTrackNetUIDX.Forms
{
    partial class Options
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.chkDisplayTransactionViewer = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboDefaultView = new DevExpress.XtraEditors.ComboBoxEdit();
            this.intHistoryToLoad = new DevExpress.XtraEditors.SpinEdit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDisplayTransactionViewer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDefaultView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intHistoryToLoad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.intHistoryToLoad);
            this.groupBox2.Controls.Add(this.comboDefaultView);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.chkDisplayTransactionViewer);
            this.groupBox2.Location = new System.Drawing.Point(19, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application options";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Default user";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(82, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserName.Properties.MaxLength = 15;
            this.txtUserName.Size = new System.Drawing.Size(188, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(471, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(390, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkDisplayTransactionViewer
            // 
            this.chkDisplayTransactionViewer.Location = new System.Drawing.Point(6, 19);
            this.chkDisplayTransactionViewer.Name = "chkDisplayTransactionViewer";
            this.chkDisplayTransactionViewer.Properties.Caption = "Display transaction viewer";
            this.chkDisplayTransactionViewer.Size = new System.Drawing.Size(154, 19);
            this.chkDisplayTransactionViewer.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Default view state";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "History months to load";
            // 
            // comboDefaultView
            // 
            this.comboDefaultView.Location = new System.Drawing.Point(133, 41);
            this.comboDefaultView.Name = "comboDefaultView";
            this.comboDefaultView.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboDefaultView.Properties.Items.AddRange(new object[] {
            "Gantt view",
            "Day",
            "Week",
            "Month"});
            this.comboDefaultView.Size = new System.Drawing.Size(100, 20);
            this.comboDefaultView.TabIndex = 1;
            // 
            // intHistoryToLoad
            // 
            this.intHistoryToLoad.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intHistoryToLoad.Location = new System.Drawing.Point(133, 67);
            this.intHistoryToLoad.Name = "intHistoryToLoad";
            this.intHistoryToLoad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.intHistoryToLoad.Properties.Mask.EditMask = "nn";
            this.intHistoryToLoad.Properties.MaxLength = 2;
            this.intHistoryToLoad.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.intHistoryToLoad.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intHistoryToLoad.Size = new System.Drawing.Size(42, 20);
            this.intHistoryToLoad.TabIndex = 2;
            // 
            // Options
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(552, 217);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.Text = "Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDisplayTransactionViewer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDefaultView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intHistoryToLoad.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.ComboBoxEdit comboDefaultView;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkDisplayTransactionViewer;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SpinEdit intHistoryToLoad;
    }
}