<%@ Page Title="CodeGen: Contracts" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="Contracts.aspx.cs" Inherits="customer_Contracts" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register src="~/controls/selectors/CustomerCombo.ascx" tagname="CustomerCombo" tagprefix="uc1" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlCustomerContracts" runat="server" Width="850px" HeaderText="Customer Contracts">
        <PanelCollection>
            <dxrp:PanelContent>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div style="float:right">
                            <dxe:aspxbutton id="btnNew" runat="server" text="New Contract" onclick="btnNew_Click" Enabled="false">
                            </dxe:aspxbutton>
                        </div>
                        <uc1:CustomerCombo ID="ucCustomer" runat="server" OnSelectedIndexChanged="ucCustomer_SelectedIndexChanged" AutoPostBack="True" />
                        <br />
                        <dxwgv:aspxgridview id="grid" runat="server" width="100%" enablecallbacks="False" autogeneratecolumns="False" datasourceid="dataSource" keyfieldname="Synergygrfa">
                            <SettingsBehavior ConfirmDelete="True" />
                            <columns>
                                <dxwgv:gridviewdatatextcolumn fieldname="Synergygrfa" visible="False" visibleindex="0">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Customer_id" readonly="True" visible="False" visibleindex="0">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn caption="Contract ID" fieldname="Contract_id" readonly="True" visibleindex="0">
                                    <Settings AllowGroup="False" />
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatatextcolumn caption="Issued By" fieldname="Issued_by" visibleindex="1">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatadatecolumn caption="Date Issued" fieldname="Issued_date" visibleindex="2">
                                </dxwgv:gridviewdatadatecolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Signed_by" visible="False" visibleindex="3">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatadatecolumn caption="Date Signed" fieldname="Signed_date" visibleindex="3">
                                </dxwgv:gridviewdatadatecolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Created_by" visible="False" visibleindex="4">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:gridviewdatadatecolumn fieldname="Created_date" visible="False" visibleindex="4">
                                </dxwgv:gridviewdatadatecolumn>
                                <dxwgv:gridviewdatatextcolumn fieldname="Contract_document" visible="False" visibleindex="4">
                                </dxwgv:gridviewdatatextcolumn>
                                <dxwgv:GridViewDataTextColumn FieldName="Replication_key" Visible="False" VisibleIndex="4">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="4">
                                    <DeleteButton Visible="True">
                                    </DeleteButton>
                                    <CellStyle HorizontalAlign="Left">
                                    </CellStyle>
                                </dxwgv:GridViewCommandColumn>
                            </columns>
                            <Settings UseFixedTableLayout="true" ShowFilterRow="true" ShowFilterRowMenu="true" ShowGroupPanel="true" />
                            <settingspager alwaysshowpager="True" Position="Top">
                                <allbutton visible="True">
                                </allbutton>
                            </settingspager>
                            <SettingsText ConfirmDelete="You are about to delete a customer contract." />
                        </dxwgv:aspxgridview>
                        <asp:HiddenField ID="customerId" runat="server" />
                        <asp:objectdatasource id="dataSource" runat="server" dataobjecttypename="ChronoTrack.Customer_contract" deletemethod="DeleteCustomerContract" insertmethod="AddCustomerContract" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllCustomerContracts" typename="CustomerContractBLL" updatemethod="UpdateCustomerContract">
                            <selectparameters>
                                <asp:controlparameter name="CustomerId" controlid="customerId" propertyname="Value" type="String" />
                            </selectparameters>
                        </asp:objectdatasource>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </dxrp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:content>

