using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_fields_TimeField : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public DateTime Date
    {
        get { return dateField.Date; }
        set { dateField.Date = value; }
    }

    public bool Enabled
    {
        get { return dateField.Enabled; }
        set { dateField.Enabled = value; }
    }

    public bool ReadOnly
    {
        get { return dateField.ReadOnly; }
        set { dateField.ReadOnly = value; }
    }

    public bool Required
    {
        get { return dateField.ValidationSettings.RequiredField.IsRequired; }
        set { dateField.ValidationSettings.RequiredField.IsRequired = value; }
    }

    public string RequiredErrorText
    {
        get { return dateField.ValidationSettings.RequiredField.ErrorText; }
        set { dateField.ValidationSettings.RequiredField.ErrorText = value; }
    }

    public event EventHandler DateChanged;

    protected void dateField_DateChanged(object sender, EventArgs e)
    {
        //If the host has bound an event handler then fire it
        if (DateChanged != null)
            DateChanged(this, e);

    }
}
