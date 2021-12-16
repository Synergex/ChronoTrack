<%@ Page Title="ChronoTrack: About" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>

<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlAbout" runat="server" Width="850px" HeaderText="About ChronoTrack Web Client">
        <PanelCollection>
            <dxrp:PanelContent>
                <table border="0" style="width:100%;">
                    <tr>
                        <td style="width:50%;" valign="top">
                            <p>
                                The ChronoTrack web client application ...
                            </p>
                        </td>
                        <td valign="top">
                            <p>
                                The following products were used during the implementation of this application:
                            </p>
                            <ul>
                                <li>Microsoft ASP.NET V3.5 SP1</li>
                                <li>Microsoft Visual Studio 2008 SP1</li>
                                <li>DevExpress DXperience for ASP.NET v2008 volume 3.6</li>
                                <li>Synergy/DE <i>xf</i>ServerPlus V9.1.5b</li>
                                <li>Synergy/DE <i>xf</i>NetLink .NET V9.1.5b</li>
                            </ul>
                        </td>
                    </tr>
                </table>
            </dxrp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:content>


