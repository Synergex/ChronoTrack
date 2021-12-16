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
 * This class is the business object for the Customer_locationDT class. It is used
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
public static class CustomerLocationBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public static Customer_locationDT GetAllCustomerLocations(string CustomerId)
    {
        Customer_locationDT customer_locationDT = new Customer_locationDT();

        if (CustomerId != null)
        {
            try
            {
                SynUtils.Server.GetCustomerLocationTable(SynUtils.UserToken, CustomerId, ref customer_locationDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerLocationBLL", "GetCustomerLocationTable");
            }
        }

        return customer_locationDT;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, false)]
    public static Customer_location GetCustomerLocation(string CustomerId,int LocationId)
    {
        Customer_location customer_location = new Customer_location();

        //Make sure that we have any required parameters
        if ((CustomerId != null) && (LocationId != 0))
        {
            try
            {
                SynUtils.Server.GetCustomerLocation(SynUtils.UserToken, CustomerId, LocationId, ref customer_location);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerLocationBLL", "GetCustomerLocation");
            }
        }

        return customer_location;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public static bool AddCustomerLocation(Customer_location customer_location)
    {
        bool returnStatus = false;

        //Make sure we have got a record to add
        if (customer_location != null)
        {
            //Create the record on the server
            try
            {
                returnStatus = SynUtils.Server.CreateCustomerLocation(SynUtils.UserToken, ref customer_location);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerLocationBLL", "CreateCustomerLocation");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateCustomerLocation(Customer_location customer_location)
    {
        bool returnStatus = false;
		string newGrfa = "";

        //Make sure we have got a record to update
        if (customer_location != null)
        {
            try
            {
                returnStatus = SynUtils.Server.UpdateCustomerLocation(SynUtils.UserToken, customer_location, ref newGrfa);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerLocationBLL", "UpdateCustomerLocation");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteCustomerLocation(Customer_location customer_location)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (customer_location != null)
        {
            try
            {
                returnStatus = SynUtils.Server.DeleteCustomerLocation(SynUtils.UserToken, customer_location);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerLocationBLL", "DeleteCustomerLocation");
            }
        }

        return returnStatus;
    }
}
