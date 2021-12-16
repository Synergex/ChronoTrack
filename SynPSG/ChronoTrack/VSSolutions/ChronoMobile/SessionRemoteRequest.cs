using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace ChronoMobile
{
    class SessionRemoteService : ChronoTrackWS.RemoteService // Extends xfpl-enabled web service
    {
        private static string cookie = null;  // Variable to hold session cookie, if available

        protected override WebResponse GetWebResponse(WebRequest req)
        {
            // Check response for a session cookie, and store it if present
            HttpWebResponse rep = (HttpWebResponse)base.GetWebResponse(req);
            if (rep.Headers["Set-Cookie"] != null) { cookie = rep.Headers["Set-Cookie"]; }
            return rep;
        }
        protected override WebRequest GetWebRequest(Uri uri)
        {
            // If a session cookie is used, add it to the request header
            HttpWebRequest req = (HttpWebRequest)base.GetWebRequest(uri);
            if (cookie != null) { req.Headers.Add("Cookie", cookie); }
            return req;
        }
    }
}
