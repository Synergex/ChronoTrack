using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_selectors_ProjectStatus : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public int Value
    {
        get
        {
            return Convert.ToInt32(cboStatus.Value);
        }
        set
        {
            cboStatus.Value = value;
        }
    }

    public bool Enabled
    {
        get
        {
            return cboStatus.Enabled;
        }
        set
        {
            cboStatus.Enabled = value;
        }
    }

    public event EventHandler SelectedIndexChanged;

    protected void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        //If the host has bound an event handler then fire it
        if (SelectedIndexChanged != null)
            SelectedIndexChanged(this, e);
    }
}
