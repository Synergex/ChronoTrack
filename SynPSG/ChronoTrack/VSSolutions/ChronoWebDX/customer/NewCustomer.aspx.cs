using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customer_NewCustomer : ThemedPage
{
    private bool creatingAdminContact;
    private bool creatingTechContact;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Set the default state of the admin and tech contact panels
        creatingAdminContact = chkAdminContact.Checked;
        creatingTechContact = chkTechContact.Checked;
    }

    protected void ucCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        //If the country changes then switch around the various address fields
        if (ucCountry.Value.Equals("US"))
        {
            lblState.Text = "State";
            ucState.Enabled = true;
            ucState.Visible = true;
            txtRegion.Enabled = false;
            txtRegion.Visible = false;
            txtRegion.Text = "";
            lblZip.Text = "Zip Code";
            txtZip.Required = true;
        }
        else
        {
            lblState.Text = "Region";
            ucState.Enabled = false;
            ucState.Visible = false;
            ucState.SelectedIndex = -1;
            txtRegion.Enabled = true;
            txtRegion.Visible = true;
            lblZip.Text = "Postal Code";
            txtZip.Required = false;
        }
    }

    protected void chkAdminContact_CheckedChanged(object sender, EventArgs e)
    {
        //Enable or disable the admin contact fields based on the check box
        creatingAdminContact = chkAdminContact.Checked;
        switch (creatingAdminContact)
        {
            case true:
                txtAdminFirstName.Focus();
                break;
            case false:
                txtAdminFirstName.Text = "";
                txtAdminLastName.Text = "";
                txtAdminJobTitle.Text = "";
                txtAdminOfficePhone.Text = "";
                txtAdminMobilePhone.Text = "";
                txtAdminEmail.Text = "";
                break;
        }
        pnlAdminContact.Enabled = creatingAdminContact;
    }

    protected void chkTechContact_CheckedChanged(object sender, EventArgs e)
    {
        //Enable or disable the tech contact fields based on the check box
        creatingTechContact = chkTechContact.Checked;
        switch (creatingTechContact)
        {
            case true:
                txtTechFirstName.Focus();
                break;
            case false:
                txtTechFirstName.Text = "";
                txtTechLastName.Text = "";
                txtTechJobTitle.Text = "";
                txtTechOfficePhone.Text = "";
                txtTechMobilePhone.Text = "";
                txtTechEmail.Text = "";
                break;
        }
        pnlTechContact.Enabled = creatingTechContact;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        lblErrorText.Text = "";
        bool hadError = false;

        //Get the connection to the Synergy server
        ChronoTrack.ChronoTrack chronoServer = SynUtils.Server;

        //Declare the data objects that we need
        ChronoTrack.Customer customer = new ChronoTrack.Customer();
        ChronoTrack.Customer_location location = new ChronoTrack.Customer_location();
        ChronoTrack.Customer_contact adminContact = new ChronoTrack.Customer_contact();
        ChronoTrack.Customer_contact techContact = new ChronoTrack.Customer_contact();

        /*
         * Create the new customer record. This ensures that the customer ID is not
         * already used. We may need to update the record later if we have legal or
         * tech contacts.
         */
        customer.Customer_id = txtCustomerId.Text;
        customer.Company = txtCompanyName.Text;

        try
        {
            if (!chronoServer.CreateCustomer((string)Session["USERTOKEN"], ref customer))
            {
                lblErrorText.Text = "Failed to create customer record!";
                return;
            }
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "NewCustomer.ascx", "CreateCustomer");
        }


        //Create the customer location record

        location.Customer_id = txtCustomerId.Text;
        location.Description = txtDescription.Text;
        location.Addr1 = txtAddress1.Text;
        location.Addr2 = txtAddress2.Text;
        location.Addr3 = txtCity.Text;
        location.Addr4 = txtRegion.Text;
        location.State = ucState.Value;
        location.Zip = txtZip.Text;
        location.Country_id = ucCountry.Value;
        location.Phone = txtPhone.Text;
        try
        {
            if (!chronoServer.CreateCustomerLocation((string)Session["USERTOKEN"], ref location))
            {
                lblErrorText.Text = "Customer created but failed to create primary location!";
                hadError = true;
            }
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "NewCustomer.ascx", "CreateCustomerLocation");
        }


        //If we have an admin contact then create the contact record

        if (creatingAdminContact)
        {
            adminContact.Customer_id = customer.Customer_id;
            adminContact.First_name = txtAdminFirstName.Text;
            adminContact.Last_name = txtAdminLastName.Text;
            adminContact.Title = txtAdminJobTitle.Text;
            adminContact.Current_location = 1;
            adminContact.Office_phone = txtAdminOfficePhone.Text;
            adminContact.Mobile_phone = txtAdminMobilePhone.Text;
            adminContact.Email = txtAdminEmail.Text;
            try
            {
                if (!chronoServer.CreateCustomerContact((string)Session["USERTOKEN"], ref adminContact))
                {
                    lblErrorText.Text = lblErrorText.Text + " Failed to create admin contact!";
                    hadError = true;
                }
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "NewCustomer.ascx", "CreateCustomerContact (Admin contact)");
            }

        }

        //If we have a legal contact then create the contact record

        if (creatingTechContact)
        {
            techContact.Customer_id = customer.Customer_id;
            techContact.First_name = txtTechFirstName.Text;
            techContact.Last_name = txtTechLastName.Text;
            techContact.Title = txtTechJobTitle.Text;
            techContact.Current_location = 1;
            techContact.Office_phone = txtTechOfficePhone.Text;
            techContact.Mobile_phone = txtTechMobilePhone.Text;
            techContact.Email = txtTechEmail.Text;
            try
            {
                if (!chronoServer.CreateCustomerContact((string)Session["USERTOKEN"], ref techContact))
                {
                    lblErrorText.Text = lblErrorText.Text + " Failed to create technical contact!";
                    hadError = true;
                }
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "NewCustomer.ascx", "CreateCustomerContact (Tech contact)");
            }

        }

        if (creatingAdminContact || creatingTechContact)
        {
            /*
             * Update the customer record with the ID's of the legal and/or tech contacts
             */

            //TODO: We're assuming that AddContact returns the record with the contact ID, check this is true!!!

            if (creatingAdminContact)
                customer.Legal_contact_id = adminContact.Contact_id;

            if (creatingTechContact)
                customer.Tech_contact_id = techContact.Contact_id;

            //TODO: Update the customer record
            try
            {
                string newGrfa = "";
                if (!chronoServer.UpdateCustomer((string)Session["USERTOKEN"], customer, ref newGrfa))
                {
                    lblErrorText.Text = lblErrorText.Text + " Failed to update customer with admin and tech contact ID's!";
                    hadError = true;
                }
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "NewCustomer.ascx", "UpdateCustomer");
            }

        }
        if (!hadError)
            Response.Redirect("~/customer/Default.aspx", true);
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customer/Default.aspx", true);
    }

}
