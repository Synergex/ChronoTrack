<%@ Page Title="ChronoTrack: New Location" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="NewLocation.aspx.cs" Inherits="customer_NewLocation" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="~/controls/selectors/CustomerCombo.ascx" tagname="CustomerCombo" tagprefix="uc1" %>
<%@ Register src="~/controls/selectors/StateCombo.ascx" tagname="StateCombo" tagprefix="uc2" %>
<%@ Register src="~/controls/selectors/CountryCombo.ascx" tagname="CountryCombo" tagprefix="uc3" %>
<%@ Register src="~/controls/fields/LocationName.ascx" tagname="LocationName" tagprefix="uc4" %>
<%@ Register src="~/controls/fields/Address1Street.ascx" tagname="Address1Street" tagprefix="uc5" %>
<%@ Register src="~/controls/fields/Address2Street.ascx" tagname="Address2Street" tagprefix="uc6" %>
<%@ Register src="~/controls/fields/Address3City.ascx" tagname="Address3City" tagprefix="uc7" %>
<%@ Register src="~/controls/fields/Address4Region.ascx" tagname="Address4Region" tagprefix="uc8" %>
<%@ Register src="~/controls/fields/AddressZipCode.ascx" tagname="AddressZipCode" tagprefix="uc9" %>
<%@ Register src="~/controls/fields/PhoneNumber.ascx" tagname="PhoneNumber" tagprefix="uc10" %>
<%@ Register src="~/controls/buttons/OkButton.ascx" tagname="OkButton" tagprefix="uc11" %>
<%@ Register src="~/controls/buttons/CancelButton.ascx" tagname="CancelButton" tagprefix="uc12" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlNewLocation" runat="server" Width="850px" HeaderText="New Customer Location">
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
                                <uc1:CustomerCombo ID="ucCustomer" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ucCustomer_SelectedIndexChanged" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblDescription" runat="server" Text="Description">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc4:LocationName ID="txtDescription" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblAddress1" runat="server" Text="Address">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc5:Address1Street ID="txtAddress1" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                <uc6:Address2Street ID="txtAddress2" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblCity" runat="server" Text="City">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc7:Address3City ID="txtCity" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblState" runat="server" Text="State">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc2:StateCombo ID="ucState" runat="server" Enabled="false" />
                                <uc8:Address4Region ID="txtRegion" runat="server" Visible="False" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblZip" runat="server" Text="Zip Code">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc9:AddressZipCode ID="txtZip" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblCountry" runat="server" Text="Country">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc3:CountryCombo ID="ucCountry" runat="server" Enabled="false" AutoPostBack="true" OnSelectedIndexChanged="ucCountry_SelectedIndexChanged" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblPhone" runat="server" Text="Main Phone #">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc10:PhoneNumber ID="txtPhone" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                <table border="0">
                                <tr>
                                    <td><uc11:OkButton ID="btnOK" runat="server" Enabled="false" onclick="btnOK_Click" /></td>
                                    <td><uc12:CancelButton ID="btnCancel" runat="server" onclick="btnCancel_Click" /></td>
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
