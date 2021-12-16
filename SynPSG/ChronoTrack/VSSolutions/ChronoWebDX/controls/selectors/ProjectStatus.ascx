<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProjectStatus.ascx.cs" Inherits="controls_selectors_ProjectStatus" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<dxe:ASPxComboBox ID="cboStatus" runat="server" onselectedindexchanged="cboStatus_SelectedIndexChanged" ValueType="System.Int32" Width="120px">
    <Items>
        <dxe:ListEditItem Text="Created" Value="0" />
        <dxe:ListEditItem Text="Quoted" Value="1" />
        <dxe:ListEditItem Text="Signed" Value="2" />
        <dxe:ListEditItem Text="Implementation" Value="3" />
        <dxe:ListEditItem Text="Post-project" Value="4" />
        <dxe:ListEditItem Text="Completed" Value="5" />
    </Items>
</dxe:ASPxComboBox>
