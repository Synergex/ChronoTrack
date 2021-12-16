<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProjectTaskActivities.ascx.cs" Inherits="controls_ProjectTaskActivities" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<dxwgv:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" Caption="Task Activities" KeyFieldName="Task_id" Width="100%">
    <Columns>
        <dxwgv:GridViewDataTextColumn FieldName="Synergygrfa" ShowInCustomizationForm="False" Visible="False" VisibleIndex="0">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn Caption="Project" FieldName="Project_id" ReadOnly="True" Visible="False" VisibleIndex="0" Width="40px">
            <CellStyle HorizontalAlign="Left">
            </CellStyle>
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn Caption="Task" FieldName="Task_id" ReadOnly="True" Visible="False" VisibleIndex="0" Width="30px">
            <CellStyle HorizontalAlign="Left">
            </CellStyle>
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn Caption="Activity" FieldName="Activity_id" ReadOnly="True" VisibleIndex="0" Width="30px">
            <CellStyle HorizontalAlign="Left">
            </CellStyle>
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn Caption="Description" FieldName="Description" VisibleIndex="1">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataDateColumn Caption="Start Date" FieldName="Start_date" VisibleIndex="2" Width="80px">
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataDateColumn Caption="Start Time" FieldName="Start_time" Visible="False" VisibleIndex="3" Width="60px">
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataDateColumn Caption="End Date" FieldName="End_date" VisibleIndex="3" Width="80px">
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataDateColumn Caption="End Time" FieldName="End_time" Visible="False" VisibleIndex="4" Width="60px">
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataTextColumn Caption="Created By" FieldName="Created_by" Visible="False" VisibleIndex="4" Width="80px">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataDateColumn Caption="Created" FieldName="Created_date" Visible="False" VisibleIndex="4" Width="60px">
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataTextColumn Caption="Modified By" FieldName="Modified_by" Visible="False" VisibleIndex="4" Width="80px">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataDateColumn Caption="Modified" FieldName="Modified_date" Visible="False" VisibleIndex="4" Width="80px">
        </dxwgv:GridViewDataDateColumn>
        <dxwgv:GridViewDataTextColumn Caption="Detail" FieldName="Text" Visible="False" VisibleIndex="4">
        </dxwgv:GridViewDataTextColumn>
        <dxwgv:GridViewDataTextColumn Caption="Replication Key" FieldName="Replication_key" ShowInCustomizationForm="False" Visible="False" VisibleIndex="4">
        </dxwgv:GridViewDataTextColumn>
    </Columns>
</dxwgv:ASPxGridView>
<asp:ObjectDataSource ID="ds" runat="server" DataObjectTypeName="ChronoTrack.Project_activity" DeleteMethod="DeleteProjectActivity" InsertMethod="AddProjectActivity" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllProjectActivitys" TypeName="ProjectActivityBLL" UpdateMethod="UpdateProjectActivity">
    <SelectParameters>
        <asp:SessionParameter Name="ProjectId" SessionField="CurrentProject" Type="Int32" />
        <asp:SessionParameter Name="TaskId" SessionField="CurrentProjectTask" Type="Int32" />
    </SelectParameters>
</asp:ObjectDataSource>