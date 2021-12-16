<%@ Page Title="ChronoTrack: Countries" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="Countries.aspx.cs" Inherits="admin_Countries" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v9.2.Export, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView.Export" tagprefix="dxwgv" %>
<%@ Register src="~/controls/fields/CountryCode.ascx" tagname="CountryCode" tagprefix="uc1" %>
<%@ Register src="~/controls/fields/CountryName.ascx" tagname="CountryName" tagprefix="uc2" %>
<%@ Register src="~/controls/fields/DiallingCode.ascx" tagname="DiallingCode" tagprefix="uc3" %>
<%@ Register src="~/controls/fields/CurrencyCode.ascx" tagname="CurrencyCode" tagprefix="uc4" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlCountries" runat="server" Width="850px" HeaderText="Countries">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div style="float:right">
                            <dxe:aspxbutton ID="btnNew" runat="server" Text="New Country" onclick="btnNew_Click" />
                        </div>

                        <dxwgv:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" DataSourceID="dsCountry" KeyFieldName="Synergygrfa" Width="100%" onrowupdating="grid_RowUpdating" onparsevalue="grid_ParseValue" onrowvalidating="grid_RowValidating">
                            <Columns>
                                <dxwgv:GridViewDataTextColumn FieldName="Synergygrfa" Visible="False" VisibleIndex="0" >
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Country Code" FieldName="Country_id" VisibleIndex="0">
                                    <Settings AllowGroup="False" />
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Country Name" FieldName="Country_name" VisibleIndex="1">
                                    <Settings AllowGroup="False" />
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Dialling Code" FieldName="Dialing_code" VisibleIndex="2">
                                    <CellStyle HorizontalAlign="Left">
                                    </CellStyle>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Currency Code" FieldName="Currency_code" VisibleIndex="3">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Replication Key" FieldName="Replication_key" Visible="False" VisibleIndex="4">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="4" Width="100px">
                                    <EditButton Visible="True">
                                    </EditButton>
                                    <DeleteButton Visible="True">
                                    </DeleteButton>
                                    <CellStyle HorizontalAlign="Left">
                                    </CellStyle>
                                </dxwgv:GridViewCommandColumn>
                            </Columns>
                            <Templates>
                                <EditForm>
                                    <asp:HiddenField ID="fldSynergygrfa" runat="server" Value='<%# Bind("Synergygrfa") %>' />
                                    <asp:HiddenField ID="fldReplicationKey" runat="server" Value='<%# Bind("Replication_key") %>' />
                                    <table border="0">
                                        <tr>
                                            <td><dxe:ASPxLabel ID="lblCountryCode" runat="server" Text="Country Code" /></td>
                                            <td><uc1:CountryCode ID="txtCountryCode" runat="server" Text='<%# Bind("Country_id") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td><dxe:ASPxLabel ID="lblCountryName" runat="server" Text="Country Name" /></td>
                                            <td><uc2:CountryName ID="txtCountryName" runat="server" Text='<%# Bind("Country_name") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td><dxe:ASPxLabel ID="lblDiallingCode" runat="server" Text="Dialling Code" /></td>
                                            <td><uc3:DiallingCode ID="txtDiallingCode" runat="server" Text='<%# Bind("Dialing_code") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td><dxe:ASPxLabel ID="lblCurrencyCode" runat="server" Text="Currency Code" /></td>
                                            <td><uc4:CurrencyCode ID="txtCurrencyCode" runat="server" Text='<%# Bind("Currency_code") %>' /></td>
                                        </tr>
                                        <tr>
                                            <td></td>
                                            <td align="right">
                                                 <dxwgv:ASPxGridViewTemplateReplacement ID="UpdateButton" ReplacementType="EditFormUpdateButton" runat="server"></dxwgv:ASPxGridViewTemplateReplacement>
                                                 <dxwgv:ASPxGridViewTemplateReplacement ID="CancelButton" ReplacementType="EditFormCancelButton" runat="server"></dxwgv:ASPxGridViewTemplateReplacement>
                                            </td>
                                        </tr>
                                    </table>
                                </EditForm>
                            </Templates>
                            <images>
                                <FilterRowButton Width="13px" />
                            </images>
                            <Settings GridLines="Horizontal" UseFixedTableLayout="true" ShowFilterRow="true" ShowGroupPanel="true" />
                            <SettingsBehavior ConfirmDelete="true" />
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" PopupEditFormHeight="200px" PopupEditFormHorizontalAlign="Center" PopupEditFormVerticalAlign="Middle" PopupEditFormWidth="600px" />
                            <settingspager pagesize="20" AlwaysShowPager="true" Position="Top">
                                <AllButton Visible="true"></AllButton>
                                <FirstPageButton Visible="true"></FirstPageButton>
                                <LastPageButton Visible="true"></LastPageButton>
                            </settingspager>
                            <SettingsText ConfirmDelete="You are about to delete a country record." />
                        </dxwgv:ASPxGridView>
                        <asp:objectdatasource ID="dsCountry" runat="server" DataObjectTypeName="ChronoTrack.Country" DeleteMethod="DeleteCountry" InsertMethod="AddCountry" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllCountrys" TypeName="CountryBLL" UpdateMethod="UpdateCountry"></asp:objectdatasource>
                        <dxwgv:ASPxGridViewExporter ID="gridExporter" runat="server" FileName="Countries" GridViewID="grid" Landscape="True">
                        </dxwgv:ASPxGridViewExporter>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:content>

