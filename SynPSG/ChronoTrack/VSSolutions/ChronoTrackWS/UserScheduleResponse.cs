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
    public class UserScheduleResponse : BaseResponse
    {
        private ChronoTrack.UserDT mUserDataTable;

        public UserScheduleResponse()
        {
            mUserDataTable=new ChronoTrack.UserDT();
        }

        public DataTable UserScheduleTable
        {
            get { return mUserDataTable; }
            set { mUserDataTable = (ChronoTrack.UserDT)value; }
        }
    }
}
