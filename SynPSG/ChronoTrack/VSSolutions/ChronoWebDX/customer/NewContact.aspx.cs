using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customer_NewContact : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PreviousPageUrl.Value = Request.UrlReferrer.ToString();

            if (Request.QueryString["CustomerID"] != null)
            {
                ucCustomer.Value = Request.QueryString["CustomerID"];
                getLocations();
                enableForm();

                if (Request.QueryString["LocationID"] != null)
                    ucLocation.Value = int.Parse(Request.QueryString["LocationID"].ToString());
            }

        }
    }

    protected void ucCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        enableForm();
    }

    private void enableForm()
    {
        txtFirstName.Enabled = true;
        txtLastName.Enabled = true;
        txtJobTitle.Enabled = true;
        getLocations();
        txtOfficePhone.Enabled = true;
        txtMobilePhone.Enabled = true;
        txtEmail.Enabled = true;
    }

    private void getLocations()
    {
        ucLocation.DoBinding(ucCustomer.Value);
        ucLocation.SelectFirstIfItems();
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        ChronoTrack.Customer_contact contact = new ChronoTrack.Customer_contact();
        contact.Customer_id = ucCustomer.Value;
        contact.First_name = txtFirstName.Text;
        contact.Last_name = txtLastName.Text;
        contact.Friendly_name = txtFirstName.Text + " " + txtLastName.Text;
        contact.Title = txtJobTitle.Text;
        contact.Current_location = ucLocation.Value;
        contact.Office_phone = txtOfficePhone.Text;
        contact.Mobile_phone = txtMobilePhone.Text;
        contact.Email = txtEmail.Text;

        if (CustomerContactBLL.AddCustomerContact(contact))
            goBack();
        else
            lblErrorText.Text = "Failed to create contact!";

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        goBack();
    }

    private void goBack()
    {
        if (ucCustomer.SelectedIndex > -1)
            Response.Redirect("~/customer/Contacts.aspx?CustomerID=" + ucCustomer.Value, true);
        else
            Response.Redirect("~/customer/Contacts.aspx", true);
    }

}
