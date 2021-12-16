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
 * This class is the business object for the StateDT class. It is used
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
using System;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.SessionState;
using ChronoTrack;

[DataObject]
public static class StateBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public static StateDT GetAllStates()
    {
        //Create a data table to return
        StateDT stateDT = new StateDT();

        //Do we have an existing cache?
        HttpSessionState Session = HttpContext.Current.Session;
        if (Session["CACHE_STATE"] != null)
            stateDT = (StateDT)Session["CACHE_STATE"];
        else
        {
            //No cache, get the table from the server
            bool methodOK = false;
            try
            {
                if (!(methodOK = SynUtils.Server.GetStateTable(SynUtils.UserToken, ref stateDT)))
                    SynUtils.MethodFailure("Method returned fail status", "StateBLL/GetAllStates", "GetStateTable");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "StateBLL/GetAllStates", "GetStateTable");
            }

			//If we got data back then cache it for next time
            if (methodOK && (stateDT.Rows.Count > 0))
                Session.Add("CACHE_STATE",stateDT);
        }

        return stateDT;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, false)]
    public static ChronoTrack.State GetState(string Code)
    {
        State state = new ChronoTrack.State();

        //Make sure we have any required parameters
        if (Code != null)
        {
            try
            {
                if (!(SynUtils.Server.GetState(SynUtils.UserToken, Code, ref state)))
                    SynUtils.MethodFailure("Method returned fail status", "StateBLL/GetState", "GetState");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "StateBLL/GetState", "GetState");
            }
        }

        return state;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public static bool AddState(State state)
    {
        bool recordCreated = false;

        //Make sure we have been given a record to create
        if (state != null)
        {
            try
            {
                //Create the record on the server
                if (!(recordCreated = SynUtils.Server.CreateState(SynUtils.UserToken, ref state)))
                    SynUtils.MethodFailure("Method returned fail status", "StateBLL/AddState", "CreateState");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "StateBLL/AddState", "CreateState");
            }

            //If the server create was successful then add the item to any cache
            HttpSessionState Session = HttpContext.Current.Session;
            if (recordCreated && (Session["CACHE_STATE"] != null))
            {
                StateDT stateDT = (StateDT)Session["CACHE_STATE"];
                stateDT.AddRow(state);
                stateDT.AcceptChanges();
            }
        }

        return recordCreated;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateState(State state)
    {
        bool recordUpdated = false;

        //Make sure we have been given a record to update
		if (state != null)
        {
            //Save the original GRFA so we can locate the updated record in cache if necessary
            string originalGrfa = state.Synergygrfa;
			string newGrfa = "";
		
            //Update the record on the server
            try
            {
                if (!(recordUpdated = SynUtils.Server.UpdateState(SynUtils.UserToken, state, ref newGrfa)))
                    SynUtils.MethodFailure("Method returned fail status", "StateBLL/UpdateState", "UpdateState");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "StateBLL/UpdateState", "UpdateState");
            }

            //If the server update was successful then update the item in any cache
            HttpSessionState Session = HttpContext.Current.Session;
            if (recordUpdated && (Session["CACHE_STATE"] != null))
            {
                //Find the existing row to be updated in cache
                StateDT stateDT = (StateDT)Session["CACHE_STATE"];
                string selectStatement = string.Concat("Synergygrfa='",originalGrfa,"'");
                DataRow[] affectedRows = stateDT.Select(selectStatement);

                //Did we find ONE matching row?
                if (affectedRows.Length == 1)
                {
                    affectedRows[0]["Synergygrfa"] = state.Synergygrfa;
                    affectedRows[0]["Code"] = state.Code;
                    affectedRows[0]["Name"] = state.Name;

                    //Store the new GRFA that came back from the update method
                    affectedRows[0]["Synergygrfa"] = newGrfa;

                    //Commit the changes to the table
                    stateDT.AcceptChanges();
                }
                else
                    invalidateCache();
            }
        }

        return recordUpdated;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteState(State state)
    {
        bool recordDeleted = false;

        //Make sure we have been given a record to delete
        if (state != null)
        {
            //Delete the record on the server
            try
            {
                if (!(recordDeleted = SynUtils.Server.DeleteState(SynUtils.UserToken, state)))
                    SynUtils.MethodFailure("Method returned fail status", "StateBLL/DeleteState", "DeleteState");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "StateBLL/DeleteState", "DeleteState");
            }

            //If the server delete was successful then delete the item from any cache
            HttpSessionState Session = HttpContext.Current.Session;
            if (recordDeleted && (Session["CACHE_STATE"] != null))
            {
                //Find the row to be deleted
                StateDT stateDT = (StateDT)Session["CACHE_STATE"];
                string selectStatement = string.Concat("Synergygrfa='",state.Synergygrfa,"'");
                DataRow[] affectedRows = stateDT.Select(selectStatement);

                //Did we find ONE matching row?
                if (affectedRows.Length == 1)
                {
                    affectedRows[0].Delete();
                    stateDT.AcceptChanges();

                    //If the table is now empty then remove the cache
                    if (stateDT.Rows.Count == 0)
                        invalidateCache();
                }
                else
                {
                    //No, something got out of step
                    invalidateCache();
                }
            }
        }

        return recordDeleted;
    }

    private static void invalidateCache()
    {
        HttpSessionState Session = HttpContext.Current.Session;
        Session.Remove("CACHE_STATE");
    }
}
