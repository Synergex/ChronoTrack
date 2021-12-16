using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChronoMobile
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        #region public members

        //this is our ChronoTrack web service object!
        public static SessionRemoteService ws;

        //create the response classes from the web service
        public static ChronoTrackWS.ProjectNotesResponse notes;
        public static ChronoTrackWS.ValidateUserResponse userResponse;
        public static ChronoTrackWS.ProjectResponse projects;
        public static ChronoTrackWS.ProjectSummaryResponse combinedProjectView;
        public static int selectedProjectIndex;

        //store the user details
        public static string userName;
        public static string password;

        //general project statuses
        public enum ProjectViewStatus
        {
            New,
            Current,
            Old
        }
        public static ProjectViewStatus currentListStatus;

        #endregion

        [MTAThread]
        static void Main()
        {
            Application.Run(new FormMain());
        }
    }
}