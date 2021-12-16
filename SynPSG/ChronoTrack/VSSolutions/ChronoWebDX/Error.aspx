<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Error.aspx.cs" Inherits="Error" %>

<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ChronoTrack Error</title>
    <link href="App_Themes/ChronoTrackWebClient.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:panel ID="pnlErrorDetail" runat="server" Visible=false>
        <h3>Unexpected Error</h3>
        <table border="0" width="100%">
        <tr>
            <td valign="top">Page being processed</td>
            <td valign="top"><dxe:ASPxLabel id="lblPage" runat="server" /></td>
        </tr>
        <tr>
            <td valign="top">Method being called</td>
            <td valign="top"><dxe:ASPxLabel id="lblMethod" runat="server" /></td>
        </tr>
        <tr>
            <td valign="top">Error</td>
            <td valign="top"><dxe:ASPxLabel id="lblErrorText" runat="server" /></td>
        </tr>
        <tr>
            <td valign="top">Source</td>
            <td valign="top"><dxe:ASPxLabel id="lblSource" runat="server" /></td>
        </tr>
        </table>
    </asp:panel>
    <p>
        <dxe:aspxbutton id="btnContinue" runat="server" text="Continue" onclick="btnContinue_Click">
        </dxe:aspxbutton>
    </p>
    </form>
</body>
</html>
