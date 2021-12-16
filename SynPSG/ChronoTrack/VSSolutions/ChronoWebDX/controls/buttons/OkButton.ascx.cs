using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

[DefaultEvent("Click")]
public partial class controls_buttons_OkButton : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [DefaultValue("OK")]
    public string Text
    {
        get { return button.Text; }
        set { button.Text = value; }
    }

    [DefaultValue(true)]
    public bool Enabled
    {
        get { return button.Enabled; }
        set { button.Enabled = value; }
    }

    protected void button_Click(object sender, EventArgs e)
    {
        //If the host has bound an event handler then fire it
        if (Click != null)
            Click(this, e);
    }

    public event EventHandler Click;

}
