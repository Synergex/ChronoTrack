<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="FeeTypes.aspx.cs" Inherits="admin_FeeTypes" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlFeeType" runat="server" HeaderText="Fee Types" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div style="float:right">
                            <dxe:aspxbutton ID="btnNew" runat="server" Text="New Fee Type" onclick="btnNew_Click">
                            </dxe:aspxbutton>
                        </div>
                        <dxwgv:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" DataSourceID="dsFeeType" KeyFieldName="Synergygrfa" Width="100%" onrowupdating="grid_RowUpdating" onbeforegetcallbackresult="grid_BeforeGetCallbackResult" onparsevalue="grid_ParseValue" onrowvalidating="grid_RowValidating">
                            <Columns>
                                <dxwgv:GridViewDataTextColumn FieldName="Synergygrfa" Visible="False" VisibleIndex="0">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Fee Type ID" FieldName="Fee_type_id" VisibleIndex="0">
                                    <Settings AllowGroup="False" />
                                    <CellStyle HorizontalAlign="Left">
                                    </CellStyle>
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn FieldName="Description" VisibleIndex="1">
                                    <Settings AllowGroup="False" />
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataCheckColumn Caption="Billed By Unit" FieldName="Has_units" VisibleIndex="2">
                                </dxwgv:GridViewDataCheckColumn>
                                <dxwgv:GridViewDataTextColumn FieldName="Replication_key" VisibleIndex="3" Visible="False">
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
                            <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" PopupEditFormHeight="150px" PopupEditFormHorizontalAlign="Center" PopupEditFormVerticalAlign="Middle" PopupEditFormWidth="350px" />
                            <SettingsPager AlwaysShowPager="true" Position="Top">
                                <AllButton Visible="true">
                                </AllButton>
                                <FirstPageButton Visible="true">
                                </FirstPageButton>
                                <LastPageButton Visible="true">
                                </LastPageButton>
                            </SettingsPager>
                            <SettingsText ConfirmDelete="You are about to delete a fee type record." />
                        </dxwgv:ASPxGridView>
                        <asp:objectdatasource ID="dsFeeType" runat="server" DataObjectTypeName="ChronoTrack.Fee_type" DeleteMethod="DeleteFeeType" InsertMethod="AddFeeType" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllFeeTypes" TypeName="FeeTypeBLL" UpdateMethod="UpdateFeeType"></asp:objectdatasource>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:content>

