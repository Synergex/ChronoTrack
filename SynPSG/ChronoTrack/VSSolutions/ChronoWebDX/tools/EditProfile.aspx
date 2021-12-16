<%@ Page Title="ChronoTrack: Edit Profile" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="EditProfile.aspx.cs" Inherits="tools_EditProfile" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="~/controls/selectors/StateCombo.ascx" tagname="StateCombo" tagprefix="uc1" %>
<%@ Register src="~/controls/selectors/CountryCombo.ascx" tagname="CountryCombo" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlProfile" runat="server" HeaderText="Edit User Profile" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:HiddenField ID="PreviousPage" runat="server" />

                        <table border="0" width="100%" cellpadding="10">
                            <tr>
                                <td style="width:400px;" valign="top">
                                    <p>
                                        This page allows you to change your contact details within the ChronoTrack application.
                                    </p>
                                    <p>
                                        Changes you make here update your contact details for all ChronoTrack
                                        applications that you may use.
                                    </p>
                                </td>
                                <td valign="top">
                                    <table border="0" cellpadding="10">
                                        <tr>
                                            <td>
                                                <dxe:ASPxLabel ID="lblAddress1" runat="server" Text="Address">
                                                </dxe:ASPxLabel>
                                            </td>
                                            <td>
                                                <dxe:ASPxTextBox ID="txtAddress1" runat="server" MaxLength="30" Size="35">
                                                    <ValidationSettings>
                                                        <RequiredField IsRequired="true" ErrorText="Required" />
                                                    </ValidationSettings>
                                                </dxe:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td>
                                                <dxe:ASPxTextBox ID="txtAddress2" runat="server" MaxLength="30" Size="35">
                                                </dxe:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <dxe:ASPxLabel ID="lblCity" runat="server" Text="City">
                                                </dxe:ASPxLabel>
                                            </td>
                                            <td>
                                                <dxe:ASPxTextBox ID="txtCity" runat="server" MaxLength="30" Size="35">
                                                    <ValidationSettings>
                                                        <RequiredField IsRequired="true" ErrorText="Required" />
                                                    </ValidationSettings>
                                                </dxe:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td>
                                                <dxe:ASPxTextBox ID="txtAddress4" runat="server" MaxLength="30" Size="35">
                                                </dxe:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <dxe:ASPxLabel ID="lblState" runat="server" Text="State">
                                                </dxe:ASPxLabel>
                                            </td>
                                            <td>
                                                <uc1:StateCombo ID="ucState" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <dxe:ASPxLabel ID="lblZip" runat="server" Text="Zip Code">
                                                </dxe:ASPxLabel>
                                            </td>
                                            <td>
                                                <dxe:ASPxTextBox ID="txtZipCode" runat="server" MaxLength="10" Size="13">
                                                    <ValidationSettings>
                                                        <RequiredField IsRequired="true" ErrorText="Required" />
                                                    </ValidationSettings>
                                                </dxe:ASPxTextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <dxe:ASPxLabel ID="lblCountry" runat="server" Text="Country">
                                                </dxe:ASPxLabel>
                                            </td>
                                            <td>
                                                <uc2:CountryCombo ID="ucCountry" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>&nbsp;</td>
                                            <td>
                                                <table border="0">
                                                    <tr>
                                                        <td>
                                                            <dxe:ASPxButton ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click">
                                                            </dxe:ASPxButton>
                                                        </td>
                                                        <td>
                                                            <dxe:ASPxButton ID="btnCancel" runat="server" Text="Cancel" CausesValidation="false" OnClick="btnCancel_Click">
                                                            </dxe:ASPxButton>
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