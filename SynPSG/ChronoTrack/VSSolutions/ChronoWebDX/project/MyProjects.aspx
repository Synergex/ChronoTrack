<%@ Page Title="ChronoTrack: Project Home" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="MyProjects.aspx.cs" Inherits="project_MyProjects" %>

<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dxp" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxGridView" tagprefix="dxwgv" %>
<%@ Register src="../controls/selectors/ConsultantProjectCombo.ascx" tagname="ConsultantProjectCombo" tagprefix="uc1" %>

<%@ Register src="controls/ProjectMasterTable.ascx" tagname="ProjectMasterTable" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="850px" HeaderText="My Projects">
                <PanelCollection>
                    <dxrp:PanelContent>
                        <!-- Project master -->
                        <uc2:ProjectMasterTable ID="ucProjectMaster" runat="server" OnSelectedProjectChanged="ucProjectMaster_SelectedProjectChanged" />
                        
                        <dxp:ASPxPanel ID="pnlProjectDetail" runat="server" Width="100%" Visible="false">
                            <PanelCollection>
                                <dxp:PanelContent>

                                    <!-- Consultants -->
                                    <div style="float:right;">
                                        <table border="0">
                                            <tr>
                                                <td>
                                                    <dxe:ASPxCheckBox ID="chkConsultantGroup" runat="server" Text="Grouping" AutoPostBack="True" oncheckedchanged="chkConsultantGroup_CheckedChanged">
                                                    </dxe:ASPxCheckBox>
                                                </td>
                                                <td>
                                                    <dxe:ASPxCheckBox ID="chkConsultantFilter" runat="server" Text="Filtering" AutoPostBack="True" oncheckedchanged="chkConsultantFilter_CheckedChanged">
                                                    </dxe:ASPxCheckBox>
                                                </td>
                                                <td>
                                                    <dxe:ASPxButton ID="btnAddConsultant" runat="server" Text="Add Consultant" OnClick="btnAddConsultant_Click" Width="120px">
                                                    </dxe:ASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>                        
                                    <dxwgv:ASPxGridView ID="grdConsultants" runat="server" AutoGenerateColumns="False" KeyFieldName="User_id" Width="100%" OnCustomButtonCallback="gridCustomButtonCallback">
                                        <Columns>
                                            <dxwgv:GridViewDataTextColumn Caption="Name" FieldName="Friendly_name" VisibleIndex="1" Width="140px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Job Title" FieldName="Title" VisibleIndex="2" Width="180px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Office Phone" FieldName="Office_phone" VisibleIndex="3" Width="120px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Mobile Phone" FieldName="Mobile_phone" VisibleIndex="4" Width="120px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Email Address" FieldName="Email" Visible="false" VisibleIndex="0">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Synergygrfa" Visible="False" VisibleIndex="0">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="User_id" ReadOnly="True" Visible="False" VisibleIndex="0">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Password" Visible="False" VisibleIndex="0">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataCheckColumn FieldName="Inactive" Visible="False" VisibleIndex="0">
                                            </dxwgv:GridViewDataCheckColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="First_name" Visible="False" VisibleIndex="0">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Last_name" Visible="False" VisibleIndex="0">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Addr1" Visible="False" VisibleIndex="1">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Addr2" Visible="False" VisibleIndex="1">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Addr3" Visible="False" VisibleIndex="1">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Addr4" Visible="False" VisibleIndex="1">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="State" Visible="False" VisibleIndex="1">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Zip" Visible="False" VisibleIndex="1">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Country_id" Visible="False" VisibleIndex="1">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataCheckColumn FieldName="Is_employee" Visible="False" VisibleIndex="4">
                                            </dxwgv:GridViewDataCheckColumn>
                                            <dxwgv:GridViewDataCheckColumn FieldName="Is_manager" Visible="False" VisibleIndex="4">
                                            </dxwgv:GridViewDataCheckColumn>
                                            <dxwgv:GridViewDataCheckColumn FieldName="Is_consultant" Visible="False" VisibleIndex="4">
                                            </dxwgv:GridViewDataCheckColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Picture_file" Visible="False" VisibleIndex="4">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Replication_key" Visible="False" VisibleIndex="5">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="6" Width="100px">
                                                <ClearFilterButton Visible="True">
                                                </ClearFilterButton>
                                                <CustomButtons>
                                                    <dxwgv:GridViewCommandColumnCustomButton ID="DeleteConsultant" Text="Delete">
                                                    </dxwgv:GridViewCommandColumnCustomButton>
                                                </CustomButtons>
                                                <CellStyle HorizontalAlign="Center" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                            </dxwgv:GridViewCommandColumn>
                                        </Columns>
                                        <Settings UseFixedTableLayout="True" ShowFilterRowMenu="True" ShowTitlePanel="True" />
                                        <SettingsDetail ShowDetailRow="true" ShowDetailButtons="true" />
                                        <SettingsPager PageSize="5">
                                            <AllButton Visible="True">
                                            </AllButton>
                                        </SettingsPager>
                                        <SettingsText Title="Consultants & Rates" />
                                        <Templates>
                                            <DetailRow>
                                                <dxwgv:ASPxGridView ID="grdFees" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="Fee_type_id" oninit="grdFees_Init">
                                                    <Columns>
                                                        <dxwgv:GridViewDataTextColumn FieldName="User_id" Visible="False" VisibleIndex="0">
                                                        </dxwgv:GridViewDataTextColumn>
                                                        <dxwgv:GridViewDataTextColumn Caption="Fee Type" FieldName="Fee_type_id" Visible="false" VisibleIndex="0">
                                                        </dxwgv:GridViewDataTextColumn>
                                                        <dxwgv:GridViewDataTextColumn Caption="Description" FieldName="Description" VisibleIndex="0">
                                                        </dxwgv:GridViewDataTextColumn>
                                                        <dxwgv:GridViewDataTextColumn Caption="Charge" FieldName="Cost" VisibleIndex="1" Width="130px">
                                                            <HeaderStyle HorizontalAlign="Right" />
                                                        </dxwgv:GridViewDataTextColumn>
                                                    </Columns>
                                                    <SettingsBehavior AllowSort="false" />
                                                    <SettingsDetail IsDetailGrid="true" />
                                                </dxwgv:ASPxGridView>
                                            </DetailRow>
                                        </Templates>
                                    </dxwgv:ASPxGridView>
                                    <asp:ObjectDataSource ID="dsConsultants" runat="server" DataObjectTypeName="ChronoTrack.User" DeleteMethod="DeleteUser" InsertMethod="AddUser" OldValuesParameterFormatString="original_{0}" SelectMethod="GetProjectConsultants" TypeName="UserBLL" UpdateMethod="UpdateUser">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="ucProjectMaster" Name="projectId" PropertyName="SelectedProjectId" Type="Int32" />
                                        </SelectParameters>
                                    </asp:ObjectDataSource>

                                    <!-- Notes -->
                                    <br />
                                    <div style="float:right;">
                                        <table border="0">
                                            <tr>
                                                <td>
                                                    <dxe:ASPxCheckBox ID="chkNoteGroup" runat="server" Text="Grouping" AutoPostBack="True" oncheckedchanged="chkNoteGroup_CheckedChanged">
                                                    </dxe:ASPxCheckBox>
                                                </td>
                                                <td>
                                                    <dxe:ASPxCheckBox ID="chkNoteFilter" runat="server" Text="Filtering" AutoPostBack="True" oncheckedchanged="chkNoteFilter_CheckedChanged">
                                                    </dxe:ASPxCheckBox>
                                                </td>
                                                <td>
                                                    <dxe:ASPxButton ID="btnAddNote" runat="server" Text="Add Note" OnClick="btnAddNote_Click" Width="120px">
                                                    </dxe:ASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>                        
                                    <dxwgv:ASPxGridView ID="grdNotes" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="Note_id" oncustombuttoncallback="gridCustomButtonCallback" OnDetailRowExpandedChanged="grdNotes_DetailRowExpandedChanged" EnableCallBacks="false">
                                        <Columns>
                                            <dxwgv:GridViewDataTextColumn FieldName="Project_id" Visible="False" VisibleIndex="0">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Note #" FieldName="Note_id" Visible="False" VisibleIndex="0" Width="40px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataDateColumn Caption="Date" FieldName="Created_date" VisibleIndex="0" Width="80px">
                                            </dxwgv:GridViewDataDateColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Consultant" FieldName="Created_by" VisibleIndex="1" Width="140px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Subject" FieldName="Description" VisibleIndex="2">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="3" Width="100px">
                                                <ClearFilterButton Visible="True">
                                                </ClearFilterButton>
                                                <CustomButtons>
                                                    <dxwgv:GridViewCommandColumnCustomButton ID="EditNote" Text="Edit">
                                                    </dxwgv:GridViewCommandColumnCustomButton>
                                                    <dxwgv:GridViewCommandColumnCustomButton ID="DeleteNote" Text="Delete">
                                                    </dxwgv:GridViewCommandColumnCustomButton>
                                                </CustomButtons>
                                                <CellStyle HorizontalAlign="Center" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                            </dxwgv:GridViewCommandColumn>
                                        </Columns>
                                        <Templates>
                                            <DetailRow>
                                                <dxe:ASPxLabel ID="lblNoteDetail" runat="server" Text="" oninit="lblNoteDetail_Init">
                                                </dxe:ASPxLabel>
                                            </DetailRow>
                                        </Templates>
                                        <Settings UseFixedTableLayout="True" ShowFilterRowMenu="True" ShowTitlePanel="True" />
                                        <SettingsDetail ShowDetailRow="True" AllowOnlyOneMasterRowExpanded="True" />
                                        <SettingsPager PageSize="5">
                                            <AllButton Visible="True">
                                            </AllButton>
                                        </SettingsPager>
                                        <SettingsText Title="Notes" />
                                    </dxwgv:ASPxGridView>
                                    <asp:ObjectDataSource ID="dsNotes" runat="server" DataObjectTypeName="ChronoTrack.Project_note" DeleteMethod="DeleteNote" InsertMethod="AddProjectNote" OldValuesParameterFormatString="original_{0}" SelectMethod="GetProjectNotesSummary" TypeName="ProjectNoteBLL" UpdateMethod="UpdateProjectNote">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="ucProjectMaster" Name="ProjectId" PropertyName="SelectedProjectId" Type="Int32" />
                                        </SelectParameters>
                                    </asp:ObjectDataSource>

                                    <!-- Tasks -->
                                    <br />
                                    <div style="float:right;">
                                        <table border="0">
                                            <tr>
                                                <td>
                                                    <dxe:ASPxCheckBox ID="chkTaskGroup" runat="server" Text="Grouping" AutoPostBack="True" oncheckedchanged="chkTaskGroup_CheckedChanged">
                                                    </dxe:ASPxCheckBox>
                                                </td>
                                                <td>
                                                    <dxe:ASPxCheckBox ID="chkTaskFilter" runat="server" Text="Filtering" AutoPostBack="True" oncheckedchanged="chkTaskFilter_CheckedChanged">
                                                    </dxe:ASPxCheckBox>
                                                </td>
                                                <td>
                                                    <dxe:ASPxButton ID="btnAddTask" runat="server" Text="Add Task" Width="120px" OnClick="btnAddTask_Click">
                                                    </dxe:ASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>                        
                                    <dxwgv:ASPxGridView ID="grdTasks" runat="server" AutoGenerateColumns="False" Width="100%" OnDetailRowExpandedChanged="grdTasks_DetailRowExpandedChanged" KeyFieldName="Task_id" EnableCallBacks="false" oncustombuttoncallback="gridCustomButtonCallback">
                                        <Columns>
                                            <dxwgv:GridViewDataTextColumn FieldName="Project_id" Visible="False" VisibleIndex="0">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Task" FieldName="Task_id" VisibleIndex="1" Width="30px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Type" FieldName="Task_type" VisibleIndex="2" Width="120px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Description" FieldName="Description" VisibleIndex="3">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Assigned To" FieldName="Assigned_to" VisibleIndex="4" Width="100px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataDateColumn Caption="Start Date" FieldName="Start_date" VisibleIndex="5" Width="70px">
                                            </dxwgv:GridViewDataDateColumn>
                                            <dxwgv:GridViewDataDateColumn Caption="End Date" FieldName="End_date" VisibleIndex="6" Width="70px">
                                            </dxwgv:GridViewDataDateColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Done" FieldName="Completed" VisibleIndex="7" Width="30px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="8" Width="100px">
                                                <ClearFilterButton Visible="True">
                                                </ClearFilterButton>
                                                <CustomButtons>
                                                    <dxwgv:GridViewCommandColumnCustomButton ID="EditTask" Text="Edit">
                                                    </dxwgv:GridViewCommandColumnCustomButton>
                                                    <dxwgv:GridViewCommandColumnCustomButton ID="DeleteTask" Text="Delete">
                                                    </dxwgv:GridViewCommandColumnCustomButton>
                                                </CustomButtons>
                                                <CellStyle HorizontalAlign="Center" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                            </dxwgv:GridViewCommandColumn>
                                        </Columns>
                                        <Templates>
                                            <DetailRow>
                                                <div style="float:right;">
                                                    <dxe:ASPxButton ID="btnAddActivity" runat="server" Text="Add Activity" Width="120px" OnClick="btnAddActivity_Click">
                                                    </dxe:ASPxButton>
                                                </div>
                                                <p>
                                                <dxe:ASPxLabel ID="lblTaskDetail" runat="server" Text="" oninit="lblTaskDetail_Init" Font-Bold="true">
                                                </dxe:ASPxLabel>
                                                </p>
                                                <dxwgv:ASPxGridView ID="grdActivities" runat="server" AutoGenerateColumns="False" Width="100%" KeyFieldName="Project_id" oninit="grdActivities_Init">
                                                    <Columns>
                                                        <dxwgv:GridViewDataTextColumn FieldName="Synergygrfa" Visible="False" VisibleIndex="0">
                                                        </dxwgv:GridViewDataTextColumn>
                                                        <dxwgv:GridViewDataTextColumn FieldName="Project_id" ReadOnly="True" Visible="False" VisibleIndex="0">
                                                        </dxwgv:GridViewDataTextColumn>
                                                        <dxwgv:GridViewDataTextColumn FieldName="Task_id" ReadOnly="True" Visible="False" VisibleIndex="0">
                                                        </dxwgv:GridViewDataTextColumn>
                                                        <dxwgv:GridViewDataTextColumn FieldName="Activity_id" ReadOnly="True" VisibleIndex="0" Caption="#" Width="40px">
                                                            <CellStyle HorizontalAlign="Left">
                                                            </CellStyle>
                                                        </dxwgv:GridViewDataTextColumn>
                                                        <dxwgv:GridViewDataTextColumn FieldName="Description" VisibleIndex="1" Caption="Subject">
                                                        </dxwgv:GridViewDataTextColumn>
                                                        <dxwgv:GridViewDataDateColumn FieldName="Start_date" VisibleIndex="2" Caption="Date" Width="70px">
                                                        </dxwgv:GridViewDataDateColumn>
                                                        <dxwgv:GridViewDataDateColumn FieldName="Start_time" VisibleIndex="3" Caption="Time" Width="40px">
                                                            <PropertiesDateEdit DisplayFormatString="t">
                                                            </PropertiesDateEdit>
                                                        </dxwgv:GridViewDataDateColumn>
                                                        <dxwgv:GridViewDataDateColumn FieldName="End_date" VisibleIndex="4" Visible="False" Width="70px">
                                                        </dxwgv:GridViewDataDateColumn>
                                                        <dxwgv:GridViewDataDateColumn FieldName="End_time" VisibleIndex="5" Visible="False" Width="40px">
                                                            <PropertiesDateEdit DisplayFormatString="t">
                                                            </PropertiesDateEdit>
                                                        </dxwgv:GridViewDataDateColumn>
                                                        <dxwgv:GridViewDataTextColumn FieldName="Created_by" Visible="False" VisibleIndex="6">
                                                        </dxwgv:GridViewDataTextColumn>
                                                        <dxwgv:GridViewDataDateColumn FieldName="Created_date" Visible="False" VisibleIndex="6">
                                                        </dxwgv:GridViewDataDateColumn>
                                                        <dxwgv:GridViewDataTextColumn FieldName="Modified_by" Visible="False" VisibleIndex="6">
                                                        </dxwgv:GridViewDataTextColumn>
                                                        <dxwgv:GridViewDataDateColumn FieldName="Modified_date" Visible="False" VisibleIndex="6">
                                                        </dxwgv:GridViewDataDateColumn>
                                                        <dxwgv:GridViewDataTextColumn FieldName="Text" VisibleIndex="4" Caption="Details">
                                                        </dxwgv:GridViewDataTextColumn>
                                                        <dxwgv:GridViewDataTextColumn FieldName="Replication_key" Visible="False" VisibleIndex="6">
                                                        </dxwgv:GridViewDataTextColumn>
                                                    </Columns>
                                                    <SettingsBehavior AllowSort="false" />
                                                    <SettingsDetail IsDetailGrid="true" />
                                                </dxwgv:ASPxGridView>
                                                <asp:ObjectDataSource ID="dsActivities" runat="server" DataObjectTypeName="ChronoTrack.Project_activity" DeleteMethod="DeleteProjectActivity" InsertMethod="AddProjectActivity" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllProjectActivitys" TypeName="ProjectActivityBLL" UpdateMethod="UpdateProjectActivity">
                                                    <SelectParameters>
                                                        <asp:SessionParameter Name="ProjectId" SessionField="ProjectId" Type="Int32" />
                                                        <asp:SessionParameter Name="TaskId" SessionField="TaskId" Type="Int32" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                            </DetailRow>
                                        </Templates>
                                        <Settings UseFixedTableLayout="True" ShowFilterRowMenu="True" ShowGroupButtons="False" ShowTitlePanel="True" />
                                        <SettingsPager PageSize="5">
                                            <AllButton Visible="True">
                                            </AllButton>
                                        </SettingsPager>
                                        <SettingsDetail AllowOnlyOneMasterRowExpanded="True" ShowDetailRow="True" />
                                        <SettingsText Title="Tasks &amp; Activities" />
                                    </dxwgv:ASPxGridView>
                                    <asp:ObjectDataSource ID="dsTasks" runat="server" DataObjectTypeName="ChronoTrack.Project_task" DeleteMethod="DeleteProjectTask" InsertMethod="AddProjectTask" OldValuesParameterFormatString="original_{0}" SelectMethod="GetProjectTasksSummary" TypeName="ProjectTaskBLL" UpdateMethod="UpdateProjectTask">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="ucProjectMaster" Name="ProjectId" PropertyName="SelectedProjectId" Type="Int32" />
                                        </SelectParameters>
                                    </asp:ObjectDataSource>

                                    <!-- Expenses -->
                                    <br />
                                    <div style="float:right;">
                                        <table border="0">
                                            <tr>
                                                <td>
                                                    <dxe:ASPxCheckBox ID="chkExpenseGroup" runat="server" Text="Grouping" AutoPostBack="True" oncheckedchanged="chkExpenseGroup_CheckedChanged">
                                                    </dxe:ASPxCheckBox>
                                                </td>
                                                <td>
                                                    <dxe:ASPxCheckBox ID="chkExpenseFilter" runat="server" Text="Filtering" AutoPostBack="True" oncheckedchanged="chkExpenseFilter_CheckedChanged">
                                                    </dxe:ASPxCheckBox>
                                                </td>
                                                <td>
                                                    <dxe:ASPxButton ID="btnAddExpense" runat="server" Text="Add Expense" Width="120px" OnClick="btnAddExpense_Click">
                                                    </dxe:ASPxButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>                        
                                    <dxwgv:ASPxGridView ID="grdExpenses" runat="server" AutoGenerateColumns="False" Width="100%" oncustombuttoncallback="gridCustomButtonCallback" EnableCallBacks="False" >
                                        <Columns>
                                            <dxwgv:GridViewDataTextColumn FieldName="Project_id" Visible="False" VisibleIndex="0">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn FieldName="Expense_id" Visible="False" VisibleIndex="0">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataDateColumn Caption="Date" FieldName="Expense_date" VisibleIndex="0" Width="60px">
                                            </dxwgv:GridViewDataDateColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Consultant" FieldName="Expensed_by" VisibleIndex="1" Width="90px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Description" FieldName="Description" VisibleIndex="2">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Estimate" FieldName="Is_estimate" VisibleIndex="3" Width="50px">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Currency" FieldName="Currency_code" VisibleIndex="4" Visible="False">
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Price Each" FieldName="Unit_price" VisibleIndex="4" Width="60px">
                                                <PropertiesTextEdit DisplayFormatString="{0:c}">
                                                </PropertiesTextEdit>
                                                <HeaderStyle HorizontalAlign="Right" />
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Quantity" FieldName="Quantity" VisibleIndex="5" Width="50px">
                                                <HeaderStyle HorizontalAlign="Right" />
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewDataTextColumn Caption="Total" FieldName="Total_price" VisibleIndex="6" Width="70px">
                                                <PropertiesTextEdit DisplayFormatString="{0:c}">
                                                </PropertiesTextEdit>
                                                <HeaderStyle HorizontalAlign="Right" />
                                            </dxwgv:GridViewDataTextColumn>
                                            <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="7" Width="100px">
                                                <ClearFilterButton Visible="True">
                                                </ClearFilterButton>
                                                <CustomButtons>
                                                    <dxwgv:GridViewCommandColumnCustomButton ID="EditExpense" Text="Edit">
                                                    </dxwgv:GridViewCommandColumnCustomButton>
                                                    <dxwgv:GridViewCommandColumnCustomButton ID="DeleteExpense" Text="Delete">
                                                    </dxwgv:GridViewCommandColumnCustomButton>
                                                </CustomButtons>
                                                <CellStyle HorizontalAlign="Center" />
                                                <HeaderStyle HorizontalAlign="Center" />
                                            </dxwgv:GridViewCommandColumn>
                                        </Columns>
                                        <TotalSummary>
                                            <dxwgv:ASPxSummaryItem DisplayFormat="{0:c}" FieldName="Total_price" ShowInColumn="Total" SummaryType="Sum" />
                                        </TotalSummary>
                                        <Settings ShowFilterRowMenu="True" ShowTitlePanel="True" UseFixedTableLayout="True" ShowFooter="True" />
                                        <SettingsPager PageSize="5">
                                            <AllButton Visible="True">
                                            </AllButton>
                                        </SettingsPager>
                                        <SettingsText Title="Expenses" />
                                    </dxwgv:ASPxGridView>
                                    <asp:ObjectDataSource ID="dsExpenses" runat="server" DataObjectTypeName="ChronoTrack.Project_expense" DeleteMethod="DeleteExpense" InsertMethod="AddProjectExpense" OldValuesParameterFormatString="original_{0}" SelectMethod="GetProjectExpensesSummary" TypeName="ProjectExpenseBLL" UpdateMethod="UpdateProjectExpense">
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="ucProjectMaster" Name="ProjectId" PropertyName="SelectedProjectId" Type="Int32" />
                                        </SelectParameters>
                                    </asp:ObjectDataSource>
                                </dxp:PanelContent>
                            </PanelCollection>
                        </dxp:ASPxPanel>
                    </dxrp:PanelContent>
                </PanelCollection>
            </dxrp:ASPxRoundPanel>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

