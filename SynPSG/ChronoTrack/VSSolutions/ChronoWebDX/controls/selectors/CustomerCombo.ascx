<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CustomerCombo.ascx.cs" Inherits="controls_selectors_CustomerCombo" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<dxe:aspxcombobox id="comboBox" runat="server" datasourceid="dsCustomers" textfield="Company" valuefield="Customer_id" valuetype="System.String" onselectedindexchanged="comboBox_SelectedIndexChanged" Width="220px">
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required!" />
    </ValidationSettings>
</dxe:aspxcombobox>
<asp:objectdatasource id="dsCustomers" runat="server" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllCustomers" typename="CustomerBLL" DataObjectTypeName="ChronoTrack.Customer" DeleteMethod="DeleteCustomer" InsertMethod="AddCustomer" UpdateMethod="UpdateCustomer"></asp:objectdatasource>
