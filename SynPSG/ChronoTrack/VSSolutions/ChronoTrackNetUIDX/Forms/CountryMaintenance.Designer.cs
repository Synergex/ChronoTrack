namespace ChronoTrackNetUIDX.Forms
{
    partial class CountryMaintenance
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
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling2 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.dataNavigator = new DevExpress.XtraEditors.DataNavigator();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtCurrencyCode = new DevExpress.XtraEditors.TextEdit();
            this.txtDialCode = new DevExpress.XtraEditors.SpinEdit();
            this.spellChecker = new DevExpress.XtraSpellChecker.SpellChecker();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDialCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNavigator
            // 
            this.dataNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dataNavigator.DataSource = this.countryBindingSource;
            this.dataNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataNavigator.Name = "dataNavigator";
            this.dataNavigator.Size = new System.Drawing.Size(419, 24);
            this.dataNavigator.TabIndex = 0;
            this.dataNavigator.Text = "dataNavigator1";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(ChronoTrack.Country);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(47, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(47, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(57, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Dialing code";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(47, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Currency code";
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "Country_id", true));
            this.txtID.Location = new System.Drawing.Point(135, 37);
            this.txtID.Name = "txtID";
            this.txtID.Properties.MaxLength = 3;
            this.spellChecker.SetShowSpellCheckMenu(this.txtID, true);
            this.txtID.Size = new System.Drawing.Size(37, 20);
            this.spellChecker.SetSpellCheckerOptions(this.txtID, optionsSpelling3);
            this.txtID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "Country_name", true));
            this.txtName.Location = new System.Drawing.Point(135, 63);
            this.txtName.Name = "txtName";
            this.txtName.Properties.MaxLength = 30;
            this.txtName.Properties.NullText = "<required>";
            this.spellChecker.SetShowSpellCheckMenu(this.txtName, true);
            this.txtName.Size = new System.Drawing.Size(256, 20);
            this.spellChecker.SetSpellCheckerOptions(this.txtName, optionsSpelling2);
            this.txtName.TabIndex = 1;
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "Currency_code", true));
            this.txtCurrencyCode.Location = new System.Drawing.Point(135, 115);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCurrencyCode.Properties.MaxLength = 2;
            this.spellChecker.SetShowSpellCheckMenu(this.txtCurrencyCode, true);
            this.txtCurrencyCode.Size = new System.Drawing.Size(37, 20);
            this.spellChecker.SetSpellCheckerOptions(this.txtCurrencyCode, optionsSpelling1);
            this.txtCurrencyCode.TabIndex = 3;
            // 
            // txtDialCode
            // 
            this.txtDialCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.countryBindingSource, "Dialing_code", true));
            this.txtDialCode.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDialCode.Location = new System.Drawing.Point(135, 89);
            this.txtDialCode.Name = "txtDialCode";
            this.txtDialCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null)});
            this.txtDialCode.Properties.MaxLength = 3;
            this.txtDialCode.Properties.MaxValue = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtDialCode.Size = new System.Drawing.Size(37, 20);
            this.txtDialCode.TabIndex = 2;
            // 
            // spellChecker
            // 
            this.spellChecker.Culture = new System.Globalization.CultureInfo("en-GB");
            this.spellChecker.ParentContainer = this;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(333, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CountryMaintenance
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(419, 174);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDialCode);
            this.Controls.Add(this.txtCurrencyCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dataNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CountryMaintenance";
            this.Text = "Country maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrencyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDialCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DataNavigator dataNavigator;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtCurrencyCode;
        private DevExpress.XtraEditors.SpinEdit txtDialCode;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}