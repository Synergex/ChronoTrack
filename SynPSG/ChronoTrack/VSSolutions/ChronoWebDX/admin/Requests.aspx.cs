using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxEditors;

public partial class admin_Requests : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnNewRequest_Click(object sender, EventArgs e)
    {
        pnlRequest.Visible = true;
        dvSelectedRequest.ChangeMode(DetailsViewMode.Insert);
    }

    protected void grdRequests_CustomButtonCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs e)
    {
        if (e.ButtonID.Equals("btnEdit"))
        {
            //Get the DataRow for the selected grid item
            System.Data.DataRow thisRow = grdRequests.GetDataRow(e.VisibleIndex);
            //Store the value from the first column in a hidden label.  This label is used as a parameter
            //source by dsSelectedRequest
            lblRequestId.Text = ((int)thisRow.ItemArray[1]).ToString();

            //Tell the forms datasource to go get it's data
            dsSelectedRequest.Select();
            dvSelectedRequest.DataBind();

            loadCustomerData();

            //Edit the selected request
            dvSelectedRequest.ChangeMode(DetailsViewMode.Edit);
            pnlRequest.Visible = true;
            dvSelectedRequest.Focus();
        }

    }

    protected void ucCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        loadCustomerData();
    }

    private void loadCustomerData()
    {
        lblCustomer.Text = ((controls_selectors_CustomerCombo)dvSelectedRequest.FindControl("ucCustomer")).Value;
        ((controls_selectors_ContactCombo)dvSelectedRequest.FindControl("ucContact")).DoBinding(lblCustomer.Text);
        ((controls_selectors_LocationCombo)dvSelectedRequest.FindControl("ucLocation")).DoBinding(lblCustomer.Text);
    }

    protected void dvSelectedRequest_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
    {
        backToGrid();
    }

    protected void dvSelectedRequest_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
    {
        backToGrid();
    }

    protected void dvSelectedRequest_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Cancel"))
        {
            backToGrid();
        }
    }

    protected void grdRequests_RowDeleted(object sender, DevExpress.Web.Data.ASPxDataDeletedEventArgs e)
    {
        backToGrid();
    }

    private void backToGrid()
    {
        pnlRequest.Visible = false;
        dvSelectedRequest.ChangeMode(DetailsViewMode.Insert);
        grdRequests.Focus();
    }

}
