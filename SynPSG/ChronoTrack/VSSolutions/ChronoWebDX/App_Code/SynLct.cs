using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

public static class SynLct
{
    //PInvoke requires full security permissions because we are calling unmanaged code
    [DllImport("syncli_api.dll", SetLastError = true, CallingConvention=CallingConvention.Winapi)]
    static extern int win_lm_stat(string product, string application, [MarshalAs(UnmanagedType.LPArray)]int[] count, [MarshalAs(UnmanagedType.LPArray)]int[] syserr);

    [DllImport("syncli_api.dll", SetLastError = true, CallingConvention=CallingConvention.Winapi)]
    static extern int win_lm_login(string product, string application, int a3, int seat, [MarshalAs(UnmanagedType.LPArray)]int[] token, [MarshalAs(UnmanagedType.LPArray)]int[] syserr);

    [DllImport("syncli_api.dll", SetLastError = true, CallingConvention=CallingConvention.Winapi)]
    static extern int win_lm_logout(string product, string application, int seat, int token, [MarshalAs(UnmanagedType.LPArray)]int[] syserr);

    public static int LicenseUsageSnapshot(string producerCode, string productCode)
    {
        int[] error = new int[1];
        int rslt;
        int[] count = new int[1];
        if ((rslt = win_lm_stat(producerCode, productCode, count, error)) != 0)
            reportError("Status", rslt, error[0]);
        return count[0];
    }

    /// <summary>
    /// log in to lct
    /// </summary>
    /// <returns>login token</returns>
    public static int AllocateLicense(string producerCode, string productCode, int seat)
    {
        int[] error = new int[1];
        int rslt;
        int[] token = new int[1];
        if ((rslt = win_lm_login(producerCode, productCode, 0, seat, token, error)) != 0)
            reportError("Login", rslt, error[0]);
        return token[0];
    }

    public static void DeallocateLicense(string producerCode, string productCode, int seat, int token)
    {
        int[] error = new int[1];
        int rslt;
        if ((rslt = win_lm_logout(producerCode, productCode, seat, token, error)) != 0)
            reportError("Logout", rslt, error[0]);
    }

    private static void reportError(string currentOperation, int errorNumber, int systemError)
    {
        throw new ApplicationException(string.Format("Logout error = {0} System error = {1}\n", errorNumber, systemError));
    }
}
