namespace ChronoTrackNetUIDX.Forms
{
    partial class RequestCreate
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
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling3 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEndDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtText = new DevExpress.XtraEditors.MemoEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spellChecker = new DevExpress.XtraSpellChecker.SpellChecker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request details";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.requestBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(73, 42);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.MaxLength = 60;
            this.spellChecker.SetShowSpellCheckMenu(this.txtDescription, true);
            this.txtDescription.Size = new System.Drawing.Size(445, 65);
            this.spellChecker.SetSpellCheckerOptions(this.txtDescription, optionsSpelling3);
            this.txtDescription.TabIndex = 5;
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataSource = typeof(ChronoTrack.Request);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Description";
            // 
            // txtEndDate
            // 
            this.txtEndDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.requestBindingSource, "End_date", true));
            this.txtEndDate.EditValue = null;
            this.txtEndDate.Location = new System.Drawing.Point(269, 16);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtEndDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtEndDate.Size = new System.Drawing.Size(136, 20);
            this.txtEndDate.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(220, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "End date";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Start date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.requestBindingSource, "Start_date", true));
            this.txtStartDate.EditValue = new System.DateTime(2009, 1, 12, 0, 0, 0, 0);
            this.txtStartDate.Location = new System.Drawing.Point(73, 16);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtStartDate.Size = new System.Drawing.Size(128, 20);
            this.txtStartDate.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userList);
            this.groupBox2.Location = new System.Drawing.Point(10, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rsources";
            // 
            // userList
            // 
            this.userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userList.Location = new System.Drawing.Point(3, 16);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(518, 113);
            this.userList.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtText);
            this.groupBox3.Location = new System.Drawing.Point(10, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // txtText
            // 
            this.txtText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.requestBindingSource, "Text", true));
            this.txtText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestBindingSource, "Text", true));
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.Location = new System.Drawing.Point(3, 16);
            this.txtText.Name = "txtText";
            this.spellChecker.SetShowSpellCheckMenu(this.txtText, true);
            this.txtText.Size = new System.Drawing.Size(518, 125);
            this.spellChecker.SetSpellCheckerOptions(this.txtText, optionsSpelling1);
            this.txtText.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(378, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(459, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ChronoTrack.User_breif);
            // 
            // spellChecker
            // 
            this.spellChecker.Culture = new System.Globalization.CultureInfo("en-GB");
            this.spellChecker.ParentContainer = null;
            // 
            // RequestCreate
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(547, 457);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestCreate";
            this.Text = "Request create";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtStartDate;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit txtEndDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.MemoEdit txtText;
        private DevExpress.XtraEditors.CheckedListBoxControl userList;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker;
    }
}