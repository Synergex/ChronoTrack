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
using System;
using System.ComponentModel;
using System.Data;
using System.Web;
using System.Web.SessionState;
using ChronoTrack;

[DataObject]
public class CustomerBLL
{
    private HttpSessionState Session;

    //Constructor
    public CustomerBLL()
    {
        Session = HttpContext.Current.Session;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public CustomerDT GetAllCustomers()
    {
        //Create a data table to return
        CustomerDT customerDT = new CustomerDT();

        //Do we have an existing cache?
        if (Session["CACHE_CUSTOMER"] != null)
        {
            //Yes, return the cached table
            customerDT = (CustomerDT)Session["CACHE_CUSTOMER"];
        }
        else
        {
            //No, get the table from the server
            bool methodOK = false;
            try
            {
                methodOK = SynUtils.Server.GetCustomerTable(SynUtils.UserToken, ref customerDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerBLL", "GetCustomerTable");
            }

			//If we got data back then cache it for next time
            if (methodOK && (customerDT.Rows.Count > 0))
                Session.Add("CACHE_CUSTOMER",customerDT);
        }

        return customerDT;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, false)]
    public Customer GetCustomer(string CustomerId)
    {
        Customer customer = new Customer();

        //Make sure we have any required parameters
        if (CustomerId != null)
        {
            try
            {
                SynUtils.Server.GetCustomer(SynUtils.UserToken, CustomerId, ref customer);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerBLL", "GetCustomer");
            }
        }

        return customer;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public bool AddCustomer(Customer customer)
    {
        bool recordCreated = false;

        //Make sure we have been given a record to create
        if (customer != null)
        {
            //Create the record on the server
            try
            {
                recordCreated = SynUtils.Server.CreateCustomer(SynUtils.UserToken, ref customer);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerBLL", "CreateCustomer");
            }

            //If the server create was successful then add the item to any cache
            if (recordCreated && (Session["CACHE_CUSTOMER"] != null))
            {
                CustomerDT customerDT = (CustomerDT)Session["CACHE_CUSTOMER"];
                customerDT.AddRow(customer);
                customerDT.AcceptChanges();
            }
        }

        return recordCreated;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public bool UpdateCustomer(Customer customer)
    {
        bool recordUpdated = false;

        //Make sure we have been given a record to update
		if (customer != null)
        {
            //Save the original GRFA so we can locate the updated record in cache if necessary
            string originalGrfa = customer.Synergygrfa;
			string newGrfa = "";
		
           //Update the record on the server
            try
            {
                recordUpdated = SynUtils.Server.UpdateCustomer(SynUtils.UserToken, customer, ref newGrfa);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerBLL", "UpdateCustomer");
            }

            //If the server update was successful then update the item in any cache
            if (recordUpdated && (Session["CACHE_CUSTOMER"] != null))
            {
                //Find the existing row to be updated in cache
                CustomerDT customerDT = (CustomerDT)Session["CACHE_CUSTOMER"];
                string selectStatement = string.Concat("Synergygrfa='",originalGrfa,"'");
                DataRow[] affectedRows = customerDT.Select(selectStatement);

                //Did we find ONE matching row?
                if (affectedRows.Length == 1)
                {
                    affectedRows[0]["Synergygrfa"] = customer.Synergygrfa;
                    affectedRows[0]["Customer_id"] = customer.Customer_id;
                    affectedRows[0]["Company"] = customer.Company;
                    affectedRows[0]["Tech_contact_id"] = customer.Tech_contact_id;
                    affectedRows[0]["Legal_contact_id"] = customer.Legal_contact_id;
                    affectedRows[0]["Current_contract"] = customer.Current_contract;

                    //Store the new GRFA that came back from the update method
                    affectedRows[0]["Synergygrfa"] = newGrfa;

                    //Commit the changes to the table
                    customerDT.AcceptChanges();
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
    public bool DeleteCustomer(Customer customer)
    {
        bool recordDeleted = false;

        //Make sure we have been given a record to delete
        if (customer != null)
        {
            //Delete the record on the server
            try
            {
                recordDeleted = SynUtils.Server.DeleteCustomer(SynUtils.UserToken, customer);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerBLL", "DeleteCustomer");
            }

            //If the server delete was successful then delete the item from any cache
            if (recordDeleted && (Session["CACHE_CUSTOMER"]!=null))
            {
                //Find the row to be deleted
                CustomerDT customerDT = (CustomerDT)Session["CACHE_CUSTOMER"];
                string selectStatement = string.Concat("Synergygrfa='",customer.Synergygrfa,"'");
                DataRow[] affectedRows = customerDT.Select(selectStatement);

                //Did we find ONE matching row?
                if (affectedRows.Length == 1)
                {
                    affectedRows[0].Delete();
                    customerDT.AcceptChanges();

                    //If the table is now empty then remove the cache
                    if (customerDT.Rows.Count == 0)
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
        Session.Remove("CACHE_CUSTOMER");
    }
}
