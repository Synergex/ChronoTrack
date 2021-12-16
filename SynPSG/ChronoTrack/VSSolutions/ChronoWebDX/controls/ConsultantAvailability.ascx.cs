using System;
using System.Collections.Generic;
using DevExpress.XtraScheduler;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class controls_ConsultantAvailability : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Start the scheduler display on the current date
        schedulerControl.Start = DateTime.Now;

        if (!IsPostBack)
        {
            changeViewByState();
        }
    }
    
    protected void rblGroupBy_SelectedIndexChanged(object sender, EventArgs e)
    {
        changeViewByValue();
    }

    protected void schedulerControl_ActiveViewChanged(object sender, EventArgs e)
    {
        changeViewByState();
    }



    private void changeViewByState()
    {
        switch (schedulerControl.ActiveViewType)
        {
            case SchedulerViewType.Day:
                rblGroupBy.Enabled = true;
                break;
            case SchedulerViewType.WorkWeek:
                rblGroupBy.Enabled = true;
                break;
            case SchedulerViewType.Week:
                rblGroupBy.Enabled = true;
                break;
            case SchedulerViewType.Month:
                rblGroupBy.Enabled = true;
                break;
            case SchedulerViewType.Timeline:
                rblGroupBy.Enabled = false;
                break;
        }
    }
    private void changeViewByValue()
    {
        switch (rblGroupBy.Value.ToString())
        {
            case "R":
                schedulerControl.GroupType = SchedulerGroupType.Resource;
                break;
            case "D":
                schedulerControl.GroupType = SchedulerGroupType.Date;
                break;
            case "N":
                schedulerControl.GroupType = SchedulerGroupType.None;
                break;
        }
    }
}
