<%@ Page Title="ChronoTrack: All Contacts" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ContactsAllCustomers.aspx.cs" Inherits="customer_ContactsAllCustomers" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register src="~/controls/selectors/CustomerCombo.ascx" tagname="CustomerCombo" tagprefix="uc1" %>
<%@ Register src="~/controls/selectors/LocationCombo.ascx" tagname="LocationCombo" tagprefix="uc2" %>
<%@ Register src="~/controls/fields/FirstName.ascx" tagname="FirstName" tagprefix="uc3" %>
<%@ Register src="~/controls/fields/LastName.ascx" tagname="LastName" tagprefix="uc4" %>
<%@ Register src="~/controls/fields/JobTitle.ascx" tagname="JobTitle" tagprefix="uc5" %>
<%@ Register src="~/controls/fields/PhoneNumber.ascx" tagname="PhoneNumber" tagprefix="uc6" %>
<%@ Register src="~/controls/fields/EmailAddress.ascx" tagname="EmailAddress" tagprefix="uc7" %>
<%@ Register src="~/controls/fields/FriendlyName.ascx" tagname="FriendlyName" tagprefix="uc8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" HeaderText="Contacts: All Customers" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <div style="float:right;">
                    <dxe:ASPxButton ID="btnNew" runat="server" Text="New Contact" OnClick="btnNew_Click">
                    </dxe:ASPxButton>
                </div>
                <dxwgv:ASPxGridView ID="gridView" runat="server" DataSourceID="dataSource" Width="100%" AutoGenerateColumns="False" KeyFieldName="Synergygrfa" onstartrowediting="gridView_StartRowEditing">
                    <Columns>
                        <dxwgv:GridViewDataTextColumn FieldName="Synergygrfa" Visible="False" VisibleIndex="0">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn Caption="Customer" FieldName="Customer_id" VisibleIndex="0">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn FieldName="Contact_id" ReadOnly="True" Visible="False" VisibleIndex="1">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn Caption="First Name" FieldName="First_name" VisibleIndex="1">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn Caption="Last Name" FieldName="Last_name" VisibleIndex="2">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn Caption="Job Title" FieldName="Title" VisibleIndex="3">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn Caption="Location" FieldName="Current_location" VisibleIndex="4">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn FieldName="Office_phone" Visible="False" VisibleIndex="5">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn FieldName="Mobile_phone" Visible="False" VisibleIndex="5">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn FieldName="Email" Visible="False" VisibleIndex="5">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn FieldName="Picture_file" Visible="False" VisibleIndex="5">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn FieldName="Friendly_name" Visible="False" VisibleIndex="5">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewDataTextColumn FieldName="Replication_key" Visible="False" VisibleIndex="5">
                        </dxwgv:GridViewDataTextColumn>
                        <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="5" Width="120px">
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
                            <table border="0">
                                <tr>
                                    <td><dxe:ASPxLabel ID="lblFirstName" runat="server" Text="First Name" /></td>
                                    <td><uc3:FirstName ID="txtFirstName" runat="server" Text='<%# Bind("First_name") %>'/></td>
                                </tr>
                                <tr>
                                    <td><dxe:ASPxLabel ID="lblLastName" runat="server" Text="Last Name" /></td>
                                    <td><uc4:LastName ID="txtLastName" runat="server" Text='<%# Bind("Last_name") %>'/></td>
                                </tr>
                                <tr>
                                    <td><dxe:ASPxLabel ID="lblFriendlyName" runat="server" Text="Friendly Name" /></td>
                                    <td><uc8:FriendlyName ID="txtFriendlyName" runat="server" Text='<%# Bind("Friendly_name") %>'/></td>
                                </tr>
                                <tr>
                                    <td><dxe:ASPxLabel ID="lblJobTitle" runat="server" Text="Job Title" /></td>
                                    <td><uc5:JobTitle ID="txtJobTitle" runat="server" Text='<%# Bind("Title") %>'/></td>
                                </tr>
                                <tr>
                                    <td><dxe:ASPxLabel ID="lblLocation" runat="server" Text="Location" /></td>
                                    <td><uc2:LocationCombo ID="cboLocation" runat="server" CustomerId='<%# Bind("Customer_id") %>' Value='<%# Bind("Current_location") %>' /></td>
                                </tr>
                                <tr>
                                    <td><dxe:ASPxLabel ID="lblOfficePhone" runat="server" Text="Office Phone" /></td>
                                    <td><uc6:PhoneNumber ID="txtOfficePhone" runat="server" Text='<%# Bind("Office_phone") %>' /></td>
                                </tr>
                                <tr>
                                    <td><dxe:ASPxLabel ID="lblMobilePhone" runat="server" Text="Mobile Phone" /></td>
                                    <td><uc6:PhoneNumber ID="txtMobilePhone" runat="server" Text='<%# Bind("Mobile_phone") %>' /></td>
                                </tr>
                                <tr>
                                    <td><dxe:ASPxLabel ID="lblEmail" runat="server" Text="Email Address" /></td>
                                    <td><uc7:EmailAddress ID="txtEmail" runat="server" Text='<%# Bind("Email") %>' /></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td align="right">
                                         <dxwgv:ASPxGridViewTemplateReplacement ID="UpdateButton" ReplacementType="EditFormUpdateButton" runat="server"></dxwgv:ASPxGridViewTemplateReplacement>
                                         <dxwgv:ASPxGridViewTemplateReplacement ID="CancelButton" ReplacementType="EditFormCancelButton" runat="server"></dxwgv:ASPxGridViewTemplateReplacement>
                                    </td>
                                </tr>
                            </table>
                            <asp:HiddenField ID="fldSynergygrfa" runat="server" Value='<%# Bind("Synergygrfa") %>' />
                            <asp:HiddenField ID="fldCustomerId" runat="server" Value='<%# Bind("Customer_id") %>' />
                            <asp:HiddenField ID="fldContactId" runat="server" Value='<%# Bind("Contact_id") %>' />
                            <asp:HiddenField ID="fldPictureFile" runat="server" Value='<%# Bind("Picture_file") %>' />
                            <asp:HiddenField ID="fldReplicationKey" runat="server" Value='<%# Bind("Replication_key") %>' />
                        </EditForm>
                    </Templates>
                    <Settings ShowFilterBar="Visible" ShowFilterRow="True" ShowFilterRowMenu="True" ShowGroupPanel="True" />
                    <SettingsBehavior ConfirmDelete="True" />
                    <SettingsEditing EditFormColumnCount="1" Mode="PopupEditForm" PopupEditFormHorizontalAlign="WindowCenter" PopupEditFormVerticalAlign="WindowCenter" PopupEditFormWidth="500px"/>
                    <SettingsPager AlwaysShowPager="True" Position="Top" PageSize="20">
                        <AllButton Visible="True">
                        </AllButton>
                    </SettingsPager>
                    <SettingsText PopupEditFormCaption="Edit Customer Contact" />
                </dxwgv:ASPxGridView>
                <asp:HiddenField ID="customerId" runat="server" Value="          " />
                <asp:ObjectDataSource ID="dataSource" runat="server" DataObjectTypeName="ChronoTrack.Customer_contact" DeleteMethod="DeleteCustomerContact" InsertMethod="AddCustomerContact" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllCustomerContacts" TypeName="CustomerContactBLL" UpdateMethod="UpdateCustomerContact">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="customerId" Name="CustomerId" PropertyName="Value" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:Content>

