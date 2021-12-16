using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class customer_Locations : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((!IsPostBack) && (Request.QueryString["CustomerID"] != null))
        {
            ucCustomer.Value = Request.QueryString["CustomerID"];
            DoBinding(ucCustomer.Value);
            btnNew.Enabled = true;
        }
    }

    protected void ucCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        DoBinding(ucCustomer.Value);
        btnNew.Enabled = true;
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customer/NewLocation.aspx?CustomerID=" + ucCustomer.Value, true);
    }

    private void DoBinding(string CustomerId)
    {
        customerId.Value = CustomerId;
        dataSource.Select();
        grid.DataBind();
    }

}
