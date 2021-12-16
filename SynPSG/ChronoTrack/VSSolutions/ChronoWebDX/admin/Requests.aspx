<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="Requests.aspx.cs" Inherits="admin_Requests" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="~/controls/selectors/CustomerCombo.ascx" tagname="CustomerCombo" tagprefix="uc2" %>
<%@ Register src="~/controls/selectors/LocationCombo.ascx" tagname="LocationCombo" tagprefix="uc3" %>
<%@ Register src="~/controls/selectors/ContactCombo.ascx" tagname="ContactCombo" tagprefix="uc4" %>
<%@ Register src="~/controls/selectors/CustomerProjectCombo.ascx" tagname="CustomerProjectCombo" tagprefix="uc5" %>
<%@ Register src="~/controls/selectors/ConsultantCombo.ascx" tagname="ConsultantCombo" tagprefix="uc6" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>

<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlRequests" runat="server" HeaderText="Resource Requests" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div style="float:right">
                            <dxe:aspxbutton id="btnNewRequest" runat="server" text="New Request" onclick="btnNewRequest_Click">
                            </dxe:aspxbutton>
                        </div>
                        <asp:objectdatasource ID="dsRequests" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllRequests" TypeName="RequestBLL" DataObjectTypeName="ChronoTrack.Request" DeleteMethod="DeleteRequest"></asp:objectdatasource>
                        <dxwgv:ASPxGridView ID="grdRequests" runat="server" Width="100%" AutoGenerateColumns="False" DataSourceID="dsRequests" KeyFieldName="Request_id" oncustombuttoncallback="grdRequests_CustomButtonCallback" EnableCallBacks="False" onrowdeleted="grdRequests_RowDeleted">
                            <Columns>
                                <dxwgv:GridViewDataTextColumn Caption="Customer ID" FieldName="Customer_id" VisibleIndex="0">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Requested By" FieldName="Created_by" VisibleIndex="1">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataTextColumn Caption="Description" FieldName="Description" VisibleIndex="2">
                                </dxwgv:GridViewDataTextColumn>
                                <dxwgv:GridViewDataDateColumn Caption="Start Date" FieldName="Start_date" VisibleIndex="3">
                                </dxwgv:GridViewDataDateColumn>
                                <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="4">
                                    <CellStyle HorizontalAlign="Left">
                                    </CellStyle>
                                    <CustomButtons>
                                        <dxwgv:GridViewCommandColumnCustomButton ID="btnEdit" Text="Edit" />
                                    </CustomButtons>
                                    <DeleteButton Visible="true" />
                                </dxwgv:GridViewCommandColumn>
                            </Columns>
                            <Images>
                                <FilterRowButton Width="13px" />
                            </Images>
                            <Settings GridLines="Horizontal" UseFixedTableLayout="true" ShowFilterRow="true" ShowGroupPanel="true" />
                            <SettingsPager AlwaysShowPager="True" PageSize="20" Position="Top">
                                <AllButton Visible="true">
                                </AllButton>
                            </SettingsPager>
                            <SettingsBehavior ConfirmDelete="true" />
                            <SettingsEditing Mode="PopupEditForm" />
                            <SettingsText ConfirmDelete="You are about to delete a consulting request." />
                        </dxwgv:ASPxGridView>
                        <br />
                        <dxrp:ASPxRoundPanel ID="pnlRequest" runat="server" Width="100%" HeaderText="Selected Request Details" Visible="False">
                            <BottomRightCorner Width="10px" />
                            <NoHeaderTopRightCorner Width="10px" />
                            <TopRightCorner Width="10px" />
                            <NoHeaderTopLeftCorner Width="10px" />
                            <PanelCollection>
                                <dxp:PanelContent ID="PanelContent1" runat="server">
                                    <asp:objectdatasource ID="dsSelectedRequest" runat="server" DataObjectTypeName="ChronoTrack.Request" InsertMethod="AddRequest" OldValuesParameterFormatString="original_{0}" SelectMethod="GetRequest" TypeName="RequestBLL" UpdateMethod="UpdateRequest">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="lblRequestId" Name="RequestId" PropertyName="Text" Type="Int32" />
                                        </SelectParameters>
                                    </asp:objectdatasource>
                                    <asp:DetailsView ID="dvSelectedRequest" runat="server" AutoGenerateRows="False" DataSourceID="dsSelectedRequest" Height="50px" Width="100%" DefaultMode="Insert" OnItemCommand="dvSelectedRequest_ItemCommand" OnItemInserted="dvSelectedRequest_ItemInserted" OnItemUpdated="dvSelectedRequest_ItemUpdated">
                                        <Fields>
                                            <asp:BoundField DataField="Synergygrfa" HeaderText="Synergygrfa" SortExpression="Synergygrfa" Visible="False" />
                                            <asp:BoundField DataField="Request_id" HeaderText="Request_id" SortExpression="Request_id" Visible="False" />
                                            <asp:TemplateField HeaderText="Customer">
                                                <ItemTemplate>
                                                    <uc2:CustomerCombo ID="ucCustomer" runat="server" Value='<%# Bind("Customer_id") %>' OnSelectedIndexChanged="ucCustomer_SelectedIndexChanged" AutoPostBack="true" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Contact">
                                                <ItemTemplate>
                                                    <uc4:ContactCombo ID="ucContact" runat="server" Value='<%# Bind("Contact_id") %>' />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Project">
                                                <ItemTemplate>
                                                    <uc5:CustomerProjectCombo ID="ucProject" runat="server" Value='<%# Bind("Project_id") %>'/>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Work Location">
                                                <ItemTemplate>
                                                    <uc3:LocationCombo ID="ucLocation" runat="server" Value='<%# Bind("Work_location_id") %>' />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Description">
                                                <ItemTemplate>
                                                    <dxe:ASPxTextBox ID="txtDescription" runat="server" Text='<%# Bind("Description") %>' MaxLength="60" Size="63">
                                                    </dxe:ASPxTextBox>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Consultant">
                                                <ItemTemplate>
                                                    <uc6:ConsultantCombo ID="ucConsultant" runat="server" Value='<%# Bind("Resource") %>' />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Start Date">
                                                <ItemTemplate>
                                                    <dxe:ASPxDateEdit ID="deStartDate" runat="server" Date='<%# Bind("Start_date") %>'>
                                                    </dxe:ASPxDateEdit>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="End Date">
                                                <ItemTemplate>
                                                    <dxe:ASPxDateEdit ID="deEndDate" runat="server" Date='<%# Bind("End_date") %>'>
                                                    </dxe:ASPxDateEdit>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Start Time">
                                                <ItemTemplate>
                                                    <dxe:aspxdateedit id="dteStartTime" runat="server" editformat="Custom" editformatstring="t" Date='<%# Bind("Start_time") %>'>
                                                        <dropdownbutton visible="false" />
                                                        <ClientSideEvents DropDown="function(s, e) { s.HideDropDown(); }" />
                                                    </dxe:aspxdateedit>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="End Time">
                                                <ItemTemplate>
                                                    <dxe:aspxdateedit id="dteEndTime" runat="server" editformat="Custom" editformatstring="t" Date='<%# Bind("End_time") %>'>
                                                        <dropdownbutton visible="false" />
                                                        <ClientSideEvents DropDown="function(s, e) { s.HideDropDown(); }" />
                                                    </dxe:aspxdateedit>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="Created_by" HeaderText="Created_by" SortExpression="Created_by" />
                                            <asp:BoundField DataField="Created_date" HeaderText="Created_date" ReadOnly="True" SortExpression="Created_date" />
                                            <asp:TemplateField HeaderText="Description">
                                                <ItemTemplate>
                                                    <dxe:ASPxMemo ID="txtTescription" runat="server" Rows="10" Columns="70" Text='<%# Bind("Text") %>'>
                                                    </dxe:ASPxMemo>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:CommandField ShowDeleteButton="False" ShowEditButton="True" ShowInsertButton="True" />
                                        </Fields>
                                    </asp:DetailsView>
                                </dxp:PanelContent>
                            </PanelCollection>
                            <TopLeftCorner Width="10px" />
                            <BottomLeftCorner Width="10px" />
                        </dxrp:ASPxRoundPanel>

                        <dxe:ASPxLabel ID="lblRequestId" runat="server" Visible="False"></dxe:ASPxLabel>
                        <dxe:ASPxLabel ID="lblCustomer" runat="server" Visible="False"></dxe:ASPxLabel>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:content>

