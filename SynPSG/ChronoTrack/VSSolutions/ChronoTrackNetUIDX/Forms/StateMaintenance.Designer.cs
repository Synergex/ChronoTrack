namespace ChronoTrackNetUIDX.Forms
{
    partial class StateMaintenance
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
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling2 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.stateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataNavigator = new DevExpress.XtraEditors.DataNavigator();
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker();
            this.Code = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // stateBindingSource
            // 
            this.stateBindingSource.DataSource = typeof(ChronoTrack.State);
            // 
            // dataNavigator
            // 
            this.dataNavigator.DataSource = this.stateBindingSource;
            this.dataNavigator.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataNavigator.Name = "dataNavigator";
            this.dataNavigator.Size = new System.Drawing.Size(397, 24);
            this.dataNavigator.TabIndex = 0;
            this.dataNavigator.Text = "dataNavigator1";
            // 
            // spellChecker1
            // 
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("en-GB");
            this.spellChecker1.ParentContainer = null;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(68, 45);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(25, 13);
            this.Code.TabIndex = 1;
            this.Code.Text = "Code";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(68, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Name";
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateBindingSource, "Code", true));
            this.txtCode.Location = new System.Drawing.Point(110, 42);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Properties.MaxLength = 2;
            this.spellChecker1.SetShowSpellCheckMenu(this.txtCode, true);
            this.txtCode.Size = new System.Drawing.Size(31, 20);
            this.spellChecker1.SetSpellCheckerOptions(this.txtCode, optionsSpelling1);
            this.txtCode.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(110, 68);
            this.txtName.Name = "txtName";
            this.txtName.Properties.MaxLength = 30;
            this.spellChecker1.SetShowSpellCheckMenu(this.txtName, true);
            this.txtName.Size = new System.Drawing.Size(239, 20);
            this.spellChecker1.SetSpellCheckerOptions(this.txtName, optionsSpelling2);
            this.txtName.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(274, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StateMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 160);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.dataNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StateMaintenance";
            this.Text = "State maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.stateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource stateBindingSource;
        private DevExpress.XtraEditors.DataNavigator dataNavigator;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
        private DevExpress.XtraEditors.LabelControl Code;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}