namespace ChronoTrackNetUI.Forms
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
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.txtUserName = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.intHistoryToLoad = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.comboDefaultView = new System.Windows.Forms.ComboBox();
            this.chkDisplayTransactionViewer = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            this.btnSave = new Infragistics.Win.Misc.UltraButton();
            this.btnCancel = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intHistoryToLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(7, 23);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(71, 23);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "Default user";
            // 
            // txtUserName
            // 
            this.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserName.Location = new System.Drawing.Point(84, 19);
            this.txtUserName.MaxLength = 15;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(213, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.ultraLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login defaults";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.intHistoryToLoad);
            this.groupBox2.Controls.Add(this.ultraLabel3);
            this.groupBox2.Controls.Add(this.ultraLabel2);
            this.groupBox2.Controls.Add(this.comboDefaultView);
            this.groupBox2.Controls.Add(this.chkDisplayTransactionViewer);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 103);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application options";
            // 
            // intHistoryToLoad
            // 
            this.intHistoryToLoad.Location = new System.Drawing.Point(131, 73);
            this.intHistoryToLoad.MaxValue = 12;
            this.intHistoryToLoad.MinValue = 1;
            this.intHistoryToLoad.Name = "intHistoryToLoad";
            this.intHistoryToLoad.PromptChar = ' ';
            this.intHistoryToLoad.Size = new System.Drawing.Size(48, 21);
            this.intHistoryToLoad.TabIndex = 4;
            this.intHistoryToLoad.Value = 1;
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(7, 77);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(118, 23);
            this.ultraLabel3.TabIndex = 3;
            this.ultraLabel3.Text = "History months to load";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(5, 48);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(120, 23);
            this.ultraLabel2.TabIndex = 2;
            this.ultraLabel2.Text = "Default view state";
            // 
            // comboDefaultView
            // 
            this.comboDefaultView.FormattingEnabled = true;
            this.comboDefaultView.Items.AddRange(new object[] {
            "Gantt view",
            "Day",
            "Week",
            "Month"});
            this.comboDefaultView.Location = new System.Drawing.Point(131, 45);
            this.comboDefaultView.Name = "comboDefaultView";
            this.comboDefaultView.Size = new System.Drawing.Size(121, 21);
            this.comboDefaultView.TabIndex = 1;
            // 
            // chkDisplayTransactionViewer
            // 
            this.chkDisplayTransactionViewer.Location = new System.Drawing.Point(7, 19);
            this.chkDisplayTransactionViewer.Name = "chkDisplayTransactionViewer";
            this.chkDisplayTransactionViewer.Size = new System.Drawing.Size(172, 20);
            this.chkDisplayTransactionViewer.TabIndex = 0;
            this.chkDisplayTransactionViewer.Text = "Display transaction viewer";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(383, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(464, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(552, 217);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intHistoryToLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Infragistics.Win.Misc.UltraButton btnSave;
        private Infragistics.Win.Misc.UltraButton btnCancel;
        private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkDisplayTransactionViewer;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtUserName;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private System.Windows.Forms.ComboBox comboDefaultView;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor intHistoryToLoad;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
    }
}