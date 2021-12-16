<%@ Control Language="C#" AutoEventWireup="true" CodeFile="StateCombo.ascx.cs" Inherits="controls_selectors_StateCombo" %>

<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<dxe:aspxcombobox id="comboBox" runat="server" datasourceid="dataSource" textfield="Name" valuefield="Code" valuetype="System.String" onselectedindexchanged="comboBox_SelectedIndexChanged">
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required!" />
    </ValidationSettings>
</dxe:aspxcombobox>
<asp:objectdatasource id="dataSource" runat="server" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllStates" typename="StateBLL" DataObjectTypeName="ChronoTrack.State" DeleteMethod="DeleteState" InsertMethod="AddState" UpdateMethod="UpdateState"></asp:objectdatasource>
