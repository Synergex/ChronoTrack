using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_selectors_ContactCombo : System.Web.UI.UserControl
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

    //CustomerId
    public string CustomerId
    {
        get
        {
            return customerId.Value;
        }
        set
        {
            DoBinding(value);
        }
    }

    public void DoBinding(string CustomerId)
    {
        customerId.Value = CustomerId;
        comboBox.DataSource = dataSource;
        comboBox.DataBind();
    }

    //Enable the control if it contains items
    public void EnableIfItems()
    {
        comboBox.Enabled = (comboBox.Items.Count > 0);
    }

    //Enable the control and select the first item if it contains items
    public void SelectFirstIfItems()
    {
        if (comboBox.Items.Count > 0)
        {
            comboBox.Enabled = true;
            comboBox.SelectedIndex = 0;
        }
    }

    //Current Value
    public int Value
    {
        get
        {
            if (comboBox != null)
                return (int)comboBox.Value;
            else
                return 0;
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
