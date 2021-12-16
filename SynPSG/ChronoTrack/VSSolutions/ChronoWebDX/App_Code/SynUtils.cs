using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

/// <summary>
/// Summary description for SynUtils
/// </summary>
public static class SynUtils
{
    public static string ServerHost
    {
        get
        {
            string hostName = getAppSetting("xfServerPlusHost");
            if (hostName.Length==0)
                hostName = "localhost";
            return hostName;
        }
    }

    public static int GetServerPort(bool debugMode)
    {
        int hostPort = 2365;
        string portSettingName = "xfServerPlusPort";
        if (debugMode)
        {
            hostPort = 2366;
            portSettingName = "xfServerPlusDebugPort";
        }
        string portSettingValue = getAppSetting(portSettingName);
        if (portSettingValue.Length>0)
            hostPort = int.Parse(portSettingValue);
        return hostPort;
    }

    private static string getAppSetting(string settingName)
    {
        string settingValue = "";
        System.Configuration.Configuration webConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/Web.config");
        if (webConfig.AppSettings.Settings.Count > 0)
        {
            System.Configuration.KeyValueConfigurationElement thisSetting = webConfig.AppSettings.Settings[settingName];
            if (thisSetting != null)
                settingValue = thisSetting.Value;
        }
        return settingValue;
    }

    public static ChronoTrack.ChronoTrack Server
    {
        get
        {
            HttpSessionState Session = HttpContext.Current.Session;
            ChronoTrack.ChronoTrack chronoServer;
            
            if (Session["CHRONOSERVER"]==null)
                chronoServer = new ChronoTrack.ChronoTrack();
            else
                chronoServer = (ChronoTrack.ChronoTrack)Session["CHRONOSERVER"];

            return chronoServer;
        }
    }

    public static void ReleaseServer(ref ChronoTrack.ChronoTrack chronoServer)
    {
        //TODO: Add this once pooling is used: chronoServer.Dispose();
        chronoServer = null;
    }

    public static string UserToken
    {
        get
        {
            HttpSessionState Session = HttpContext.Current.Session;
            string userToken = "";

            if (Session["USERTOKEN"] != null)
                userToken = (string)Session["USERTOKEN"];

            return userToken;
        }
    }

    public static string UserName
    {
        get
        {
            HttpSessionState Session = HttpContext.Current.Session;
            string userName = "";

            if (Session["USERNAME"] != null)
                userName = (string)Session["USERNAME"];

            return userName;
        }
    }

    public static bool SynLctEnabled
    {
        get
        {
            return (getAppSetting("SynLctEnabled") == "true");
        }
    }

    public static string SynLctProducerCode
    {
        get
        {
            return getAppSetting("SynLctProducerCode");
        }
    }

    public static string SynLctProductCode
    {
        get
        {
            return getAppSetting("SynLctProductCode");
        }
    }

    public static bool SynLctLogin(ref int seatNumber, ref int licenseToken)
    {
        bool retVal=true;
        Random random = new Random();
        seatNumber = random.Next(20000000);
        try
        {
            licenseToken = SynLct.AllocateLicense(SynLctProducerCode, SynLctProductCode, seatNumber);
        }
        catch
        {
            retVal = false;
        }
        return retVal;
    }

    public static void SynLctLogout(int seatNumber, int licenseToken)
    {
        try
        {
            SynLct.DeallocateLicense(SynLctProducerCode, SynLctProductCode, seatNumber, licenseToken);
        }
        catch
        {
        }
    }

    public static int SynLctCurrentUsers()
    {
        int currentUsers = -1;
        if (SynLctEnabled)
        {
            try
            {
                currentUsers = SynLct.LicenseUsageSnapshot(SynLctProducerCode, SynLctProductCode);
            }
            catch
            {
            }
        }
        return currentUsers;
    }

    public static void CallFailure(Exception ex, string pageOrControl, string methodName)
    {
        HttpSessionState Session = HttpContext.Current.Session;
        HttpResponse Response = HttpContext.Current.Response;
        ChronoWebException webEx = new ChronoWebException(ex, pageOrControl, methodName);
        Session.Add("EXCEPTION", webEx);
        Response.Redirect("~/Error.aspx", true);

    }

    public static void MethodFailure(string errorText, string pageOrControl, string methodName)
    {
        HttpSessionState Session = HttpContext.Current.Session;
        HttpResponse Response = HttpContext.Current.Response;
        Exception ex = new Exception(errorText);
        ChronoWebException webEx = new ChronoWebException(ex, pageOrControl, methodName);
        Session.Add("EXCEPTION", webEx);
        Response.Redirect("~/Error.aspx", true);

    }

    public static DateTime MakeDateTime(DateTime date, DateTime time)
    {
        return new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
    }

}
