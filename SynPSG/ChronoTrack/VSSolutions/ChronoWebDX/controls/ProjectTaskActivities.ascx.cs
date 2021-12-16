using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;

public partial class controls_ProjectTaskActivities : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UserControl thisControl = (UserControl)sender;

        //Are we inside the detail row of another grid?
        if (thisControl.Parent.ToString().Equals("DevExpress.Web.ASPxGridView.GridViewDetailRowTemplateContainer"))
        {
            //Yes, get the parent grid row key value
            GridViewDetailRowTemplateContainer template = (GridViewDetailRowTemplateContainer)thisControl.Parent;
            int taskId = int.Parse(template.KeyValue.ToString());
            int projectId = int.Parse(Session["CurrentProject"].ToString());
            DoBinding(projectId,taskId);
        }
    }

    public void DoBinding(int projectId, int taskId)
    {
        Session["CurrentProjectTask"] = taskId;
        grid.DataSource = ds;
        grid.DataBind();
    }
}
