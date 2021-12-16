using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_fields_TaskType : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //ItemCount
    public int ItemCount
    {
        get
        {
            return comboBox.Items.Count;
        }
    }

    //Current Value
    public int Value
    {
        get
        {
            return int.Parse(comboBox.Value.ToString());
        }
        set
        {
            try
            {
                comboBox.Value = value;
            }
            catch
            {
            }
        }
    }

    //Enabled
    public bool Enabled
    {
        get { return comboBox.Enabled; }
        set { comboBox.Enabled = value; }
    }

    //AutoPostBack
    public bool AutoPostBack
    {
        get { return comboBox.AutoPostBack; }
        set { comboBox.AutoPostBack = value; }
    }

    //Selected Index
    public int SelectedIndex
    {
        get { return comboBox.SelectedIndex; }
        set { comboBox.SelectedIndex = value; }
    }

    //Required field
    public bool Required
    {
        get { return comboBox.ValidationSettings.RequiredField.IsRequired; }
        set { comboBox.ValidationSettings.RequiredField.IsRequired = value; }
    }

    //Required field error message
    public string RequiredErrorText
    {
        get { return comboBox.ValidationSettings.RequiredField.ErrorText; }
        set { comboBox.ValidationSettings.RequiredField.ErrorText = value; }
    }

    public event EventHandler SelectedIndexChanged;

    protected void comboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        //If the host has bound an event handler then fire it
        if (SelectedIndexChanged != null)
            SelectedIndexChanged(this, e);
    }
}
