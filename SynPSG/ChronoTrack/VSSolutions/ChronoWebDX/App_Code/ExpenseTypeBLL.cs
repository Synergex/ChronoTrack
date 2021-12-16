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
 * This class is the business object for the Expense_typeDT class. It is used
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
public class ExpenseTypeBLL
{
    private HttpSessionState Session;

    //Constructor
    public ExpenseTypeBLL()
    {
        Session = HttpContext.Current.Session;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public Expense_typeDT GetAllExpenseTypes()
    {
        //Create a data table to return
        Expense_typeDT expense_typeDT = new Expense_typeDT();

        //Do we have an existing cache?
        if (Session["CACHE_EXPENSE_TYPE"] != null)
            expense_typeDT = (Expense_typeDT)Session["CACHE_EXPENSE_TYPE"];
        else
        {
            //No, get the table from the server
            bool methodOK = false;
            try
            {
                methodOK = SynUtils.Server.GetExpenseTypeTable(SynUtils.UserToken, ref expense_typeDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ExpenseTypeBLL", "GetExpenseTypeTable");
            }

			//If we got data back then cache it for next time
            if (methodOK && (expense_typeDT.Rows.Count > 0))
                Session.Add("CACHE_EXPENSE_TYPE",expense_typeDT);
        }

        return expense_typeDT;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, false)]
    public Expense_type GetExpenseType(string ExpenseTypeId)
    {
        Expense_type expense_type = new Expense_type();

        //Make sure we have any required parameters
        if (ExpenseTypeId != null)
        {
            try
            {
                SynUtils.Server.GetExpenseType(SynUtils.UserToken, ExpenseTypeId, ref expense_type);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ExpenseTypeBLL", "GetExpenseType");
            }
        }

        return expense_type;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public bool AddExpenseType(Expense_type expense_type)
    {
        bool recordCreated = false;

        //Make sure we have been given a record to create
        if (expense_type != null)
        {
            //Create the record on the server
            try
            {
                recordCreated = SynUtils.Server.CreateExpenseType(SynUtils.UserToken, ref expense_type);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ExpenseTypeBLL", "CreateExpenseType");
            }

            //If the server create was successful then add the item to any cache
            if (recordCreated && (Session["CACHE_EXPENSE_TYPE"] != null))
            {
                Expense_typeDT expense_typeDT = (Expense_typeDT)Session["CACHE_EXPENSE_TYPE"];
                expense_typeDT.AddRow(expense_type);
                expense_typeDT.AcceptChanges();
            }
        }

        return recordCreated;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public bool UpdateExpenseType(Expense_type expense_type)
    {
        bool recordUpdated = false;

        //Make sure we have been given a record to update
		if (expense_type != null)
        {
            //Save the original GRFA so we can locate the updated record in cache if necessary
            string originalGrfa = expense_type.Synergygrfa;
			string newGrfa = "";
		
           //Update the record on the server
            try
            {
                recordUpdated = SynUtils.Server.UpdateExpenseType(SynUtils.UserToken, expense_type, ref newGrfa);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ExpenseTypeBLL", "UpdateExpenseType");
            }

            //If the server update was successful then update the item in any cache
            if (recordUpdated && (Session["CACHE_EXPENSE_TYPE"] != null))
            {
                //Find the existing row to be updated in cache
                Expense_typeDT expense_typeDT = (Expense_typeDT)Session["CACHE_EXPENSE_TYPE"];
                string selectStatement = string.Concat("Synergygrfa='",originalGrfa,"'");
                DataRow[] affectedRows = expense_typeDT.Select(selectStatement);

                //Did we find ONE matching row?
                if (affectedRows.Length == 1)
                {
                    affectedRows[0]["Synergygrfa"] = expense_type.Synergygrfa;
                    affectedRows[0]["Expense_type_id"] = expense_type.Expense_type_id;
                    affectedRows[0]["Description"] = expense_type.Description;
                    affectedRows[0]["Has_units"] = expense_type.Has_units;

                    //Store the new GRFA that came back from the update method
                    affectedRows[0]["Synergygrfa"] = newGrfa;

                    //Commit the changes to the table
                    expense_typeDT.AcceptChanges();
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
    public bool DeleteExpenseType(Expense_type expense_type)
    {
        bool recordDeleted = false;

        //Make sure we have been given a record to delete
        if (expense_type != null)
        {
            //Delete the record on the server
            try
            {
                recordDeleted = SynUtils.Server.DeleteExpenseType(SynUtils.UserToken, expense_type);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ExpenseTypeBLL", "DeleteExpenseType");
            }

            //If the server delete was successful then delete the item from any cache
            if (recordDeleted && (Session["CACHE_EXPENSE_TYPE"]!=null))
            {
                //Find the row to be deleted
                Expense_typeDT expense_typeDT = (Expense_typeDT)Session["CACHE_EXPENSE_TYPE"];
                string selectStatement = string.Concat("Synergygrfa='",expense_type.Synergygrfa,"'");
                DataRow[] affectedRows = expense_typeDT.Select(selectStatement);

                //Did we find ONE matching row?
                if (affectedRows.Length == 1)
                {
                    affectedRows[0].Delete();
                    expense_typeDT.AcceptChanges();

                    //If the table is now empty then remove the cache
                    if (expense_typeDT.Rows.Count == 0)
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
        Session.Remove("CACHE_EXPENSE_TYPE");
    }
}
