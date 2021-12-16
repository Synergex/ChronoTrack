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
 * This class is the business object for the Project_attachmentDT class. It is used
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
public class ProjectAttachmentBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public Project_attachmentDT GetAllProjectAttachments(int ProjectId,int TaskId)
    {
        Project_attachmentDT project_attachmentDT = new Project_attachmentDT();

        //Make sure that we have any required parameters
        if ((ProjectId != 0) && (TaskId != 0))
        {
            try
            {
                SynUtils.Server.GetProjectAttachmentTable(SynUtils.UserToken, ProjectId, TaskId, ref project_attachmentDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectAttachmentBLL", "GetProjectAttachmentTable");
            }
        }

        return project_attachmentDT;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, false)]
    public Project_attachment GetProjectAttachment(int ProjectId,int TaskId,int AttachmentId)
    {
        Project_attachment project_attachment = new Project_attachment();

        //Make sure that we have any required parameters
        if ((ProjectId != 0) && (TaskId != 0) && (AttachmentId != 0))
        {
            try
            {
                SynUtils.Server.GetAttachment(SynUtils.UserToken, ProjectId, TaskId, AttachmentId, ref project_attachment);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectAttachmentBLL", "GetAttachment");
            }
        }

        return project_attachment;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public bool AddProjectAttachment(Project_attachment project_attachment)
    {
        bool returnStatus = false;

        //Make sure we have got a record to add
        if (project_attachment != null)
        {
            //Create the record on the server
            try
            {
                returnStatus = SynUtils.Server.CreateAttachment(SynUtils.UserToken, ref project_attachment);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectAttachmentBLL", "CreateAttachment");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public bool UpdateProjectAttachment(Project_attachment project_attachment)
    {
        bool returnStatus = false;
		string newGrfa = "";

        //Make sure we have got a record to update
        if (project_attachment != null)
        {
            try
            {
                returnStatus = SynUtils.Server.UpdateAttachment(SynUtils.UserToken, project_attachment, ref newGrfa);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectAttachmentBLL", "UpdateAttachment");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public bool DeleteProjectAttachment(Project_attachment project_attachment)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (project_attachment != null)
        {
            try
            {
                returnStatus = SynUtils.Server.DeleteAttachment(SynUtils.UserToken, project_attachment);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectAttachmentBLL", "DeleteAttachment");
            }
        }

        return returnStatus;
    }
}
