<%@ Page Title="ChronoTrack: Add Customer" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="NewCustomer.aspx.cs" Inherits="customer_NewCustomer" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register src="~/controls/selectors/StateCombo.ascx" tagname="StateCombo" tagprefix="uc1" %>
<%@ Register src="~/controls/selectors/CountryCombo.ascx" tagname="CountryCombo" tagprefix="uc2" %>
<%@ Register src="~/controls/fields/EmailAddress.ascx" tagname="EmailAddress" tagprefix="uc3" %>
<%@ Register src="~/controls/buttons/OkButton.ascx" tagname="OkButton" tagprefix="uc4" %>
<%@ Register src="~/controls/buttons/CancelButton.ascx" tagname="CancelButton" tagprefix="uc5" %>
<%@ Register src="~/controls/fields/PhoneNumber.ascx" tagname="PhoneNumber" tagprefix="uc6" %>
<%@ Register src="~/controls/fields/JobTitle.ascx" tagname="JobTitle" tagprefix="uc7" %>
<%@ Register src="~/controls/fields/FirstName.ascx" tagname="FirstName" tagprefix="uc8" %>
<%@ Register src="~/controls/fields/LastName.ascx" tagname="LastName" tagprefix="uc9" %>
<%@ Register src="~/controls/fields/CustomerId.ascx" tagname="CustomerId" tagprefix="uc10" %>
<%@ Register src="~/controls/fields/CompanyName.ascx" tagname="CompanyName" tagprefix="uc11" %>
<%@ Register src="~/controls/fields/LocationName.ascx" tagname="LocationName" tagprefix="uc12" %>
<%@ Register src="~/controls/fields/Address1Street.ascx" tagname="Address1Street" tagprefix="uc13" %>
<%@ Register src="~/controls/fields/Address2Street.ascx" tagname="Address2Street" tagprefix="uc14" %>
<%@ Register src="~/controls/fields/Address3City.ascx" tagname="Address3City" tagprefix="uc15" %>
<%@ Register src="~/controls/fields/Address4Region.ascx" tagname="Address4Region" tagprefix="uc16" %>
<%@ Register src="~/controls/fields/AddressZipCode.ascx" tagname="AddressZipCode" tagprefix="uc17" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlNewCustomer" runat="server" Width="850px" HeaderText="Create New Customer Account">
        <PanelCollection>
            <dxrp:PanelContent>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <table border="0" width="100%">
                        <tr>
                            <td valign="top" style="width:180px;">
                                <!--Customer account details-->
                                <dxe:ASPxLabel ID="lblAccountDetails" style="font-size:14pt;" runat="server" Text="Account Details">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <table width="100%">
                                    <tr>
                                        <td style="width:130px;">
                                            <dxe:aspxlabel id="lblCustomerId" runat="server" text="Customer ID">
                                            </dxe:aspxlabel>
                                        </td>
                                        <td>
                                            <uc10:CustomerId ID="txtCustomerId" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:aspxlabel id="lblCompanyName" runat="server" text="Company">
                                            </dxe:aspxlabel>
                                        </td>
                                        <td>
                                            <uc11:CompanyName ID="txtCompanyName" runat="server" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <!--Customer primary location details-->
                                <dxe:ASPxLabel ID="lblPrimaryLocation" style="font-size:14pt;" runat="server" Text="Primary Location">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <table width="100%">
                                    <tr>
                                        <td style="width:130px;">
                                            <dxe:aspxlabel id="lblDescription" runat="server" text="Description">
                                            </dxe:aspxlabel>
                                        </td>
                                        <td>
                                            <uc12:LocationName ID="txtDescription" runat="server" Text="Head Office" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:aspxlabel id="lblAddress" runat="server" text="Address">
                                            </dxe:aspxlabel>
                                        </td>
                                        <td>
                                            <uc13:Address1Street ID="txtAddress1" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td>
                                            <uc14:Address2Street ID="txtAddress2" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:aspxlabel id="lblCity" runat="server" text="City">
                                            </dxe:aspxlabel>
                                        </td>
                                        <td>
                                            <uc15:Address3City ID="txtCity" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:aspxlabel id="lblState" runat="server" text="State">
                                            </dxe:aspxlabel>
                                        </td>
                                        <td>
                                            <uc1:StateCombo ID="ucState" runat="server" />
                                            <uc16:Address4Region ID="txtRegion" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:aspxlabel id="lblZip" runat="server" text="Zip Code">
                                            </dxe:aspxlabel>
                                        </td>
                                        <td>
                                            <uc17:AddressZipCode ID="txtZip" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:aspxlabel id="lblCountry" runat="server" text="Country">
                                            </dxe:aspxlabel>
                                        </td>
                                        <td>
                                            <uc2:CountryCombo ID="ucCountry" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ucCountry_SelectedIndexChanged" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:aspxlabel id="lblPhone" runat="server" text="Phone">
                                            </dxe:aspxlabel>
                                        </td>
                                        <td>
                                            <uc6:PhoneNumber ID="txtPhone" runat="server" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <!--Admin contact details-->
                                <dxe:ASPxLabel ID="lblAdminContact" style="font-size:14pt;" runat="server" Text="Admin Contact">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <dxe:aspxcheckbox id="chkAdminContact" runat="server" text="Also create admin contact" checked="true" autopostback="true" oncheckedchanged="chkAdminContact_CheckedChanged">
                                </dxe:aspxcheckbox>
                                <dxp:ASPxPanel ID="pnlAdminContact" runat="server">
                                    <panelcollection>
                                        <dxp:panelcontent>
                                        <table width="100%">
                                            <tr>
                                                <td style="width:130px;">
                                                    <dxe:aspxlabel id="lblAdminFirstName" runat="server" text="First Name">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc8:FirstName ID="txtAdminFirstName" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dxe:aspxlabel id="lblAdminLastName" runat="server" text="Last Name">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc9:LastName ID="txtAdminLastName" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dxe:aspxlabel id="lblAdminJobTitle" runat="server" text="Job Title">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc7:JobTitle ID="txtAdminJobTitle" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dxe:aspxlabel id="lblAdminOfficePhone" runat="server" text="Office Phone">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc6:PhoneNumber ID="txtAdminOfficePhone" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dxe:aspxlabel id="lblAdminMobilePhone" runat="server" text="Mobile Phone">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc6:PhoneNumber ID="txtAdminMobilePhone" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dxe:aspxlabel id="lblAdminEmail" runat="server" text="Email">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc3:EmailAddress ID="txtAdminEmail" runat="server" />
                                                </td>
                                            </tr>
                                        </table>
                                        </dxp:panelcontent>
                                    </panelcollection>
                                </dxp:ASPxPanel>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <!--Technical contact details-->
                                <dxe:ASPxLabel ID="lblTechContact" style="font-size:14pt;" runat="server" Text="Technical Contact">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <dxe:aspxcheckbox id="chkTechContact" runat="server" text="Also create technical contact" checked="true" autopostback="True" oncheckedchanged="chkTechContact_CheckedChanged" >
                                </dxe:aspxcheckbox>
                                <dxp:ASPxPanel id="pnlTechContact" runat="server" headertext="Technical Contact (Optional)" width="100%">
                                    <panelcollection>
                                        <dxp:panelcontent>
                                        <table width="100%">
                                            <tr>
                                                <td style="width:130px;">
                                                    <dxe:aspxlabel id="lblTechFirstName" runat="server" text="First Name">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc8:FirstName ID="txtTechFirstName" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dxe:aspxlabel id="lblTechLastName" runat="server" text="Last Name">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc9:LastName ID="txtTechLastName" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dxe:aspxlabel id="lblTechJobTitle" runat="server" text="Job Title">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc7:JobTitle ID="txtTechJobTitle" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dxe:aspxlabel id="lblTechOfficePhone" runat="server" text="Office Phone">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc6:PhoneNumber ID="txtTechOfficePhone" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dxe:aspxlabel id="lblTechMobilePhone" runat="server" text="Mobile Phone">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc6:PhoneNumber ID="txtTechMobilePhone" runat="server" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <dxe:aspxlabel id="lblTechEmail" runat="server" text="Email">
                                                    </dxe:aspxlabel>
                                                </td>
                                                <td>
                                                    <uc3:EmailAddress ID="txtTechEmail" runat="server" />
                                                </td>
                                            </tr>
                                        </table>
                                        </dxp:panelcontent>
                                    </panelcollection>            
                                </dxp:ASPxPanel>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td>
                                <!--Buttons-->
                                <br />
                                <table border="0" width="100%" cellpadding="8">
                                    <tr>
                                        <td align="right" style="width:100%;">
                                            &nbsp;
                                            <dxe:ASPxLabel ID="lblErrorText" runat="server" Text="" CssClass="ErrorText">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <uc4:OkButton ID="btnOK" runat="server" onclick="btnOK_Click" />
                                        </td>
                                        <td>
                                            <uc5:CancelButton ID="btnCancel" runat="server" onclick="btnCancel_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </dxrp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:content>

