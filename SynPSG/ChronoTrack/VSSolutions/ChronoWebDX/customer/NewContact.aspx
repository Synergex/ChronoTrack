<%@ Page Title="ChronoTrack: New Contact" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="NewContact.aspx.cs" Inherits="customer_NewContact" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="~/controls/selectors/CustomerCombo.ascx" tagname="CustomerCombo" tagprefix="uc1" %>
<%@ Register src="~/controls/selectors/LocationCombo.ascx" tagname="LocationCombo" tagprefix="uc2" %>
<%@ Register src="~/controls/fields/FirstName.ascx" tagname="FirstName" tagprefix="uc3" %>
<%@ Register src="~/controls/fields/LastName.ascx" tagname="LastName" tagprefix="uc4" %>
<%@ Register src="~/controls/fields/JobTitle.ascx" tagname="JobTitle" tagprefix="uc5" %>
<%@ Register src="~/controls/fields/PhoneNumber.ascx" tagname="PhoneNumber" tagprefix="uc6" %>
<%@ Register src="~/controls/fields/EmailAddress.ascx" tagname="EmailAddress" tagprefix="uc7" %>
<%@ Register src="~/controls/buttons/OkButton.ascx" tagname="OkButton" tagprefix="uc8" %>
<%@ Register src="~/controls/buttons/CancelButton.ascx" tagname="CancelButton" tagprefix="uc9" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlNewContact" runat="server" Width="850px" HeaderText="New Customer Contact">
        <PanelCollection>
            <dxrp:PanelContent>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table border="0">
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblCustomerId" runat="server" Text="Customer">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc1:CustomerCombo ID="ucCustomer" runat="server" OnSelectedIndexChanged="ucCustomer_SelectedIndexChanged" AutoPostBack="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblFirstName" runat="server" Text="First Name">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc3:FirstName ID="txtFirstName" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblLastName" runat="server" Text="Last Name">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc4:LastName ID="txtLastName" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblTitle" runat="server" Text="Job Title">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc5:JobTitle ID="txtJobTitle" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblLocation" runat="server" Text="Location">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc2:LocationCombo ID="ucLocation" runat="server" Enabled="false"/>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblOfficePhone" runat="server" Text="Office Phone">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc6:PhoneNumber ID="txtOfficePhone" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblMobilePhone" runat="server" Text="Mobile Pone">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc6:PhoneNumber ID="txtMobilePhone" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblEmail" runat="server" Text="Email">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc7:EmailAddress ID="txtEmail" runat="server" Enabled="False" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                <table border="0">
                                <tr>
                                    <td>
                                        <uc8:OkButton ID="btnOk" runat="server" OnClick="btnOk_Click" />
                                    </td>
                                    <td>
                                        <uc9:CancelButton ID="btnCancel" runat="server" OnClick="btnCancel_Click" />
                                    </td>
                                </tr>
                                </table>
                                <dxe:ASPxLabel ID="lblErrorText" runat="server" Text="">
                                </dxe:ASPxLabel>
                            </td>
                        </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </dxrp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
    <asp:HiddenField ID="PreviousPageUrl" runat="server" />
</asp:Content>

