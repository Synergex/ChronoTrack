/******************************************************************************
 *
 * Author:      Steve Ives
 *
 * Company:     Synergex Professional Services Group
 *
 * Created:     01/28/2009 at 14:14
 *
 ******************************************************************************
 *
 * This class is the business object for the ProjectDT class. It is used
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
public static class ProjectBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public static ProjectDT GetAllProjects()
    {
        //Create a data table to return
        ProjectDT projectDT = new ProjectDT();

        //Get the table from the server
        try
        {
            SynUtils.Server.GetProjectTable(SynUtils.UserToken, ref projectDT, "", new System.DateTime(), "");
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "ProjectBLL", "GetProjectTable");
        }

        return projectDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static ProjectDT GetCustomerProjects(string customerId)
    {
        //Create a data table to return
        ProjectDT projectDT = new ProjectDT();

        //Make sure we have a customer ID
        if ((customerId != null) && (customerId != ""))
        {
            //Get the table from the server
            bool methodOK = false;
            try
            {
                methodOK = SynUtils.Server.GetProjectTable(SynUtils.UserToken, ref projectDT, customerId, new System.DateTime(), "");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectBLL", "GetProjectTable");
            }
        }
        return projectDT;
    }


    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Project_summaryDT GetConsultantProjects(string consultantId)
    {
        //Create a data table to return
        Project_summaryDT projectDT = new Project_summaryDT();

        //Make sure we have a consultant ID
        if ((consultantId != null) && (consultantId != ""))
        {
            //Get the table from the server
            string errorText = "";
            try
            {
                if (!SynUtils.Server.GetConsultantProjects(SynUtils.UserToken, consultantId, ref projectDT, ref errorText))
                    SynUtils.MethodFailure(errorText, "ProjectBLL", "GetConsultantProjects");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectBLL", "GetConsultantProjects");
            }
        }

        return projectDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Project_summaryDT GetConsultantProjectSummary(string consultantId)
    {
        //Create a data table to return
        Project_summaryDT projectDT = new Project_summaryDT();

        //Make sure we have a consultant ID
        if ((consultantId != null) && (consultantId != ""))
        {
            //Get the table from the server
            bool methodOK = false;
            string errorText = "";
            try
            {
                methodOK = SynUtils.Server.GetConsultantProjects(SynUtils.UserToken, consultantId, ref projectDT, ref errorText);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectBLL", "GetConsultantProjects");
            }
        }

        return projectDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Project GetProject(int ProjectId)
    {
        Project project = new Project();

        //Make sure we have any required parameters
        if (ProjectId != 0)
        {
            try
            {
                SynUtils.Server.GetProject(SynUtils.UserToken, ProjectId, ref project);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectBLL", "GetProject");
            }
        }

        return project;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public static bool AddProject(Project project)
    {
        bool recordCreated = false;

        //Make sure we have been given a record to create
        if (project != null)
        {
            //Create the record on the server
            try
            {
                recordCreated = SynUtils.Server.CreateProject(SynUtils.UserToken, ref project);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectBLL", "CreateProject");
            }
        }

        return recordCreated;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateProject(Project project)
    {
        bool recordUpdated = false;

        //Make sure we have been given a record to update
		if (project != null)
        {
			string newGrfa = "";
		
            //Update the record on the server
            try
            {
                recordUpdated = SynUtils.Server.UpdateProject(SynUtils.UserToken, project, ref newGrfa);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectBLL", "UpdateProject");
            }

            if (recordUpdated)
                project.Synergygrfa = newGrfa;
        }

        return recordUpdated;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteProject(Project project)
    {
        bool recordDeleted = false;

        //Make sure we have been given a record to delete
        if (project != null)
        {
            //Delete the record on the server
            try
            {
                recordDeleted = SynUtils.Server.DeleteProject(SynUtils.UserToken, project);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectBLL", "DeleteProject");
            }
        }

        return recordDeleted;
    }

    public static void GetProjectDetails(int projectId, ref Project_summary project,ref UserDT consultants,ref Project_consultantDT rates,ref Project_task_summaryDT tasks,ref Project_activity_summaryDT activities,ref Project_expense_summaryDT expenses,ref Project_note_summaryDT notes, ref string errorText)
    {
        project = new Project_summary();
        consultants = new UserDT();
        tasks = new Project_task_summaryDT();
        notes = new Project_note_summaryDT();
        expenses = new ChronoTrack.Project_expense_summaryDT();
        rates = new Project_consultantDT();
        activities = new Project_activity_summaryDT();

        try
        {
            if (!SynUtils.Server.GetProjectDetails(SynUtils.UserToken, projectId, ref project, ref consultants, ref rates, ref tasks, ref activities, ref expenses, ref notes, ref errorText))
                SynUtils.MethodFailure(errorText, "ProjectBLL", "GetProjectDetails");
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "ProjectBLL", "GetProjectDetails");
        }
    }

    public static void AddConsultant(int projectId, Consultant_fee_summaryDT fees)
    {
        //Add the consultant fees to the project
        string errorText = "";
        try
        {
            if (!SynUtils.Server.ProjectAddConsultant(SynUtils.UserToken, projectId, fees, ref errorText))
                SynUtils.MethodFailure(errorText, "ProjectBLL/AddConsultant", "ProjectAddConsultant");
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "ProjectBLL/AddConsultant", "ProjectAddConsultant");
        }
    }

    public static void RemoveConsultantRates(int projectId, string consultantId)
    {
        try
        {
            string errorText = "";
            if (!(SynUtils.Server.ProjectRemoveConsultant(SynUtils.UserToken, projectId, consultantId, ref errorText)))
                SynUtils.MethodFailure(errorText, "ProjectBLL/RemoveConsultantRates", "ProjectRemoveConsultant");
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "ProjectBLL/RemoveConsultantRates", "ProjectRemoveConsultant");
        }
    }

}
