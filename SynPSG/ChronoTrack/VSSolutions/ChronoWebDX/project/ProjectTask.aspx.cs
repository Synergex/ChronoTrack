using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChronoTrack;

public partial class project_ProjectTask : ThemedPage
{
    private Project_summary ps;
    private Project pf;
    private Project_task t;
    private Project_task_summaryDT s;
    private int taskId;

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
                ps = (Project_summary)Session["Project"];
                pf = (Project)Session["ProjectFull"];

                cboAssignedTo.DoBinding(ps.Project_id);

                multiView.SetActiveView(normalView);

                //Are we being asked to edit an existing note?
                if (!(Request.QueryString["TaskId"] == null))
                    loadTask();
            }
        }
        else
        {
            ps = (Project_summary)Session["Project"];
            pf = (Project)Session["ProjectFull"];
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //Go back to "My Projects"
        Response.Redirect(PreviousPageUrl.Value, true);
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (btnOk.Text == "Add Task")
            addTask();
        else
            updateTask();

        //Re-get the collection of project notes
        s = ProjectTaskBLL.GetProjectTasksSummary(ps.Project_id);

        //Update the cache
        Session["ProjectTasks"] = s;

        //Go back to "My Projects"
        Response.Redirect(PreviousPageUrl.Value, true);
    }

    protected void addTask()
    {
        t = new Project_task();
        t.Project_id = ps.Project_id;
        t.Task_type = int.Parse(cboTaskType.Value.ToString());
        t.Description = txtDescription.Text;
        t.Assigned_to = cboAssignedTo.Value;
        t.Start_date = ucStartDate.Date;
        t.Start_time = ucStartTime.Date;
        t.End_date = ucEndDate.Date;
        t.End_time = ucEndTime.Date;
        t.Location = pf.Work_location_id;
        t.Text = txtDetail.Text;

        //Add the new note
        ProjectTaskBLL.AddProjectTask(t);
    }

    protected void loadTask()
    {
        taskId = int.Parse(Request.QueryString["TaskId"].ToString());
        t = ProjectTaskBLL.GetTask(ps.Project_id, taskId);
        cboTaskType.Value = t.Task_type;
        txtDescription.Text = t.Description;
        cboAssignedTo.Value = t.Assigned_to;
        ucStartDate.Date = t.Start_date;
        ucStartTime.Date = t.Start_time;
        ucEndDate.Date = t.End_date;
        ucEndTime.Date = t.End_time;
        txtDetail.Text = t.Text;
        btnOk.Text = "Update Task";
    }

    protected void updateTask()
    {
        taskId = int.Parse(Request.QueryString["TaskId"].ToString());
        t = ProjectTaskBLL.GetTask(ps.Project_id, taskId);
        t.Task_type = int.Parse(cboTaskType.Value.ToString());
        t.Description = txtDescription.Text;
        t.Assigned_to = cboAssignedTo.Value;
        t.Start_date = ucStartDate.Date;
        t.Start_time = ucStartTime.Date;
        t.End_date = ucEndDate.Date;
        t.End_time = ucEndTime.Date;
        t.Text = txtDetail.Text;
        ProjectTaskBLL.UpdateProjectTask(t);
    }
}
