namespace ChronoMobile
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mitemLogout = new System.Windows.Forms.MenuItem();
            this.mitemOptions = new System.Windows.Forms.MenuItem();
            this.mitemView = new System.Windows.Forms.MenuItem();
            this.mitemNotes = new System.Windows.Forms.MenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.pbConnect = new System.Windows.Forms.ProgressBar();
            this.lblConnecting = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.listProjects = new System.Windows.Forms.ListBox();
            this.lblComplete = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.pictureComplete = new System.Windows.Forms.PictureBox();
            this.pictureNew = new System.Windows.Forms.PictureBox();
            this.pictureCurrent = new System.Windows.Forms.PictureBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.mitemLogout);
            this.mainMenu1.MenuItems.Add(this.mitemOptions);
            // 
            // mitemLogout
            // 
            this.mitemLogout.Text = "Log out";
            this.mitemLogout.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // mitemOptions
            // 
            this.mitemOptions.Enabled = false;
            this.mitemOptions.MenuItems.Add(this.mitemView);
            this.mitemOptions.MenuItems.Add(this.mitemNotes);
            this.mitemOptions.Text = "Options";
            this.mitemOptions.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // mitemView
            // 
            this.mitemView.Text = "View";
            this.mitemView.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // mitemNotes
            // 
            this.mitemNotes.Text = "Notes";
            this.mitemNotes.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 90);
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(29, 99);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 20);
            this.lblUsername.Text = "User name";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(29, 123);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 20);
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(102, 97);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 21);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(102, 121);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.WordWrap = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(102, 148);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(72, 20);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblErrorMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorMsg.Location = new System.Drawing.Point(102, 181);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(100, 20);
            this.lblErrorMsg.Visible = false;
            // 
            // pbConnect
            // 
            this.pbConnect.Location = new System.Drawing.Point(102, 181);
            this.pbConnect.Name = "pbConnect";
            this.pbConnect.Size = new System.Drawing.Size(100, 20);
            this.pbConnect.Visible = false;
            // 
            // lblConnecting
            // 
            this.lblConnecting.BackColor = System.Drawing.Color.Transparent;
            this.lblConnecting.Location = new System.Drawing.Point(3, 181);
            this.lblConnecting.Name = "lblConnecting";
            this.lblConnecting.Size = new System.Drawing.Size(93, 20);
            this.lblConnecting.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblConnecting.Visible = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Controls.Add(this.lblConnecting);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.lblUsername);
            this.panelLogin.Controls.Add(this.pbConnect);
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtUsername);
            this.panelLogin.Controls.Add(this.lblErrorMsg);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(240, 268);
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.listProjects);
            this.panelSummary.Controls.Add(this.lblComplete);
            this.panelSummary.Controls.Add(this.lblNew);
            this.panelSummary.Controls.Add(this.lblCurrent);
            this.panelSummary.Controls.Add(this.pictureComplete);
            this.panelSummary.Controls.Add(this.pictureNew);
            this.panelSummary.Controls.Add(this.pictureCurrent);
            this.panelSummary.Controls.Add(this.lblSummary);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSummary.Location = new System.Drawing.Point(0, 0);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(240, 268);
            // 
            // listProjects
            // 
            this.listProjects.DisplayMember = "DisplayText";
            this.listProjects.Location = new System.Drawing.Point(7, 96);
            this.listProjects.Name = "listProjects";
            this.listProjects.Size = new System.Drawing.Size(222, 156);
            this.listProjects.TabIndex = 16;
            this.listProjects.ValueMember = "ItemValue";
            this.listProjects.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listProjects_KeyPress);
            // 
            // lblComplete
            // 
            this.lblComplete.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.lblComplete.Location = new System.Drawing.Point(119, 78);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(50, 20);
            this.lblComplete.Text = "Complete";
            this.lblComplete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNew
            // 
            this.lblNew.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.lblNew.Location = new System.Drawing.Point(63, 78);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(50, 20);
            this.lblNew.Text = "New";
            this.lblNew.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrent
            // 
            this.lblCurrent.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.lblCurrent.Location = new System.Drawing.Point(7, 78);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(50, 20);
            this.lblCurrent.Text = "Current";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureComplete
            // 
            this.pictureComplete.Image = ((System.Drawing.Image)(resources.GetObject("pictureComplete.Image")));
            this.pictureComplete.Location = new System.Drawing.Point(119, 27);
            this.pictureComplete.Name = "pictureComplete";
            this.pictureComplete.Size = new System.Drawing.Size(50, 50);
            this.pictureComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureComplete.Tag = "Complete Projects";
            this.pictureComplete.Click += new System.EventHandler(this.pictureComplete_Click);
            this.pictureComplete.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureComplete_Paint);
            // 
            // pictureNew
            // 
            this.pictureNew.Image = ((System.Drawing.Image)(resources.GetObject("pictureNew.Image")));
            this.pictureNew.Location = new System.Drawing.Point(63, 27);
            this.pictureNew.Name = "pictureNew";
            this.pictureNew.Size = new System.Drawing.Size(50, 50);
            this.pictureNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureNew.Tag = "New Projects";
            this.pictureNew.Click += new System.EventHandler(this.pictureNew_Click);
            this.pictureNew.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureNew_Paint);
            // 
            // pictureCurrent
            // 
            this.pictureCurrent.BackColor = System.Drawing.Color.White;
            this.pictureCurrent.Image = ((System.Drawing.Image)(resources.GetObject("pictureCurrent.Image")));
            this.pictureCurrent.Location = new System.Drawing.Point(7, 27);
            this.pictureCurrent.Name = "pictureCurrent";
            this.pictureCurrent.Size = new System.Drawing.Size(50, 50);
            this.pictureCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCurrent.Tag = "Current Projects";
            this.pictureCurrent.Click += new System.EventHandler(this.pictureCurrent_Click);
            this.pictureCurrent.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureCurrent_Paint);
            // 
            // lblSummary
            // 
            this.lblSummary.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblSummary.Location = new System.Drawing.Point(4, 4);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(233, 20);
            this.lblSummary.Text = "Projects for ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.StartUp_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.FormMain_Closing);
            this.panelLogin.ResumeLayout(false);
            this.panelSummary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem mitemLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.ProgressBar pbConnect;
        private System.Windows.Forms.Label lblConnecting;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.MenuItem mitemOptions;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.PictureBox pictureCurrent;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.PictureBox pictureComplete;
        private System.Windows.Forms.PictureBox pictureNew;
        private System.Windows.Forms.ListBox listProjects;
        private System.Windows.Forms.MenuItem mitemView;
        private System.Windows.Forms.MenuItem mitemNotes;
    }
}

