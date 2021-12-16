/******************************************************************************
 *
 * Author:      Steve Ives
 *
 * Company:     Synergex Professional Services Group
 *
 * Created:     01/28/2009 at 14:05
 *
 ******************************************************************************
 *
 * This class is the business object for the CustomerDT class. It is used
 * by the ObjectDataSource controls on forms.
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
using System.ComponentModel;
using ChronoTrack;

[DataObject]
public class GanttViewBLL
{
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public Gantt_viewDT GetGanttViewTable()
    {
        //Create a data table to return
        Gantt_viewDT ganttViewDT = new Gantt_viewDT();

        //Get the table from the server
        SynUtils.Server.GetGanttViewTable(SynUtils.UserToken, ref ganttViewDT);

        return ganttViewDT;
    }

}
