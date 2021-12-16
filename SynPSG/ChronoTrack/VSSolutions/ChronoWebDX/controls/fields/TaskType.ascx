<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaskType.ascx.cs" Inherits="controls_fields_TaskType" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<dxe:ASPxComboBox ID="comboBox" runat="server" ValueType="System.Int32" SelectedIndex="1">
    <Items>
        <dxe:ListEditItem Text="Pre-Project Task" Value="0" />
        <dxe:ListEditItem Text="Implementation Task" Value="1" />
        <dxe:ListEditItem Text="Post-Project Task" Value="2" />
        <dxe:ListEditItem Text="PSG Time" Value="3" />
        <dxe:ListEditItem Text="Beta Testing" Value="4" />
        <dxe:ListEditItem Text="Development Doc Review" Value="5" />
        <dxe:ListEditItem Text="Marketing Doc Review" Value="6" />
        <dxe:ListEditItem Text="Vacation" Value="7" />
        <dxe:ListEditItem Text="Illness" Value="8" />
        <dxe:ListEditItem Text="Sales Trip" Value="9" />
        <dxe:ListEditItem Text="Training &amp; Education" Value="10" />
    </Items>
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required!" />
    </ValidationSettings>
</dxe:ASPxComboBox>
