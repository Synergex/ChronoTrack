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
 * This class is the business object for the Project_noteDT class. It is used
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
public static class ProjectNoteBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public static Project_noteDT GetProjectNotes(int ProjectId)
    {
        Project_noteDT results = new Project_noteDT();

        //Make sure that we have any required parameters
        if (ProjectId != 0)
        {
            try
            {
                if (!SynUtils.Server.GetProjectNoteTable(SynUtils.UserToken, ProjectId, ref results))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectNoteBLL/GetProjectNotes", "GetProjectNoteTable");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectNoteBLL/GetProjectNotes", "GetProjectNoteTable");
            }
        }

        return results;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select,false)]
    public static Project_note_summaryDT GetProjectNotesSummary(int ProjectId)
    {
        Project_note_summaryDT results = new Project_note_summaryDT();

        //Make sure that we have any required parameters
        if (ProjectId != 0)
        {
            string errorText = "";
            try
            {
                if (!SynUtils.Server.GetProjectNotesSummary(SynUtils.UserToken, ProjectId, ref results, ref errorText))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectNoteBLL/GetProjectNotesSummary", "GetProjectNotesSummary");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectNoteBLL/GetProjectNotesSummary", "GetProjectNotesSummary");
            }
        }

        return results;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Project_note GetNote(int ProjectId, int NoteId)
    {
        Project_note project_note = new Project_note();

        //Make sure that we have any required parameters
        if ((ProjectId != 0) && (NoteId != 0))
        {
            try
            {
                if (!SynUtils.Server.GetNote(SynUtils.UserToken, ProjectId, NoteId, ref project_note))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectNoteBLL/GetNote", "GetNote");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectNoteBLL/GetNote", "GetNote");
            }
        }

        return project_note;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public static bool AddProjectNote(Project_note project_note)
    {
        bool returnStatus = false;

        //Make sure we have got a record to add
        if (project_note != null)
        {
            //Create the record on the server
            try
            {
                if (!(returnStatus = SynUtils.Server.CreateNote(SynUtils.UserToken, ref project_note)))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectNoteBLL/AddProjectNote", "CreateNote");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectNoteBLL/AddProjectNote", "CreateNote");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateProjectNote(Project_note project_note)
    {
        bool returnStatus = false;
		string newGrfa = "";

        //Make sure we have got a record to update
        if (project_note != null)
        {
            try
            {
                if (!(returnStatus = SynUtils.Server.UpdateNote(SynUtils.UserToken, project_note, ref newGrfa)))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectNoteBLL/UpdateProjectNote", "UpdateNote");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectNoteBLL/UpdateProjectNote", "UpdateNote");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteNote(Project_note project_note)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (project_note != null)
        {
            try
            {
                if (!(returnStatus = SynUtils.Server.DeleteNote(SynUtils.UserToken, project_note)))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectNoteBLL/DeleteNote", "DeleteNote");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectNoteBLL/DeleteNote", "DeleteNote");
            }
        }

        return returnStatus;
    }
}
