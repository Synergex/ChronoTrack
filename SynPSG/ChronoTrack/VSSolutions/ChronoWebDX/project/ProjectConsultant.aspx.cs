using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChronoTrack;

public partial class project_ProjectConsultant : ThemedPage
{
    private string consultantId;
    private Project_summary p;
    private Consultant_fee_summaryDT consultantFees;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Project"] == null)
            {
                multiView.SetActiveView(noProjectView);
            }
            else
            {
                p = (Project_summary)Session["Project"];
                txtProjectId.Text = p.Project_id.ToString();
                multiView.SetActiveView(normalView);

                //Load the consultants combo
                loadConsultants();

            }
        }
        else
        {
            p = (Project_summary)Session["Project"];
            consultantFees = (Consultant_fee_summaryDT)Session["ConsultantFees"];
            grdFees.DataSource = consultantFees;
        }

    }

    protected void loadConsultants()
    {
        UserDT allConsultants = UserBLL.GetAllConsultants();

        //Remove any consultants already assigned to this project
        UserDT projectConsultants = (UserDT)Session["ProjectConsultants"];
        foreach (DataRow projectConsultant in projectConsultants.Rows)
        {
            foreach (DataRow allConsultant in allConsultants.Rows)
            {
                if (projectConsultant.Field<string>("User_id") == allConsultant.Field<string>("User_id"))
                {
                    allConsultant.Delete();
                    allConsultant.AcceptChanges();
                    break;
                }
            }
        }

        if (allConsultants.Rows.Count == 0)
            multiView.SetActiveView(noConsultantView);
        else
        {
            //Bind the consultants to the combo
            cboConsultant.DataSource = allConsultants;
            cboConsultant.TextField = "Friendly_name";
            cboConsultant.ValueField = "User_id";
            cboConsultant.DataBind();
            cboConsultant.SelectedIndex = 0;
            loadConsultantFees();
            btnAddConsultant.Enabled = true;
        }
    }

    private void loadConsultantFees()
    {
        //Get the consultant ID
        consultantId = cboConsultant.SelectedItem.Value.ToString();

        //Get a summary table of that consultants fees
        consultantFees = ConsultantFeeBLL.GetConsultantFeesSummary(consultantId);
        
        //Bind the results to the grid
        grdFees.DataSourceID = "";
        grdFees.DataSource = consultantFees;
        grdFees.DataBind();

        //Cache for postback
        Session["ConsultantFees"] = consultantFees;
    }

    protected void cboConsultant_SelectedIndexChanged(object sender, EventArgs e)
    {
        loadConsultantFees();
    }
    
    protected void btnAddConsultant_Click(object sender, EventArgs e)
    {
        //Get the consultant fee data from the grid
        Consultant_fee_summaryDT fees = (Consultant_fee_summaryDT)grdFees.DataSource;

        //Add the consultant fees to the project
        ProjectBLL.AddConsultant(p.Project_id, fees);

        //Reload the ProjectConsultants cache
        Session["ProjectConsultants"] = UserBLL.GetProjectConsultants(p.Project_id);
        
        //Delete local page cache and return to "My Projects"
        Session.Remove("ConsultantFees");
        Response.Redirect("~/project/MyProjects.aspx", true);
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Session.Remove("ConsultantFees");
        Response.Redirect("~/project/MyProjects.aspx", true);
    }

    protected void grdFees_CustomButtonCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs e)
    {
        int feeTypeId = int.Parse(grdFees.GetRowValues(e.VisibleIndex, "Fee_type_id").ToString());
        
        switch (e.ButtonID)
        {
            case "Delete":
                //Delete the fee type record from cache
                foreach (DataRow r in consultantFees.Rows)
                {
                    if (r.Field<int>("Fee_type_id") == feeTypeId)
                    {
                        r.Delete();
                        r.AcceptChanges();
                        break;
                    }
                }

                //Rebind the grid
                grdFees.DataBind();

                break;
        }

    }
}
