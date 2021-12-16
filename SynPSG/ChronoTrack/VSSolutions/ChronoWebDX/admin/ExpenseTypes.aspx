<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ExpenseTypes.aspx.cs" Inherits="admin_ExpenseTypes" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlExpenseTypes" runat="server" Width="850px" HeaderText="Expense Types">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div style="float:right">
                            <dxe:aspxbutton ID="btnNew" runat="server" Text="New Expense Type" onclick="btnNew_Click">
                            </dxe:aspxbutton>
                        </div>

                        <dxwgv:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" DataSourceID="dsExpenseType" KeyFieldName="Synergygrfa" Width="100%" onbeforegetcallbackresult="grid_BeforeGetCallbackResult" onparsevalue="grid_ParseValue" onrowupdating="grid_RowUpdating" onrowvalidating="grid_RowValidating">
                            <Columns>
                                <dxwgv:GridViewDataTextColumn FieldName="Synergygrfa" Visible="False" VisibleIndex="0">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn FieldName="Expense_type_id" VisibleIndex="0" Caption="Code">
                                    <Settings AllowGroup="False" />
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn FieldName="Description" VisibleIndex="1" Caption="Description">
                                    <Settings AllowGroup="False" />
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataCheckColumn Caption="Charged Per Unit" FieldName="Has_units" VisibleIndex="2">
                                </dxwgv:GridViewDataCheckColumn>
                                <dxwgv:GridViewDataTextColumn FieldName="Replication_key" Visible="False">
                                    <Settings AllowGroup="False" />
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="3">
                                    <DeleteButton Visible="True">
                                    </DeleteButton>
                                    <EditButton Visible="True">
                                    </EditButton>
                                    <CellStyle HorizontalAlign="Left">
                                    </CellStyle>
                                </dxwgv:GridViewCommandColumn>
                            </Columns>
                            <Images>
                                <FilterRowButton Width="13px" />
                            </Images>
                            <Settings GridLines="Horizontal" UseFixedTableLayout="true" ShowFilterRow="true" ShowGroupPanel="true" />
                            <SettingsBehavior ConfirmDelete="true" />
                            <SettingsEditing EditFormColumnCount="1" Mode="Inline"/>
                            <settingspager pagesize="20" AlwaysShowPager="true" Position="Top">
                                <AllButton Visible="true"></AllButton>
                                <FirstPageButton Visible="true"></FirstPageButton>
                                <LastPageButton Visible="true"></LastPageButton>
                            </settingspager>
                            <SettingsText ConfirmDelete="You are about to delete an expense type." />
                        </dxwgv:ASPxGridView>
                        <asp:objectdatasource ID="dsExpenseType" runat="server" DataObjectTypeName="ChronoTrack.Expense_type" DeleteMethod="DeleteExpenseType" InsertMethod="AddExpenseType" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllExpenseTypes" TypeName="ExpenseTypeBLL" UpdateMethod="UpdateExpenseType"></asp:objectdatasource>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:content>

