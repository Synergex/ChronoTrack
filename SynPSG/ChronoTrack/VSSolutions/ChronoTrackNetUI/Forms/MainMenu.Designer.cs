namespace ChronoTrackNetUI.Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Exit Chronotrack", "Exit.bmp");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("User maintenance", "Users.bmp");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Country maintenance", "Flag.bmp");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("State maintenance", "Internet.bmp");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Fee type Maintenance", "Currency.bmp");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Customer Maintenance", "Image.bmp");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Resource Requester", "Research.bmp");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Appliction Options", "Support.bmp");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Project Creator", "Project.bmp");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Change password", "User-Password.bmp");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Project Centre", "Project-Centre.bmp");
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList.Images.SetKeyName(0, "User-Password.bmp");
            this.imageList.Images.SetKeyName(1, "Currency.bmp");
            this.imageList.Images.SetKeyName(2, "Flag.bmp");
            this.imageList.Images.SetKeyName(3, "Image.bmp");
            this.imageList.Images.SetKeyName(4, "Support.bmp");
            this.imageList.Images.SetKeyName(5, "Users.bmp");
            this.imageList.Images.SetKeyName(6, "Currency-Notes.bmp");
            this.imageList.Images.SetKeyName(7, "Exit.bmp");
            this.imageList.Images.SetKeyName(8, "Project.bmp");
            this.imageList.Images.SetKeyName(9, "Research.bmp");
            this.imageList.Images.SetKeyName(10, "Internet.bmp");
            this.imageList.Images.SetKeyName(11, "Project-Centre.bmp");
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewItem1.Tag = "PRGEXIT";
            listViewItem1.ToolTipText = "Exit the ChronoTrack application";
            listViewItem2.Tag = "USERMNT";
            listViewItem2.ToolTipText = "Maintain users within the system";
            listViewItem2.UseItemStyleForSubItems = false;
            listViewItem3.Tag = "COUNTRYMNT";
            listViewItem3.ToolTipText = "Maintain country details within the system";
            listViewItem3.UseItemStyleForSubItems = false;
            listViewItem4.Tag = "STATEMNT";
            listViewItem4.ToolTipText = "Maintain state names within the system";
            listViewItem4.UseItemStyleForSubItems = false;
            listViewItem5.Tag = "FEETYPMNT";
            listViewItem5.ToolTipText = "Maintain fee types";
            listViewItem6.Tag = "CUSTMNT";
            listViewItem6.ToolTipText = "Maintain customer records";
            listViewItem7.Tag = "RQSTRSC";
            listViewItem7.ToolTipText = "Request resources";
            listViewItem8.Tag = "APPOPTNS";
            listViewItem8.ToolTipText = "Change user application settings";
            listViewItem9.Tag = "PRJCREATE";
            listViewItem9.ToolTipText = "Create new project";
            listViewItem10.Tag = "CHNGPW";
            listViewItem10.ToolTipText = "Change your password";
            listViewItem11.Tag = "PRJCENTR";
            listViewItem11.ToolTipText = "view, create and manage projects and requests";
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11});
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(517, 350);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Tile;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 350);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView listView;


    }
}