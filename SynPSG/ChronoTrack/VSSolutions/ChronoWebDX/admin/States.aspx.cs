using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;
using DevExpress.Web.Data;

public partial class admin_States : ThemedPage
{
    private string validationErrorText;

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        grid.AddNewRow();
    }

    protected void grid_BeforeGetCallbackResult(object sender, EventArgs e)
    {
        //Get a handle on the Synergy primary key column
        GridViewDataColumn column = (GridViewDataColumn)grid.Columns["Code"];
        //If editing an existing row make sure the user can't edit the column
        if (grid.IsEditing && !grid.IsNewRowEditing)
            column.ReadOnly = true;
        else
            column.ReadOnly = false;
    }

    protected void grid_ParseValue(object sender, ASPxParseValueEventArgs e)
    {
        if (e.FieldName == "Code")
        {
            if ((e.Value == null) || (e.Value.ToString().Length != 2))
                validationErrorText += "State code must be 2 characters. ";
            else
                e.Value = e.Value.ToString().ToUpper();
        }

        if (e.FieldName == "Name")
        {
            if (e.Value == null)
                validationErrorText += "State name is required. ";
        }
    }

    protected void grid_RowValidating(object sender, ASPxDataValidationEventArgs e)
    {
        e.RowError = this.validationErrorText;
    }

    protected void grid_RowUpdating(object sender, ASPxDataUpdatingEventArgs e)
    {
        //Propagate data from hidden fields
        e.NewValues["Replication_key"] = (sender as ASPxGridView).GetRowValuesByKeyValue(e.Keys[0], new string[] { "Replication_key" });
    }

}
