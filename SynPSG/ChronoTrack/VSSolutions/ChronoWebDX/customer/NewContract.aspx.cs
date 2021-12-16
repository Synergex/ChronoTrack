using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customer_NewContract : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Default the issued date to today
            dteIssuedDate.Date = DateTime.Now;

            //If we have a passed customer ID then use it, and load contacts for that customer
            if (Request.QueryString["CustomerID"] != null)
            {
                ucCustomer.Value = Request.QueryString["CustomerID"];
                getContacts();
            }
        }
    }
    protected void ucCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Selected customer changed, get new contacts for the customer
        getContacts();
    }
    private void getContacts()
    {
        if (ucCustomer.SelectedIndex > -1)
        {
            txtContractId.Enabled = true;
            ucIssuedBy.Enabled = true;
            dteIssuedDate.Enabled = true;
            ucSignedBy.DoBinding(ucCustomer.Value);
            ucSignedBy.SelectFirstIfItems();
            dteSignedDate.Enabled = true;
            txtDocument.Enabled = true;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ChronoTrack.Customer_contract contract = new ChronoTrack.Customer_contract();

        contract.Customer_id = ucCustomer.Value;
        contract.Contract_id = txtContractId.Text;
        contract.Issued_by = ucIssuedBy.Value;
        contract.Issued_date = dteIssuedDate.Date;
        contract.Signed_by = ucSignedBy.Value;
        contract.Signed_date = dteSignedDate.Date;
        contract.Contract_document = txtDocument.Text;

        CustomerContractBLL bll = new CustomerContractBLL();
        if (bll.AddCustomerContract(contract))
            goBack();
        else
            lblErrorText.Text = "Failed to create contract!";

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        goBack();
    }

    private void goBack()
    {
        if (ucCustomer.SelectedIndex > -1)
            Response.Redirect("~/customer/Contracts.aspx?CustomerID=" + ucCustomer.Value, true);
        else
            Response.Redirect("~/customer/Contracts.aspx", true);
    }
    protected void dteIssuedDate_DateChanged(object sender, EventArgs e)
    {
        //Issue date changed, make sure the signed date can't be before the issued date
        dteSignedDate.MinDate = dteIssuedDate.Date.AddDays(-1);
    }
}
