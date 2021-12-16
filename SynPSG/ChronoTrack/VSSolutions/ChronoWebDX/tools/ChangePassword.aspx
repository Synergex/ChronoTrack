<%@ Page Title="ChronoTrack: Change Password" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="tools_ChangePassword" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="~/controls/fields/Password.ascx" tagname="Password" tagprefix="uc1" %>
<%@ Register src="~/controls/buttons/OkButton.ascx" tagname="OkButton" tagprefix="uc2" %>
<%@ Register src="~/controls/buttons/CancelButton.ascx" tagname="CancelButton" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlChangePassword" runat="server" HeaderText="Change Password" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:HiddenField ID="PreviousPageUrl" runat="server" />

                        <table border="0" width="100%" cellpadding="10">
                            <tr>
                                <td style="width:500px;" valign="top">
                                    <p>
                                        This page allows you to change the password that you use to log in to the
                                        ChronoTrack application.
                                    </p>
                                    <p>
                                        Changing your password here will change your password for all ChronoTrack
                                        applications that you may use.
                                    </p>
                                </td>
                                <td valign="top">
                                    <table border="0" cellpadding="10">
                                        <tr>
                                            <td>
                                                <dxe:ASPxLabel ID="lblCurrentPassword" runat="server" Text="Current Password">
                                                </dxe:ASPxLabel>
                                                <uc1:Password ID="txtCurrentPassword" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <dxe:ASPxLabel ID="lblNewPassword1" runat="server" Text="New Password">
                                                </dxe:ASPxLabel>
                                                <uc1:Password ID="txtNewPassword1" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <dxe:ASPxLabel ID="lblNewPassword2" runat="server" Text="Confirm New Password">
                                                </dxe:ASPxLabel>
                                                <uc1:Password ID="txtNewPassword2" runat="server" CustomValidation="true" OnValidation="txtNewPassword2_Validation" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table border="0">
                                                    <tr>
                                                        <td>
                                                            <uc2:OkButton ID="btnOk" runat="server" OnClick="btnOk_Click" />
                                                        </td>
                                                        <td>
                                                            <uc3:CancelButton ID="btnCancel" runat="server" OnClick="btnCancel_Click" />
                                                        </td>
                                                    </tr>
                                                </table>
                                                <dxe:ASPxLabel ID="lblErrorText" runat="server" Text="">
                                                </dxe:ASPxLabel>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table> 
                   </ContentTemplate>
                </asp:UpdatePanel>
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:Content>