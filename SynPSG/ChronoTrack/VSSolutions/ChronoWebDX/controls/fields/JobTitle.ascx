<%@ Control Language="C#" AutoEventWireup="true" CodeFile="JobTitle.ascx.cs" Inherits="controls_fields_JobTitle" %>

<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<dxe:ASPxTextBox ID="textBox" runat="server" MaxLength="30" Size="35">
    <ValidationSettings>
        <RequiredField ErrorText="Required" />
    </ValidationSettings>
</dxe:ASPxTextBox>
