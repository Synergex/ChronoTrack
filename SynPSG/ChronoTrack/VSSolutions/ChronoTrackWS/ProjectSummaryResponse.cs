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
    public class ProjectSummaryResponse : BaseResponse
    {
        private ChronoTrack.Project_combinedDT mProjectCombinedDataTable;

        public ProjectSummaryResponse()
        {
            mProjectCombinedDataTable = new ChronoTrack.Project_combinedDT();
        }

        public DataTable ProjectDataTableCombined
        {
            get { return mProjectCombinedDataTable; }
            set { mProjectCombinedDataTable = (ChronoTrack.Project_combinedDT)value; }
        }

    }
}
