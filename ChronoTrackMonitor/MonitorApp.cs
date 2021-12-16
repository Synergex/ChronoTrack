using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace ChronoTrackMonitor
{
    class MonitorApp : ApplicationContext
    {
        #region private members

        //this is our ChronoTrack web service object!
        private ChronoTrackWS.RemoteService ws;

        //use the cookie container to manage client/server state
        private CookieContainer cookieJar;

        private System.ComponentModel.IContainer components;
        private NotifyIcon mNotifyIcon;
        private ContextMenuStrip mContextMenu;
        private ToolStripMenuItem mMenuItem;
        private ToolStripSeparator mSeparator;
        private Timer mCheckServerTimer;

        //create the response classes from the web service
        private ChronoTrackWS.DisconnectResponse disconnect;
        private ChronoTrackWS.ValidateUserResponse userResonse;
        private ChronoTrackWS.ProjectResponse projects;
        private ChronoTrackWS.ProjectSummaryResponse combinedProjectView;

        //store the user details
        private string userName;
        private string password;

        //remember how many new projects have been seen
        private int showNewProjects;

        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public MonitorApp()
        {
            //Instantiate the component module to hold everything
            components = new System.ComponentModel.Container();

            //need to get/validate user login details
            userName = Properties.Settings.Default.StoredUserName;
            password = Properties.Settings.Default.StoredPassword;

            //try to connect with the stored settings

            ws = new ChronoTrackMonitor.ChronoTrackWS.RemoteService();

            //create a cookie container to maintain state between remote XML web service calls
            cookieJar = new CookieContainer();

            //assign the cookieJar collector to the web service instance
            ws.CookieContainer = cookieJar;

            if (validateTheUser())
            {
                //don't need server anymore
                disconnect = ws.Disconnect();

                /*
                 * Instantiate tie NotifyIcon attaching it to the componenet container and
                 * provide it an icon
                 */
                mNotifyIcon = new NotifyIcon(this.components);
                mNotifyIcon.Icon = Properties.Resources.Folder;
                mNotifyIcon.Text = Properties.Resources.mMonitorTitle;
                mNotifyIcon.Visible = true;

                //Instantate the context menu and items
                mContextMenu = new ContextMenuStrip();

                //attach the menu to the notify icon
                mNotifyIcon.ContextMenuStrip = mContextMenu;

                mMenuItem = new ToolStripMenuItem();
                mMenuItem.Text = Properties.Resources.mOpenProjectView;
                mMenuItem.Click += new EventHandler(displayProjectViewer_Click);
                mContextMenu.Items.Add(mMenuItem);

                mSeparator = new ToolStripSeparator();
                mContextMenu.Items.Add(mSeparator);

                mMenuItem = new ToolStripMenuItem();
                mMenuItem.Text = Properties.Resources.mResetSystemSettings;
                mMenuItem.Click += new EventHandler(resetSystemSettings_Click);
                mContextMenu.Items.Add(mMenuItem);

                mSeparator = new ToolStripSeparator();
                mContextMenu.Items.Add(mSeparator);

                mMenuItem = new ToolStripMenuItem();
                mMenuItem.Text = Properties.Resources.mExitMonitor;
                mMenuItem.Click += new EventHandler(exitApplicaton_Click);
                mContextMenu.Items.Add(mMenuItem);

                //setup a timer so we periodically check the ChronoTrack web server
                mCheckServerTimer = new Timer(components);
                mCheckServerTimer.Tick += new EventHandler(checkServerTimer_Tick);
                mCheckServerTimer.Interval = 10000;
                mCheckServerTimer.Enabled = true;
            }
        }

        //vaidate the user with the server
        private Boolean validateTheUser()
        {
            userResonse = ws.ValidateUser(userName, password);
            if (userResonse.CallStatus == false)
            {
                //allow them to enter new username/password details
                Forms.ClientLogin login = new Forms.ClientLogin();
                if (login.ShowDialog() == DialogResult.Cancel)
                {
                    disconnect = ws.Disconnect();
                    return false;
                }

                //re-try the login
                userName = login.UserName;
                password = login.Password;
                userResonse = ws.ValidateUser(userName, password);
                if (userResonse.CallStatus == false)
                {
                    MessageBox.Show(userResonse.ErrorMessage, Properties.Resources.mMonitorTitle);
                    disconnect = ws.Disconnect();
                    return false;
                }
            }

            return true;
        }

        private void checkServerTimer_Tick(object sender, EventArgs e)
        {
            //don't refire the timer
            mCheckServerTimer.Enabled = false;

            //first validate the user - this reconnects the server
            if (validateTheUser())
            {

                //let's see if we have any "Created" projects
                projects = ws.Projects("", new DateTime(), userName, ChronoTrackMonitor.ChronoTrackWS.ProjectStatus.Created);
                if (projects.CallStatus == false)
                {
                    MessageBox.Show(projects.ErrorMessage);
                    disconnect = ws.Disconnect();
                    return;
                }

                //set to default state
                mNotifyIcon.Icon = Properties.Resources.Folder;
                mNotifyIcon.Text = Properties.Resources.mMonitorTitle;

                //if we have "Created" projects, display the count of them.
                if (projects.ProjectDataTable.Rows.Count != 0 && projects.ProjectDataTable.Rows.Count != showNewProjects)
                {
                    mNotifyIcon.Icon = Properties.Resources.FolderNew;
                    mNotifyIcon.Text = string.Format(Properties.Resources.mMonitorTitleNewProjects, projects.ProjectDataTable.Rows.Count.ToString());
                    mNotifyIcon.ShowBalloonTip(30, Properties.Resources.mBalloonCaption,
                        string.Format(Properties.Resources.mProjectCount, projects.ProjectDataTable.Rows.Count),
                        ToolTipIcon.Info);
                    showNewProjects = projects.ProjectDataTable.Rows.Count;
                }

                //see if we have any new requests
                //            requests = ws.Requests(new DateTime(), userName);
                //            MessageBox.Show(requests.RequestDataTable.Rows.Count.ToString());

                disconnect = ws.Disconnect();
            }
            mCheckServerTimer.Enabled = true;
        }

        private void exitApplicaton_Click(object sender, EventArgs e)
        {
            //call our overridden exit thread core method
            mNotifyIcon.Visible = false;
            //save away our settings
            Properties.Settings.Default.StoredUserName = userName;
            Properties.Settings.Default.StoredPassword = password;
            Properties.Settings.Default.Save();
            //cause the server to disconnect
            ws.Disconnect();
            ExitThreadCore();
        }

        private void displayProjectViewer_Click(object sender, EventArgs e)
        {
            mCheckServerTimer.Enabled = false;

            //validate the user so the server is reconnected
            if (validateTheUser())
            {
                //load the required data
                combinedProjectView = ws.ProjectSummary(userName, new DateTime());
                if (combinedProjectView.CallStatus == false)
                {
                    MessageBox.Show(combinedProjectView.ErrorMessage);
                    disconnect = ws.Disconnect();
                    return;
                }

                //display the project viewer window
                Forms.ProjectView pv = new ChronoTrackMonitor.Forms.ProjectView(ws, combinedProjectView.ProjectDataTableCombined);
                pv.Text = string.Format(Properties.Resources.mProjectViewCaption, userResonse.FullName);
                pv.ShowDialog();
            }
            mCheckServerTimer.Enabled = true;
        }

        private void configureMonitor_Click(object sender, EventArgs e)
        {
            Forms.Configure frm = new ChronoTrackMonitor.Forms.Configure();
            frm.ShowDialog();
        }

        private void resetSystemSettings_Click(object sender, EventArgs e)
        {
            userName = "";
            password = "";
            Properties.Settings.Default.Save();
        }

        protected override void ExitThreadCore()
        {
            /*
             * Clean up all references needed
             */

            //call the base method
            base.ExitThreadCore();
        }

    }
}
