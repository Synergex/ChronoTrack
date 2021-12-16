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
 * This class is the business object for the Project_consultantDT class. It is used
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
public static class ProjectRateBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public static Project_consultantDT GetProjectRates(int ProjectId)
    {
        Project_consultantDT project_consultantDT = new Project_consultantDT();

        //Make sure that we have any required parameters
        if (ProjectId != 0)
        {
            try
            {
                SynUtils.Server.GetProjectConsultantTable(SynUtils.UserToken, ProjectId, " ", ref project_consultantDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectRateBLL", "GetProjectConsultantTable (GetProjectRates)");
            }
        }

        return project_consultantDT;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, false)]
    public static Project_consultantDT GetProjectConsultantRates(int ProjectId, string ConsultantId)
    {
        Project_consultantDT project_consultantDT = new Project_consultantDT();

        //Make sure that we have any required parameters
        if ((ProjectId != 0) && (ConsultantId != null))
        {
            try
            {
                SynUtils.Server.GetProjectConsultantTable(SynUtils.UserToken, ProjectId, ConsultantId, ref project_consultantDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectRateBLL", "LocateProjectConsultantRecord (GetProjectConsultantRates)");
            }
        }

        return project_consultantDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Consultant_fee_summaryDT GetConsultantRates(int ProjectId, string ConsultantId)
    {
        Consultant_fee_summaryDT rates = new Consultant_fee_summaryDT();

        //Make sure that we have any required parameters
        if ((ProjectId != 0) && (ConsultantId != null))
        {
            try
            {
                string errorText = "";
                if (!SynUtils.Server.GetProjectConsultantRates(SynUtils.UserToken, ProjectId, ConsultantId, ref rates, ref errorText))
                    SynUtils.MethodFailure(errorText, "ProjectRateBLL/GetConsultantRates", "GetProjectConsultantRates");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectRateBLL/GetConsultantRates", "GetProjectConsultantRates");
            }
        }

        return rates;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
    public static bool CreateProjectRate(Project_consultant project_consultant)
    {
        bool returnStatus = false;

        //Make sure we have got a record to add
        if (project_consultant != null)
        {
            //Create the record on the server
            try
            {
                returnStatus = SynUtils.Server.CreateProjectRate(SynUtils.UserToken, ref project_consultant);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectRateBLL", "CreateProjectRate");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateProjectRate(Project_consultant project_consultant)
    {
        bool returnStatus = false;
		string newGrfa = "";

        //Make sure we have got a record to update
        if (project_consultant != null)
        {
            try
            {
                returnStatus = SynUtils.Server.UpdateProjectRate(SynUtils.UserToken, project_consultant, ref newGrfa);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectRateBLL", "UpdateProjectRate");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteProjectRate(Project_consultant project_consultant)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (project_consultant != null)
        {
            try
            {
                returnStatus = SynUtils.Server.DeleteProjectRate(SynUtils.UserToken, project_consultant);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectRateBLL", "DeleteProjectRate");
            }
        }

        return returnStatus;
    }
}
