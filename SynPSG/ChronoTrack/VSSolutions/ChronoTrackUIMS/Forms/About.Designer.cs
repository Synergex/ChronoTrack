namespace ChronoTrackNetUIMS.Forms
{
    partial class About
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelChronoTrackVersion = new System.Windows.Forms.Label();
            this.labelTKVersion = new System.Windows.Forms.Label();
            this.labelDBLVersion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.assemblyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assemblyInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(574, 150);
            this.panelTop.TabIndex = 0;
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.labelDBLVersion);
            this.panelDetails.Controls.Add(this.labelTKVersion);
            this.panelDetails.Controls.Add(this.labelChronoTrackVersion);
            this.panelDetails.Controls.Add(this.label3);
            this.panelDetails.Controls.Add(this.label2);
            this.panelDetails.Controls.Add(this.label1);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetails.Location = new System.Drawing.Point(0, 150);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(574, 85);
            this.panelDetails.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panel1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 384);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(574, 23);
            this.panelBottom.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(374, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 23);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(125, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ChronoTrack Version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Synergy UI Toolkit version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Synergy Language version";
            // 
            // labelChronoTrackVersion
            // 
            this.labelChronoTrackVersion.AutoSize = true;
            this.labelChronoTrackVersion.Location = new System.Drawing.Point(213, 14);
            this.labelChronoTrackVersion.Name = "labelChronoTrackVersion";
            this.labelChronoTrackVersion.Size = new System.Drawing.Size(35, 13);
            this.labelChronoTrackVersion.TabIndex = 3;
            this.labelChronoTrackVersion.Text = "label4";
            // 
            // labelTKVersion
            // 
            this.labelTKVersion.AutoSize = true;
            this.labelTKVersion.Location = new System.Drawing.Point(213, 36);
            this.labelTKVersion.Name = "labelTKVersion";
            this.labelTKVersion.Size = new System.Drawing.Size(35, 13);
            this.labelTKVersion.TabIndex = 4;
            this.labelTKVersion.Text = "label4";
            // 
            // labelDBLVersion
            // 
            this.labelDBLVersion.AutoSize = true;
            this.labelDBLVersion.Location = new System.Drawing.Point(213, 59);
            this.labelDBLVersion.Name = "labelDBLVersion";
            this.labelDBLVersion.Size = new System.Drawing.Size(35, 13);
            this.labelDBLVersion.TabIndex = 5;
            this.labelDBLVersion.Text = "label5";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ChronoTrackNetUIMS.Properties.Resources.synergyde_logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 99);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ChronoTrackNetUIMS.Properties.Resources.ChronoTrack;
            this.pictureBox1.Location = new System.Drawing.Point(192, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 150);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.assemblyNameDataGridViewTextBoxColumn,
            this.versionNumberDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.assemblyInfoBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 235);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(574, 149);
            this.dataGridView.TabIndex = 3;
            // 
            // assemblyNameDataGridViewTextBoxColumn
            // 
            this.assemblyNameDataGridViewTextBoxColumn.DataPropertyName = "AssemblyName";
            this.assemblyNameDataGridViewTextBoxColumn.HeaderText = "AssemblyName";
            this.assemblyNameDataGridViewTextBoxColumn.Name = "assemblyNameDataGridViewTextBoxColumn";
            this.assemblyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // versionNumberDataGridViewTextBoxColumn
            // 
            this.versionNumberDataGridViewTextBoxColumn.DataPropertyName = "VersionNumber";
            this.versionNumberDataGridViewTextBoxColumn.HeaderText = "VersionNumber";
            this.versionNumberDataGridViewTextBoxColumn.Name = "versionNumberDataGridViewTextBoxColumn";
            this.versionNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assemblyInfoBindingSource
            // 
            this.assemblyInfoBindingSource.DataSource = typeof(ChronoTrackNetUIMS.Data.AssemblyInfo);
            // 
            // About
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(574, 407);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.panelTop.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label labelDBLVersion;
        private System.Windows.Forms.Label labelTKVersion;
        private System.Windows.Forms.Label labelChronoTrackVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn assemblyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource assemblyInfoBindingSource;
    }
}