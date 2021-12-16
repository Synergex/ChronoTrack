using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SynPSGNetCore.Interop;

namespace ChronoTrackNetUIDX.Forms
{
    public partial class MainMenu : Form//DevExpress.XtraEditors.XtraForm
    {
        private SynInterop interop;

        public MainMenu(SynInterop i)
        {
            InitializeComponent();
            interop = i;
            //set the default web page
            webBrowser1.Navigate("http://www.spc.synergex.com");
        }

        private void menuNavigation_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            switch (e.Link.Item.Name)
            {
                case "navAllCustomerContacts":
                case "navCustomerLocationSummary":
                case "navUserContactList":
                case "navConsultantFees":
                case "navCountryListing":
                case "navStateListing":
                case "navProjectReport":
                case "navHome":
                    webBrowser1.Navigate(e.Link.Item.Tag.ToString());
                    break;
                default:
                    interop.SendMenuSignal(e.Link.Item.Tag.ToString());
                    break;
            }
        }
    }
}