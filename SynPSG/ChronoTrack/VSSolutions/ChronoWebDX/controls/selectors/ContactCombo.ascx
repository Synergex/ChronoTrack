<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ContactCombo.ascx.cs" Inherits="controls_selectors_ContactCombo" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<dxe:aspxcombobox id="comboBox" runat="server" textfield="Friendly_name" valuefield="Contact_id" ValueType="System.Int32" >
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required!" />
    </ValidationSettings>
</dxe:aspxcombobox>
<asp:HiddenField ID="customerId" runat="server" />
<asp:objectdatasource id="dataSource" runat="server" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllCustomerContacts" typename="CustomerContactBLL" DataObjectTypeName="ChronoTrack.Customer_contact" DeleteMethod="DeleteCustomerContact" InsertMethod="AddCustomerContact" UpdateMethod="UpdateCustomerContact" >
    <SelectParameters>
        <asp:ControlParameter Name="CustomerId" ControlID="customerId" PropertyName="Value" Type="String" />
    </SelectParameters>
</asp:objectdatasource>
