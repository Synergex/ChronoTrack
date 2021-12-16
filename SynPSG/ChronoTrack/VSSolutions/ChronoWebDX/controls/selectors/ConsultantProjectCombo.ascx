<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ConsultantProjectCombo.ascx.cs" Inherits="controls_selectors_ConsultantProjectCombo" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<dxe:aspxcombobox id="comboBox" runat="server" textfield="Customer_name" valuefield="Project_id" ValueType="System.Int32" OnSelectedIndexChanged="comboBox_SelectedIndexChanged" >
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required!" />
    </ValidationSettings>
</dxe:aspxcombobox>
<asp:HiddenField ID="consultantId" runat="server" />
<asp:objectdatasource id="dataSource" runat="server" oldvaluesparameterformatstring="original_{0}" selectmethod="GetConsultantProjectSummary" typename="ProjectBLL" DataObjectTypeName="ChronoTrack.Project" DeleteMethod="DeleteProject" InsertMethod="AddProject" UpdateMethod="UpdateProject" >
    <SelectParameters>
        <asp:ControlParameter Name="ConsultantId" ControlID="consultantId" PropertyName="Value" Type="String" />
    </SelectParameters>
</asp:objectdatasource>

