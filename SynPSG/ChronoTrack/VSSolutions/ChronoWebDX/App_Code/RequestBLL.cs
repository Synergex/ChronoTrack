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
 * This class is the business object for the RequestDT class. It is used
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
public static class RequestBLL
{
    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public static RequestDT GetAllRequests()
    {
        RequestDT requestDT = new RequestDT();

        try
        {
            if (!SynUtils.Server.GetRequestTable(SynUtils.UserToken, ref requestDT, new System.DateTime(), "", ""))
                SynUtils.MethodFailure("Method returned fail status", "RequestBLL/GetAllRequests", "GetRequestTable");
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "RequestBLL/GetAllRequests", "GetRequestTable");
        }

        return requestDT;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Select, false)]
    public static Request GetRequest(int RequestId)
    {
        Request request = new Request();

        //Make sure that we have any required parameters
        if (RequestId != 0)
        {
            try
            {
                if (!SynUtils.Server.GetRequest(SynUtils.UserToken, RequestId, ref request))
                    SynUtils.MethodFailure("Method returned fail status", "RequestBLL/GetRequest", "GetRequest");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "RequestBLL/GetRequest", "GetRequest");
            }
        }

        return request;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public static bool AddRequest(Request request)
    {
        bool returnStatus = false;

        //Make sure we have got a record to add
        if (request != null)
        {
            //Create the record on the server
            try
            {
                if (!(returnStatus = SynUtils.Server.CreateRequest(SynUtils.UserToken, ref request)))
                    SynUtils.MethodFailure("Method returned fail status", "RequestBLL/AddRequest", "CreateRequest");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "RequestBLL/AddRequest", "CreateRequest");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateRequest(Request request)
    {
        bool returnStatus = false;
		string newGrfa = "";

        //Make sure we have got a record to update
        if (request != null)
        {
            try
            {
                if (!(returnStatus = SynUtils.Server.UpdateRequest(SynUtils.UserToken, request, ref newGrfa)))
                    SynUtils.MethodFailure("Method returned fail status", "RequestBLL/UpdateRequest", "UpdateRequest");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "RequestBLL/UpdateRequest", "UpdateRequest");
            }
        }

        return returnStatus;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteRequest(Request request)
    {
        bool returnStatus = false;

        //Make sure we have got a record to delete
        if (request != null)
        {
            try
            {
                if (!(returnStatus = SynUtils.Server.DeleteRequest(SynUtils.UserToken, request)))
                    SynUtils.MethodFailure("Method returned fail status", "RequestBLL/DeleteRequest", "DeleteRequest");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "RequestBLL/DeleteRequest", "DeleteRequest");
            }
        }

        return returnStatus;
    }
}
