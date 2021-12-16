using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class project_NewProject : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            PreviousPage.Value = Request.UrlReferrer.ToString();
    }

    protected void ucCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        //We have a customer, get their contracts
        ucContract.DoBinding(ucCustomer.Value);
        if (ucContract.ItemCount > 0)
        {
            ucLocation.DoBinding(ucCustomer.Value);
            ucLocation.SelectFirstIfItems();

            ucContract.Enabled = true;
            ucContract.SelectedIndex = ucContract.ItemCount - 1;

            ucApprovedBy.DoBinding(ucCustomer.Value);
            ucApprovedBy.SelectFirstIfItems();

            ucStartDate.Enabled = true;
            ucStartDate.Focus();
        }

    }

    protected void ucStartDate_DateChanged(object sender, EventArgs e)
    {
        ucEndDate.MinDate = ucStartDate.Date;
        ucEndDate.Enabled = true;
        ucEndDate.Focus();
        ucCoordinator.Enabled = true;
        ucLeadConsultant.Enabled = true;
        ucDescription.Enabled = true;
        txtDetails.Enabled = true;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ChronoTrack.Project p = new ChronoTrack.Project();

        p.Customer_id = ucCustomer.Value;
        p.Contract_id = ucContract.Value;
        p.Description = ucDescription.Text;
        p.Start_date = ucStartDate.Date;
        p.End_date = ucEndDate.Date;
        p.Lead_consultant = ucLeadConsultant.Value;
        p.Coordinator = ucCoordinator.Value;
        p.Approved_by_first = ucApprovedBy.Value;
        p.Approved_by_last = ucApprovedBy.Value;
        p.Approved_date = DateTime.Now;         //TODO: not really true, need an extra field
        p.Approval_location = ucLocation.Value; //TODO: not really true, should be approval contacts location
        p.Work_location_id = ucLocation.Value;
        p.Text = txtDetails.Text;

        if (ProjectBLL.AddProject(p))
            goBack();
        else
            lblErrorText.Text = "Failed to create project!";
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        goBack();
    }

    private void goBack()
    {
        Response.Redirect(PreviousPage.Value, true);
    }

}
