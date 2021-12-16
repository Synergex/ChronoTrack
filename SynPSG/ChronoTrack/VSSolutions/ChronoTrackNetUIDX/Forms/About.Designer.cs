namespace ChronoTrackNetUIDX.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.labelDBLVersion = new DevExpress.XtraEditors.LabelControl();
            this.labelTKVersion = new DevExpress.XtraEditors.LabelControl();
            this.labelChronoTrackVersion = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelAssembly = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.assemblyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelAssembly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 384);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(574, 23);
            this.panelBottom.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(499, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.labelDBLVersion);
            this.panelDetails.Controls.Add(this.labelTKVersion);
            this.panelDetails.Controls.Add(this.labelChronoTrackVersion);
            this.panelDetails.Controls.Add(this.labelControl3);
            this.panelDetails.Controls.Add(this.labelControl2);
            this.panelDetails.Controls.Add(this.labelControl1);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetails.Location = new System.Drawing.Point(0, 150);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(574, 70);
            this.panelDetails.TabIndex = 2;
            // 
            // labelDBLVersion
            // 
            this.labelDBLVersion.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelDBLVersion.Appearance.Options.UseFont = true;
            this.labelDBLVersion.Location = new System.Drawing.Point(182, 47);
            this.labelDBLVersion.Name = "labelDBLVersion";
            this.labelDBLVersion.Size = new System.Drawing.Size(75, 13);
            this.labelDBLVersion.TabIndex = 5;
            this.labelDBLVersion.Text = "labelControl6";
            // 
            // labelTKVersion
            // 
            this.labelTKVersion.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelTKVersion.Appearance.Options.UseFont = true;
            this.labelTKVersion.Location = new System.Drawing.Point(182, 28);
            this.labelTKVersion.Name = "labelTKVersion";
            this.labelTKVersion.Size = new System.Drawing.Size(75, 13);
            this.labelTKVersion.TabIndex = 4;
            this.labelTKVersion.Text = "labelControl5";
            // 
            // labelChronoTrackVersion
            // 
            this.labelChronoTrackVersion.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelChronoTrackVersion.Appearance.Options.UseFont = true;
            this.labelChronoTrackVersion.Location = new System.Drawing.Point(182, 9);
            this.labelChronoTrackVersion.Name = "labelChronoTrackVersion";
            this.labelChronoTrackVersion.Size = new System.Drawing.Size(75, 13);
            this.labelChronoTrackVersion.TabIndex = 3;
            this.labelChronoTrackVersion.Text = "labelControl4";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(34, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Synergy Language version";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Synergy UI Toolkit version";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(99, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ChronoTrack version";
            // 
            // panelAssembly
            // 
            this.panelAssembly.Controls.Add(this.gridControl1);
            this.panelAssembly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAssembly.Location = new System.Drawing.Point(0, 220);
            this.panelAssembly.Name = "panelAssembly";
            this.panelAssembly.Size = new System.Drawing.Size(574, 164);
            this.panelAssembly.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChronoTrackNetUIDX.Properties.Resources.ChronoTrack;
            this.pictureBox1.Location = new System.Drawing.Point(191, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 95);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.assemblyBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(574, 164);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 407);
            this.Controls.Add(this.panelAssembly);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelAssembly.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Panel panelDetails;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panelAssembly;
        private DevExpress.XtraEditors.LabelControl labelDBLVersion;
        private DevExpress.XtraEditors.LabelControl labelTKVersion;
        private DevExpress.XtraEditors.LabelControl labelChronoTrackVersion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource assemblyBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}