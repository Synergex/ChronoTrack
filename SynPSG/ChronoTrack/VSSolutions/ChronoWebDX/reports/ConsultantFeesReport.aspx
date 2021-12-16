<%@ Page Title="" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ConsultantFeesReport.aspx.cs" Inherits="reports_ConsultantFeesReport" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:content>
<asp:content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="1200px" ProcessingMode="Remote" Width="850px" ZoomMode="PageWidth">
        <ServerReport DisplayName="Consultant Fees" ReportServerUrl="http://localhost/reportserver" ReportPath="/ChronoTrackReports/Consultant Fees" />
    </rsweb:ReportViewer>
</asp:content>

