<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="admin_User" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register src="~/controls/buttons/OkButton.ascx" tagname="OkButton" tagprefix="uc2" %>
<%@ Register src="~/controls/buttons/CancelButton.ascx" tagname="CancelButton" tagprefix="uc3" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlUser" runat="server" HeaderText="User Details" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <table border="0" width="100%">
                <tr>
                    <td>
                        <dxe:ASPxLabel ID="lblUserIdPrompt" runat="server" Text="User ID">
                        </dxe:ASPxLabel>
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblUserId" runat="server">
                        </dxe:ASPxLabel>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td rowspan="7" valign="top">
                        <dxe:ASPxImage ID="imgPhoto" runat="server" Visible="false" Width="80px" Height="100px">
                        </dxe:ASPxImage>
                    </td>
                </tr>
                <tr>
                    <td>
                        <dxe:ASPxLabel ID="lblNamePrompt" runat="server" Text="Name">
                        </dxe:ASPxLabel>
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblFirstName" runat="server">
                        </dxe:ASPxLabel>
                        &nbsp;
                        <dxe:ASPxLabel ID="lblLastName" runat="server">
                        </dxe:ASPxLabel>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <dxe:ASPxLabel ID="lblAddressPrompt" runat="server" Text="Address">
                        </dxe:ASPxLabel>
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblAddress1" runat="server" />
                        ,&nbsp;
                        <dxe:ASPxLabel ID="lblAddress2" runat="server" Visible="false" />
                        <dxe:ASPxLabel ID="lblAddress2Comma" runat="server" Text=", " Visible="false" />
                        <dxe:ASPxLabel ID="lblCity" runat="server" Visible="false" />
                        <dxe:ASPxLabel ID="lblCityComma" runat="server" Text=", " Visible="false" />
                        <dxe:ASPxLabel ID="lblRegion" runat="server" Visible="false" />
                        <dxe:ASPxLabel ID="lblRegionComma" runat="server" Text=", " Visible="false" />
                        <dxe:ASPxLabel ID="lblState" runat="server" Visible="false" />
                        <dxe:ASPxLabel ID="lblStateComma" runat="server" Text=", " Visible="false" />
                        <dxe:ASPxLabel ID="lblZip" runat="server" Visible="false" />
                        <dxe:ASPxLabel ID="lblZipComma" runat="server" Text=", " Visible="false" />
                        <dxe:ASPxLabel ID="lblCountry" runat="server" />
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <dxe:ASPxLabel ID="lblOfficePhonePrompt" runat="server" Text="Office Phone" />
                    </td>
                    <td>
                        <dxe:ASPxHyperLink ID="hlOfficePhone" runat="server" />
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblEmployeePrompt" runat="server" Text="Employee">
                        </dxe:ASPxLabel>
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblEmployee" runat="server">
                        </dxe:ASPxLabel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <dxe:ASPxLabel ID="lblMobilePhonePrompt" runat="server" Text="Mobile Phone" />
                    </td>
                    <td>
                        <dxe:ASPxHyperLink ID="hlMobilePhone" runat="server" />
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblConsultantPrompt" runat="server" Text="Consultant">
                        </dxe:ASPxLabel>
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblConsultant" runat="server">
                        </dxe:ASPxLabel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <dxe:ASPxLabel ID="lblEmailPrompt" runat="server" Text="Email" />
                    </td>
                    <td>
                        <dxe:ASPxHyperLink ID="hlEmail" runat="server">
                        </dxe:ASPxHyperLink>
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblManagerPrompt" runat="server" Text="Manager">
                        </dxe:ASPxLabel>
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblManager" runat="server">
                        </dxe:ASPxLabel>
                    </td>
                </tr>
                <tr>
                    <td>
                        <dxe:ASPxLabel ID="lblJobTitlePrompt" runat="server" Text="Job Title" />
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblJobTitle" runat="server" />
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblActivePrompt" runat="server" Text="Active">
                        </dxe:ASPxLabel>
                    </td>
                    <td>
                        <dxe:ASPxLabel ID="lblActive" runat="server">
                        </dxe:ASPxLabel>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                        <dxe:ASPxButton ID="btnDone" runat="server" Text="Done" OnClick="btnDone_Click">
                        </dxe:ASPxButton>
                    </td>
                </tr>
                </table>
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
    <asp:HiddenField ID="PreviousPageUrl" runat="server" />
</asp:content>