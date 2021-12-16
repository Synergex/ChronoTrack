using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * This class is a base class which should be used by all web pages in the application that need to adhere
 * to the user-selected theme.  In this application this technique relies on the following:
 * 
 * 1. One or more themes which are stored in the App_Themes folder.
 * 
 * 2. An XML file called App_Data\Themes.xml which defines and names the themes which are available.
 * 
 * 3. A JavaScript module called Scripts\ThemeUtilities.js containing various client-side support methods etc.
 * 
 * 4. All themed web pages must inherit from this class instead of inheriting from System.Web.UI.Page
 * 
 * 5. The page tools/ChangeTheme.aspx contains a combo box which allows the current theme to be changed, as
 *    well as both client- and server-side code to support the theme switch.
 */

/// <summary>
/// Base class for all web pages which need to default to a user selected theme.
/// </summary>
public class ThemedPage : System.Web.UI.Page
{
    public ThemedPage()
    {
    }

    //This method returns the name of the default theme for new users
    protected string GetDefaultTheme()
    {
        return "PlasticBlue";
    }

    //This method returns the name of the cookie to store the default theme in
    protected string GetThemeCookieName()
    {
        return "ChronoTrackTheme";
    }

    //Register the JavaScript module containing the client side theme support routines
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        Page.ClientScript.RegisterClientScriptInclude("Utilities", Page.ResolveUrl("~/Scripts/ThemeUtilities.js"));
    }

    //Set the theme to use in the page
    protected void Page_PreInit(object sender, EventArgs e)
    {
        //Set the default theme to use if there is no theme cookie
        string themeName = GetDefaultTheme();

        //Check if we have a theme cookie
        if (Page.Request.Cookies[GetThemeCookieName()] != null)
        {
            //Yes we do, do get the theme name from the cookie
            themeName = Page.Request.Cookies[GetThemeCookieName()].Value;
        }

        string clientScriptBlock = "var DXCurrentThemeCookieName = \"" + GetThemeCookieName() + "\";";
        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "DXCurrentThemeCookieName", clientScriptBlock, true);

        //Set the theme name in the current page
        this.Theme = themeName;
    }


}
