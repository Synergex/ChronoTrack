<%@ Page Title="ChronoTrack: Add Expense" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ProjectExpense.aspx.cs" Inherits="project_ProjectExpense" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register src="../controls/fields/DateField.ascx" tagname="DateField" tagprefix="uc1" %>
<%@ Register src="../controls/selectors/ExpenseTypeCombo.ascx" tagname="ExpenseTypeCombo" tagprefix="uc2" %>
<%@ Register src="../controls/selectors/ProjectConsultantCombo.ascx" tagname="ProjectConsultantCombo" tagprefix="uc3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">

    <asp:HiddenField ID="PreviousPageUrl" runat="server" />

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="850px" HeaderText="Project Expenses">
                <PanelCollection>
                    <dxp:PanelContent ID="PanelContent1" runat="server">
                        <asp:MultiView ID="multiView" runat="server">
                            <asp:View ID="normalView" runat="server">
                                <table border="0" width="100%">
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
                                        <td colspan="4">
                                            <hr />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblExpenseDate" runat="server" Text="Expense Date">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <uc1:DateField ID="ucExpenseDate" runat="server" />
                                        </td>
                                        <td>
                                            <dxe:ASPxLabel ID="lblExpenseType" runat="server" Text="Expense Type">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <uc2:ExpenseTypeCombo ID="ucExpenseType" runat="server"  OnSelectedIndexChanged="ucExpenseType_SelectedIndexChanged" AutoPostBack="true">
                                            </uc2:ExpenseTypeCombo>
                                        </td>
                                     </tr>
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblDescription" runat="server" Text="Description">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td colspan="3">
                                            <dxe:ASPxTextBox ID="txtDescription" runat="server" MaxLength="60" Size="65" Enabled="false">
                                                <ValidationSettings>
                                                    <RequiredField IsRequired="true" ErrorText="Required" />
                                                </ValidationSettings>
                                            </dxe:ASPxTextBox>
                                        </td>
                                     </tr>
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblUnitPrice" runat="server" Text="Unit Price">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <dxe:ASPxTextBox ID="txtUnitPrice" runat="server" MaxLength="12" Size="15" Enabled="false" HorizontalAlign="Right">
                                                <ValidationSettings>
                                                    <RequiredField IsRequired="true" ErrorText="Required" />
                                                    <RegularExpression ValidationExpression="^(\d{0,9}\.\d{0,2}|\d{0,9})$" ErrorText="Invalid, use XXXXXXXXX.XX." />
                                                </ValidationSettings>
                                            </dxe:ASPxTextBox>
                                        </td>
                                        <td>
                                            <dxe:ASPxLabel ID="lblQuantity" runat="server" Text="Quantity">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <dxe:ASPxTextBox ID="txtQuantity" runat="server" MaxLength="7" Size="10" Enabled="false" HorizontalAlign="Right">
                                                <ValidationSettings>
                                                    <RequiredField IsRequired="true" ErrorText="Required" />
                                                    <RegularExpression ValidationExpression="^(\d{0,4}\.\d{0,2}|\d{0,4})$" ErrorText="Invalid, use XXXX.XX." />
                                                </ValidationSettings>
                                            </dxe:ASPxTextBox>
                                        </td>
                                     </tr>
                                    <tr>
                                        <td>
                                            <dxe:ASPxLabel ID="lblExpensedBy" runat="server" Text="Expensed By">
                                            </dxe:ASPxLabel>
                                        </td>
                                        <td>
                                            <uc3:ProjectConsultantCombo ID="ucExpensedBy" runat="server" Enabled="false" />
                                        </td>
                                        <td>
                                        </td>
                                        <td>
                                            <dxe:ASPxCheckBox ID="chkIsEstimate" runat="server" Text ="This is en estimated expense" Enabled="false">
                                            </dxe:ASPxCheckBox>
                                        </td>
                                     </tr>
                                     <tr>
                                        <td>
                                        </td>
                                        <td colspan="3">
                                            <table border="0">
                                                <tr>
                                                    <td>
                                                        <dxe:ASPxButton ID="btnOk" runat="server" Text="Add Expense" OnClick="btnOk_Click" Enabled="false">
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
                                You must select a project before you can add an expense.  Please use 
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

