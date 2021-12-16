using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChronoTrack;

public partial class project_ProjectExpense : ThemedPage
{
    private Project_summary p;
    private Project_expense expense;
    private Project_expense_summaryDT expenseTable;
    private int expenseId;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PreviousPageUrl.Value = Request.UrlReferrer.ToString();
            if (Session["Project"] == null)
            {
                multiView.SetActiveView(errorView);
            }
            else
            {
                p = (Project_summary)Session["Project"];
                txtProjectId.Text = p.Project_id.ToString();
                txtCustomer.Text = p.Customer_name;
                multiView.SetActiveView(normalView);

                //Configure add expense form defaults
                ucExpenseDate.Date = DateTime.Now;
                ucExpensedBy.DoBinding(p.Project_id);
                ucExpensedBy.SelectFirstIfItems();
                txtQuantity.Text = "1";

                //Are we being asked to edit an existing note?
                if (!(Request.QueryString["ExpenseId"] == null))
                {
                    loadExpense();
                    enableFields();
                }
            }
        }
        else
            p = (Project_summary)Session["Project"];

    }

    protected void ucExpenseType_SelectedIndexChanged(object sender, EventArgs e)
    {
        enableFields();
    }

    protected void enableFields()
    {
        txtDescription.Enabled = true;
        txtUnitPrice.Enabled = true;
        txtQuantity.Enabled = true;
        ucExpensedBy.Enabled = true;
        chkIsEstimate.Enabled = true;
        btnOk.Enabled = true;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //Go back to "My Projects"
        Response.Redirect(PreviousPageUrl.Value, true);
    }
    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (btnOk.Text == "Add Expense")
            addExpense();
        else
            updateExpense();

        //Re-get the collection of project expenses
        expenseTable = ProjectExpenseBLL.GetProjectExpensesSummary(p.Project_id);

        //Update the cache
        Session["ProjectExpenses"] = expenseTable;

        //Go back to the previous page
        Response.Redirect(PreviousPageUrl.Value, true);

    }

    protected void addExpense()
    {
        expense = new Project_expense();
        expense.Project_id = p.Project_id;
        expense.Expense_date = ucExpenseDate.Date;
        expense.Expense_type = ucExpenseType.Value;
        expense.Description = txtDescription.Text;
        expense.Currency_code = "US";
        expense.Unit_price = Decimal.Parse(txtUnitPrice.Text);
        expense.Quantity = Decimal.Parse(txtQuantity.Text);
        expense.Expensed_by = ucExpensedBy.Value;
        expense.Is_estimate = chkIsEstimate.Checked;

        //Add the new expense
        ProjectExpenseBLL.AddProjectExpense(expense);
    }
    
    protected void loadExpense()
    {
        expenseId = int.Parse(Request.QueryString["ExpenseId"].ToString());

        expense = ProjectExpenseBLL.GetExpense(p.Project_id, expenseId);

        ucExpenseDate.Date = expense.Expense_date;
        ucExpenseType.Value = expense.Expense_type;
        txtDescription.Text = expense.Description;
        txtUnitPrice.Text = expense.Unit_price.ToString();
        txtQuantity.Text = expense.Quantity.ToString();
        ucExpensedBy.Value = expense.Expensed_by;
        chkIsEstimate.Checked = expense.Is_estimate;
        btnOk.Text = "Update Expense";
    }

    protected void updateExpense()
    {
        expenseId = int.Parse(Request.QueryString["ExpenseId"].ToString());

        //Get the current expense record from the server (we need the GRFA and replication key)
        expense = ProjectExpenseBLL.GetExpense(p.Project_id, expenseId);

        //Update the form data with our copy
        expense.Expense_date = ucExpenseDate.Date;
        expense.Expense_type = ucExpenseType.Value;
        expense.Description = txtDescription.Text;
        expense.Unit_price = Decimal.Parse(txtUnitPrice.Text);
        expense.Quantity = Decimal.Parse(txtQuantity.Text);
        expense.Expensed_by = ucExpensedBy.Value;
        expense.Is_estimate = chkIsEstimate.Checked;

        //Save the new record
        ProjectExpenseBLL.UpdateProjectExpense(expense);
    }

}
