<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmailAddress.ascx.cs" Inherits="controls_fields_EmailAddress" %>

<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<dxe:ASPxTextBox ID="textBox" runat="server" MaxLength="70" Size="50">
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required" />
        <RegularExpression ErrorText="Invalid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
    </ValidationSettings>
</dxe:ASPxTextBox>
