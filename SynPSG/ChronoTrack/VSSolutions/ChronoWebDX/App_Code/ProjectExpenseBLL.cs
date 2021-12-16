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
 * This class is the business object for the Project_expenseDT class. It is used
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
using ChronoTrack;

[DataObject]
public static class ProjectExpenseBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, false)]
    public static Project_expenseDT GetProjectExpenses(int ProjectId)
    {
        Project_expenseDT results = new Project_expenseDT();

        //Make sure that we have any required parameters
        if (ProjectId != 0)
        {
            try
            {
                if (!SynUtils.Server.GetProjectExpenseTable(SynUtils.UserToken, ProjectId, ref results))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectExpenseBLL/GetProjectExpenses", "GetProjectExpenseTable");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectExpenseBLL/GetProjectExpenses", "GetProjectExpenseTable");
            }
        }

        return results;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static Project_expense_summaryDT GetProjectExpensesSummary(int ProjectId)
    {
        Project_expense_summaryDT results = new Project_expense_summaryDT();

        //Make sure that we have any required parameters
        if (ProjectId != 0)
        {
            string errorText = "";
            try
            {
                if (!SynUtils.Server.GetProjectExpensesSummary(SynUtils.UserToken, ProjectId, ref results, ref errorText))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectExpenseBLL/GetProjectExpensesSummary", "GetProjectExpensesSummary");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectExpenseBLL/GetProjectExpensesSummary", "GetProjectExpensesSummary");
            }
        }

        return results;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Project_expense GetExpense(int ProjectId, int ExpenseId)
    {
        Project_expense project_expense = new Project_expense();

        //Make sure that we have any required parameters
        if ((ProjectId != 0) && (ExpenseId != 0))
        {
            try
            {
                if (!SynUtils.Server.GetExpense(SynUtils.UserToken, ProjectId, ExpenseId, ref project_expense))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectExpenseBLL/GetExpense", "GetExpense");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectExpenseBLL/GetExpense", "GetExpense");
            }
        }

        return project_expense;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public static bool AddProjectExpense(Project_expense project_expense)
    {
        bool returnStatus = false;

        //Make sure we have got a record to add
        if (project_expense != null)
        {
            //Create the record on the server
            try
            {
                if (!(returnStatus = SynUtils.Server.CreateExpense(SynUtils.UserToken, ref project_expense)))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectExpenseBLL/AddProjectExpense", "CreateExpense");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectExpenseBLL/AddProjectExpense", "CreateExpense");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateProjectExpense(Project_expense project_expense)
    {
        bool returnStatus = false;
		string newGrfa = "";

        //Make sure we have got a record to update
        if (project_expense != null)
        {
            try
            {
                if (!(returnStatus = SynUtils.Server.UpdateExpense(SynUtils.UserToken, project_expense, ref newGrfa)))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectExpenseBLL/UpdateProjectExpense", "UpdateExpense");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectExpenseBLL/UpdateProjectExpense", "UpdateExpense");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteExpense(Project_expense project_expense)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (project_expense != null)
        {
            try
            {
                if (!(returnStatus = SynUtils.Server.DeleteExpense(SynUtils.UserToken, project_expense)))
                    SynUtils.MethodFailure("Method returned fail status", "ProjectExpenseBLL/DeleteExpense", "DeleteExpense");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ProjectExpenseBLL/DeleteExpense", "DeleteExpense");
            }
        }

        return returnStatus;
    }
}
