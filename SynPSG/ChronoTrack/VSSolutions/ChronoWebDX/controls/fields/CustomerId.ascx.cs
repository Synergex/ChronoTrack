using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_fields_CustomerId : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string Text
    {
        get { return textBox.Text; }
        set { textBox.Text = value; }
    }

    public bool Enabled
    {
        get { return textBox.Enabled; }
        set { textBox.Enabled = value; }
    }

    public bool ReadOnly
    {
        get { return textBox.ReadOnly; }
        set { textBox.ReadOnly = value; }
    }

    public bool Required
    {
        get { return textBox.ValidationSettings.RequiredField.IsRequired; }
        set { textBox.ValidationSettings.RequiredField.IsRequired = value; }
    }

    public string RequiredErrorText
    {
        get { return textBox.ValidationSettings.RequiredField.ErrorText; }
        set { textBox.ValidationSettings.RequiredField.ErrorText = value; }
    }

    protected void textBox_ValueChanged(object sender, EventArgs e)
    {
        textBox.Text = textBox.Text.ToUpper();
    }
}
