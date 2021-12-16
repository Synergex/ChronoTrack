namespace ChronoMobile
{
    partial class FormProjectNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.listNotes = new System.Windows.Forms.ListBox();
            this.mitemCancel = new System.Windows.Forms.MenuItem();
            this.mitemAdd = new System.Windows.Forms.MenuItem();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mitemCancel);
            this.mainMenu1.MenuItems.Add(this.mitemAdd);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(4, 4);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(233, 20);
            this.lblDescription.Text = "Project Description";
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic);
            this.lblCompany.Location = new System.Drawing.Point(0, 28);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(237, 20);
            this.lblCompany.Text = "Company Name";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listNotes
            // 
            this.listNotes.DisplayMember = "DisplayText";
            this.listNotes.Location = new System.Drawing.Point(4, 52);
            this.listNotes.Name = "listNotes";
            this.listNotes.Size = new System.Drawing.Size(233, 72);
            this.listNotes.TabIndex = 2;
            this.listNotes.ValueMember = "ItemValue";
            this.listNotes.SelectedIndexChanged += new System.EventHandler(this.listNotes_SelectedIndexChanged);
            // 
            // mitemCancel
            // 
            this.mitemCancel.Text = "Back";
            this.mitemCancel.Click += new System.EventHandler(this.mitemCancel_Click);
            // 
            // mitemAdd
            // 
            this.mitemAdd.Text = "Add";
            this.mitemAdd.Click += new System.EventHandler(this.mitemAdd_Click);
            // 
            // txtNote
            // 
            this.txtNote.AcceptsReturn = true;
            this.txtNote.AcceptsTab = true;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtNote.Location = new System.Drawing.Point(4, 129);
            this.txtNote.MaxLength = 700;
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(233, 136);
            this.txtNote.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtDescription.Location = new System.Drawing.Point(3, 105);
            this.txtDescription.MaxLength = 60;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(233, 19);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Visible = false;
            // 
            // FormProjectNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.listNotes);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblDescription);
            this.Menu = this.mainMenu1;
            this.Name = "FormProjectNotes";
            this.Text = "FormProjectNotes";
            this.Load += new System.EventHandler(this.FormProjectNotes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ListBox listNotes;
        private System.Windows.Forms.MenuItem mitemCancel;
        private System.Windows.Forms.MenuItem mitemAdd;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtDescription;
    }
}