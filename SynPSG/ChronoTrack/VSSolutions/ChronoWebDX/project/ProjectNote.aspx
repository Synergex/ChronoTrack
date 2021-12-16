<%@ Page Title="ChronoTrack: Add Note" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ProjectNote.aspx.cs" Inherits="project_ProjectNote" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">

    <asp:HiddenField ID="PreviousPageUrl" runat="server" />

    <dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="850px" HeaderText="Project Notes">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <asp:MultiView ID="multiView" runat="server">
                    <asp:View ID="normalView" runat="server">
                        <table border="0">
                            <tr>
                                <td>
                                    <dxe:ASPxLabel ID="lblProjectId" runat="server" Text="Project">
                                    </dxe:ASPxLabel>
                                </td>
                                <td>
                                    <dxe:ASPxTextBox ID="txtProjectId" runat="server" MaxLength="8" Size="10" ReadOnly="true">
                                        <ValidationSettings>
                                                <RequiredField IsRequired="True" ErrorText="Required"></RequiredField>
                                        </ValidationSettings>
                                    </dxe:ASPxTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <dxe:ASPxLabel ID="lblCustomer" runat="server" Text="Customer">
                                    </dxe:ASPxLabel>
                                </td>
                                <td>
                                    <dxe:ASPxTextBox ID="txtCustomer" runat="server" MaxLength="40" Size="45" ReadOnly="true">
                                        <ValidationSettings>
                                                <RequiredField IsRequired="True" ErrorText="Required"></RequiredField>
                                        </ValidationSettings>
                                    </dxe:ASPxTextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <dxe:ASPxLabel ID="lblSubject" runat="server" Text="Subject">
                                    </dxe:ASPxLabel>
                                </td>
                                <td>
                                    <dxe:ASPxTextBox ID="txtSubject" runat="server" MaxLength="60" Size="65">
                                        <ValidationSettings>
                                                <RequiredField IsRequired="True" ErrorText="Required"></RequiredField>
                                        </ValidationSettings>
                                    </dxe:ASPxTextBox>
                                </td>
                             </tr>
                             <tr>
                                <td valign="top">
                                    <dxe:ASPxLabel ID="lblDetails" runat="server" Text="Details">
                                    </dxe:ASPxLabel>
                                </td>
                                <td>
                                    <dxe:ASPxMemo ID="txtDetails" runat="server" Columns="70" Rows="10">
                                        <ValidationSettings>
                                                <RequiredField IsRequired="True" ErrorText="Required"></RequiredField>
                                        </ValidationSettings>
                                    </dxe:ASPxMemo>
                                </td>
                             </tr>
                             <tr>
                                <td>
                                </td>
                                <td align="right">
                                    <table border="0">
                                        <tr>
                                            <td>
                                                <dxe:ASPxButton ID="btnOk" runat="server" Text="Add Note" OnClick="btnOk_Click">
                                                </dxe:ASPxButton>
                                            </td>
                                            <td>
                                                <dxe:ASPxButton ID="btnCancel" runat="server" Text="Cancel" CausesValidation="false" OnClick="btnCancel_Click">
                                                </dxe:ASPxButton>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                             </tr>
                        </table>
                    </asp:View>
                    <asp:View ID="errorView" runat="server">
                        You must select a project before you can add a note.  Please use 
                        <dxe:ASPxHyperLink ID="ASPxHyperLink1" runat="server" Text="My Projects" NavigateUrl="~/project/MyProjects.aspx">
                        </dxe:ASPxHyperLink>
                         to select a project.
                    </asp:View>
                </asp:MultiView>
            
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>

</asp:Content>

