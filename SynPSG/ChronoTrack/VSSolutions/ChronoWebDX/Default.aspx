<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ChronoTrack</title>
    <link href="App_Themes/ChronoTrackWebClient.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
        <table border="0" align="center">
            <tr>
                <td>
                    <dxe:ASPxImage ID="ASPxImage1" runat="server" ImageUrl="~/images/desktop_image.jpg">
                    </dxe:ASPxImage>
                </td>
            </tr>
            <tr>
                <td style="height:40px;">
                </td>
            </tr>
            <tr>
                <td>
                    <table border="0" align="center">
                    <tr>
                        <td>
                            <dxe:aspxlabel id="lblUsername" runat="server" text="User">
                            </dxe:aspxlabel>
                        </td>
                        <td>
                            <dxe:aspxtextbox id="txtUsername" runat="server" maxlength="15" Size="20">
                                <validationsettings>
                                    <requiredfield errortext="Required" isrequired="True" />
                                </validationsettings>
                            </dxe:aspxtextbox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dxe:aspxlabel id="lblPassword" runat="server" text="Password" >
                            </dxe:aspxlabel>
                        </td>
                        <td>
                            <dxe:aspxtextbox id="txtPassword" runat="server" maxlength="15" Size="20" password="True">
                                <validationsettings>
                                    <requiredfield errortext="Required" isrequired="True" />
                                </validationsettings>
                            </dxe:aspxtextbox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <table border="0">
                            <tr>
                                <td>
                                    <dxe:ASPxButton id="btnLogin" runat="server" text="Login" onclick="btnLogin_Click" />
                                </td>
                                <td>
                                    <dxe:ASPxButton ID="btnCheat" runat="server" Text="Cheat" CausesValidation="False" onclick="btnCheat_Click" />
                                </td>
                            </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <dxe:ASPxLabel ID="fldLoginError" runat="server" CssClass="ErrorText" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <dxe:ASPxCheckBox ID="chkDebugServer" runat="server" Text="Use debug server" Visible="false">
                            </dxe:ASPxCheckBox>
                        </td>
                    </tr>
                    </table>
                </td>
            </tr>
        </table>
    
    </form>
</body>
</html>
