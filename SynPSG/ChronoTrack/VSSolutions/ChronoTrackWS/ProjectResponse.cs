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
    public class ProjectResponse : BaseResponse
    {
        private ChronoTrack.ProjectDT mProjectDataTable;

        public ProjectResponse()
        {
            mProjectDataTable = new ChronoTrack.ProjectDT();
        }

        public DataTable ProjectDataTable
        {
            get { return mProjectDataTable; }
            set { mProjectDataTable = (ChronoTrack.ProjectDT)value; }
        }
    }
}
