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
 * This class is the business object for the Fee_typeDT class. It is used
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
public class FeeTypeBLL
{
    private HttpSessionState Session;
    //Constructor
    public FeeTypeBLL()
    {
        Session = HttpContext.Current.Session;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public Fee_typeDT GetAllFeeTypes()
    {
        //Create a data table to return
        Fee_typeDT fee_typeDT = new Fee_typeDT();

        //Do we have an existing cache?
        if (Session["CACHE_FEE_TYPE"] != null)
            fee_typeDT = (Fee_typeDT)Session["CACHE_FEE_TYPE"];
        else
        {
            //No, get the table from the server
            bool methodOK = false;
            try
            {
                methodOK = SynUtils.Server.GetFeeTypeTable(SynUtils.UserToken, ref fee_typeDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "FeeTypeBLL", "GetFeeTypeTable");
            }

			//If we got data back then cache it for next time
            if (methodOK && (fee_typeDT.Rows.Count > 0))
                Session.Add("CACHE_FEE_TYPE",fee_typeDT);
        }

        return fee_typeDT;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, false)]
    public Fee_type GetFeeType(int FeeTypeId)
    {
        Fee_type fee_type = new Fee_type();

        //Make sure we have any required parameters
        if (FeeTypeId != 0)
        {
            try
            {
                SynUtils.Server.GetFeeType(SynUtils.UserToken, FeeTypeId, ref fee_type);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "FeeTypeBLL", "GetFeeType");
            }
        }

        return fee_type;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public bool AddFeeType(Fee_type fee_type)
    {
        bool recordCreated = false;

        //Make sure we have been given a record to create
        if (fee_type != null)
        {
            //Create the record on the server
            try
            {
                recordCreated = SynUtils.Server.CreateFeeType(SynUtils.UserToken, ref fee_type);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "FeeTypeBLL", "CreateFeeType");
            }

            //If the server create was successful then add the item to any cache
            if (recordCreated && (Session["CACHE_FEE_TYPE"] != null))
            {
                Fee_typeDT fee_typeDT = (Fee_typeDT)Session["CACHE_FEE_TYPE"];
                fee_typeDT.AddRow(fee_type);
                fee_typeDT.AcceptChanges();
            }
        }

        return recordCreated;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public bool UpdateFeeType(Fee_type fee_type)
    {
        bool recordUpdated = false;

        //Make sure we have been given a record to update
		if (fee_type != null)
        {
            //Save the original GRFA so we can locate the updated record in cache if necessary
            string originalGrfa = fee_type.Synergygrfa;
			string newGrfa = "";
		
           //Update the record on the server
            try
            {
                recordUpdated = SynUtils.Server.UpdateFeeType(SynUtils.UserToken, fee_type, ref newGrfa);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "FeeTypeBLL", "UpdateFeeType");
            }

            //If the server update was successful then update the item in any cache
            if (recordUpdated && (Session["CACHE_FEE_TYPE"] != null))
            {
                //Find the existing row to be updated in cache
                Fee_typeDT fee_typeDT = (Fee_typeDT)Session["CACHE_FEE_TYPE"];
                string selectStatement = string.Concat("Synergygrfa='",originalGrfa,"'");
                DataRow[] affectedRows = fee_typeDT.Select(selectStatement);

                //Did we find ONE matching row?
                if (affectedRows.Length == 1)
                {
                    affectedRows[0]["Synergygrfa"] = fee_type.Synergygrfa;
                    affectedRows[0]["Fee_type_id"] = fee_type.Fee_type_id;
                    affectedRows[0]["Description"] = fee_type.Description;
                    affectedRows[0]["Has_units"] = fee_type.Has_units;

                    //Store the new GRFA that came back from the update method
                    affectedRows[0]["Synergygrfa"] = newGrfa;

                    //Commit the changes to the table
                    fee_typeDT.AcceptChanges();
                }
                else
                {
                    //No, something got out of step!
                    invalidateCache();
                }
            }
        }

        return recordUpdated;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public bool DeleteFeeType(Fee_type fee_type)
    {
        bool recordDeleted = false;

        //Make sure we have been given a record to delete
        if (fee_type != null)
        {
            //Delete the record on the server
            try
            {
                recordDeleted = SynUtils.Server.DeleteFeeType(SynUtils.UserToken, fee_type);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "FeeTypeBLL", "DeleteFeeType");
            }

            //If the server delete was successful then delete the item from any cache
            if (recordDeleted && (Session["CACHE_FEE_TYPE"]!=null))
            {
                //Find the row to be deleted
                Fee_typeDT fee_typeDT = (Fee_typeDT)Session["CACHE_FEE_TYPE"];
                string selectStatement = string.Concat("Synergygrfa='",fee_type.Synergygrfa,"'");
                DataRow[] affectedRows = fee_typeDT.Select(selectStatement);

                //Did we find ONE matching row?
                if (affectedRows.Length == 1)
                {
                    affectedRows[0].Delete();
                    fee_typeDT.AcceptChanges();

                    //If the table is now empty then remove the cache
                    if (fee_typeDT.Rows.Count == 0)
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

    private void invalidateCache()
    {
        HttpSessionState Session = HttpContext.Current.Session;
        Session.Remove("CACHE_FEE_TYPE");
    }
}
