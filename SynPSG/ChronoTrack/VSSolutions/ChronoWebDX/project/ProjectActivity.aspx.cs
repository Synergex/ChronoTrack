using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChronoTrack;

public partial class project_ProjectActivity : ThemedPage
{
    private Project_summary projectSummary;
    //private Project projectFull;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PreviousPageUrl.Value = Request.UrlReferrer.ToString();

            if (Session["Project"] == null)
            {
                multiView.SetActiveView(errorView);
            }
            else
            {
                projectSummary = (Project_summary)Session["Project"];
                //projectFull = (Project)Session["ProjectFull"];

                multiView.SetActiveView(normalView);
            }
        }
        else
        {
            projectSummary = (Project_summary)Session["Project"];
            //projectFull = (Project)Session["ProjectFull"];
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //Go back to "My Projects"
        Response.Redirect(PreviousPageUrl.Value, true);
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        int projectId = projectSummary.Project_id;
        int taskId = int.Parse(Session["CurrentTaskId"].ToString());

        Project_activity a = new Project_activity();
        a.Project_id = projectId;
        a.Task_id = taskId;

        a.Description = txtDescription.Text;
        a.Start_date = ucStartDate.Date;
        a.Start_time = ucStartTime.Date;
        a.End_date = ucEndDate.Date;
        a.End_time = ucEndTime.Date;
        a.Text = txtDetail.Text;

        //Add the new activity
        ProjectActivityBLL.AddProjectActivity(a);

        //Re-get the collection of project activities
        Project_activity_summaryDT s = ProjectActivityBLL.GetProjectActivitiesSummary(projectSummary.Project_id);

        //Update the cache
        Session["ProjectActivities"] = s;

        //Go back to "My Projects"
        Response.Redirect(PreviousPageUrl.Value, true);
    }

}
