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
 * This class is the business object for the Consultant_feeDT class. It is used
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
public static class ConsultantFeeBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public static Consultant_feeDT GetAllConsultantFees(string UserId)
    {
        Consultant_feeDT consultant_feeDT = new Consultant_feeDT();

        //Make sure that we have any required parameters
        if (UserId != null)
        {
            try
            {
                if (!SynUtils.Server.GetConsultantFeeTable(SynUtils.UserToken, UserId, ref consultant_feeDT))
                    SynUtils.MethodFailure("Method returned fail status", "ConsultantFeeBLL/GetAllConsultantFees", "GetConsultantFeeTable");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ConsultantFeeBLL/GetAllConsultantFees", "GetConsultantFeeTable");
            }
        }

        return consultant_feeDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Consultant_fee_summaryDT GetConsultantFeesSummary(string UserId)
    {
        Consultant_fee_summaryDT results = new Consultant_fee_summaryDT();

        //Make sure that we have any required parameters
        if (UserId != null)
        {
            string errorText = "";
            try
            {
                if (!SynUtils.Server.GetConsultantFeesSummary(SynUtils.UserToken, UserId, ref results, ref errorText))
                    SynUtils.MethodFailure(errorText, "ConsultantFeeBLL", "GetConsultantFeesSummary");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ConsultantFeeBLL", "GetConsultantFeesSummary");
            }
        }

        return results;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static Consultant_fee GetConsultantFee(string UserId, int FeeTypeId)
    {
        Consultant_fee consultant_fee = new Consultant_fee();

        //Make sure that we have any required parameters
        if ((UserId != null) && (FeeTypeId != 0))
        {
            try
            {
                if (!SynUtils.Server.GetConsultantFee(SynUtils.UserToken, UserId, FeeTypeId, ref consultant_fee))
                    SynUtils.MethodFailure("Method returned fail status", "ConsultantFeeBLL/GetConsultantFee", "GetConsultantFee");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ConsultantFeeBLL/GetConsultantFee", "GetConsultantFee");
            }
        }

        return consultant_fee;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public static bool AddConsultantFee(Consultant_fee consultant_fee)
    {
        bool returnStatus = false;

        //Make sure we have got a record to add
        if (consultant_fee != null)
        {
            //Add the record
            try
            {
                if (!(returnStatus = SynUtils.Server.CreateConsultantFee(SynUtils.UserToken, ref consultant_fee)))
                    SynUtils.MethodFailure("Method returned fail status", "ConsultantFeeBLL/AddConsultantFee", "CreateConsultantFee");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ConsultantFeeBLL/AddConsultantFee", "CreateConsultantFee");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateConsultantFee(Consultant_fee consultant_fee)
    {
        bool returnStatus = false;
		string newGrfa = "";

        //Make sure we have got a record to update
        if (consultant_fee != null)
        {
            try
            {
                if (!(returnStatus = SynUtils.Server.UpdateConsultantFee(SynUtils.UserToken, consultant_fee, ref newGrfa)))
                    SynUtils.MethodFailure("Method returned fail status", "ConsultantFeeBLL/UpdateConsultantFee", "UpdateConsultantFee");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ConsultantFeeBLL/UpdateConsultantFee", "UpdateConsultantFee");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteConsultantFee(Consultant_fee consultant_fee)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (consultant_fee != null)
        {
            try
            {
                if (!(returnStatus = SynUtils.Server.DeleteConsultantFee(SynUtils.UserToken, consultant_fee)))
                    SynUtils.MethodFailure("Method returned fail status", "ConsultantFeeBLL/DeleteConsultantFee", "DeleteConsultantFee");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "ConsultantFeeBLL/DeleteConsultantFee", "DeleteConsultantFee");
            }
        }

        return returnStatus;
    }
}
