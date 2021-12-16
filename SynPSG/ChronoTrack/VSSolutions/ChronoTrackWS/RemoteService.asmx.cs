using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace ChronoTrackWS
{
    /// <summary>
    /// Summary description for RemoteService
    /// </summary>
    [WebService(Namespace = "http://ChronoTrack.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RemoteService : System.Web.Services.WebService
    {
        #region private members

        ChronoTrack.ChronoTrack xfsp = new ChronoTrack.ChronoTrack();
        #endregion 

        #region public table definitions

        [System.Web.Services.WebMethod]
        public ChronoTrack.Project ProjectTableLayout()
        {
            return new ChronoTrack.Project();
        }

        [System.Web.Services.WebMethod]
        public ChronoTrack.Project_combined ProjectCombinedTableLayout()
        {
            return new ChronoTrack.Project_combined();
        }

        #endregion

        /// <summary>
        /// Validate a users credntials
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>ValidateUserResponse</returns>
        [System.Web.Services.WebMethod(EnableSession=true, MessageName = "ValidationDetails")]
        public ValidateUserResponse ValidateUser(string userName, string password)
        {
            //create our response object
            ValidateUserResponse response = new ValidateUserResponse();

            try
            {
                //start off not logged in!!
                Session["LoginState"] = false;
                Session["ErrorMessage"] = "";

                try
                {
                    validateLogin();
                }
                catch (Exception)
                {
                    connectToServer();
                }
                //move the passed data

                string mUserName;
                string mPassword;
                try
                {
                    mUserName = userName;
                    mPassword = password;

                    try
                    {
                        string errorMessage = "";
                        string userToken = "";
                        if (!xfsp.RemoteLogin(mUserName, mPassword,0, ref errorMessage,ref userToken))
                        {
                            response.CallStatus = false;
                            response.ErrorMessage = errorMessage;
                            //we need to disconnect from the server!
                            xfsp.disconnect();
                            Session["XFSP"] = null;
                        }
                        else
                        {
                            Session.Add("USERTOKEN", userToken);
                            response.CallStatus = true;
                            response.FullName = "Richard Morris";
                        }
                    }
                    catch (Exception e)
                    {
                        response.CallStatus = false;
                        response.ErrorMessage = e.Message;
                    }
                }
                catch (Exception e)
                {
                    response.CallStatus = false;
                    response.ErrorMessage = e.Message;
                }
            }
            catch (Exception e)
            {
                response.CallStatus = false;
                response.ErrorMessage = e.Message;
            }

            Session["LoginState"] = response.CallStatus;
            Session["ErrorMessage"] = response.ErrorMessage;

            //return response
            return response;
        }

        /// <summary>
        /// allow client to force a disconnect
        /// </summary>
        /// <returns>UserScheduleResponse</returns>
        [System.Web.Services.WebMethod(EnableSession = true,MessageName = "DisconnectDetails")]
        public DisconnectResponse Disconnect()
        {
            DisconnectResponse response = new DisconnectResponse();

            try
            {
                validateLogin();

                //must be valid and logged in, so disconnect
                xfsp.disconnect();
                Session["XFSP"] = null;
                Session["LoginState"] = false;
                Session["ErrorMessage"] = "Client disconnected";
                response.CallStatus = true;

            }
            catch (Exception e)
            {
                response.CallStatus = false;
                response.ErrorMessage = e.Message;
            }

            return response;

        }

        /// <summary>
        /// Return the users schedule
        /// </summary>
        /// <returns>UserScheduleResponse</returns>
        [System.Web.Services.WebMethod(EnableSession = true,MessageName = "ScheduleDetails")]
        public UserScheduleResponse UserSchedule()
        {
            //create a new 
            UserScheduleResponse response = new UserScheduleResponse();
            string userToken = (string)Session["USERTOKEN"];

            try
            {
                validateLogin();
                ChronoTrack.UserDT udt = new ChronoTrack.UserDT();
                xfsp.GetUserTable(userToken, ref udt);
                response.UserScheduleTable = udt;
                response.CallStatus = true;
            }
            catch (Exception e)
            {
                response.CallStatus = false;
                response.ErrorMessage = e.Message;
            }
            return response;
        }

        /// <summary>
        /// Return the projects
        /// </summary>
        /// <returns></returns>
        [System.Web.Services.WebMethod(EnableSession = true, MessageName = "RequestDetails")]
        public RequestResponse Requests(DateTime date, string resource)
        {
            //create a new project response
            RequestResponse response = new RequestResponse();
            string userToken = (string)Session["USERTOKEN"];
            try
            {
                validateLogin();
                ChronoTrack.RequestDT rdt = new ChronoTrack.RequestDT();
                xfsp.GetRequestTable(userToken, ref rdt, date, "", resource);

                response.RequestDataTable = rdt;
                response.CallStatus = true;
            }
            catch (Exception e)
            {
                response.CallStatus = false;
                response.ErrorMessage = e.Message;
            }
            return response;
        }

        [System.Web.Services.WebMethod(EnableSession = true, MessageName = "ProjectDetails")]
        public ProjectResponse Projects(string customer, DateTime date, string consultant, ProjectStatus status)
        {
            //create a new project response
            ProjectResponse response = new ProjectResponse();
            string userToken = (string)Session["USERTOKEN"];
            try
            {
                validateLogin();
                ChronoTrack.ProjectDT pdt = new ChronoTrack.ProjectDT();
                xfsp.GetProjectTable(userToken, ref pdt, customer, date, consultant);
                //now we need to remove the projects without the required status
                if (status != ProjectStatus.All)
                {
                    //selective status
                    int iStatus = (int)status;
                    foreach (DataRow row in pdt.Rows)
                    {
                        if ((int)row["Current_status"] != iStatus)
                        {
                            row.Delete();
                        }
                    }
                    pdt.AcceptChanges();
                }
                response.ProjectDataTable = pdt;
                response.CallStatus = true;
            }
            catch (Exception e)
            {
                response.CallStatus = false;
                response.ErrorMessage = e.Message;
            }
            return response;
        }

        [System.Web.Services.WebMethod(EnableSession = true, MessageName = "ProjectSummaryDetails")]
        public ProjectSummaryResponse ProjectSummary(string consultant, DateTime date)
        {
            //create a new project response
            ProjectSummaryResponse response = new ProjectSummaryResponse();
            string userToken = (string)Session["USERTOKEN"];

            try
            {
                validateLogin();
                ChronoTrack.Project_combinedDT pdt = new ChronoTrack.Project_combinedDT();
                xfsp.GetProjectTableCombined(userToken, ref pdt, "", date, consultant);
                response.ProjectDataTableCombined = pdt;
                response.CallStatus = true;
            }
            catch (Exception e)
            {
                response.CallStatus = false;
                response.ErrorMessage = e.Message;
            }

            return response;
        }

        [System.Web.Services.WebMethod(EnableSession = true, MessageName = "ProjectNotesCreateResponse")]
        public BaseResponse CreateProjectNote(int projectID, string description, string text)
        {
            BaseResponse response = new BaseResponse();
            string userToken = (string)Session["USERTOKEN"];

            try
            {
                validateLogin();
                ChronoTrack.Project_note note = new ChronoTrack.Project_note();
                note.Project_id = projectID;
                note.Description = description;
                note.Text = text;
                response.CallStatus = xfsp.CreateNote(userToken, ref note);
            }
            catch (Exception e)
            {
                response.CallStatus = false;
                response.ErrorMessage = e.Message;
            }

            return response;

        }

        [System.Web.Services.WebMethod(EnableSession = true, MessageName = "ProjectNoteDetails")]
        public ProjectNotesResponse ProjectNotes(int projectID)
        {
            ProjectNotesResponse response = new ProjectNotesResponse();
            string userToken = (string)Session["USERTOKEN"];

            try
            {
                validateLogin();
                ChronoTrack.Project_noteDT ndt = new ChronoTrack.Project_noteDT();
                xfsp.GetProjectNoteTable(userToken, projectID, ref ndt);
                response.ProjectNotesDataTable = ndt;
                response.CallStatus = true;
            }
            catch (Exception e)
            {
                response.CallStatus = false;
                response.ErrorMessage = e.Message;
            }

            return response;

        }


        #region private methods

        private void connectToServer()
        {
            try
            {
                //connect through to the ChronoTrack server
                xfsp.connect("localhost", 2365);

                //if we get a connection, keep it!!
                Session["XFSP"] = xfsp;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void validateLogin()
        {
            try
            {
                if (!(bool)Context.Session["LoginState"])
                    throw new Exception("Login failed");
                xfsp = (ChronoTrack.ChronoTrack)Session["XFSP"];
                if (xfsp == null)
                    throw new Exception("No server connection established");
            }
            catch (Exception)
            {
                throw;
            }
            return;
        }

        #endregion
    }
}
