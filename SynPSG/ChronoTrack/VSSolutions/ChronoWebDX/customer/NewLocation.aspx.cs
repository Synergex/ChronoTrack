using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customer_NewLocation : ThemedPage
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PreviousPageUrl.Value = Request.UrlReferrer.ToString();

            if (Request.QueryString["CustomerID"] != null)
            {
                ucCustomer.Value = Request.QueryString["CustomerID"];
                enableForm();
            }

        }
    }

    protected void ucCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        enableForm();
    }

    private void enableForm()
    {
        txtDescription.Enabled = true;
        txtAddress1.Enabled = true;
        txtAddress2.Enabled = true;
        txtCity.Enabled = true;
        ucState.Enabled = true;
        txtZip.Enabled = true;
        ucCountry.Enabled = true;
        txtPhone.Enabled = true;
        btnOK.Enabled = true;
    }

    protected void ucCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ucCountry.Value.Equals("US"))
        {
            lblState.Text = "State";
            txtRegion.Text = "";
            txtRegion.Enabled = false;
            txtRegion.Visible = false;
            ucState.Enabled = true;
            ucState.Visible = true;
            lblZip.Text = "Zip Code";
        }
        else
        {
            lblState.Text = "Region";
            txtRegion.Enabled = true;
            txtRegion.Visible = true;
            ucState.SelectedIndex = -1;
            ucState.Enabled = false;
            ucState.Visible = false;
            lblZip.Text = "Postal Code";
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ChronoTrack.Customer_location location = new ChronoTrack.Customer_location();

        location.Customer_id = ucCustomer.Value;
        location.Description = txtDescription.Text;
        location.Addr1 = txtAddress1.Text;
        location.Addr2 = txtAddress2.Text;
        location.Addr3 = txtCity.Text;
        if (ucCountry.Value.Equals("US"))
            if (ucState.SelectedIndex > -1)
                location.State = ucState.Value;
        else
            location.Addr4 = txtRegion.Text;
        location.Zip = txtZip.Text;
        location.Country_id = ucCountry.Value;
        location.Phone = txtPhone.Text;

        if (CustomerLocationBLL.AddCustomerLocation(location))
            goBack();
        else
            lblErrorText.Text = "Failed to create location!";
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        goBack();
    }

    private void goBack()
    {
        if (PreviousPageUrl.Value.EndsWith("/customer/Locations.aspx"))
        {
            if (ucCustomer.SelectedIndex > -1)
                Response.Redirect("~/customer/Locations.aspx?CustomerID=" + ucCustomer.Value, true);
            else
                Response.Redirect("~/customer/Locations.aspx", true);
        }
        else
            Response.Redirect(PreviousPageUrl.Value,true);

    }

}
