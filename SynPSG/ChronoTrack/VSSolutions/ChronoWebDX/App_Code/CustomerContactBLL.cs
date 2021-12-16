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
 * This class is the business object for the Customer_contactDT class. It is used
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
public static class CustomerContactBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public static Customer_contactDT GetAllCustomerContacts(string CustomerId)
    {
        Customer_contactDT customer_contactDT = new Customer_contactDT();

        //Make sure that we have any required parameters
        if (CustomerId != null)
        {
            try
            {
                SynUtils.Server.GetCustomerContactTable(SynUtils.UserToken, CustomerId, ref customer_contactDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContactBLL", "GetCustomerContactTable");
            }
        }

        return customer_contactDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Customer_contactDT GetLocationContacts(string CustomerId, int LocationId)
    {
        Customer_contactDT customer_contactDT = new Customer_contactDT();

        //Make sure that we have any required parameters
        if ((CustomerId != null) && (LocationId != 0))
        {
            try
            {
                SynUtils.Server.GetCustomerLocationContacts(SynUtils.UserToken, CustomerId, LocationId, ref customer_contactDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContactBLL", "GetCustomerLocationContacts");
            }
        }

        return customer_contactDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Customer_contact GetCustomerContact(string CustomerId, int ContactId)
    {
        Customer_contact customer_contact = new Customer_contact();

        //Make sure that we have any required parameters
        if ((CustomerId != null) && (ContactId != 0))
        {
            try
            {
                SynUtils.Server.GetCustomerContact(SynUtils.UserToken, CustomerId, ContactId, ref customer_contact);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContactBLL", "GetCustomerContact");
            }
        }

        return customer_contact;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public static bool AddCustomerContact(Customer_contact customer_contact)
    {
        bool returnStatus = false;

        //Make sure we have got a record to add
        if (customer_contact != null)
        {
            //Create the record on the server
            try
            {
                returnStatus = SynUtils.Server.CreateCustomerContact(SynUtils.UserToken, ref customer_contact);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContactBLL", "CreateCustomerContact");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateCustomerContact(Customer_contact customer_contact)
    {
        bool returnStatus = false;
		string newGrfa = "";

        //Make sure we have got a record to update
        if (customer_contact != null)
        {
            //Update the record on the server
            try
            {
                returnStatus = SynUtils.Server.UpdateCustomerContact(SynUtils.UserToken, customer_contact, ref newGrfa);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContactBLL", "UpdateCustomerContact");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteCustomerContact(Customer_contact customer_contact)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (customer_contact != null)
        {
            try
            {
                returnStatus = SynUtils.Server.DeleteCustomerContact(SynUtils.UserToken, customer_contact);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContactBLL", "DeleteCustomerContact");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteContact(string CustomerId, int ContactId)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (CustomerId != null && ContactId!=0)
        {
            string errorText = "";
            try
            {
                returnStatus = SynUtils.Server.DeleteContact(SynUtils.UserToken, CustomerId, ContactId, ref errorText);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContactBLL", "DeleteCustomerContact");
            }
        }

        return returnStatus;
    }

}
