<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ContractCombo.ascx.cs" Inherits="controls_selectors_ContractCombo" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<dxe:aspxcombobox id="comboBox" runat="server" textfield="Contract_id" valuefield="Contract_id" ValueType="System.String" >
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required!" />
    </ValidationSettings>
</dxe:aspxcombobox>
<asp:HiddenField ID="customerId" runat="server" />
<asp:objectdatasource id="dataSource" runat="server" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllCustomerContracts" typename="CustomerContractBLL" DataObjectTypeName="ChronoTrack.Customer_contract" DeleteMethod="DeleteCustomerContract" InsertMethod="AddCustomerContract" UpdateMethod="UpdateCustomerContract" >
    <SelectParameters>
        <asp:ControlParameter Name="CustomerId" ControlID="customerId" PropertyName="Value" Type="String" />
    </SelectParameters>
</asp:objectdatasource>
