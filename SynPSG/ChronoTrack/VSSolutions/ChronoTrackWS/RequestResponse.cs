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
    public class RequestResponse : BaseResponse
    {
        private ChronoTrack.RequestDT mRequestDataTable;

        public RequestResponse()
        {
            mRequestDataTable = new ChronoTrack.RequestDT();
        }

        public DataTable RequestDataTable
        {
            get { return mRequestDataTable; }
            set { mRequestDataTable = (ChronoTrack.RequestDT)value; }
        }
    }
}
