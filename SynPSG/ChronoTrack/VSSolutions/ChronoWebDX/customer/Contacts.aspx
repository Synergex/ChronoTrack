<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="Contacts.aspx.cs" Inherits="customer_Contacts" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="~/controls/selectors/CustomerCombo.ascx" tagname="CustomerCombo" tagprefix="uc1" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
<dxrp:ASPxRoundPanel ID="pnlCustomerContacts" runat="server" Width="850px" HeaderText="Customer Contacts">
    <PanelCollection>
        <dxrp:PanelContent>
            <asp:updatepanel id="UpdatePanel1" runat="server">
                <contenttemplate>
                    <div style="float:right">
                        <dxe:aspxbutton id="btnNew" runat="server" text="New Contact" onclick="btnNew_Click" Enabled="False">
                        </dxe:aspxbutton>
                    </div>
                    <uc1:CustomerCombo ID="ucCustomer" runat="server" OnSelectedIndexChanged="ucCustomer_SelectedIndexChanged" AutoPostBack="true" />
                    <br />
                    <dxwgv:aspxgridview id="grid" runat="server" autogeneratecolumns="False" datasourceid="dataSource" keyfieldname="Synergygrfa" width="100%">
                        <columns>
                            <dxwgv:gridviewdatatextcolumn fieldname="Synergygrfa" visible="False" visibleindex="0" Caption="GRFA">
                            </dxwgv:gridviewdatatextcolumn>
                            <dxwgv:gridviewdatatextcolumn fieldname="Customer_id" readonly="True" visible="False" visibleindex="0" Caption="Customer ID">
                            </dxwgv:gridviewdatatextcolumn>
                            <dxwgv:gridviewdatatextcolumn fieldname="Contact_id" readonly="True" visible="False" visibleindex="0" Caption="Contact ID">
                            </dxwgv:gridviewdatatextcolumn>
                            <dxwgv:gridviewdatatextcolumn fieldname="Friendly_name" visibleindex="0" Caption="Name">
                                <Settings AllowGroup="False" />
                            </dxwgv:gridviewdatatextcolumn>
                            <dxwgv:gridviewdatatextcolumn fieldname="First_name" visibleindex="0" Visible="False" Caption="First Name">
                            </dxwgv:gridviewdatatextcolumn>
                            <dxwgv:gridviewdatatextcolumn fieldname="Last_name" visibleindex="0" Visible="False" Caption="Last Name">
                            </dxwgv:gridviewdatatextcolumn>
                            <dxwgv:gridviewdatatextcolumn fieldname="Title" visibleindex="1">
                            </dxwgv:gridviewdatatextcolumn>
                            <dxwgv:gridviewdatatextcolumn fieldname="Current_location" visible="False" visibleindex="1" Caption="Location ID">
                            </dxwgv:gridviewdatatextcolumn>
                            <dxwgv:gridviewdatatextcolumn fieldname="Office_phone" visibleindex="2" Caption="Office Phone">
                                <Settings AllowGroup="False" />
                            </dxwgv:gridviewdatatextcolumn>
                            <dxwgv:gridviewdatatextcolumn fieldname="Mobile_phone" visibleindex="1" Visible="False" Caption="Mobile Phone">
                            </dxwgv:gridviewdatatextcolumn>
                            <dxwgv:gridviewdatatextcolumn fieldname="Email" visibleindex="3" Caption="Email">
                                <Settings AllowGroup="False" />
                            </dxwgv:gridviewdatatextcolumn>
                            <dxwgv:GridViewDataTextColumn FieldName="Picture_file" Visible="False" VisibleIndex="2" Caption="Picture File">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewDataTextColumn FieldName="Replication_key" Visible="False" VisibleIndex="3" Caption="SQL Timestamp">
                            </dxwgv:GridViewDataTextColumn>
                            <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="4">
                                <DeleteButton Visible="True">
                                </DeleteButton>
                                <CellStyle HorizontalAlign="Left">
                                </CellStyle>
                            </dxwgv:GridViewCommandColumn>
                        </columns>
                        <SettingsPager Position="Top">
                        </SettingsPager>
                        <Settings UseFixedTableLayout="true" ShowFilterRow="true" ShowFilterRowMenu="true" ShowGroupPanel="true" />
                        <SettingsBehavior ConfirmDelete="true" />
                        <SettingsText ConfirmDelete="You are about to delete a customer contact." />
                    </dxwgv:aspxgridview>
                    <asp:HiddenField ID="customerId" runat="server" />
                    <asp:objectdatasource id="dataSource" runat="server" dataobjecttypename="ChronoTrack.Customer_contact" deletemethod="DeleteCustomerContact" insertmethod="AddCustomerContact" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllCustomerContacts" typename="CustomerContactBLL" updatemethod="UpdateCustomerContact">
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