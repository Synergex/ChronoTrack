using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class consultant_ReserveConsultant : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PreviousPage.Value = Request.UrlReferrer.ToString();
            setDefaults();
        }

    }
    protected void fldStartDate_ValueChanged(object sender, EventArgs e)
    {
        //Make sure the end date is not earlier than the start date
        dteEndDate.MinDate = dteStartDate.Date;

        //Default to a single-day request
        dteEndDate.Date = dteStartDate.Date;

        //Default to 8 AM - 5 PM on that date

        dteStartTime.Value = new DateTime(dteStartDate.Date.Year, dteStartDate.Date.Month, dteStartDate.Date.Day, 8, 0, 0);
        dteEndTime.Value = new DateTime(dteStartDate.Date.Year, dteStartDate.Date.Month, dteStartDate.Date.Day, 17, 0, 0);

        //Ebable the request data fields
        dteEndDate.Enabled = true;
        dteStartTime.Enabled = true;
        dteEndTime.Enabled = true;
        ucConsultant.Enabled = true;
        ucCustomer.Enabled = true;

        fldDescription.Enabled = true;
        memoText.Enabled = true;

        //Skip over the end date
        dteStartTime.Focus();

    }

    protected void fldEndDate_ValueChanged(object sender, EventArgs e)
    {
        if (dteEndDate.Date.Equals(dteStartDate.Date))
        {
            //Start date and end date are the same, we need start and end times

            dteStartTime.Date = new DateTime(dteStartDate.Date.Year, dteStartDate.Date.Month, dteStartDate.Date.Day, 8, 0, 0);
            dteStartTime.Enabled = true;

            dteEndTime.Date = new DateTime(dteStartDate.Date.Year, dteStartDate.Date.Month, dteStartDate.Date.Day, 17, 0, 0);
            dteEndTime.Enabled = true;

            dteStartTime.Focus();
        }
        else
        {
            //Start date and end date are different, we don't need start and end times

            dteStartTime.Value = null;
            dteStartTime.Enabled = false;

            dteEndTime.Value = null;
            dteEndTime.Enabled = false;

            ucConsultant.Focus();
        }
    }

    protected void ucCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        ucLocation.DoBinding(ucCustomer.Value);
        ucLocation.SelectFirstIfItems();

        ucContact.DoBinding(ucCustomer.Value);
        ucContact.SelectFirstIfItems();

        ucProject.DoBinding(ucCustomer.Value);
        if (ucProject.ItemCount > 0)
        {
            ucProject.Enabled = true;
            ucProject.SelectedIndex = ucProject.ItemCount - 1;
        }
    }

    protected void ucProject_SelectedIndexChanged(object sender, EventArgs e)
    {
        fldAddendum.Enabled = true;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        lblErrorText.Text = "";

        ChronoTrack.Request newRequest = new ChronoTrack.Request();
        newRequest.Start_date = dteStartDate.Date;
        newRequest.End_date = dteEndDate.Date;
        if (newRequest.End_date.Equals(newRequest.Start_date))
        {
            newRequest.Start_time = dteStartTime.Date;
            newRequest.End_time = dteEndTime.Date;
        }
        newRequest.Resource = ucConsultant.Value;
        newRequest.Customer_id = ucCustomer.Value;
        newRequest.Work_location_id = ucLocation.Value;
        newRequest.Project_id = ucProject.Value;
        newRequest.Contact_id = ucContact.Value;
        newRequest.Description = fldDescription.Text;
        newRequest.Text = memoText.Text;
        newRequest.Created_by = Session["USERNAME"].ToString();

        if (RequestBLL.AddRequest(newRequest))
            Response.Redirect(PreviousPage.Value, true);
        else
            lblErrorText.Text = "Failed to record request!";

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect(PreviousPage.Value, true);
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        lblErrorText.Text = "";
        setDefaults();
    }

    //Utility routines

    private void setDefaults()
    {
        //Ensure that neither date fields are in the past
        dteStartDate.MinDate = DateTime.Now.AddDays(-1);
        dteEndDate.MinDate = dteStartDate.MinDate;

        //Disable the data fields
        dteEndDate.Enabled = false;
        dteStartTime.Enabled = false;
        dteEndTime.Enabled = false;
        ucConsultant.Enabled = false;
        ucCustomer.Enabled = false;
        ucLocation.Enabled = false;
        ucContact.Enabled = false;
        ucProject.Enabled = false;
        fldAddendum.Enabled = false;
        fldDescription.Enabled = false;
        memoText.Enabled = false;

        //Reset all field values to nothing;
        dteStartDate.Value = null;
        dteEndDate.Value = null;
        dteStartTime.Value = null;
        dteEndTime.Value = null;
        ucConsultant.SelectedIndex = -1;
        ucCustomer.SelectedIndex = -1;
        ucLocation.SelectedIndex = -1;
        ucContact.SelectedIndex = -1;
        ucProject.SelectedIndex = -1;
        fldAddendum.Value = null;
        fldDescription.Value = null;
        memoText.Value = null;

        //Set initial focus
        dteStartDate.Focus();
    }

}
