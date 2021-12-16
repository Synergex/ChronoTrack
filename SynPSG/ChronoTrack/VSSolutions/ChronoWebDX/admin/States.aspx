<%@ Page Title="ChronoTrack: States" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="States.aspx.cs" Inherits="admin_States" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" HeaderText="US States" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div style="float:right">
                            <dxe:aspxbutton ID="btnNew" runat="server" Text="New State" onclick="btnNew_Click" />
                        </div>
                        <dxwgv:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" DataSourceID="dsStates" KeyFieldName="Synergygrfa" Width="100%" OnBeforeGetCallbackResult="grid_BeforeGetCallbackResult" onparsevalue="grid_ParseValue" OnRowValidating="grid_RowValidating" onrowupdating="grid_RowUpdating">
                            <Columns>
                                <dxwgv:GridViewDataTextColumn FieldName="Synergygrfa" VisibleIndex="0" Visible="False" ShowInCustomizationForm="False">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="State Code" FieldName="Code" VisibleIndex="0">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="State Name" FieldName="Name" VisibleIndex="1">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn FieldName="Replication_key" Visible="False" VisibleIndex="2" ShowInCustomizationForm="False">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewCommandColumn VisibleIndex="2" Caption="Options">
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
                            <Settings GridLines="Horizontal" UseFixedTableLayout="true" ShowFilterRow="true" ShowFilterRowMenu="true"/>
                            <SettingsBehavior ConfirmDelete="True" />
                            <SettingsEditing Mode="PopupEditForm" PopupEditFormHeight="120px" PopupEditFormHorizontalAlign="Center" PopupEditFormVerticalAlign="Middle" PopupEditFormWidth="500px" EditFormColumnCount="1" />
                            <SettingsPager PageSize="20" Position="Top">
                                <AllButton Visible="True">
                                </AllButton>
                                <FirstPageButton Visible="true">
                                </FirstPageButton>
                                <LastPageButton Visible="true">
                                </LastPageButton>
                            </SettingsPager>
                            <SettingsText ConfirmDelete="You are about to delete a state record." />
                        </dxwgv:ASPxGridView>
                        <asp:objectdatasource ID="dsStates" runat="server" DataObjectTypeName="ChronoTrack.State" DeleteMethod="DeleteState" InsertMethod="AddState" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllStates" TypeName="StateBLL" UpdateMethod="UpdateState"></asp:objectdatasource>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:content>

