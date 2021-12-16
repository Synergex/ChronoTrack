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
 * This class is the business object for the Customer_contractDT class. It is used
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
public class CustomerContractBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public Customer_contractDT GetAllCustomerContracts(string CustomerId)
    {
        Customer_contractDT customer_contractDT = new Customer_contractDT();

        //Make sure that we have any required parameters
        if (CustomerId != null)
        {
            try
            {
                SynUtils.Server.GetCustomerContractTable(SynUtils.UserToken, CustomerId, ref customer_contractDT);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContractBLL", "GetCustomerContractTable");
            }
        }

        return customer_contractDT;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, false)]
    public Customer_contract GetCustomerContract(string CustomerId,string ContractId)
    {
        Customer_contract customer_contract = new Customer_contract();

        //Make sure that we have any required parameters
        if ((CustomerId != null) && (ContractId != null))
        {
            try
            {
                SynUtils.Server.GetCustomerContract(SynUtils.UserToken, CustomerId, ContractId, ref customer_contract);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContractBLL", "GetCustomerContract");
            }
        }

        return customer_contract;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public bool AddCustomerContract(Customer_contract customer_contract)
    {
        bool returnStatus = false;

        //Make sure we have got a record to add
        if (customer_contract != null)
        {
            //Create the record on the server
            try
            {
                returnStatus = SynUtils.Server.CreateCustomerContract(SynUtils.UserToken, ref customer_contract);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContractBLL", "CreateCustomerContract");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public bool UpdateCustomerContract(Customer_contract customer_contract)
    {
        bool returnStatus = false;
		string newGrfa = "";

        //Make sure we have got a record to update
        if (customer_contract != null)
        {
            try
            {
                returnStatus = SynUtils.Server.UpdateCustomerContract(SynUtils.UserToken, customer_contract, ref newGrfa);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContractBLL", "UpdateCustomerContract");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public bool DeleteCustomerContract(Customer_contract customer_contract)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (customer_contract != null)
        {
            try
            {
                returnStatus = SynUtils.Server.DeleteCustomerContract(SynUtils.UserToken, customer_contract);
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "CustomerContractBLL", "DeleteCustomerContract");
            }
        }

        return returnStatus;
    }
}
