using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Data;
using DevExpress.Web.ASPxGridView;

public partial class customer_BrowseCustomers : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridViewColumn col = grdCustomers.Columns["Company"];
        grdCustomers.SortBy(col, ColumnSortOrder.Ascending);
    }

    protected void grdLocations_Init(object sender, EventArgs e)
    {
        ASPxGridView grdLocation = (ASPxGridView)sender;
        fldCustomerId.Value = (string)grdLocation.GetMasterRowKeyValue();
        dsLocation.Select();
        grdLocation.DataBind();
    }

    protected void grdContact_Init(object sender, EventArgs e)
    {
        ASPxGridView grdContact = (ASPxGridView)sender;
        fldLocationId.Value = grdContact.GetMasterRowKeyValue().ToString();
        dsContact.Select();
        grdContact.DataBind();
    }

    protected void btnAddCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customer/NewCustomer.aspx", true);
    }

    protected void btnAddLocation_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customer/NewLocation.aspx?CustomerID=" + fldCustomerId.Value, true);
    }
    
    protected void btnAddContact_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/customer/NewContact.aspx?CustomerID=" + fldCustomerId.Value+"&LocationID="+fldLocationId.Value, true);
    }
}
