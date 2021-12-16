<%@ Page Title="About ChronoTrack" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="AboutChronoTrack.aspx.cs" Inherits="AboutChronoTrack" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
<dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="850px" HeaderText="About ChronoTrack">
    <PanelCollection>
        <dxp:PanelContent runat="server">
            <table border="0" width="100%">
                <tr>
                    <td style="width:48%;" valign="top">
                        <dxe:ASPxLabel ID="ASPxLabel1" runat="server" Text="Introducing ChronoTrack" Font-Size="Large">
                        </dxe:ASPxLabel>
                        <p>ChronoTrack is a series of applications developed by Synergex Professional Services Group to showcase the use of Synergy/DE technologies.</p>
                        
                        <p>
                            The ChronoTrack applications are designed to be used by a profesional services organisation, and allow such an orianisation to track information about consulting engagements for their clients.</p>
                        <p>
                            At the heart of ChronoTrack is a core Synergy/DE UI Toolkit application, which in turn uses a Synergy DBMS database.</p>
                        <p>
                            The ChronoTrack web client is designed to be used by consultants who are working on customer projects, remote from their regular work place.&nbsp; The application allows these consultants to access and manipulate information relating to the projects currently assigned to them.</p>
                        
                    </td>
                    <td style="width:4%;">
                    </td>
                    <td style="width:48%;" valign="top">
                        <dxe:ASPxLabel ID="ASPxLabel2" runat="server" Text="Components" Font-Size="Large">
                        </dxe:ASPxLabel>
                        <p>ChronoTrack consists of the following main components:</p>
                        <ul>
                        <li>A Synergy/DE UI Toolkit Client (Cell based)</li>
                        <li>A Synergy/DE UI Toolkit Client (.NET Enhanced)</li>
                        <li>An ASP.NET Web Client</li>
                        <li>A Windows Mobile Client</li>
                        <li>A .NET Monitor Application</li>
                        <li>A .NET Dashboard Application</li>
                        </ul>
                        <dxe:ASPxLabel ID="ASPxLabel3" runat="server" Text="Technologies" Font-Size="Large">
                        </dxe:ASPxLabel>
                        <p>Amongs others, ChronoTrack makes use of the following technologies:</p>
                        <ul>
                        <li>
                            <dxe:ASPxHyperLink ID="ASPxHyperLink2" runat="server" Text="Synergy/DE" NavigateUrl="http://www.synergyde.com" Target="_blank">
                            </dxe:ASPxHyperLink>
                            (all products)</li>
                        <li>
                            <dxe:ASPxHyperLink ID="ASPxHyperLink7" runat="server" Text="Microsoft .NET" NavigateUrl="http://www.microsoft.com/NET" Target="_blank">
                            </dxe:ASPxHyperLink>
                        </li>
                        <li>
                            <dxe:ASPxHyperLink ID="ASPxHyperLink1" runat="server" Text="Infragistics NetAdvantage" NavigateUrl="http://www.infragistics.com/dotnet/netadvantage.aspx" Target="_blank">
                            </dxe:ASPxHyperLink>
                        </li>
                        <li>
                            <dxe:ASPxHyperLink ID="ASPxHyperLink3" runat="server" Text="DevExpress DXperience" NavigateUrl="http://www.devexpress.com/Products/NET/DXperience" Target="_blank">
                            </dxe:ASPxHyperLink>
                        </li>
                        <li>
                            <dxe:ASPxHyperLink ID="ASPxHyperLink6" runat="server" Text="Microsoft ASP.NET" NavigateUrl="http://msdn.microsoft.com/en-us/asp.net" Target="_blank">
                            </dxe:ASPxHyperLink>
                        </li>
                        <li>
                            <dxe:ASPxHyperLink ID="ASPxHyperLink4" runat="server" Text="SQL Server 2008 Database" NavigateUrl="http://www.microsoft.com/sqlserver/2008/en/us" Target="_blank">
                            </dxe:ASPxHyperLink>
                        </li>
                        <li>
                            <dxe:ASPxHyperLink ID="ASPxHyperLink5" runat="server" Text="SQL Server 2008 Reporting Services" NavigateUrl="http://www.microsoft.com/sqlserver/2008/en/us/reporting.aspx" Target="_blank">
                            </dxe:ASPxHyperLink>
                        </li>
                        </ul>
                    </td>
                </tr>
            </table>
        </dxp:PanelContent>
    </PanelCollection>
</dxrp:ASPxRoundPanel>

</asp:Content>

