<%@ Page Title="ChronoTrack: Consultant Availability" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ShowAvailability.aspx.cs" Inherits="consultant_ShowAvailability" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ Register src="../controls/ConsultantAvailability.ascx" tagname="ConsultantAvailability" tagprefix="uc1" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlConsultantAvailability" runat="server" HeaderText="Consultant Availability" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <uc1:ConsultantAvailability ID="ConsultantAvailability1" runat="server" />
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:content>
