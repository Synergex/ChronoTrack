using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace ChronoTrackWS
{
    public class ProjectNotesResponse : BaseResponse
    {
        private ChronoTrack.Project_noteDT mProjectNotesDataTable;

        public ProjectNotesResponse()
        {
            mProjectNotesDataTable = new ChronoTrack.Project_noteDT();
        }

        public DataTable ProjectNotesDataTable
        {
            get { return mProjectNotesDataTable; }
            set { mProjectNotesDataTable = (ChronoTrack.Project_noteDT)value; }
        }

    }
}
