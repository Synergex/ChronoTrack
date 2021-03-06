<%@ Page Title="ChronoTrack: Task" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ProjectTask.aspx.cs" Inherits="project_ProjectTask" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>

<%@ Register src="../controls/selectors/ProjectConsultantCombo.ascx" tagname="ProjectConsultantCombo" tagprefix="uc1" %>
<%@ Register src="../controls/fields/DateField.ascx" tagname="DateField" tagprefix="uc2" %>
<%@ Register src="../controls/fields/TimeField.ascx" tagname="TimeField" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <asp:HiddenField ID="PreviousPageUrl" runat="server" />

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="850px" HeaderText="Project Task">
                <PanelCollection>
                    <dxp:PanelContent ID="PanelContent1" runat="server">
                        <asp:MultiView ID="multiView" runat="server">
                            <asp:View ID="normalView" runat="server">
                                <table border="0" width="100%">
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblTaskType" runat="server" Text="Type">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <dxe:ASPxComboBox ID="cboTaskType" runat="server" ValueType="System.Int32" SelectedIndex="1">
                                                <Items>
                                                    <dxe:ListEditItem Text="Pre-project" Value="0" />
                                                    <dxe:ListEditItem Text="Implementation" Value="1" />
                                                    <dxe:ListEditItem Text="Post-project" Value="2" />
                                                </Items>
                                            </dxe:ASPxComboBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblDescription" runat="server" Text="Description">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <dxe:ASPxTextBox ID="txtDescription" runat="server" Width="170px">
                                            </dxe:ASPxTextBox>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblAssignedTo" runat="server" Text="Assigned to">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <uc1:ProjectConsultantCombo ID="cboAssignedTo" runat="server"></uc1:ProjectConsultantCombo>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblStartDate" runat="server" Text="Start Date">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <uc2:DateField ID="ucStartDate" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblStartTime" runat="server" Text="Start Time">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <uc3:TimeField ID="ucStartTime" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblEndDate" runat="server" Text="End Date">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <uc2:DateField ID="ucEndDate" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblEndTime" runat="server" Text="End Time">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <uc3:TimeField ID="ucEndTime" runat="server" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblDetail" runat="server" Text="Detail">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <dxe:ASPxMemo ID="txtDetail" runat="server" Rows="10" Columns="70">
                                                <ValidationSettings>
                                                    <RequiredField IsRequired="true" ErrorText="Required" />
                                                </ValidationSettings>
                                            </dxe:ASPxMemo>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                        </td>
                                        <td>
                                            <table border="0">
                                                <tr>
                                                    <td>
                                                        <dxe:ASPxButton ID="btnOk" runat="server" Text="Add Task" OnClick="btnOk_Click">
                                                        </dxe:ASPxButton>
                                                    </td>
                                                    <td>
                                                        <dxe:ASPxButton ID="btnCancel" runat="server" Text="Cancel" CausesValidation="False" OnClick="btnCancel_Click">
                                                        </dxe:ASPxButton>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </asp:View>
                            <asp:View ID="errorView" runat="server">
                                You must select a project before you can add a task.  Please use 
                                <dxe:ASPxHyperLink ID="ASPxHyperLink1" runat="server" Text="My Projects" NavigateUrl="~/project/MyProjects.aspx">
                                </dxe:ASPxHyperLink>
                                 to select a project.
                            </asp:View>
                        </asp:MultiView>
                    </dxp:PanelContent>
                </PanelCollection>
            </dxrp:ASPxRoundPanel>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

