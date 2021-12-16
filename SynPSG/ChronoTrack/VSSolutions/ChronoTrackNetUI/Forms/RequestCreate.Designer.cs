namespace ChronoTrackNetUI.Forms
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.btnCancel = new Infragistics.Win.Misc.UltraButton();
            this.btnSave = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.txtStartDate = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEndDate = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.txtText = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraSpellChecker = new Infragistics.Win.UltraWinSpellChecker.UltraSpellChecker(this.components);
            this.btnSpell = new Infragistics.Win.Misc.UltraButton();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userList = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraSpellChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(466, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(385, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(8, 23);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(63, 23);
            this.ultraLabel1.TabIndex = 3;
            this.ultraLabel1.Text = "Start date";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(227, 23);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(55, 23);
            this.ultraLabel2.TabIndex = 4;
            this.ultraLabel2.Text = "End date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requestBindingSource, "Start_date", true));
            this.txtStartDate.Location = new System.Drawing.Point(77, 19);
            this.txtStartDate.MaskInput = "{date} {time}";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.PromptChar = ' ';
            this.txtStartDate.Size = new System.Drawing.Size(144, 21);
            this.txtStartDate.TabIndex = 5;
            this.txtStartDate.Validated += new System.EventHandler(this.txtStartDate_Validated);
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataSource = typeof(ChronoTrack.Request);
            // 
            // txtEndDate
            // 
            this.txtEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requestBindingSource, "End_date", true));
            this.txtEndDate.Location = new System.Drawing.Point(288, 19);
            this.txtEndDate.MaskInput = "{date} {time}";
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.PromptChar = ' ';
            this.txtEndDate.Size = new System.Drawing.Size(144, 21);
            this.txtEndDate.TabIndex = 6;
            // 
            // txtText
            // 
            this.txtText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestBindingSource, "Text", true));
            this.txtText.Location = new System.Drawing.Point(8, 14);
            this.txtText.MaxLength = 700;
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(484, 105);
            this.txtText.TabIndex = 7;
            this.txtText.Text = "ultraTextEditor1";
            // 
            // ultraSpellChecker
            // 
            this.ultraSpellChecker.ContainingControl = this;
            this.ultraSpellChecker.Mode = Infragistics.Win.UltraWinSpellChecker.SpellCheckingMode.AsYouType;
            // 
            // btnSpell
            // 
            appearance1.Image = global::ChronoTrackNetUI.Properties.Resources.Spell_Check1;
            this.btnSpell.Appearance = appearance1;
            this.btnSpell.Location = new System.Drawing.Point(498, 14);
            this.btnSpell.Name = "btnSpell";
            this.btnSpell.Size = new System.Drawing.Size(25, 23);
            this.btnSpell.TabIndex = 8;
            this.btnSpell.Click += new System.EventHandler(this.btnSpell_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ChronoTrack.User_breif);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.ultraLabel3);
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.ultraLabel1);
            this.groupBox1.Controls.Add(this.ultraLabel2);
            this.groupBox1.Controls.Add(this.txtStartDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 103);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request details";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requestBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(77, 48);
            this.txtDescription.MaxLength = 60;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(446, 49);
            this.txtDescription.TabIndex = 8;
            this.txtDescription.Text = "ultraTextEditor1";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(8, 46);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(63, 23);
            this.ultraLabel3.TabIndex = 7;
            this.ultraLabel3.Text = "Description";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userList);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 173);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resources";
            // 
            // userList
            // 
            this.userList.CheckOnClick = true;
            this.userList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(3, 16);
            this.userList.MultiColumn = true;
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(523, 154);
            this.userList.Sorted = true;
            this.userList.TabIndex = 1;
            this.userList.ThreeDCheckBoxes = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtText);
            this.groupBox3.Controls.Add(this.btnSpell);
            this.groupBox3.Location = new System.Drawing.Point(12, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 124);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // RequestCreate
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(547, 457);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestCreate";
            this.Text = "Request create";
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraSpellChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraButton btnCancel;
        private Infragistics.Win.Misc.UltraButton btnSave;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor txtStartDate;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor txtEndDate;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtText;
        private Infragistics.Win.UltraWinSpellChecker.UltraSpellChecker ultraSpellChecker;
        private Infragistics.Win.Misc.UltraButton btnSpell;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox userList;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDescription;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
    }
}