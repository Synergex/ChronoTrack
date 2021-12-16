<%@ Page Title="ChronoTrack: New Contract" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="NewContract.aspx.cs" Inherits="customer_NewContract" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="~/controls/selectors/CustomerCombo.ascx" tagname="CustomerCombo" tagprefix="uc1" %>
<%@ Register src="~/controls/selectors/ContactCombo.ascx" tagname="ContactCombo" tagprefix="uc2" %>
<%@ Register src="~/controls/selectors/UserCombo.ascx" tagname="UserCombo" tagprefix="uc3" %>
<%@ Register src="~/controls/fields/ContractId.ascx" tagname="ContractId" tagprefix="uc4" %>
<%@ Register src="~/controls/fields/DateField.ascx" tagname="DateField" tagprefix="uc5" %>
<%@ Register src="~/controls/fields/DocumentName.ascx" tagname="DocumentName" tagprefix="uc6" %>
<%@ Register src="~/controls/buttons/OkButton.ascx" tagname="OkButton" tagprefix="uc7" %>
<%@ Register src="~/controls/buttons/CancelButton.ascx" tagname="CancelButton" tagprefix="uc8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlNewContract" runat="server" Width="850px" HeaderText="New Customer Contract">
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
                                <dxe:ASPxLabel ID="lblContractId" runat="server" Text="Contract ID">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc4:ContractId ID="txtContractId" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblIssuedBy" runat="server" Text="Issued By">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc3:UserCombo ID="ucIssuedBy" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblIssuedDate" runat="server" Text="Date Issued">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc5:DateField ID="dteIssuedDate" runat="server" Enabled="false" OnDateChanged="dteIssuedDate_DateChanged" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblSignedBy" runat="server" Text="Signed By">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc2:ContactCombo ID="ucSignedBy" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblSignedDate" runat="server" Text="Date Signed">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc5:DateField ID="dteSignedDate" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <dxe:ASPxLabel ID="lblDocument" runat="server" Text="Document">
                                </dxe:ASPxLabel>
                            </td>
                            <td>
                                <uc6:DocumentName ID="txtDocument" runat="server" Enabled="false" />
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
                                        <uc7:OkButton ID="btnOK" runat="server" onclick="btnOK_Click" />
                                    </td>
                                    <td>
                                        <uc8:CancelButton ID="btnCancel" runat="server" onclick="btnCancel_Click" />
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
</asp:Content>

