namespace ChronoTrackMonitor.Forms
{
    partial class AddNote
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtProjectID = new DevExpress.XtraEditors.TextEdit();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtProjectDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtProjectText = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProjectNote = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectText.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectNote.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Project ID";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Description";
            // 
            // txtProjectID
            // 
            this.txtProjectID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Project_id", true));
            this.txtProjectID.Location = new System.Drawing.Point(108, 9);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(66, 20);
            this.txtProjectID.TabIndex = 0;
            this.txtProjectID.TabStop = false;
            this.txtProjectID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.catch_KeyPress);
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(ChronoTrackMonitor.ChronoTrackWS.Project);
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "Description", true));
            this.txtProjectDescription.Location = new System.Drawing.Point(180, 9);
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(397, 20);
            this.txtProjectDescription.TabIndex = 1;
            this.txtProjectDescription.TabStop = false;
            this.txtProjectDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.catch_KeyPress);
            // 
            // txtProjectText
            // 
            this.txtProjectText.Location = new System.Drawing.Point(81, 19);
            this.txtProjectText.Name = "txtProjectText";
            this.txtProjectText.Properties.MaxLength = 700;
            this.txtProjectText.Size = new System.Drawing.Size(469, 20);
            this.txtProjectText.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(421, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(502, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProjectNote);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txtProjectText);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 80);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Notes";
            // 
            // txtProjectNote
            // 
            this.txtProjectNote.Location = new System.Drawing.Point(81, 45);
            this.txtProjectNote.Name = "txtProjectNote";
            this.txtProjectNote.Size = new System.Drawing.Size(469, 20);
            this.txtProjectNote.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 48);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(23, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Note";
            // 
            // AddNote
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(591, 165);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProjectDescription);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNote";
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectText.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProjectNote.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtProjectID;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private DevExpress.XtraEditors.TextEdit txtProjectDescription;
        private DevExpress.XtraEditors.TextEdit txtProjectText;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtProjectNote;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}