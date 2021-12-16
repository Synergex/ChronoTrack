<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DateField.ascx.cs" Inherits="controls_fields_DateField" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<dxe:ASPxDateEdit ID="dateField" runat="server" ondatechanged="dateField_DateChanged">
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required" />
    </ValidationSettings>
</dxe:ASPxDateEdit>
