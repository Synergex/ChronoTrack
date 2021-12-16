<%@ Page Title="ChronoTrack: Request Consultant Time" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ReserveConsultant.aspx.cs" Inherits="consultant_ReserveConsultant" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="~/controls/selectors/CustomerCombo.ascx" tagname="CustomerCombo" tagprefix="uc1" %>
<%@ Register src="~/controls/selectors/ConsultantCombo.ascx" tagname="ConsultantCombo" tagprefix="uc2" %>
<%@ Register src="~/controls/selectors/LocationCombo.ascx" tagname="LocationCombo" tagprefix="uc3" %>
<%@ Register src="~/controls/selectors/ContactCombo.ascx" tagname="ContactCombo" tagprefix="uc4" %>
<%@ Register src="~/controls/selectors/CustomerProjectCombo.ascx" tagname="CustomerProjectCombo" tagprefix="uc5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlNewRequest" runat="server" HeaderText="Request Consultant Time" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:HiddenField ID="PreviousPage" runat="server" />

                        <table border="0" width="100%">
                        <tr>
                            <td style="width:120px;">
                                <dxe:ASPxLabel id="lblStartDate" runat="server" text="Start Date">
                                </dxe:ASPxLabel>
                            </td>
                            <td style="width:280px;">
                                <dxe:aspxdateedit id="dteStartDate" runat="server" autopostback="True" onvaluechanged="fldStartDate_ValueChanged" ></dxe:aspxdateedit>
                            </td>
                            <td style="width:120px;">
                                <dxe:ASPxLabel id="lblStartTime" runat="server" text="Start Time">
                                </dxe:ASPxLabel>
                            </td>
                            <td style="width:280px;">
                                <dxe:aspxdateedit id="dteStartTime" runat="server" editformat="Custom" editformatstring="t">
                                    <dropdownbutton visible="false" />
                                    <ClientSideEvents DropDown="function(s, e) { s.HideDropDown(); }" />
                                </dxe:aspxdateedit>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:120px;">
                                <dxe:ASPxLabel id="lblEndDate" runat="server" text="End Date">
                                </dxe:ASPxLabel>
                            </td>
                            <td style="width:280px;">
                                <dxe:aspxdateedit id="dteEndDate" runat="server" autopostback="True" onvaluechanged="fldEndDate_ValueChanged" ></dxe:aspxdateedit>
                            </td>
                            <td style="width:120px;">
                                <dxe:ASPxLabel id="lblEndTime" runat="server" text="End Time">
                                </dxe:ASPxLabel>
                            </td>
                            <td style="width:280px;">
                                <dxe:aspxdateedit id="dteEndTime" runat="server" editformat="Custom" editformatstring="t">
                                    <dropdownbutton visible="false" />
                                    <ClientSideEvents DropDown="function(s, e) { s.HideDropDown(); }" />
                                </dxe:aspxdateedit>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:120px;">
                                <dxe:ASPxLabel id="lblConsultant" runat="server" text="Consultant">
                                </dxe:ASPxLabel>
                            </td>
                            <td style="width:280px;">
                                <uc2:ConsultantCombo ID="ucConsultant" runat="server" Enabled="false" />
                            </td>
                            <td style="width:120px;">
                                <dxe:ASPxLabel id="LblCustomer" runat="server" text="Customer">
                                </dxe:ASPxLabel>
                            </td>
                            <td style="width:280px;">
                                <uc1:CustomerCombo ID="ucCustomer" runat="server" Enabled="false" OnSelectedIndexChanged="ucCustomer_SelectedIndexChanged" AutoPostBack="true" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width:120px;">
                                <dxe:ASPxLabel id="lblContact" runat="server" text="Contact">
                                </dxe:ASPxLabel>
                            </td>
                            <td style="width:280px;">
                                <uc4:ContactCombo ID="ucContact" runat="server" Enabled="false" />
                            </td>
                            <td style="width:120px;">
                                <dxe:ASPxLabel id="lblLocation" runat="server" text="Work At">
                                </dxe:ASPxLabel>
                            </td>
                            <td style="width:280px;">
                                <uc3:LocationCombo ID="ucLocation" runat="server" Enabled="false" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width:120px;">
                                <dxe:ASPxLabel id="lblProject" runat="server" text="Project #">
                                </dxe:ASPxLabel>
                            </td>
                            <td style="width:280px;">
                                <uc5:CustomerProjectCombo ID="ucProject" runat="server" Enabled="false" AutoPostBack="true" OnSelectedIndexChanged="ucProject_SelectedIndexChanged"  />
                            </td>
                            <td style="width:120px;">
                                <dxe:ASPxLabel id="lblAddendum" runat="server" text="Addendum #">
                                </dxe:ASPxLabel>
                            </td>
                            <td style="width:280px;">
                                <dxe:aspxspinedit id="fldAddendum" runat="server" height="21px" allownull="true" maxlength="3" minvalue="0" maxvalue="999">
                                </dxe:aspxspinedit>
                            </td>
                        </tr>
                        <tr>
                            <td style="width:120px;">
                                <dxe:ASPxLabel id="lblDescription" runat="server" text="Description">
                                </dxe:ASPxLabel>
                            </td>
                            <td colspan="3">
                                <dxe:aspxtextbox id="fldDescription" runat="server" MaxLength="60" Size="65">
                                    <ValidationSettings>
                                        <RequiredField IsRequired="True" />
                                    </ValidationSettings>
                                </dxe:aspxtextbox>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top" style="width:120px;">
                                <dxe:ASPxLabel id="lblText" runat="server" text="Detail">
                                </dxe:ASPxLabel>
                            </td>
                            <td colspan="3">
                                <dxe:ASPxMemo ID="memoText" runat="server" Enabled="false" Columns="100" Rows="7">
                                    <ValidationSettings>
                                        <RequiredField IsRequired="True" />
                                    </ValidationSettings>
                                </dxe:ASPxMemo>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" align="right">
                                <table border="0">
                                    <tr>
                                        <td>
                                            <dxe:aspxbutton id="btnOk" runat="server" text="OK" onclick="btnOk_Click" />
                                        </td>
                                        <td>
                                            <dxe:aspxbutton id="btnCancel" runat="server" text="Cancel" onclick="btnCancel_Click" CausesValidation="False" />
                                        </td>
                                        <td>
                                            <dxe:aspxbutton id="btnReset" runat="server" text="Reset" onclick="btnReset_Click" CausesValidation="False" />
                                        </td>
                                    </tr>
                                </table>
                                <dxe:ASPxLabel ID="lblErrorText" runat="server" Text="" CssClass="ErrorText">
                                </dxe:ASPxLabel>
                            </td>
                        </tr>
                        </table>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:Content>