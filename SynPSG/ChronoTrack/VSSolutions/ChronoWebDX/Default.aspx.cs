using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChronoTrack;

public partial class Default : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["username"] == null)
                txtUsername.Focus();
            else
            {
                txtUsername.Text = Request.Cookies["username"].Value;
                txtPassword.Focus();
            }
        }
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Get all the users
        ChronoTrack.ChronoTrack chronoServer = SynUtils.Server;
        bool loginOk = false;
        int currentUsers = SynUtils.SynLctCurrentUsers() + 1;
        string errorText = "";
        string userToken = "";

        //Connect to xfServerPlus
        try
        {
            chronoServer.connect(SynUtils.ServerHost, SynUtils.GetServerPort(chkDebugServer.Checked));
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "Default.aspx", "connect");
        }

        //Log in to ChronoTrack
        try
        {
            loginOk = chronoServer.RemoteLogin(txtUsername.Text, txtPassword.Text, currentUsers, ref userToken, ref errorText);
            if (!loginOk)
            {
                chronoServer.disconnect();
                fldLoginError.Text = errorText;
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "Default.aspx", "RemoteLogin");
        }

        //Log in a ChronoTrack license 
        if (loginOk && SynUtils.SynLctEnabled)
        {
            int seatNumber = 0;
            int licenseToken = 0;
            if (SynUtils.SynLctLogin(ref seatNumber, ref licenseToken))
            {
                Session.Add("SYNLCT_SEAT", seatNumber);
                Session.Add("SYNLCT_TOKEN", licenseToken);
            }
            else
            {
                fldLoginError.Text = "Failed to allocate license!";
                loginOk = false;
                try
                {
                    chronoServer.disconnect();
                }
                catch
                {
                }
            }
        }

        if (loginOk)
        {
            //Save username in cookie for next time
            HttpCookie cookie = new HttpCookie("username");
            cookie.Value = txtUsername.Text;
            cookie.Expires = DateTime.Now.AddMonths(1);
            Response.Cookies.Add(cookie);

            //Save context in user session state
            Session.Add("USERNAME", txtUsername.Text.ToUpper());
            Session.Add("USERTOKEN", userToken);
            Session.Add("CHRONOSERVER", chronoServer);

            //We're good to go
            Response.Redirect("~/AboutChronoTrack.aspx", true);
        }
    }
    protected void btnCheat_Click(object sender, EventArgs e)
    {
        txtPassword.Text = "p@ssw0rd";
        btnLogin_Click(sender, e);
    }

}
