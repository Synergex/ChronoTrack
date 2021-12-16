using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChronoTrack;

public partial class project_controls_ProjectMasterTable : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public Project_summaryDT ConsultantProjects
    {
        get
        {
            return (Project_summaryDT)cboProjectId.DataSource;
        }
        set
        {
            cboProjectId.DataSource = value;
            cboProjectId.DataBind();
        }
    }

    private Project_summary mProjectSummary;
    public Project_summary ProjectSummary
    {
        get
        {
            return mProjectSummary;
        }
        set
        {
            mProjectSummary = value;
            cboProjectId.Value = mProjectSummary.Project_id;
            txtProject.Text = mProjectSummary.Project_id.ToString();
            txtStatus.Text = mProjectSummary.Status;
            txtLocation.Text = mProjectSummary.Work_location;
            dteStartDate.Date = mProjectSummary.Start_date;
            dteEndDate.Date = mProjectSummary.End_date;
            txtConsultant.Text = mProjectSummary.Lead_consultant;
            txtSubject.Text = mProjectSummary.Subject;
        }
    }

    public event EventHandler SelectedProjectChanged;
    protected void cboProjectId_SelectedIndexChanged(object sender, EventArgs e)
    {
        //If the host has bound an event handler then fire it
        if (SelectedProjectChanged != null)
            SelectedProjectChanged(this, e);
    }

    public int SelectedProjectId
    {
        get
        {
            if (cboProjectId.Value != null)
                return int.Parse(cboProjectId.Value.ToString());
            else
                return 0;
        }
        set
        {
            cboProjectId.Value = value;
        }
    }


}
