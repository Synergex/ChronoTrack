using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Unavailable : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Abandon();
    }

    protected void btnContinue_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx", true);
    }
}
