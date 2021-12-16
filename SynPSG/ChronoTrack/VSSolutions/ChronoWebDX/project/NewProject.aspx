<%@ Page Title="ChronoTrack: New Project" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="NewProject.aspx.cs" Inherits="project_NewProject" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="~/controls/selectors/CustomerCombo.ascx" tagname="CustomerCombo" tagprefix="uc1" %>
<%@ Register src="~/controls/selectors/ConsultantCombo.ascx" tagname="ConsultantCombo" tagprefix="uc2" %>
<%@ Register src="~/controls/selectors/LocationCombo.ascx" tagname="LocationCombo" tagprefix="uc3" %>
<%@ Register src="~/controls/selectors/ContactCombo.ascx" tagname="ContactCombo" tagprefix="uc4" %>
<%@ Register src="~/controls/selectors/UserCombo.ascx" tagname="UserCombo" tagprefix="uc5" %>
<%@ Register src="~/controls/selectors/ContractCombo.ascx" tagname="ContractCombo" tagprefix="uc6" %>
<%@ Register src="~/controls/fields/ProjectDescription.ascx" tagname="ProjectDescription" tagprefix="uc7" %>
<%@ Register src="~/controls/fields/DateField.ascx" tagname="DateField" tagprefix="uc8" %>
<%@ Register src="~/controls/buttons/OkButton.ascx" tagname="OkButton" tagprefix="uc9" %>
<%@ Register src="~/controls/buttons/CancelButton.ascx" tagname="CancelButton" tagprefix="uc10" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>

<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlNewProject" runat="server" HeaderText="New Project" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:HiddenField ID="PreviousPage" runat="server" />

                        <!--Customer information-->
                        <table width="100%">
                            <tr>
                                <td>
                                    <dxe:aspxlabel id="lblCustomer" runat="server" text="Customer">
                                    </dxe:aspxlabel>
                                </td>
                                <td>
                                    <uc1:CustomerCombo ID="ucCustomer" runat="server" OnSelectedIndexChanged="ucCustomer_SelectedIndexChanged" AutoPostBack="true" />
                                </td>
                                <td>
                                    <dxe:aspxlabel id="lblLocation" runat="server" text="Location">
                                    </dxe:aspxlabel>
                                </td>
                                <td>
                                    <uc3:LocationCombo ID="ucLocation" runat="server" Enabled="false" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <dxe:aspxlabel id="lblContract" runat="server" text="Contract">
                                    </dxe:aspxlabel>
                                </td>
                                <td>
                                    <uc6:ContractCombo ID="ucContract" runat="server" Enabled="false" />
                                </td>
                                <td>
                                    <dxe:aspxlabel id="lblApprovedBy" runat="server" text="Approved By">
                                    </dxe:aspxlabel>
                                </td>
                                <td>
                                    <uc4:ContactCombo ID="ucApprovedBy" runat="server" Enabled="false" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <dxe:aspxlabel id="lblStartDate" runat="server" text="Start Date">
                                    </dxe:aspxlabel>
                                </td>
                                <td>
                                    <uc8:DateField ID="ucStartDate" runat="server" Enabled="false" AutoPostBack="true" OnDateChanged="ucStartDate_DateChanged" />
                                </td>
                                <td>
                                    <dxe:aspxlabel id="lblEndDate" runat="server" text="End Date">
                                    </dxe:aspxlabel>
                                </td>
                                <td>
                                    <uc8:DateField ID="ucEndDate" runat="server" Enabled="false" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <dxe:aspxlabel id="lblCoordinator" runat="server" text="Coordinator">
                                    </dxe:aspxlabel>
                                </td>
                                <td>
                                    <uc5:UserCombo ID="ucCoordinator" runat="server" Enabled="false" />
                                </td>
                                <td>
                                    <dxe:aspxlabel id="lblLeadConsultant" runat="server" text="Lead Consultant">
                                    </dxe:aspxlabel>
                                </td>
                                <td>
                                    <uc2:ConsultantCombo ID="ucLeadConsultant" runat="server" Enabled="false"/>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <dxe:aspxlabel id="lblDescription" runat="server" text="Description">
                                    </dxe:aspxlabel>
                                </td>
                                <td colspan="3">
                                    <uc7:ProjectDescription ID="ucDescription" runat="server" Enabled="false" />
                                </td>
                            </tr>
                            <tr>
                                <td valign="top">
                                    <dxe:aspxlabel id="lblDetails" runat="server" text="Details">
                                    </dxe:aspxlabel>
                                </td>
                                <td valign="top" colspan="2">
                                    <dxe:ASPxMemo ID="txtDetails" runat="server" Height="71px" Width="170px" Columns="70" Rows="10" Enabled="false">
                                        <ValidationSettings>
                                            <RequiredField IsRequired="true" ErrorText="Required" />
                                        </ValidationSettings>
                                    </dxe:ASPxMemo>
                                </td>
                                <td valign="bottom">
                                    <table border="0">
                                        <tr>
                                            <td colspan="2">
                                                <dxe:ASPxLabel ID="lblErrorText" runat="server" Text="">
                                                </dxe:ASPxLabel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <uc9:OkButton ID="btnOK" runat="server" onclick="btnOK_Click" />
                                            </td>
                                            <td>
                                                <uc10:CancelButton ID="btnCancel" runat="server" onclick="btnCancel_Click" />
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
</asp:content>

