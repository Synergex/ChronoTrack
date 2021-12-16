/******************************************************************************
 *
 * Author:      Steve Ives
 *
 * Company:     Synergex Professional Services Group
 *
 * Created:     01/23/2009 at 15:36
 *
 ******************************************************************************
 *
 * This class is the business object for the Project_taskDT class. It is used
 * by the ObjectDataSource controls on forms.
 *
 * This code is supplied as seen and without warranty or support, and is used
 * at your own risk. Neither the author or Synergex accept any responsability
 * for any loss or damage which may result from the use of this code. This text
 * must remain unaltered in this file at all times. Possession or use of this
 * code, or any modified version of this code, indicates your acceptance of
 * these conditions.
 *
 ******************************************************************************
 */
using System;
using System.ComponentModel;
using ChronoTrack;

[DataObject]
public static class ProjectTaskBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public static Project_taskDT GetProjectTasks(int ProjectId)
    {
        Project_taskDT results = new Project_taskDT();

        //Make sure that we have any required parameters
        if (ProjectId != 0)
        {
            try
            {
                if (!SynUtils.Server.GetProjectTaskTable(SynUtils.UserToken, ProjectId, ref results))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectTaskBLL/GetProjectTasks", "GetProjectTaskTable");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectTaskBLL/GetProjectTasks", "GetProjectTaskTable");
            }
        }

        return results;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Project_task_summaryDT GetProjectTasksSummary(int ProjectId)
    {
        Project_task_summaryDT results = new Project_task_summaryDT();

        //Make sure that we have any required parameters
        if (ProjectId != 0)
        {
            string errorText = "";
            try
            {
                if (!SynUtils.Server.GetProjectTasksSummary(SynUtils.UserToken, ProjectId, ref results, ref errorText))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectTaskBLL/GetProjectTasksSummary", "GetProjectTasksSummary");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectTaskBLL/GetProjectTasksSummary", "GetProjectTasksSummary");
            }
        }

        return results;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Project_task GetTask(int ProjectId, int TaskId)
    {
        Project_task project_task = new Project_task();

        //Make sure that we have any required parameters
        if ((ProjectId != 0) && (TaskId != 0))
        {
            try
            {
                if (!SynUtils.Server.GetTask(SynUtils.UserToken, ProjectId, TaskId, ref project_task))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectTaskBLL/GetTask", "GetTask");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectTaskBLL/GetTask", "GetTask");
            }
        }

        return project_task;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public static bool AddProjectTask(Project_task project_task)
    {
        bool returnStatus = false;

        //Make sure we have got a record to add
        if (project_task != null)
        {
            //Create the record on the server
            try
            {
                if (!(returnStatus = SynUtils.Server.CreateTask(SynUtils.UserToken, ref project_task)))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectTaskBLL/AddProjectTask", "CreateProjectTaskRecord");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectTaskBLL/AddProjectTask", "CreateProjectTaskRecord");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateProjectTask(Project_task project_task)
    {
        bool returnStatus = false;
		string newGrfa = "";

        //Make sure we have got a record to update
        if (project_task != null)
        {
            try
            {
                if (!(returnStatus = SynUtils.Server.UpdateTask(SynUtils.UserToken, project_task, ref newGrfa)))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectTaskBLL/UpdateProjectTask", "UpdateTask");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectTaskBLL/UpdateProjectTask", "UpdateTask");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteProjectTask(Project_task project_task)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (project_task != null)
        {
            try
            {
                if (!(returnStatus = SynUtils.Server.DeleteTask(SynUtils.UserToken, project_task)))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectTaskBLL/DeleteProjectTask", "DeleteTask");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectTaskBLL/DeleteProjectTask", "DeleteTask");
            }
        }

        return returnStatus;
    }
}
