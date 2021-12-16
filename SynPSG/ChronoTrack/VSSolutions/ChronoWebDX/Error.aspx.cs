using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Error : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Do we have error details to display?
            if (Session["EXCEPTION"] != null)
            {
                //Yes, display the error details
                ChronoWebException ex = (ChronoWebException)Session["EXCEPTION"];
                lblPage.Text = ex.Page;
                lblMethod.Text = ex.Method;
                lblErrorText.Text = ex.CaughtException.Message;
                lblSource.Text = ex.CaughtException.Source;
                pnlErrorDetail.Visible = true;
            }
            //Discard the current session and start over
            Session.Abandon();
        }
    }
    protected void btnContinue_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx", true);
    }
}
