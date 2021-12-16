using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;

public partial class controls_ProjectTasks : System.Web.UI.UserControl
{
    protected void Page_Init(object sender, EventArgs e)
    {
        UserControl thisControl = (UserControl)sender;

        //Are we inside the detail row of another grid?
        if (thisControl.Parent.ToString().Equals("DevExpress.Web.ASPxGridView.GridViewDetailRowTemplateContainer"))
        {
            //Yes, get the parent grid row key value
            GridViewDetailRowTemplateContainer template = (GridViewDetailRowTemplateContainer)thisControl.Parent;
            int projectId = int.Parse(template.KeyValue.ToString());
            DoBinding(projectId);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    public void DoBinding(int projectId)
    {
        Session["CurrentProject"] = projectId;

        dsProject.Select();
        detailView.DataSource = dsProject;
        detailView.DataBind();
        
        grid.DataSource = dsTask;
        grid.DataBind();
    }

}
