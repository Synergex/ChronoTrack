using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChronoTrack;

public partial class tools_EditProfile : ThemedPage
{
    User thisUser;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            PreviousPage.Value = Request.UrlReferrer.ToString();
            String userName = Session["USERNAME"].ToString();

            thisUser = UserBLL.GetUser(userName);
            Session["USER"] = thisUser;

            txtAddress1.Text = thisUser.Addr1;
            txtAddress2.Text = thisUser.Addr2;
            txtCity.Text = thisUser.Addr3;
            txtAddress4.Text = thisUser.Addr4;
            txtZipCode.Text = thisUser.Zip;
            ucState.Value = thisUser.State;
            ucCountry.Value = thisUser.Country_id;
        }

    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        lblErrorText.Text = "";

        thisUser = (User)Session["USER"];
        thisUser.Addr1 = txtAddress1.Text;
        thisUser.Addr2 = txtAddress2.Text;
        thisUser.Addr3 = txtCity.Text;
        thisUser.Addr4 = txtAddress4.Text;
        thisUser.State = ucState.Value;
        thisUser.Zip = txtZipCode.Text;
        thisUser.Country_id = ucCountry.Value;

        if (UserBLL.UpdateUser(thisUser))
            Response.Redirect(PreviousPage.Value, true);
        else
            lblErrorText.Text = "Failed to update contact details!";

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect(PreviousPage.Value, true);
    }

}
