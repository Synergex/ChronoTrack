using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChronoTrack;
using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxGridView;

public partial class project_MyProjects : ThemedPage
{

    private int projectId;
    private int noteId;
    private int expenseId;
    private int taskId;
    string errorText = "";
    string noteDetail = "";
    string taskDetail = "";
    private Project_summaryDT myprojects;
    private Project_summary project;
    private Project projectFull;
    private UserDT consultants;
    private Project_task_summaryDT tasks;
    private Project_note_summaryDT notes;
    private Project_expense_summaryDT expenses;
    private Project_consultantDT rates;
    private Project_activity_summaryDT activities;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the current users projects
        if (Session["MyProjects"] == null)
        {
            myprojects = ProjectBLL.GetConsultantProjects(SynUtils.UserName);
            Session.Add("MyProjects", myprojects);
        }
        else
            myprojects = (Project_summaryDT)Session["MyProjects"];

        //Load the projects into the project master user control
        ucProjectMaster.ConsultantProjects = myprojects;

        //If we have a cache then restore it
        if (!IsPostBack && Session["LastProject"] != null)
        {
            restoreCache();
            displayProject();
        }

        if (IsPostBack && Session["LastProject"] != null)
        {
            //Need to restore bindings ONLY!
            restoreCache();
            createBindings();
        }
    }

    protected void ucProjectMaster_SelectedProjectChanged(object sender, EventArgs e)
    {
        //Lose the previous project
        removeCache();

        //Load the newly selected project
        projectId = ucProjectMaster.SelectedProjectId;
        loadProject();
        displayProject();
    }

    private void createCache()
    {
        Session["LastProject"] = projectId;
        Session["Project"] = project;
        Session["ProjectFull"] = projectFull;
        Session["ProjectConsultants"] = consultants;
        Session["ProjectTasks"] = tasks;
        Session["ProjectNotes"] = notes;
        Session["ProjectExpenses"] = expenses;
        Session["ProjectActivities"] = activities;
        Session["ProjectRates"] = rates;
    }

    private void restoreCache()
    {
        projectId = int.Parse(Session["LastProject"].ToString());
        project = (Project_summary)Session["Project"];
        projectFull = (Project)Session["ProjectFull"];
        consultants = (UserDT)Session["ProjectConsultants"];
        tasks = (Project_task_summaryDT)Session["ProjectTasks"];
        notes = (Project_note_summaryDT)Session["ProjectNotes"];
        expenses = (Project_expense_summaryDT)Session["ProjectExpenses"];
        activities = (Project_activity_summaryDT)Session["ProjectActivities"];
        rates = (Project_consultantDT)Session["ProjectRates"];
    }

    private void removeCache()
    {
        Session.Remove("LastProject");
        Session.Remove("Project");
        Session.Remove("ProjectFull");
        Session.Remove("ProjectConsultants");
        Session.Remove("ProjectTasks");
        Session.Remove("ProjectNotes");
        Session.Remove("ProjectExpenses");
        Session.Remove("ProjectActivities");
        Session.Remove("ProjectRates");
    }

    private void createBindings()
    {
        grdConsultants.DataSource = consultants;
        grdTasks.DataSource = tasks;
        grdNotes.DataSource = notes;
        grdExpenses.DataSource = expenses;
    }

    private void displayProject()
    {
        ucProjectMaster.ProjectSummary = project;

        createBindings();

        grdConsultants.DataBind();
        grdTasks.DataBind();
        grdNotes.DataBind();
        grdExpenses.DataBind();

        pnlProjectDetail.Visible = true;
    }

    private void loadProject()
    {
        ProjectBLL.GetProjectDetails(projectId, ref project, ref consultants, ref rates, ref tasks, ref activities, ref expenses, ref notes, ref errorText);
        projectFull = ProjectBLL.GetProject(projectId);
        createCache();
        displayProject();
    }

    protected void gridCustomButtonCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs e)
    {
        switch (e.ButtonID)
        {
            case "DeleteConsultant":
                /*
                 * The user clicked the "Delete" button next to a project consultant.  This means that
                 * we need to remove any rate records for that consultant from the project records.
                 */
                string consultantId = grdConsultants.GetRowValues(e.VisibleIndex, "User_id").ToString();
                string consultantName = grdConsultants.GetRowValues(e.VisibleIndex, "Friendly_name").ToString();
                if (consultantName != project.Lead_consultant)
                {
                    ProjectBLL.RemoveConsultantRates(project.Project_id, consultantId);
                    consultants = UserBLL.GetProjectConsultants(project.Project_id);
                    grdConsultants.DataSource = consultants;
                    grdConsultants.DataBind();
                    Session["ProjectConsultants"] = consultants;
                }
                break;

            case "EditNote":
                noteId = int.Parse(grdNotes.GetRowValues(e.VisibleIndex, "Note_id").ToString());
                Response.Redirect("~/project/ProjectNote.aspx?NoteId=" + noteId, true);
                break;

            case "DeleteNote":

                //Get the ID of the note to be deleted
                noteId = int.Parse(grdNotes.GetRowValues(e.VisibleIndex, "Note_id").ToString());
                
                //Retrieve the note record
                Project_note n = ProjectNoteBLL.GetNote(projectId, noteId);
                
                //Delete the note record
                ProjectNoteBLL.DeleteNote(n);

                //Delete the note record from cache
                foreach (DataRow r in notes.Rows)
                {
                    if (r.Field<int>("Note_id") == noteId)
                    {
                        r.Delete();
                        r.AcceptChanges();
                        break;
                    }
                }

                //Rebind the grid
                grdNotes.DataBind();
                break;

            case "EditTask":
                taskId = int.Parse(grdTasks.GetRowValues(e.VisibleIndex, "Task_id").ToString());
                Response.Redirect("~/project/ProjectTask.aspx?TaskId=" + taskId, true);
                break;

            case "DeleteTask":

                //Get the ID of the task to delete
                taskId = int.Parse(grdTasks.GetRowValues(e.VisibleIndex, "Task_id").ToString());

                //Retrieve the task record
                Project_task pt = ProjectTaskBLL.GetTask(projectId, taskId);

                //Delete the task record
                ProjectTaskBLL.DeleteProjectTask(pt);

                //Delete the task record from cache
                foreach (DataRow r in tasks.Rows)
                {
                    if (r.Field<int>("Task_id") == taskId)
                    {
                        r.Delete();
                        r.AcceptChanges();
                        break;
                    }
                }

                //Rebind the grid
                grdTasks.DataBind();
                break;

            case "EditExpense":
                expenseId = int.Parse(grdExpenses.GetRowValues(e.VisibleIndex, "Expense_id").ToString());
                Response.Redirect("~/project/ProjectExpense.aspx?ExpenseId=" + expenseId, true);
                break;

            case "DeleteExpense":

                //Get the ID of the expense to delete
                expenseId = int.Parse(grdExpenses.GetRowValues(e.VisibleIndex, "Expense_id").ToString());
                
                //Retrieve the expense record
                Project_expense pe = ProjectExpenseBLL.GetExpense(projectId, expenseId);
                
                //Delete the expense record
                ProjectExpenseBLL.DeleteExpense(pe);

                //Delete the note record from cache
                foreach (DataRow r in expenses.Rows)
                {
                    if (r.Field<int>("Expense_id") == expenseId)
                    {
                        r.Delete();
                        r.AcceptChanges();
                        break;
                    }
                }

                //Rebind the grid
                grdExpenses.DataBind();
                break;
        }
    }

    protected void grdFees_Init(object sender, EventArgs e)
    {
        if (project != null)
        {
            ASPxGridView grdFees = (ASPxGridView)sender;
            string consultantId = grdFees.GetMasterRowKeyValue().ToString();
            Consultant_fee_summaryDT consultantFees = ProjectRateBLL.GetConsultantRates(project.Project_id, consultantId);
            grdFees.DataSourceID = "";
            grdFees.DataSource = consultantFees;
            grdFees.DataBind();
        }
    }

    protected void grdNotes_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
    {
        if (e.Expanded)
        {
            noteId = int.Parse(grdNotes.GetRowValues(e.VisibleIndex, "Note_id").ToString());
            Project_note n = ProjectNoteBLL.GetNote(projectId, noteId);
            noteDetail = n.Text;
        }
    }

    protected void lblNoteDetail_Init(object sender, EventArgs e)
    {
        //This means a detail row in the notes grid was opened.
        //Load the note detail into the label
        ASPxLabel lblNoteDetail = (ASPxLabel)sender;
        lblNoteDetail.Text = noteDetail;
    }

    protected void grdTasks_DetailRowExpandedChanged(object sender, ASPxGridViewDetailRowEventArgs e)
    {
        if (e.Expanded)
        {
            taskId = int.Parse(grdTasks.GetRowValues(e.VisibleIndex, "Task_id").ToString());
            Project_task t = ProjectTaskBLL.GetTask(projectId, taskId);
            taskDetail = t.Text;
        }
    }
    protected void lblTaskDetail_Init(object sender, EventArgs e)
    {
        //This means a detail row in the tasks grid was opened.
        //Load the task detail into the label
        ASPxLabel lblTaskDetail = (ASPxLabel)sender;
        lblTaskDetail.Text = taskDetail;
    }

    protected void grdActivities_Init(object sender, EventArgs e)
    {
        if (project != null)
        {
            ASPxGridView grdActivities = (ASPxGridView)sender;
            int taskId = int.Parse(grdActivities.GetMasterRowKeyValue().ToString());
            Project_activityDT a = ProjectActivityBLL.GetAllProjectActivitys(project.Project_id, taskId);
            grdActivities.DataSourceID = "";
            grdActivities.DataSource = a;
            grdActivities.DataBind();
            //Save the current task ID so we can detect it later to add or modify activities
            Session["CurrentTaskId"] = taskId;
        }
    }



    protected void chkConsultantGroup_CheckedChanged(object sender, EventArgs e)
    {

        grdConsultants.Settings.ShowGroupPanel = chkConsultantGroup.Checked;
        grdConsultants.SettingsBehavior.AllowGroup = chkConsultantGroup.Checked;
    }
    protected void chkConsultantFilter_CheckedChanged(object sender, EventArgs e)
    {
        grdConsultants.Settings.ShowFilterRow = chkConsultantFilter.Checked;
    }
    protected void btnAddConsultant_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/project/ProjectConsultant.aspx", true);
    }


    protected void chkTaskGroup_CheckedChanged(object sender, EventArgs e)
    {
        grdTasks.Settings.ShowGroupPanel = chkTaskGroup.Checked;
    }
    protected void chkTaskFilter_CheckedChanged(object sender, EventArgs e)
    {
        grdTasks.Settings.ShowFilterRow = chkTaskFilter.Checked;
    }
    protected void btnAddTask_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/project/ProjectTask.aspx", true);
    }

    protected void chkNoteGroup_CheckedChanged(object sender, EventArgs e)
    {
        grdNotes.Settings.ShowGroupPanel = chkNoteGroup.Checked;
    }
    protected void chkNoteFilter_CheckedChanged(object sender, EventArgs e)
    {
        grdNotes.Settings.ShowFilterRow = chkNoteFilter.Checked;
    }
    protected void btnAddNote_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/project/ProjectNote.aspx", true);
    }

    protected void btnAddActivity_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/project/ProjectActivity.aspx", true);
    }

    protected void chkExpenseGroup_CheckedChanged(object sender, EventArgs e)
    {
        grdExpenses.Settings.ShowGroupPanel = chkExpenseGroup.Checked;
        grdExpenses.SettingsBehavior.AllowGroup = chkExpenseGroup.Checked;
        //TODO: Get this working and roll it out to the other 3
        if (chkExpenseGroup.Checked)
        {
            if (grdExpenses.GroupCount > 0)
            {
                foreach (ASPxSummaryItem g in grdExpenses.GroupSummary)
                    grdExpenses.UnGroup(grdExpenses.Columns[g.FieldName]);
            }
        }
    }
    protected void chkExpenseFilter_CheckedChanged(object sender, EventArgs e)
    {
        grdExpenses.Settings.ShowFilterRow = chkExpenseFilter.Checked;
    }
    protected void btnAddExpense_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/project/ProjectExpense.aspx", true);
    }

}
