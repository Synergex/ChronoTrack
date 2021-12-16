<%@ Page Title="ChronoTrack: Add COnsultant to Project" Language="C#" MasterPageFile="~/LoggedInMaster.master" AutoEventWireup="true" CodeFile="ProjectConsultant.aspx.cs" Inherits="project_ProjectConsultant" %>

<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxRoundPanel" TagPrefix="dxrp" %>
<%@ Register assembly="DevExpress.Web.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPanel" tagprefix="dxp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeaderContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
    
    <dxrp:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="850px" HeaderText="Add Consultant to Project">
        <PanelCollection>
            <dxp:PanelContent runat="server">
                <asp:MultiView ID="multiView" runat="server">
                    <asp:View ID="normalView" runat="server">
                        <div style="float:right;">
                            <table border="0">
                                <tr>
                                    <td>
                                        <dxe:ASPxButton ID="btnAddConsultant" runat="server" Text="Add Consultant" OnClick="btnAddConsultant_Click" Enabled="false">
                                        </dxe:ASPxButton>
                                    </td>
                                    <td>
                                        <dxe:ASPxButton ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CausesValidation="false">
                                        </dxe:ASPxButton>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        <table border="0">
                            <tr>
                                <td>
                                    <dxe:ASPxLabel ID="ASPxLabel2" runat="server" Text="Project">
                                    </dxe:ASPxLabel>
                                </td>
                                <td>
                                    <dxe:ASPxTextBox ID="txtProjectId" runat="server" MaxLength="8" Size="10" ReadOnly="true">
                                    </dxe:ASPxTextBox>
                                </td>
                                <td>
                                    <dxe:ASPxLabel ID="ASPxLabel1" runat="server" Text="Consultant">
                                    </dxe:ASPxLabel>
                                </td>
                                <td>
                                    <dxe:ASPxComboBox ID="cboConsultant" runat="server" OnSelectedIndexChanged="cboConsultant_SelectedIndexChanged" AutoPostBack="true">
                                    </dxe:ASPxComboBox>
                                </td>
                            </tr>
                        </table>
                        <br />
                        <dxwgv:ASPxGridView ID="grdFees" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="dsConsultantFees" KeyFieldName="Fee_type_id" OnCustomButtonCallback="grdFees_CustomButtonCallback">
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
                                <dxwgv:GridViewCommandColumn Caption="Options" VisibleIndex="2" Width="120px">
                                    <CustomButtons>
                                        <dxwgv:GridViewCommandColumnCustomButton ID="Delete" Text="Delete">
                                        </dxwgv:GridViewCommandColumnCustomButton>
                                    </CustomButtons>
                                    <HeaderStyle HorizontalAlign="Center" />
                                </dxwgv:GridViewCommandColumn>
                            </Columns>
                        </dxwgv:ASPxGridView>
                        <asp:ObjectDataSource ID="dsConsultantFees" runat="server" DataObjectTypeName="ChronoTrack.Consultant_fee" DeleteMethod="DeleteConsultantFee" InsertMethod="AddConsultantFee" OldValuesParameterFormatString="original_{0}" SelectMethod="GetConsultantFeesSummary" TypeName="ConsultantFeeBLL" UpdateMethod="UpdateConsultantFee">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="cboConsultant" Name="UserId" PropertyName="Value" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </asp:View>
                    <asp:View ID="noProjectView" runat="server">
                        You must select a project before you can add a consultent.  Please use 
                        <dxe:ASPxHyperLink ID="ASPxHyperLink1" runat="server" Text="My Projects" NavigateUrl="~/project/MyProjects.aspx" />
                         to select a project.
                    </asp:View>
                    <asp:View ID="noConsultantView" runat="server">
                        No consultants are available at this time. This means that all available
                        consultants are already assigned to the project. Return to 
                        <dxe:ASPxHyperLink ID="ASPxHyperLink2" runat="server" Text="My Projects" NavigateUrl="~/project/MyProjects.aspx" />.
                    </asp:View>
                </asp:MultiView>
            </dxp:PanelContent>
        </PanelCollection>
    </dxrp:ASPxRoundPanel>

    </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>

