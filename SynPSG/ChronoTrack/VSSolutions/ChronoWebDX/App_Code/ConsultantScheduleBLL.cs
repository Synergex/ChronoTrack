/******************************************************************************
 *
 * Author:      Steve Ives
 *
 * Company:     Synergex Professional Services Group
 *
 * Created:     01/23/2009 at 15:36
 *
 ******************************************************************************
 *
 * This class is the business object for the Consultant_scheduleDT class. It is
 * used by the ObjectDataSource controls on forms.
 *
 * This code is supplied as seen and without warranty or support, and is used
 * at your own risk. Neither the author or Synergex accept any responsability
 * for any loss or damage which may result from the use of this code. This text
 * must remain unaltered in this file at all times. Possession or use of this
 * code, or any modified version of this code, indicates your acceptance of
 * these conditions.
 *
 ******************************************************************************
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using ChronoTrack;

public enum AppointmentStatus
{
    Free = 0,
    Tentative = 1,
    Busy = 2,
    OutOfOffice = 3
}

public enum AppointmentType
{
    None = 0,
    Important = 1,
    Business = 2,
    Personal = 3,
    Vacation = 4,
    MustAttend = 5,
    TravelRequired = 6,
    NeedsPreparation = 7,
    Birthday = 8,
    Anniversary = 9,
    PhoneCall = 10
}

[DataObject]
public class ConsultantScheduleBLL : DataSet
{
    //Constructor
    public ConsultantScheduleBLL() : base()
    {
        //Define the structure of the Appointments table and add it to our tables collection
        DataTable dt = new DataTable("Appointment");
        dt.Columns.Add("Id", typeof(int));
        dt.Columns.Add("ResourceId", typeof(string));
        dt.Columns.Add("StartTime", typeof(DateTime));
        dt.Columns.Add("EndTime", typeof(DateTime));
        dt.Columns.Add("Subject", typeof(string));
        dt.Columns.Add("Description", typeof(string));
        dt.Columns.Add("Location", typeof(string));
        dt.Columns.Add("Status", typeof(int));
        dt.Columns.Add("AppointmentType", typeof(int));
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

    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public ConsultantScheduleBLL GetConsultantSchedule()
    {
        //Get the consultant schedule data from the server
        ArrayList al = new ArrayList();
        try
        {
            SynUtils.Server.GetConsultantSchedule(SynUtils.UserToken, ref al);
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "ConsultantScheduleBLL", "GetConsultantSchedule");
        }

        /*
         * Need to iterate through every row in the returned table and concatenate
         * the Start_date and Start_time columns, and also the End_date and End_time
         * columns.  This is because the ASPxScheduler control expects a DateTime
         * value containing both, and Synergy doesn't have the concept of a DateTime
         * field, we just have Date and Time as seperate values.
         */

        ConsultantScheduleBLL ds = new ConsultantScheduleBLL();
        DataTable dt = ds.Tables["Appointment"];

        foreach (Consultant_schedule apt in al)
            dt.Rows.Add(new object[] { apt.Id, apt.Consultant_id,
                SynUtils.MakeDateTime(apt.Start_date,apt.Start_time), 
                SynUtils.MakeDateTime(apt.End_date,apt.End_time), 
                apt.Subject, apt.Description, apt.Location, apt.Status, apt.Appointment_type });

        return ds;
    }


}

