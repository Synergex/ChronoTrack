<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CountryCombo.ascx.cs" Inherits="controls_selectors_CountryCombo" %>

<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<dxe:aspxcombobox id="comboBox" runat="server" datasourceid="dataSource" textfield="Country_name" valuefield="Country_id" valuetype="System.String" onselectedindexchanged="comboBox_SelectedIndexChanged" ondatabound="comboBox_DataBound" Width="250px">
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required!" />
    </ValidationSettings>
</dxe:aspxcombobox>
<asp:objectdatasource id="dataSource" runat="server" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllCountrys" typename="CountryBLL" DataObjectTypeName="ChronoTrack.Country" DeleteMethod="DeleteCountry" InsertMethod="AddCountry" UpdateMethod="UpdateCountry"></asp:objectdatasource>
