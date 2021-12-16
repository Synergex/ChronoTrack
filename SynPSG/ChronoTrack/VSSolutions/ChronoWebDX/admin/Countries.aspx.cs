using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;

public partial class admin_Countries : ThemedPage
{
    private string validationErrorText;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnNew_Click(object sender, EventArgs e)
    {
        grid.AddNewRow();
    }

    protected void grid_ParseValue(object sender, DevExpress.Web.Data.ASPxParseValueEventArgs e)
    {
        if (e.FieldName == "Country_id")
        {
            if ((e.Value == null) || (e.Value.ToString().Length != 2))
                validationErrorText += "Country code must be 2 characters. ";
            else
                e.Value = e.Value.ToString().ToUpper();
        }

        if (e.FieldName == "Country_name")
        {
            if (e.Value == null)
                validationErrorText += "Country name is required. ";
        }

        if (e.FieldName == "Dialing_code")
        {
            if (e.Value != null)
            {
                int value;
                if ((!int.TryParse(e.Value.ToString(), out value)) || (value < 1))
                    validationErrorText += "Dialing code must be a positive number. ";
            }
        }

        if (e.FieldName == "Currency_code")
        {
            if (e.Value != null)
            {
                if (e.Value.ToString().Length != 2)
                    validationErrorText += "Currency code must be 2 characters. ";
                else
                    e.Value = e.Value.ToString().ToUpper();
            }
        }
    }

    protected void grid_RowValidating(object sender, DevExpress.Web.Data.ASPxDataValidationEventArgs e)
    {
        e.RowError = this.validationErrorText;
    }

    protected void grid_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
    {
        //Propagate data from hidden fields
        e.NewValues["Replication_key"] = (sender as ASPxGridView).GetRowValuesByKeyValue(e.Keys[0], new string[] { "Replication_key" });

    }
}
