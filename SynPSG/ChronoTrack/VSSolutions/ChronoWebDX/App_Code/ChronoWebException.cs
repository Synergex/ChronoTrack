using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ChronoWebException
/// </summary>
public class ChronoWebException : Exception
{
/*
    private Exception pEx;
    private string pPage;
    private string pMethod;
*/
    public Exception CaughtException { get; set; }
    public string Page { get; set; }
    public string Method { get; set; }

    public ChronoWebException(Exception ex, string page, string method)
	{
        CaughtException = ex;
        Page = page;
        Method = method;
	}

/*
    public Exception InnerException
    {
        get { return pEx; }
        set { pEx = value; }
    }
    
    public string PageName
    {
        get { return pPage; }
        set { pPage = value; }
    }

    public string MethodName
    {
        get { return pMethod; }
        set { pMethod = value; }
    }
*/
}
