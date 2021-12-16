<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProjectConsultantCombo.ascx.cs" Inherits="controls_selectors_ProjectConsultantCombo" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<dxe:aspxcombobox id="comboBox" runat="server" textfield="Friendly_name" valuefield="User_id" ValueType="System.String" OnSelectedIndexChanged="comboBox_SelectedIndexChanged" >
    <ValidationSettings>
        <RequiredField IsRequired="true" ErrorText="Required!" />
    </ValidationSettings>
</dxe:aspxcombobox>
<asp:HiddenField ID="projectId" runat="server" />
<asp:objectdatasource id="dataSource" runat="server" oldvaluesparameterformatstring="original_{0}" selectmethod="GetProjectConsultants" typename="UserBLL" >
    <SelectParameters>
        <asp:ControlParameter Name="projectId" ControlID="projectId" PropertyName="Value" Type="Int32" />
    </SelectParameters>
</asp:objectdatasource>
