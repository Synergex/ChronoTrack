<%@ Page Title="ChronoTrack: Customers" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="BrowseCustomers.aspx.cs" Inherits="customer_BrowseCustomers" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlCustomerBrowser" runat="server" Width="850px" HeaderText="Customer Browser">
        <PanelCollection>
            <dxrp:PanelContent>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div style="float:right;">
                            <dxe:ASPxButton ID="btnAddCustomer" runat="server" Text="Add Customer" Width="120px" onclick="btnAddCustomer_Click">
                            </dxe:ASPxButton>
                        </div>
                        <dxwgv:aspxgridview id="grdCustomers" runat="server" autogeneratecolumns="False" datasourceid="dsCustomer" keyfieldname="Customer_id" width="100%" enablecallbacks="False">
                            <columns>
                                <dxwgv:gridviewdatatextcolumn fieldname="Synergygrfa" visible="False" visibleindex="0">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn caption="Customer ID" fieldname="Customer_id" readonly="True" visibleindex="1" Width="150px">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn caption="Company" fieldname="Company" visibleindex="0" SortIndex="0" SortOrder="Ascending">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn caption="Tech Contact" fieldname="Tech_contact_id" visibleindex="2" visible="False">
                                    <cellstyle horizontalalign="Left">
                                    </cellstyle>
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn caption="Legal Contact" fieldname="Legal_contact_id" visibleindex="2" visible="False">
                                    <cellstyle horizontalalign="Left">
                                    </cellstyle>
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn caption="Current Contract ID" fieldname="Current_contract" visibleindex="2" Visible="False">
                                </dxwgv:gridviewdatatextcolumn>
                            </columns>
                            <Settings ShowFilterRow="true" ShowFilterRowMenu="true" UseFixedTableLayout="true" />
                            <settingspager alwaysshowpager="True" pagesize="20">
                                <allbutton visible="True">
                                </allbutton>
                            </settingspager>
                            <SettingsDetail ShowDetailRow="true" ShowDetailButtons="true" AllowOnlyOneMasterRowExpanded="True" />
                            <Templates>
                                <DetailRow>
                                    <div style="float:right;">
                                        <dxe:ASPxButton ID="btnAddLocation" runat="server" Text="Add Location" Width="120px" onclick="btnAddLocation_Click">
                                        </dxe:ASPxButton>
                                    </div>
                                    <dxe:ASPxLabel ID="lblLocationsTitle" runat="server" Text="Company Locations" Font-Size="Large">
                                    </dxe:ASPxLabel>
                                    <dxwgv:aspxgridview id="grdLocations" runat="server" autogeneratecolumns="False" datasourceid="dsLocation" keyfieldname="Location_id" width="100%" enablecallbacks="False" oninit="grdLocations_Init">
                                        <columns>
                                            <dxwgv:gridviewdatatextcolumn fieldname="Synergygrfa" visible="False" visibleindex="0">
                                            </dxwgv:gridviewdatatextcolumn>
                                            <dxwgv:gridviewdatatextcolumn fieldname="Customer_id" readonly="True" visible="False" visibleindex="0">
                                            </dxwgv:gridviewdatatextcolumn>
                                            <dxwgv:gridviewdatatextcolumn caption="Location ID" fieldname="Location_id" readonly="True" visibleindex="0" Visible="false">
                                                <cellstyle horizontalalign="Left">
                                                </cellstyle>
                                            </dxwgv:gridviewdatatextcolumn>
                                            <dxwgv:gridviewdatatextcolumn caption="Location Name" fieldname="Description" visibleindex="0">
                                            </dxwgv:gridviewdatatextcolumn>
                                            <dxwgv:gridviewdatatextcolumn fieldname="Addr1" visible="False" visibleindex="2">
                                            </dxwgv:gridviewdatatextcolumn>
                                            <dxwgv:gridviewdatatextcolumn fieldname="Addr2" visible="False" visibleindex="0">
                                            </dxwgv:gridviewdatatextcolumn>
                                            <dxwgv:gridviewdatatextcolumn fieldname="Addr3" visibleindex="1" Caption="City">
                                            </dxwgv:gridviewdatatextcolumn>
                                            <dxwgv:gridviewdatatextcolumn fieldname="Addr4" visible="False" visibleindex="2" Caption="Region">
                                            </dxwgv:gridviewdatatextcolumn>
                                            <dxwgv:gridviewdatatextcolumn fieldname="State" visibleindex="2">
                                            </dxwgv:gridviewdatatextcolumn>
                                            <dxwgv:gridviewdatatextcolumn fieldname="Zip" visible="False" visibleindex="2">
                                            </dxwgv:gridviewdatatextcolumn>
                                            <dxwgv:gridviewdatatextcolumn fieldname="Country_id" visibleindex="3" Caption="Country">
                                            </dxwgv:gridviewdatatextcolumn>
                                            <dxwgv:gridviewdatatextcolumn caption="Phone" fieldname="Phone" visibleindex="4">
                                                <cellstyle horizontalalign="Left">
                                                </cellstyle>
                                            </dxwgv:gridviewdatatextcolumn>
                                        </columns>
                                        <Settings UseFixedTableLayout="true" />
                                        <settingspager pagesize="5">
                                            <allbutton visible="True">
                                            </allbutton>
                                        </settingspager>
                                        <SettingsDetail IsDetailGrid="true" ShowDetailRow="true" ShowDetailButtons="true" AllowOnlyOneMasterRowExpanded="true" />
                                        <Templates>
                                            <DetailRow>
                                                <div style="float:right;">
                                                    <dxe:ASPxButton ID="btnAddContact" runat="server" Text="Add Contact" Width="120px" onclick="btnAddContact_Click">
                                                    </dxe:ASPxButton>
                                                </div>
                                                <dxe:ASPxLabel ID="lblContactsTitle" runat="server" Text="Location Contacts" Font-Size="Large">
                                                </dxe:ASPxLabel>
                                                <dxwgv:aspxgridview id="grdContact" runat="server" autogeneratecolumns="False" datasourceid="dsContact" keyfieldname="Customer_id" width="100%" oninit="grdContact_Init">
                                                    <SettingsBehavior ConfirmDelete="True" />
                                                    <columns>
                                                        <dxwgv:gridviewdatatextcolumn fieldname="Synergygrfa" visible="False" visibleindex="0">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                        <dxwgv:gridviewdatatextcolumn fieldname="Customer_id" readonly="True" visible="False" visibleindex="0">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                        <dxwgv:gridviewdatatextcolumn fieldname="Contact_id" readonly="True" visible="False" visibleindex="0">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                        <dxwgv:gridviewdatatextcolumn caption="Name" fieldname="Friendly_name" visibleindex="0">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                        <dxwgv:gridviewdatatextcolumn caption="First Name" fieldname="First_name" visibleindex="0" Visible="False">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                        <dxwgv:gridviewdatatextcolumn caption="Last Name" fieldname="Last_name" visibleindex="0" Visible="False">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                        <dxwgv:gridviewdatatextcolumn fieldname="Title" visibleindex="1">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                        <dxwgv:gridviewdatatextcolumn fieldname="Current_location" visible="False" visibleindex="3">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                        <dxwgv:gridviewdatatextcolumn fieldname="Office_phone" visibleindex="3">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                        <dxwgv:gridviewdatatextcolumn fieldname="Mobile_phone" visibleindex="4">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                        <dxwgv:gridviewdatatextcolumn fieldname="Email" visibleindex="2">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                        <dxwgv:gridviewdatatextcolumn fieldname="Picture_file" visible="False" visibleindex="4">
                                                        </dxwgv:gridviewdatatextcolumn>
                                                    </columns>
                                                    <Settings UseFixedTableLayout="true" />
                                                    <SettingsDetail IsDetailGrid="true" />
                                                </dxwgv:aspxgridview>
                                            </DetailRow>
                                        </Templates>
                                    </dxwgv:aspxgridview>
                                </DetailRow>
                            </Templates>
                        </dxwgv:aspxgridview>

                        <asp:HiddenField ID="fldCustomerId" runat="server" Visible="false" />
                        <asp:HiddenField ID="fldLocationId" runat="server" Visible="false" />

                        <asp:objectdatasource id="dsCustomer" runat="server" dataobjecttypename="ChronoTrack.Customer" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllCustomers" typename="CustomerBLL" DeleteMethod="DeleteCustomer" InsertMethod="AddCustomer" UpdateMethod="UpdateCustomer"></asp:objectdatasource>

                        <asp:objectdatasource id="dsLocation" runat="server" dataobjecttypename="ChronoTrack.Customer_location" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllCustomerLocations" typename="CustomerLocationBLL" DeleteMethod="DeleteCustomerLocation" InsertMethod="AddCustomerLocation" UpdateMethod="UpdateCustomerLocation">
                            <selectparameters>
                                <asp:controlparameter name="CustomerId" controlid="fldCustomerId" propertyname="Value" type="String" />
                            </selectparameters>
                        </asp:objectdatasource>

                        <asp:objectdatasource id="dsContact" runat="server" dataobjecttypename="ChronoTrack.Customer_contact" oldvaluesparameterformatstring="original_{0}" selectmethod="GetLocationContacts" typename="CustomerContactBLL" DeleteMethod="DeleteCustomerContact" InsertMethod="AddCustomerContact" UpdateMethod="UpdateCustomerContact">
                            <selectparameters>
                                <asp:controlparameter name="CustomerId" controlid="fldCustomerId" propertyname="Value" type="String" />
                                <asp:controlparameter name="LocationId" controlid="fldLocationId" propertyname="Value" type="Int32" />
                            </selectparameters>
                        </asp:objectdatasource>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </dxrp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:Content>

