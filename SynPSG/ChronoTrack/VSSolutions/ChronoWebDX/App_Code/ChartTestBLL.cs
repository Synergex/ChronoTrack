using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.ComponentModel;

[System.ComponentModel.DataObject]
public class ChartTestBLL : DataSet
{
    //Constructor
    public ChartTestBLL() : base()
    {
        //Define the structure of the SalesHistory table and add it to our tables collection
        DataTable dt = new DataTable("SalesHistory");
        dt.Columns.Add("Month", typeof(string));
        dt.Columns.Add("LastYearSales", typeof(Double));
        dt.Columns.Add("CurrentYearSales", typeof(Double));
        Tables.Add(dt);
    }

    #region Disable Serialization for Tables and Relations
    
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataTableCollection Tables
    {
        get { return base.Tables; }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new DataRelationCollection Relations
    {
        get { return base.Relations; }
    }

    #endregion Disable Serialization for Tables and Relations

    [System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, true)]
    public ChartTestBLL GetChartData()
    {
        //Return sample data!
        ChartTestBLL ds = new ChartTestBLL();
        DataTable dt = ds.Tables["SalesHistory"];
        System.Random rnd = new System.Random();
        dt.Rows.Add(new object[] { "Jan", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });
        dt.Rows.Add(new object[] { "Feb", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });
        dt.Rows.Add(new object[] { "Mar", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });
        dt.Rows.Add(new object[] { "Apr", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });
        dt.Rows.Add(new object[] { "May", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });
        dt.Rows.Add(new object[] { "Jun", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });
        dt.Rows.Add(new object[] { "Jul", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });
        dt.Rows.Add(new object[] { "Aug", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });
        dt.Rows.Add(new object[] { "Sep", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });
        dt.Rows.Add(new object[] { "Oct", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });
        dt.Rows.Add(new object[] { "Nov", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });
        dt.Rows.Add(new object[] { "Dec", (rnd.NextDouble() * 100), (rnd.NextDouble() * 100) });

        return ds;
    }

}
