<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

        //If we have a ChronoTrack license allocated
        if (SynUtils.SynLctEnabled)
        {
            if ((Session["SYNLCT_SEAT"] != null) && (Session["SYNLCT_TOKEN"] != null))
            {
                int seatNumber = (int)Session["SYNLCT_SEAT"];
                int licenseToken = (int)Session["SYNLCT_TOKEN"];
                try
                {
                    SynUtils.SynLctLogout(seatNumber, licenseToken);
                }
                catch
                {
                }
            }
        }

        //If we're connected to xfServerPlus then disconnect
        if (Session["CHRONOSERVER"] != null)
        {
            ChronoTrack.ChronoTrack ChronoServer = (ChronoTrack.ChronoTrack)Session["CHRONOSERVER"];
            try
            {
                ChronoServer.disconnect();
            }
            catch
            {
            }
        }        
    }
       
</script>
