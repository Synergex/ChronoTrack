﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CustomerId.ascx.cs" Inherits="controls_fields_CustomerId" %>

<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<dxe:ASPxTextBox ID="textBox" runat="server" MaxLength="10" Size="12" onvaluechanged="textBox_ValueChanged">
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required" />
    </ValidationSettings>
</dxe:ASPxTextBox>
