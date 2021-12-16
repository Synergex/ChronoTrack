<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Unavailable.aspx.cs" Inherits="Unavailable" %>

<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>ChronoTrack</title>
    <link href="App_Themes/ChronoTrackWebClient.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <p>Sorry, the ChronoTrack application is currently unavailable.</p>
    <p>
        <dxe:aspxbutton id="btnContinue" runat="server" text="Continue..." onclick="btnContinue_Click"></dxe:aspxbutton>
    </p>
    </form>
</body>
</html>