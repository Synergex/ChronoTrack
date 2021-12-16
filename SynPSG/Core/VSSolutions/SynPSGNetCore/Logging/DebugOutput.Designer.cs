namespace SynPSGNetCore.Logging
{
    partial class DebugOutput
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.includeErrorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.includeInformatonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugGrid1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debugGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearListToolStripMenuItem,
            this.includeErrorsToolStripMenuItem,
            this.includeInformatonToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clearListToolStripMenuItem.Text = "Clear list";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // includeErrorsToolStripMenuItem
            // 
            this.includeErrorsToolStripMenuItem.Name = "includeErrorsToolStripMenuItem";
            this.includeErrorsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.includeErrorsToolStripMenuItem.Text = "Include errors";
            this.includeErrorsToolStripMenuItem.Click += new System.EventHandler(this.includeErrorsToolStripMenuItem_Click);
            // 
            // includeInformatonToolStripMenuItem
            // 
            this.includeInformatonToolStripMenuItem.Name = "includeInformatonToolStripMenuItem";
            this.includeInformatonToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.includeInformatonToolStripMenuItem.Text = "Include information";
            this.includeInformatonToolStripMenuItem.Click += new System.EventHandler(this.includeInformationToolStripMenuItem_Click);
            // 
            // debugGrid1
            // 
            this.debugGrid1.AllowUserToAddRows = false;
            this.debugGrid1.AllowUserToDeleteRows = false;
            this.debugGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debugGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugGrid1.Location = new System.Drawing.Point(0, 24);
            this.debugGrid1.Name = "debugGrid1";
            this.debugGrid1.ReadOnly = true;
            this.debugGrid1.Size = new System.Drawing.Size(620, 369);
            this.debugGrid1.TabIndex = 2;
            // 
            // DebugOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 393);
            this.ControlBox = false;
            this.Controls.Add(this.debugGrid1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugOutput";
            this.ShowIcon = false;
            this.Text = "SynPSG debug output window";
            this.Load += new System.EventHandler(this.DebugOutput_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debugGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem includeErrorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem includeInformatonToolStripMenuItem;
        private System.Windows.Forms.DataGridView debugGrid1;
    }
}