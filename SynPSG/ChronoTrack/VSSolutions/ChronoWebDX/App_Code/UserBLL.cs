/******************************************************************************
 *
 * Author:      Steve Ives
 *
 * Company:     Synergex Professional Services Group
 *
 * Created:     01/28/2009 at 14:12
 *
 ******************************************************************************
 *
 * This class is the business object for the UserDT class. It is used
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
using ChronoTrack;

[DataObject]
public static class UserBLL
{

    [DataObjectMethodAttribute (DataObjectMethodType.Select, true)]
    public static UserDT GetAllUsers()
    {
        //Create a data table to return
        UserDT userDT = new UserDT();

        //Get the table from the server
        try
        {
            if (!SynUtils.Server.GetUserTable(SynUtils.UserToken, ref userDT))
                SynUtils.MethodFailure("Method returned fail status", "UserBLL/GetAllUsers", "GetUserTable");
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "UserBLL/GetAllUsers", "GetUserTable");
        }

        return userDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select,false)]
    public static UserDT GetAllConsultants()
    {
        //Create a data table to return
        UserDT userDT = new UserDT();

        //Get the table from the server
        try
        {
            if (!SynUtils.Server.GetConsultantTable(SynUtils.UserToken, ref userDT))
                SynUtils.MethodFailure("Method returned fail status", "UserBLL/GetAllConsultants", "GetConsultantTable");
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "UserBLL/GetAllConsultants", "GetConsultantTable");
        }

        return userDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static UserDT GetProjectConsultants(int projectId)
    {
        //Create a data table to return
        UserDT userDT = new UserDT();

        if (projectId > 0)
        {
            string errorText = "";

            //Get the table from the server
            try
            {
                if (!SynUtils.Server.GetProjectConsultants(SynUtils.UserToken, projectId, ref userDT, ref errorText))
                    SynUtils.MethodFailure("Method returned fail status", "UserBLL/GetProjectConsultants", "GetProjectConsultants");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "UserBLL/GetProjectConsultants", "GetProjectConsultants");
            }
        }

        return userDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static UserDT GetAllManagers()
    {
        //Create a data table to return
        UserDT userDT = new UserDT();

        //Get the table from the server
        try
        {
            if (!SynUtils.Server.GetManagerTable(SynUtils.UserToken, ref userDT))
                SynUtils.MethodFailure("Method returned fail status", "UserBLL/GetAllManagers", "GetManagerTable");
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "UserBLL/GetAllManagers", "GetManagerTable");
        }

        return userDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static UserDT GetAllEmployees()
    {
        //Create a data table to return
        UserDT userDT = new UserDT();

        //Get the table from the server
        try
        {
            if (!SynUtils.Server.GetEmployeeTable(SynUtils.UserToken, ref userDT))
                SynUtils.MethodFailure("Method returned fail status", "UserBLL/GetAllEmployees", "GetEmployeeTable");
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "UserBLL/GetAllEmployees", "GetEmployeeTable");
        }

        return userDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static UserDT GetAllContractors()
    {
        //Create a data table to return
        UserDT userDT = new UserDT();

        //Get the table from the server
        try
        {
            if (!SynUtils.Server.GetContractorTable(SynUtils.UserToken, ref userDT))
                SynUtils.MethodFailure("Method returned fail status", "UserBLL/GetAllContractors", "GetContractorTable");
        }
        catch (Exception ex)
        {
            SynUtils.CallFailure(ex, "UserBLL/GetAllContractors", "GetContractorTable");
        }

        return userDT;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static User GetUser(string UserId)
    {
        User user = new User();

        //Make sure we have any required parameters
        if (UserId != null)
        {
            try
            {
                if (!SynUtils.Server.GetUser(SynUtils.UserToken, UserId, ref user))
                    SynUtils.MethodFailure("Method returned fail status", "UserBLL/GetUser", "GetUser");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "UserBLL/GetUser", "GetUser");
            }
        }

        return user;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Insert, true)]
    public static bool AddUser(User user)
    {
        bool recordCreated = false;

        //Make sure we have been given a record to create
        if (user != null)
        {
            //Create the record on the server
            try
            {
                if (!(recordCreated = SynUtils.Server.CreateUser(SynUtils.UserToken, ref user)))
                    SynUtils.MethodFailure("Method returned fail status", "UserBLL/AddUser", "CreateUser");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "UserBLL/AddUser", "CreateUser");
            }
        }

        return recordCreated;
    }

    [DataObjectMethodAttribute (DataObjectMethodType.Update, true)]
    public static bool UpdateUser(User user)
    {
        bool recordUpdated = false;

        //Make sure we have been given a record to update
		if (user != null)
        {
			string newGrfa = "";

            //Update the record on the server
            try
            {
                if (!(recordUpdated = SynUtils.Server.UpdateUser(SynUtils.UserToken, user, ref newGrfa)))
                    SynUtils.MethodFailure("Method returned fail status", "UserBLL/UpdateUser", "UpdateUser");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "UserBLL/UpdateUser", "UpdateUser");
            }
        }

        return recordUpdated;
    }

    [DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
    public static bool DeleteUser(User user)
    {
        bool recordDeleted = false;

        //Make sure we have been given a record to delete
        if (user != null)
        {
            //Delete the record on the server
            try
            {
                if (!(recordDeleted = SynUtils.Server.DeleteUser(SynUtils.UserToken, user)))
                    SynUtils.MethodFailure("Method returned fail status", "UserBLL/DeleteUser", "DeleteUser");
            }
            catch (Exception ex)
            {
                SynUtils.CallFailure(ex, "UserBLL/DeleteUser", "DeleteUser");
            }
        }

        return recordDeleted;
    }
}
