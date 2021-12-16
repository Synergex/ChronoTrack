using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChronoTrack;

public partial class admin_User : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            PreviousPageUrl.Value = Request.UrlReferrer.ToString();

            string userId = Request.QueryString["UserId"];
            User user = UserBLL.GetUser(userId);
            lblUserId.Text = user.User_id;
            lblFirstName.Text = user.First_name;
            lblLastName.Text = user.Last_name;
            lblAddress1.Text = user.Addr1;

            if (user.Addr2.Length > 0)
            {
                lblAddress2.Text = user.Addr2;
                lblAddress2.Visible = true;
                lblAddress2Comma.Visible = true;
            }

            if (user.Addr3.Length > 0)
            {
                lblCity.Text = user.Addr3;
                lblCity.Visible = true;
                lblCityComma.Visible = true;
            }

            if (user.Addr4.Length > 0)
            {
                lblRegion.Text = user.Addr4;
                lblRegion.Visible = true;
                lblRegionComma.Visible = true;
            }

            if (user.State.Length > 0 && user.State != "ZZ")
            {
                lblState.Text = user.State;
                lblState.Visible = true;
                lblStateComma.Visible = true;
            }

            if (user.Zip.Length > 0)
            {
                lblZip.Text = user.Zip;
                lblZip.Visible = true;
                lblZipComma.Visible = true;
            }

            lblCountry.Text = user.Country_id;

            if (user.Office_phone.Length > 0)
            {
                hlOfficePhone.Text = user.Office_phone;
                user.Office_phone = user.Office_phone.Replace("(", "");
                user.Office_phone = user.Office_phone.Replace(")", "");
                user.Office_phone = user.Office_phone.Replace("-", "");
                user.Office_phone = user.Office_phone.Replace(" ", "");
                hlOfficePhone.NavigateUrl = "callto:" + user.Office_phone;
            }

            if (user.Mobile_phone.Length > 0)
            {
                hlMobilePhone.Text = user.Mobile_phone;
                user.Mobile_phone = user.Mobile_phone.Replace("(", "");
                user.Mobile_phone = user.Mobile_phone.Replace(")", "");
                user.Mobile_phone = user.Mobile_phone.Replace("-", "");
                user.Mobile_phone = user.Mobile_phone.Replace(" ", "");
                hlMobilePhone.NavigateUrl = "callto:" + user.Mobile_phone;
            }

            hlEmail.Text = user.Email;
            hlEmail.NavigateUrl = "mailto:" + user.Email;

            lblJobTitle.Text = user.Title;

            if (user.Picture_file.Length > 0)
            {
                try
                {
                    imgPhoto.ImageUrl = "~/images/" + user.Picture_file;
                    imgPhoto.Visible = true;
                }
                catch
                {
                }
            }

            if (user.Is_employee)
                lblEmployee.Text = "Yes";
            else
                lblEmployee.Text = "No";

            if (user.Is_consultant)
                lblConsultant.Text = "Yes";
            else
                lblConsultant.Text = "No";

            if (user.Is_manager)
                lblManager.Text = "Yes";
            else
                lblManager.Text = "No";

            if (user.Inactive)
                lblActive.Text = "No";
            else
                lblActive.Text = "Yes";

        }

    }

    protected void btnDone_Click(object sender, EventArgs e)
    {
        Response.Redirect(PreviousPageUrl.Value, true);
    }

}
