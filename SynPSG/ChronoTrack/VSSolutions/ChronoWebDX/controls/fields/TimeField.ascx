<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TimeField.ascx.cs" Inherits="controls_fields_TimeField" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<dxe:aspxdateedit id="dateField" runat="server" editformat="Custom" editformatstring="t">
    <dropdownbutton visible="false" />
    <ClientSideEvents DropDown="function(s, e) { s.HideDropDown(); }" />
    <ValidationSettings>
        <RequiredField IsRequired="false" ErrorText="Required" />
    </ValidationSettings>
</dxe:aspxdateedit>
