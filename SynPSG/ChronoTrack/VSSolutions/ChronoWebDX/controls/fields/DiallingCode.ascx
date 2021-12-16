<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DiallingCode.ascx.cs" Inherits="controls_fields_DiallingCode" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<dxe:ASPxTextBox ID="textBox" runat="server" MaxLength="5" Size="8">
    <ValidationSettings>
        <RegularExpression ErrorText="Invalid" ValidationExpression="\d{5}" />
        <RequiredField IsRequired="true" ErrorText="Required" />
    </ValidationSettings>
</dxe:ASPxTextBox>
