using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customer_ContactsAllCustomers : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gridView_StartRowEditing(object sender, DevExpress.Web.Data.ASPxStartRowEditingEventArgs e)
    {
        //We're starting to edit a row

        //Figure out the customer code for the row being edited
        //DataRow thisRow = gridView.GetDataRow(gridView.EditingRowVisibleIndex);
        //string customerId = thisRow["Customer_id"].ToString();

        //Get a handle on the edit forms "location" combo box and tell it to bind to the customer id
        //controls_selectors_LocationCombo location = (controls_selectors_LocationCombo)gridView.FindEditFormTemplateControl("cboLocation");
        //location.DoBinding(customerId);
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customer/NewContact.aspx", true);
    }
}
