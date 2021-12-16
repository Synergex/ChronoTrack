using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tools_ChangeTheme : ThemedPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cbSkins_DataBound(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DevExpress.Web.ASPxEditors.ListEditItem item = cbSkins.Items.FindByValue(Page.Theme);
            if (item == null)
                item = cbSkins.Items.FindByValue("Default");
            else
                cbSkins.SelectedItem = item;
        }

    }

}
