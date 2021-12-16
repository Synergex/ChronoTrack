<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ConsultantCombo.ascx.cs" Inherits="controls_selectors_ConsultantCombo" %>

<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<dxe:aspxcombobox id="comboBox" runat="server" datasourceid="dsConsultant" textfield="Friendly_name" valuefield="User_id" valuetype="System.String" onselectedindexchanged="comboBox_SelectedIndexChanged" Width="120px">
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required!" />
    </ValidationSettings>
</dxe:aspxcombobox>
<asp:objectdatasource id="dsConsultant" runat="server" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllConsultants" typename="UserBLL" DataObjectTypeName="ChronoTrack.User" DeleteMethod="DeleteUser" InsertMethod="AddUser" UpdateMethod="UpdateUser"></asp:objectdatasource>
