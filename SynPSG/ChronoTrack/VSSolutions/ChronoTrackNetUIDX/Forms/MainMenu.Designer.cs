namespace ChronoTrackNetUIDX.Forms
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
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.menuNavigation = new DevExpress.XtraNavBar.NavBarControl();
            this.navProjectCentre = new DevExpress.XtraNavBar.NavBarGroup();
            this.itemProjectCentre = new DevExpress.XtraNavBar.NavBarItem();
            this.itemProjectCreator = new DevExpress.XtraNavBar.NavBarItem();
            this.itemProjectManager = new DevExpress.XtraNavBar.NavBarItem();
            this.itemReqestResource = new DevExpress.XtraNavBar.NavBarItem();
            this.navMaintenance = new DevExpress.XtraNavBar.NavBarGroup();
            this.itemCustomerMaintenance = new DevExpress.XtraNavBar.NavBarItem();
            this.itemUserMaintenance = new DevExpress.XtraNavBar.NavBarItem();
            this.itemCountryMaintenance = new DevExpress.XtraNavBar.NavBarItem();
            this.itemStateMaintenance = new DevExpress.XtraNavBar.NavBarItem();
            this.itemFeeTypeMaintenance = new DevExpress.XtraNavBar.NavBarItem();
            this.navReports = new DevExpress.XtraNavBar.NavBarGroup();
            this.navAllCustomerContacts = new DevExpress.XtraNavBar.NavBarItem();
            this.navCustomerLocationSummary = new DevExpress.XtraNavBar.NavBarItem();
            this.navUserContactList = new DevExpress.XtraNavBar.NavBarItem();
            this.navConsultantFees = new DevExpress.XtraNavBar.NavBarItem();
            this.navCountryListing = new DevExpress.XtraNavBar.NavBarItem();
            this.navStateListing = new DevExpress.XtraNavBar.NavBarItem();
            this.navHome = new DevExpress.XtraNavBar.NavBarItem();
            this.navToolkit = new DevExpress.XtraNavBar.NavBarGroup();
            this.itemUserMaintenanceTK = new DevExpress.XtraNavBar.NavBarItem();
            this.navOptions = new DevExpress.XtraNavBar.NavBarGroup();
            this.itemApplicationOptions = new DevExpress.XtraNavBar.NavBarItem();
            this.itemChangePassword = new DevExpress.XtraNavBar.NavBarItem();
            this.navExit = new DevExpress.XtraNavBar.NavBarGroup();
            this.itemExit = new DevExpress.XtraNavBar.NavBarItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.navProjectReport = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuNavigation)).BeginInit();
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
            this.imageList.Images.SetKeyName(12, "Design.bmp");
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.menuNavigation);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(526, 508);
            this.splitContainerControl1.SplitterPosition = 215;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // menuNavigation
            // 
            this.menuNavigation.ActiveGroup = this.navProjectCentre;
            this.menuNavigation.AllowDrop = false;
            this.menuNavigation.ContentButtonHint = null;
            this.menuNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuNavigation.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navProjectCentre,
            this.navMaintenance,
            this.navReports,
            this.navToolkit,
            this.navOptions,
            this.navExit});
            this.menuNavigation.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.itemExit,
            this.itemUserMaintenance,
            this.itemCountryMaintenance,
            this.itemStateMaintenance,
            this.itemFeeTypeMaintenance,
            this.itemCustomerMaintenance,
            this.itemProjectCreator,
            this.itemReqestResource,
            this.itemApplicationOptions,
            this.itemChangePassword,
            this.itemProjectCentre,
            this.itemUserMaintenanceTK,
            this.itemProjectManager,
            this.navAllCustomerContacts,
            this.navConsultantFees,
            this.navCountryListing,
            this.navCustomerLocationSummary,
            this.navStateListing,
            this.navUserContactList,
            this.navHome,
            this.navProjectReport});
            this.menuNavigation.LargeImages = this.imageList;
            this.menuNavigation.Location = new System.Drawing.Point(0, 0);
            this.menuNavigation.Name = "menuNavigation";
            this.menuNavigation.OptionsNavPane.ExpandedWidth = 211;
            this.menuNavigation.Size = new System.Drawing.Size(211, 504);
            this.menuNavigation.TabIndex = 0;
            this.menuNavigation.Text = "Main menu";
            this.menuNavigation.View = new DevExpress.XtraNavBar.ViewInfo.SkinExplorerBarViewInfoRegistrator();
            this.menuNavigation.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.menuNavigation_LinkPressed);
            // 
            // navProjectCentre
            // 
            this.navProjectCentre.Caption = "Project centre";
            this.navProjectCentre.Expanded = true;
            this.navProjectCentre.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navProjectCentre.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemProjectCentre),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemProjectCreator),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemProjectManager),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemReqestResource)});
            this.navProjectCentre.Name = "navProjectCentre";
            // 
            // itemProjectCentre
            // 
            this.itemProjectCentre.Caption = "Project explorer";
            this.itemProjectCentre.LargeImageIndex = 11;
            this.itemProjectCentre.Name = "itemProjectCentre";
            this.itemProjectCentre.Tag = "PRJCENTR";
            // 
            // itemProjectCreator
            // 
            this.itemProjectCreator.Caption = "Project creator";
            this.itemProjectCreator.LargeImageIndex = 8;
            this.itemProjectCreator.Name = "itemProjectCreator";
            this.itemProjectCreator.Tag = "PRJCREATE";
            // 
            // itemProjectManager
            // 
            this.itemProjectManager.Caption = "Project manager";
            this.itemProjectManager.LargeImageIndex = 12;
            this.itemProjectManager.Name = "itemProjectManager";
            this.itemProjectManager.Tag = "PRJMGR";
            // 
            // itemReqestResource
            // 
            this.itemReqestResource.Caption = "Resource requestor";
            this.itemReqestResource.LargeImageIndex = 9;
            this.itemReqestResource.Name = "itemReqestResource";
            this.itemReqestResource.Tag = "RQSTRSC";
            // 
            // navMaintenance
            // 
            this.navMaintenance.Caption = "Maintenance";
            this.navMaintenance.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navMaintenance.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemCustomerMaintenance),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemUserMaintenance),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemCountryMaintenance),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemStateMaintenance),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemFeeTypeMaintenance)});
            this.navMaintenance.Name = "navMaintenance";
            // 
            // itemCustomerMaintenance
            // 
            this.itemCustomerMaintenance.Caption = "Customer Maintenance";
            this.itemCustomerMaintenance.LargeImageIndex = 3;
            this.itemCustomerMaintenance.Name = "itemCustomerMaintenance";
            this.itemCustomerMaintenance.Tag = "CUSTMNT";
            // 
            // itemUserMaintenance
            // 
            this.itemUserMaintenance.Caption = "User maintenance";
            this.itemUserMaintenance.LargeImageIndex = 5;
            this.itemUserMaintenance.Name = "itemUserMaintenance";
            this.itemUserMaintenance.Tag = "USERMNTTAB";
            // 
            // itemCountryMaintenance
            // 
            this.itemCountryMaintenance.Caption = "Country maintenance";
            this.itemCountryMaintenance.LargeImageIndex = 10;
            this.itemCountryMaintenance.Name = "itemCountryMaintenance";
            this.itemCountryMaintenance.Tag = "COUNTRYMNT";
            // 
            // itemStateMaintenance
            // 
            this.itemStateMaintenance.Caption = "State maintenance";
            this.itemStateMaintenance.LargeImageIndex = 2;
            this.itemStateMaintenance.Name = "itemStateMaintenance";
            this.itemStateMaintenance.Tag = "STATEMNT";
            // 
            // itemFeeTypeMaintenance
            // 
            this.itemFeeTypeMaintenance.Caption = "Fee type maintenance";
            this.itemFeeTypeMaintenance.LargeImageIndex = 1;
            this.itemFeeTypeMaintenance.Name = "itemFeeTypeMaintenance";
            this.itemFeeTypeMaintenance.Tag = "FEETYPMNT";
            // 
            // navReports
            // 
            this.navReports.Caption = "Reports";
            this.navReports.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navAllCustomerContacts),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCustomerLocationSummary),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navUserContactList),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navConsultantFees),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navCountryListing),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navStateListing),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navProjectReport),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navHome)});
            this.navReports.Name = "navReports";
            // 
            // navAllCustomerContacts
            // 
            this.navAllCustomerContacts.Caption = "Customer Contacts";
            this.navAllCustomerContacts.Name = "navAllCustomerContacts";
            this.navAllCustomerContacts.Tag = "http://localhost/ReportServer/Pages/ReportViewer.aspx?%2fChronoTrackReports%2fAll" +
                "+Customer+Contacts&rs:Command=Render";
            // 
            // navCustomerLocationSummary
            // 
            this.navCustomerLocationSummary.Caption = "Customer location summary";
            this.navCustomerLocationSummary.Name = "navCustomerLocationSummary";
            this.navCustomerLocationSummary.Tag = "http://localhost/ReportServer/Pages/ReportViewer.aspx?%2fChronoTrackReports%2fCus" +
                "tomer+Location+Summary&rs:Command=Render";
            // 
            // navUserContactList
            // 
            this.navUserContactList.Caption = "User contact list";
            this.navUserContactList.Name = "navUserContactList";
            this.navUserContactList.Tag = "http://localhost/ReportServer/Pages/ReportViewer.aspx?%2fChronoTrackReports%2fUse" +
                "r+Contact+List&rs:Command=Render";
            // 
            // navConsultantFees
            // 
            this.navConsultantFees.Caption = "Consultant fees";
            this.navConsultantFees.Name = "navConsultantFees";
            this.navConsultantFees.Tag = "http://localhost/ReportServer/Pages/ReportViewer.aspx?%2fChronoTrackReports%2fCon" +
                "sultant+Fees&rs:Command=Render";
            // 
            // navCountryListing
            // 
            this.navCountryListing.Caption = "Country listing";
            this.navCountryListing.Name = "navCountryListing";
            this.navCountryListing.Tag = "http://localhost/ReportServer/Pages/ReportViewer.aspx?%2fChronoTrackReports%2fCou" +
                "ntry+Listing&rs:Command=Render";
            // 
            // navStateListing
            // 
            this.navStateListing.Caption = "State listing";
            this.navStateListing.Name = "navStateListing";
            this.navStateListing.Tag = "http://localhost/ReportServer/Pages/ReportViewer.aspx?%2fChronoTrackReports%2fSta" +
                "te+Listing&rs:Command=Render";
            // 
            // navHome
            // 
            this.navHome.Caption = "Home";
            this.navHome.Name = "navHome";
            this.navHome.Tag = "http://spc.synergex.com";
            // 
            // navToolkit
            // 
            this.navToolkit.Caption = "Work in Progress";
            this.navToolkit.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navToolkit.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemUserMaintenanceTK)});
            this.navToolkit.Name = "navToolkit";
            // 
            // itemUserMaintenanceTK
            // 
            this.itemUserMaintenanceTK.Caption = "Toolkit user maintenance";
            this.itemUserMaintenanceTK.LargeImageIndex = 5;
            this.itemUserMaintenanceTK.Name = "itemUserMaintenanceTK";
            this.itemUserMaintenanceTK.Tag = "USERMNT";
            // 
            // navOptions
            // 
            this.navOptions.Caption = "Options";
            this.navOptions.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navOptions.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemApplicationOptions),
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemChangePassword)});
            this.navOptions.Name = "navOptions";
            // 
            // itemApplicationOptions
            // 
            this.itemApplicationOptions.Caption = "Application options";
            this.itemApplicationOptions.LargeImageIndex = 4;
            this.itemApplicationOptions.Name = "itemApplicationOptions";
            this.itemApplicationOptions.Tag = "APPOPTNS";
            // 
            // itemChangePassword
            // 
            this.itemChangePassword.Caption = "Change password";
            this.itemChangePassword.LargeImageIndex = 0;
            this.itemChangePassword.Name = "itemChangePassword";
            this.itemChangePassword.Tag = "CHNGPW";
            // 
            // navExit
            // 
            this.navExit.Caption = "Exit";
            this.navExit.Expanded = true;
            this.navExit.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navExit.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.itemExit)});
            this.navExit.Name = "navExit";
            // 
            // itemExit
            // 
            this.itemExit.Caption = "Exit ChronoTrack";
            this.itemExit.LargeImageIndex = 7;
            this.itemExit.Name = "itemExit";
            this.itemExit.Tag = "MB_EXIT";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(301, 504);
            this.webBrowser1.TabIndex = 0;
            // 
            // navProjectReport
            // 
            this.navProjectReport.Caption = "Project summary";
            this.navProjectReport.Name = "navProjectReport";
            this.navProjectReport.Tag = "http://localhost/ReportServer/Pages/ReportViewer.aspx?%2fChronoTrackReports%2fPro" +
                "ject+Report&rs:Command=Render";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 508);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "Main menu";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuNavigation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl menuNavigation;
        private DevExpress.XtraNavBar.NavBarGroup navProjectCentre;
        private DevExpress.XtraNavBar.NavBarGroup navMaintenance;
        private DevExpress.XtraNavBar.NavBarGroup navOptions;
        private DevExpress.XtraNavBar.NavBarGroup navExit;
        private DevExpress.XtraNavBar.NavBarItem itemExit;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevExpress.XtraNavBar.NavBarItem itemUserMaintenance;
        private DevExpress.XtraNavBar.NavBarItem itemCountryMaintenance;
        private DevExpress.XtraNavBar.NavBarItem itemStateMaintenance;
        private DevExpress.XtraNavBar.NavBarItem itemApplicationOptions;
        private DevExpress.XtraNavBar.NavBarItem itemChangePassword;
        private DevExpress.XtraNavBar.NavBarItem itemFeeTypeMaintenance;
        private DevExpress.XtraNavBar.NavBarItem itemCustomerMaintenance;
        private DevExpress.XtraNavBar.NavBarItem itemProjectCreator;
        private DevExpress.XtraNavBar.NavBarItem itemReqestResource;
        private DevExpress.XtraNavBar.NavBarItem itemProjectCentre;
        private DevExpress.XtraNavBar.NavBarGroup navToolkit;
        private DevExpress.XtraNavBar.NavBarItem itemUserMaintenanceTK;
        private DevExpress.XtraNavBar.NavBarItem itemProjectManager;
        private DevExpress.XtraNavBar.NavBarGroup navReports;
        private DevExpress.XtraNavBar.NavBarItem navAllCustomerContacts;
        private DevExpress.XtraNavBar.NavBarItem navCustomerLocationSummary;
        private DevExpress.XtraNavBar.NavBarItem navUserContactList;
        private DevExpress.XtraNavBar.NavBarItem navConsultantFees;
        private DevExpress.XtraNavBar.NavBarItem navCountryListing;
        private DevExpress.XtraNavBar.NavBarItem navStateListing;
        private DevExpress.XtraNavBar.NavBarItem navHome;
        private DevExpress.XtraNavBar.NavBarItem navProjectReport;

    }
}