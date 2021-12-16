<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Projects.ascx.cs" Inherits="controls_Projects" %>

<%@ register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="ProjectTasks.ascx" tagname="ProjectTasks" tagprefix="uc1" %>

<div style="float:right;">
    <dxe:aspxbutton id="btnNewProject" runat="server" text="New Project" postbackurl="~/project/NewProject.aspx">
    </dxe:aspxbutton>
</div>
<dxwgv:aspxgridview id="grdProjects" runat="server" autogeneratecolumns="False" datasourceid="dsProjects" keyfieldname="Project_id" width="100%" Caption="Customer Projects">
    <Templates>
        <DetailRow>
            <uc1:ProjectTasks ID="ProjectTasks1" runat="server" />
        </DetailRow>
    </Templates>
    <columns>
        <dxwgv:gridviewdatatextcolumn fieldname="Synergygrfa" visible="False" visibleindex="0" ShowInCustomizationForm="False">
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatatextcolumn caption="Project" fieldname="Project_id" readonly="True" visibleindex="0" Width="30px">
            <Settings AllowGroup="False" />
            <CellStyle HorizontalAlign="Left">
            </CellStyle>
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatatextcolumn caption="Customer" fieldname="Customer_id" visibleindex="1" Width="70px">
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatatextcolumn caption="Contract" fieldname="Contract_id" visibleindex="2" Width="70px">
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatatextcolumn caption="Sub" fieldname="Contract_project_id" visibleindex="3" Width="30px">
            <Settings AllowGroup="False" AllowSort="False" />
            <CellStyle HorizontalAlign="Left">
            </CellStyle>
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatatextcolumn caption="Description" fieldname="Description" visibleindex="4">
            <Settings AllowGroup="False" AllowSort="False" />
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatadatecolumn caption="Start Date" fieldname="Start_date" visibleindex="5" Width="60px">
        </dxwgv:gridviewdatadatecolumn>
        <dxwgv:gridviewdatadatecolumn fieldname="End_date" visible="False" visibleindex="5" Caption="End Date">
        </dxwgv:gridviewdatadatecolumn>
        <dxwgv:gridviewdatatextcolumn fieldname="Current_status" visible="False" visibleindex="5" Caption="Status">
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatadatecolumn fieldname="Status_date" visible="False" visibleindex="5" Caption="Status Date">
            <Settings AllowGroup="False" />
        </dxwgv:gridviewdatadatecolumn>
        <dxwgv:gridviewdatatextcolumn fieldname="Lead_consultant" visibleindex="6" Caption="Lead Consultant" Width="110px">
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatatextcolumn fieldname="Coordinator" visible="False" visibleindex="6" Caption="Coordinator">
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatatextcolumn fieldname="Approved_by_first" visible="False" visibleindex="6" Caption="Approved First">
            <Settings AllowGroup="False" AllowSort="False" />
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatatextcolumn fieldname="Approved_by_last" visible="False" visibleindex="6" Caption="Approved Last">
            <Settings AllowGroup="False" AllowSort="False" />
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatadatecolumn fieldname="Approved_date" visible="False" visibleindex="6" Caption="Approved">
        </dxwgv:gridviewdatadatecolumn>
        <dxwgv:gridviewdatatextcolumn fieldname="Approval_location" visible="False" visibleindex="6" Caption="Approval Location">
            <Settings AllowGroup="False" AllowSort="False" />
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatatextcolumn fieldname="Work_location_id" visible="False" visibleindex="6" Caption="Work Location">
            <Settings AllowGroup="False" AllowSort="False" />
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatatextcolumn fieldname="Created_by" visible="False" visibleindex="6" Caption="Created By">
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatadatecolumn fieldname="Created_date" visible="False" visibleindex="6" Caption="Created">
        </dxwgv:gridviewdatadatecolumn>
        <dxwgv:gridviewdatatextcolumn fieldname="Modified_by" visible="False" visibleindex="6" Caption="Modified By">
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:gridviewdatadatecolumn fieldname="Modified_date" visible="False" visibleindex="6" Caption="Modified">
        </dxwgv:gridviewdatadatecolumn>
        <dxwgv:gridviewdatatextcolumn fieldname="Text" visible="False" visibleindex="6" Caption="Details">
            <Settings AllowGroup="False" AllowSort="False" />
        </dxwgv:gridviewdatatextcolumn>
        <dxwgv:GridViewDataTextColumn Caption="Replication Key" FieldName="Replication_key" ShowInCustomizationForm="False" Visible="False" VisibleIndex="6">
            <Settings AllowGroup="False" AllowSort="False" />
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewCommandColumn Caption="Options" ShowSelectCheckbox="True" VisibleIndex="7" Width="100px">
            <CellStyle HorizontalAlign="Left">
            </CellStyle>
        </dxwgv:GridViewCommandColumn>
    </columns>
    <SettingsDetail ShowDetailRow="True" AllowOnlyOneMasterRowExpanded="True" />
    <Settings ShowFilterRow="true" ShowFilterRowMenu="true" ShowGroupPanel="true" UseFixedTableLayout="true" />
    <settingsediting mode="PopupEditForm" />
    <settingspager AlwaysShowPager="true" PageSize="20" Position="Top">
        <allbutton visible="True">
        </allbutton>
    </settingspager>
</dxwgv:aspxgridview>
<asp:objectdatasource id="dsProjects" runat="server" dataobjecttypename="ChronoTrack.Project" deletemethod="DeleteProject" insertmethod="AddProject" oldvaluesparameterformatstring="original_{0}" selectmethod="GetAllProjects" typename="ProjectBLL" updatemethod="UpdateProject"></asp:objectdatasource>
