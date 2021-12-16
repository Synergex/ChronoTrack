<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProjectMasterTable.ascx.cs" Inherits="project_controls_ProjectMasterTable" %>

<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<table border="0" width="100%">
    <tr>
        <td>
            <dxe:ASPxLabel ID="lblProjectCombo" runat="server" Text="Customer">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxComboBox ID="cboProjectId" runat="server" textfield="Customer_name" valuefield="Project_id" ValueType="System.Int32" onselectedindexchanged="cboProjectId_SelectedIndexChanged" AutoPostBack="true">
            </dxe:ASPxComboBox>
        </td>
        <td>
            <dxe:ASPxLabel ID="lblProjectId" runat="server" Text="Project">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxTextBox ID="txtProject" runat="server" MaxLength="8" Size="10" ReadOnly="true">
                <ValidationSettings>
                    <RequiredField IsRequired="true" ErrorText="Required" />
                </ValidationSettings>
            </dxe:ASPxTextBox>
        </td>
        <td>
            <dxe:ASPxLabel ID="lblStartDate" runat="server" Text="Starts">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxDateEdit ID="dteStartDate" runat="server" ReadOnly="true" Width="120px">
                <DropDownButton Enabled="False">
                </DropDownButton>
            </dxe:ASPxDateEdit>
        </td>
    </tr>
    <tr>
        <td>
            <dxe:ASPxLabel ID="lblStatus" runat="server" Text="Status">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxTextBox ID="txtStatus" runat="server" MaxLength="15" Size="20" ReadOnly="true">
                <ValidationSettings>
                    <RequiredField IsRequired="true" ErrorText="Required" />
                </ValidationSettings>
            </dxe:ASPxTextBox>
        </td>
        <td>
            <dxe:ASPxLabel ID="lblLocation" runat="server" Text="Location">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxTextBox ID="txtLocation" runat="server" MaxLength="60" Size="30" ReadOnly="true">
                <ValidationSettings>
                    <RequiredField IsRequired="true" ErrorText="Required" />
                </ValidationSettings>
            </dxe:ASPxTextBox>
        </td>
        <td>
            <dxe:ASPxLabel ID="lblEndDate" runat="server" Text="Ends">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxDateEdit ID="dteEndDate" runat="server" ReadOnly="true" Width="120px">
                <DropDownButton Enabled="False">
                </DropDownButton>
            </dxe:ASPxDateEdit>
        </td>
    </tr>
    <tr>
        <td>
            <dxe:ASPxLabel ID="lblConsultant" runat="server" Text="Consultant">
            </dxe:ASPxLabel>
        </td>
        <td>
            <dxe:ASPxTextBox ID="txtConsultant" runat="server" MaxLength="60" Size="20" ReadOnly="true">
                <ValidationSettings>
                    <RequiredField IsRequired="true" ErrorText="Required" />
                </ValidationSettings>
            </dxe:ASPxTextBox>
        </td>
        <td>
            <dxe:ASPxLabel ID="lblSubject" runat="server" Text="Task">
            </dxe:ASPxLabel>
        </td>
        <td colspan="3">
            <dxe:ASPxTextBox ID="txtSubject" runat="server" MaxLength="60" Size="60" ReadOnly="true">
                <ValidationSettings>
                    <RequiredField IsRequired="true" ErrorText="Required" />
                </ValidationSettings>
            </dxe:ASPxTextBox>
        </td>
    </tr>
</table>
<br />