<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ExpenseTypeCombo.ascx.cs" Inherits="controls_selectors_ExpenseTypeCombo" %>

<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<dxe:aspxcombobox id="comboBox" runat="server" datasourceid="dsExpenseType" textfield="Description" valuefield="Expense_type_id" valuetype="System.String" onselectedindexchanged="comboBox_SelectedIndexChanged">
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required!" />
    </ValidationSettings>
</dxe:aspxcombobox>
<asp:objectdatasource id="dsExpenseType" runat="server" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllExpenseTypes" typename="ExpenseTypeBLL" DataObjectTypeName="ChronoTrack.Expense_type" DeleteMethod="DeleteExpenseType" InsertMethod="AddExpenseType" UpdateMethod="UpdateExpenseType"></asp:objectdatasource>
