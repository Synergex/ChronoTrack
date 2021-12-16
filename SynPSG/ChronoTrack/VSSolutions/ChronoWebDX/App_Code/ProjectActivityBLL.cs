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
 * This class is the business object for the Project_activityDT class. It is used
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
public static class ProjectActivityBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public static Project_activityDT GetAllProjectActivitys(int ProjectId,int TaskId)
    {
        Project_activityDT project_activityDT = new Project_activityDT();

        //Make sure that we have any required parameters
        if ((ProjectId != 0) && (TaskId != 0))
        {
            try
            {
                SynUtils.Server.GetProjectActivityTable(SynUtils.UserToken, ProjectId, TaskId, ref project_activityDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectActivityBLL", "GetProjectActivityTable");
            }
        }

        return project_activityDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Project_activity_summaryDT GetProjectActivitiesSummary(int ProjectId)
    {
        Project_activity_summaryDT results = new Project_activity_summaryDT();

        //Make sure that we have any required parameters
        if (ProjectId!=0)
        {
            string errorText = "";
            try
            {
                if (!SynUtils.Server.GetProjectActivitiesSummary(SynUtils.UserToken,ProjectId, ref results, ref errorText))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectActivityBLL/GetProjectActivitiesSummary", "GetProjectActivitiesSummary");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectActivityBLL/GetProjectActivitiesSummary", "GetProjectActivitiesSummary");
            }
        }

        return results;
    }
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Project_activity GetProjectActivity(int ProjectId,int TaskId,int ActivityId)
    {
        Project_activity project_activity = new Project_activity();

        //Make sure that we have any required parameters
        if ((ProjectId != 0) && (TaskId != 0) && (ActivityId != 0))
        {
            try
            {
                SynUtils.Server.GetActivity(SynUtils.UserToken, ProjectId, TaskId, ActivityId, ref project_activity);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectActivityBLL", "GetActivity");
            }
        }

        return project_activity;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public static bool AddProjectActivity(Project_activity project_activity)
    {
        bool returnStatus = false;

        //Make sure we have got a record to add
        if (project_activity != null)
        {
            //Create the record on the server
            try
            {
                returnStatus = SynUtils.Server.CreateActivity(SynUtils.UserToken, ref project_activity);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectActivityBLL", "CreateActivity");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateProjectActivity(Project_activity project_activity)
    {
        bool returnStatus = false;
		string newGrfa = "";

        //Make sure we have got a record to update
        if (project_activity != null)
        {
            try
            {
                returnStatus = SynUtils.Server.UpdateActivity(SynUtils.UserToken, project_activity, ref newGrfa);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectActivityBLL", "UpdateActivity");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteProjectActivity(Project_activity project_activity)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (project_activity != null)
        {
            try
            {
                returnStatus = SynUtils.Server.DeleteActivity(SynUtils.UserToken, project_activity);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectActivityBLL", "DeleteActivity");
            }
        }

        return returnStatus;
    }
}
