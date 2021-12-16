<%@ Page Title="ChronoTrack: Locations" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="Locations.aspx.cs" Inherits="customer_Locations" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register src="~/controls/selectors/CustomerCombo.ascx" tagname="CustomerCombo" tagprefix="uc1" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlCustomerlocations" runat="server" Width="850px" HeaderText="Customer Locations">
        <PanelCollection>
            <dxrp:PanelContent>
                <asp:updatepanel id="UpdatePanel1" runat="server">
                    <contenttemplate>
                        <div style="float:right">
                            <dxe:aspxbutton id="btnNew" runat="server" text="New Location" OnClick="btnNew_Click" Enabled="false">
                            </dxe:aspxbutton>
                        </div>
                        <uc1:CustomerCombo ID="ucCustomer" runat="server" OnSelectedIndexChanged="ucCustomer_SelectedIndexChanged" AutoPostBack="true" />
                        <br />
                        <dxwgv:aspxgridview id="grid" runat="server" autogeneratecolumns="False" datasourceid="dataSource" keyfieldname="Synergygrfa" width="100%" enablecallbacks="False">
                            <SettingsBehavior ConfirmDelete="True" />
                            <columns>
                                <dxwgv:gridviewdatatextcolumn fieldname="Synergygrfa" visible="False" visibleindex="0">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Customer_id" readonly="True" visible="False" visibleindex="0">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Location_id" readonly="True" visibleindex="0" Visible="False">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn caption="Location Name" fieldname="Description" visibleindex="0">
                                    <Settings AllowGroup="False" />
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Addr1" visible="False" visibleindex="1">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Addr2" visible="False" visibleindex="1">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Addr3" visibleindex="1" Caption="City">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Addr4" visible="False" visibleindex="2">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="State" visibleindex="2">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Zip" visible="False" visibleindex="3">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Country_id" visibleindex="3" Caption="Country">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Phone" visibleindex="4">
                                    <Settings AllowGroup="False" />
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:GridViewDataTextColumn FieldName="Replication_key" Visible="False" VisibleIndex="5">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="5">
                                    <DeleteButton Visible="True">
                                    </DeleteButton>
                                    <CellStyle HorizontalAlign="Left">
                                    </CellStyle>
                                </dxwgv:GridViewCommandColumn>
                            </columns>
                            <Settings UseFixedTableLayout="true" ShowFilterRow="true" ShowFilterRowMenu="true" ShowGroupPanel="true" />
                            <settingspager alwaysshowpager="True" pagesize="20" Position="Top">
                                <allbutton visible="True">
                                </allbutton>
                            </settingspager>
                            <SettingsText ConfirmDelete="You are about to delete a customer location." />
                        </dxwgv:aspxgridview>
                        <asp:HiddenField ID="customerId" runat="server" />
                        <asp:objectdatasource id="dataSource" runat="server" dataobjecttypename="ChronoTrack.Customer_location" deletemethod="DeleteCustomerLocation" insertmethod="AddCustomerLocation" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllCustomerLocations" typename="CustomerLocationBLL" updatemethod="UpdateCustomerLocation">
                            <selectparameters>
                                <asp:controlparameter name="CustomerId" controlid="customerId" propertyname="Value" type="String" />
                            </selectparameters>
                        </asp:objectdatasource>
                    </contenttemplate>
                </asp:updatepanel>
            </dxrp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:content>

