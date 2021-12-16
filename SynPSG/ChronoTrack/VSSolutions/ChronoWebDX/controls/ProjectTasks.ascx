<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProjectTasks.ascx.cs" Inherits="controls_ProjectTasks" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dxe" %>
<%@ Register src="ProjectTaskActivities.ascx" tagname="ProjectTaskActivities" tagprefix="uc1" %>
<div style="float:right;">
    <dxe:aspxbutton id="btnNew" runat="server" text="New Task" postbackurl="~/project/NewProjectTask.aspx">
    </dxe:aspxbutton>
</div>
<asp:ObjectDataSource ID="dsProject" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetProject" TypeName="ProjectBLL" DataObjectTypeName="ChronoTrack.Project">
    <SelectParameters>
        <asp:SessionParameter Name="ProjectId" SessionField="CurrentProject" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>
<asp:DetailsView ID="detailView" runat="server" AutoGenerateRows="False" BorderStyle="None" GridLines="None">
    <FieldHeaderStyle Font-Bold="True" Width="120px" />
    <Fields>
        <asp:BoundField DataField="End_date" HeaderText="End Date" SortExpression="End_date" />
        <asp:BoundField DataField="Current_status" HeaderText="Status" SortExpression="Current_status" />
        <asp:BoundField DataField="Status_date" HeaderText="Status Date" ReadOnly="True" SortExpression="Status_date" />
        <asp:BoundField DataField="Coordinator" HeaderText="Coordinator" SortExpression="Coordinator" />
        <asp:BoundField DataField="Approved_date" HeaderText="Approved" SortExpression="Approved_date" />
    </Fields>
    <HeaderStyle Font-Bold="False" />
</asp:DetailsView>
<asp:ObjectDataSource ID="dsTask" runat="server" DataObjectTypeName="ChronoTrack.Project_task" OldValuesParameterFormatString="original_{0}" SelectMethod="GetProjectTasks" TypeName="ProjectTaskBLL">
    <SelectParameters>
        <asp:SessionParameter Name="ProjectId" SessionField="CurrentProject" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>
<dxwgv:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" KeyFieldName="Task_id" Width="100%" Caption="Project Tasks">
    <Templates>
        <DetailRow>
            <uc1:ProjectTaskActivities ID="ProjectTaskActivities1" runat="server" />
        </DetailRow>
    </Templates>
    <Columns>
        <dxwgv:GridViewDataTextColumn FieldName="Synergygrfa" VisibleIndex="0" Caption="GRFA" ShowInCustomizationForm="False" Visible="False">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn FieldName="Project_id" ReadOnly="True" VisibleIndex="0" Caption="Project" Visible="False">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn FieldName="Task_id" ReadOnly="True" VisibleIndex="0" Caption="Task" Width="40px">
            <Settings AllowGroup="False" />
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn FieldName="Task_type" VisibleIndex="1" Caption="Type" Visible="False" Width="40px">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn FieldName="Description" VisibleIndex="1" Caption="Description">
            <Settings AllowGroup="False" AllowSort="False" />
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn FieldName="Assigned_to" VisibleIndex="2" Caption="Consultant" Width="100px">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataDateColumn FieldName="Start_date" VisibleIndex="3" Caption="Start Date" Width="80px">
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataDateColumn FieldName="Start_time" VisibleIndex="4" Caption="Start Time" Visible="False">
            <Settings AllowGroup="False" AllowSort="False" />
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataDateColumn FieldName="End_date" VisibleIndex="4" Caption="End Date" Width="80px">
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataDateColumn FieldName="End_time" VisibleIndex="5" Caption="End Time" Visible="False">
            <Settings AllowGroup="False" AllowSort="False" />
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataTextColumn FieldName="Location" VisibleIndex="5" Caption="Location" Visible="False">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn FieldName="Billable_hours" VisibleIndex="5" Caption="Billable Hours" Visible="False">
            <Settings AllowGroup="False" />
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn FieldName="Created_by" VisibleIndex="5" Caption="Created By" Visible="False">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataDateColumn FieldName="Created_date" VisibleIndex="5" Caption="Created" Visible="False">
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataTextColumn FieldName="Modified_by" VisibleIndex="5" Caption="Modified By" Visible="False">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataDateColumn FieldName="Modified_date" VisibleIndex="5" Caption="Modified" Visible="False">
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataCheckColumn FieldName="Completed" VisibleIndex="5" Caption="Complete" Width="40px">
        </dxwgv:GridViewDataCheckColumn>
        <dxwgv:GridViewDataTextColumn FieldName="Text" VisibleIndex="6" Caption="Notes" Visible="False">
            <Settings AllowGroup="True" AllowSort="True" />
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn FieldName="Replication_key" VisibleIndex="17" Caption="Replication Key" ShowInCustomizationForm="False" Visible="False">
            <Settings AllowGroup="True" AllowSort="False" />
        </dxwgv:GridViewDataTextColumn>
    </Columns>
    <SettingsPager Position="Top">
        <AllButton Visible="True">
        </AllButton>
    </SettingsPager>
    <SettingsDetail IsDetailGrid="True" AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
    <Settings ShowFilterRow="True" ShowFilterRowMenu="True" ShowGroupPanel="True" />
</dxwgv:ASPxGridView>

