<%@ Page Title="ChronoTrack: Consultants" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ConsultantBrowser.aspx.cs" Inherits="consultant_ConsultantBrowser" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxDataView" TagPrefix="dxdv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlConsultantBrowser" runat="server" HeaderText="Consultants" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <dxdv:aspxdataview ID="dvUSers" runat="server" DataSourceID="dsUsers" AlwaysShowPager="True" RowPerPage="2" Width="100%">
                    <ItemTemplate>
                        <dxe:ASPxHyperLink ID="lnkPhotoFile" runat="server" ImageUrl='<%# "~/images/" + Eval("Picture_file") %>' Width="80px" Height="100px" NavigateUrl='<%# "~/admin/User.aspx?UserId=" + Eval("User_id") %>'>
                        </dxe:ASPxHyperLink>
                        <br />
                        <dxe:ASPxLabel ID="lblFirstName" runat="server" Text='<%# Eval("First_name") %>' Font-Bold="true" />&nbsp;<dxe:ASPxLabel ID="Last_nameLabel" runat="server" Text='<%# Eval("Last_name") %>' Font-Bold="true" />
                        <br />
                        <dxe:ASPxLabel ID="lblTitle" runat="server" Text='<%# Eval("Title") %>' />
                        <br />
                        <dxe:ASPxLabel ID="lblEmail" runat="server" Text='<%# Eval("Email") %>' />
                        <br />
                        <dxe:ASPxLabel ID="lblOfficePhone" runat="server" Text='<%# "W: " + Eval("Office_phone") %>' />
                        <br />
                        <dxe:ASPxLabel ID="lblMobilePhone" runat="server" Text='<%# "C: " + Eval("Mobile_phone") %>' />
                    </ItemTemplate>
                    <PagerSettings>
                        <AllButton>
                            <Image Width="25px" />
                        </AllButton>
                        <FirstPageButton>
                            <Image Width="22px" />
                        </FirstPageButton>
                        <LastPageButton>
                            <Image Width="22px" />
                        </LastPageButton>
                        <NextPageButton>
                            <Image Width="20px" />
                        </NextPageButton>
                        <PrevPageButton>
                            <Image Width="20px" />
                        </PrevPageButton>
                    </PagerSettings>
                </dxdv:aspxdataview>
                <asp:objectdatasource ID="dsUsers" runat="server" DataObjectTypeName="ChronoTrack.User" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllConsultants" TypeName="UserBLL"></asp:objectdatasource>
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:content>
