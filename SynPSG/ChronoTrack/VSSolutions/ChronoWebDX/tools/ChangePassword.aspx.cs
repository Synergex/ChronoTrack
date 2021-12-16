using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChronoTrack;

public partial class tools_ChangePassword : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            PreviousPageUrl.Value = Request.UrlReferrer.ToString();
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        lblErrorText.Text = "";

        String userName = Session["USERNAME"].ToString();
        String oldPassword = txtCurrentPassword.Text;
        String newPassword = txtNewPassword1.Text;

        //Code here to change password
        User thisUser = UserBLL.GetUser(userName);

        //Check the password
        if (oldPassword.Equals(thisUser.Password))
        {
            thisUser.Password = newPassword;
            //Update the user record
            UserBLL.UpdateUser(thisUser);
            Response.Redirect(PreviousPageUrl.Value, true);
        }
        else
        {
            lblErrorText.Text = "The current password you entered is incorrect!";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect(PreviousPageUrl.Value, true);
    }

    protected void txtNewPassword2_Validation(object sender, DevExpress.Web.ASPxEditors.ValidationEventArgs e)
    {
        e.IsValid = txtNewPassword2.Text.Equals(txtNewPassword1.Text);
    }

}
