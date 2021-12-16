<%@ Page Title="ChronoTrack: Change Theme" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ChangeTheme.aspx.cs" Inherits="tools_ChangeTheme" %>

<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRoundPanel" tagprefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <dxrp:ASPxRoundPanel ID="pnlChangeTheme" runat="server" HeaderText="Change Theme" Width="850px">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <table border="0" width="100%" cellpadding="10">
                    <tr>
                        <td style="width:500px;">
                            <p>
                                The ChronoTrack web client supports several themes, each of which changes
                                the look and feel of the web application.  You can choose the color scheme
                                that you wish to use by selecting one of the themes from the list opposite.
                            </p>
                            <p>
                                The theme that you select will be stored in a cookie on your system, so the
                                theme will remain in effect until you return to this page and select a different
                                theme.
                            </p>
                        </td>
                        <td valign="top">
                            <dxe:aspxcombobox id="cbSkins" runat="server" autopostback="True" clientinstancename="cbSkins" enableviewstate="False" width="200px" ondatabound="cbSkins_DataBound" DataSourceID="xdsThemes" >
                            <ClientSideEvents SelectedIndexChanged="
                            function(s, e) {
                                DXSaveCurrentThemeToCookies(s.GetSelectedItem().value);
                            }" />
                            </dxe:aspxcombobox>
                        </td>
                    </tr>
                </table>
                <asp:xmldatasource DataFile="~/App_Themes/Themes.xml" XPath="//Theme" ID="xdsThemes" runat="server" />
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>
</asp:Content>

