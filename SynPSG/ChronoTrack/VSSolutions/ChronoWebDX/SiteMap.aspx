<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="SiteMap.aspx.cs" Inherits="SiteMap" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSiteMapControl" TagPrefix="dxsm" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlSiteMap" runat="server" Width="850px" HeaderText="Site Map">
        <PanelCollection>
            <dxrp:PanelContent>
                <dxsm:ASPxSiteMapControl ID="siteMapChronoTrack" runat="server" Width="100%" DataSourceID="siteMapDataSource" Categorized="True">
                    <Columns>
                        <dxsm:Column>
                        </dxsm:Column>
                        <dxsm:Column>
                        </dxsm:Column>
                    </Columns>
                </dxsm:ASPxSiteMapControl>
                <dxsm:ASPxSiteMapDataSource ID="siteMapDataSource" runat="server" SiteMapFileName="~/Web.sitemap" />
            </dxrp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:Content>

