using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChronoTrack;

public partial class project_ProjectNote : ThemedPage
{
    private Project_summary p;
    private Project_note n;
    private Project_note_summaryDT s;
    private int noteId;

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
                p = (Project_summary)Session["Project"];
                txtProjectId.Text = p.Project_id.ToString();
                txtCustomer.Text = p.Customer_name;
                multiView.SetActiveView(normalView);

                //Are we being asked to edit an existing note?
                if (!(Request.QueryString["NoteId"] == null))
                    loadNote();
            }
        }
        else
            p = (Project_summary)Session["Project"];

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //Go back to "My Projects"
        Response.Redirect(PreviousPageUrl.Value, true);
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (btnOk.Text == "Add Note")
            addNote();
        else
            updateNote();

        //Re-get the collection of project notes
        s = ProjectNoteBLL.GetProjectNotesSummary(p.Project_id);

        //Update the cache
        Session["ProjectNotes"] = s;

        //Go back to "My Projects"
        Response.Redirect(PreviousPageUrl.Value, true);
    }

    protected void addNote()
    {
        n = new Project_note();
        n.Project_id = p.Project_id;
        n.Description = txtSubject.Text;
        n.Text = txtDetails.Text;

        //Add the new note
        ProjectNoteBLL.AddProjectNote(n);
    }
    
    protected void loadNote()
    {
        noteId = int.Parse(Request.QueryString["NoteId"].ToString());
        n = ProjectNoteBLL.GetNote(p.Project_id, noteId);
        txtSubject.Text = n.Description;
        txtDetails.Text = n.Text;
        btnOk.Text = "Update Note";
    }

    protected void updateNote()
    {
        noteId = int.Parse(Request.QueryString["NoteId"].ToString());
        n = ProjectNoteBLL.GetNote(p.Project_id, noteId);
        n.Description = txtSubject.Text;
        n.Text = txtDetails.Text;
        ProjectNoteBLL.UpdateProjectNote(n);
    }

}
