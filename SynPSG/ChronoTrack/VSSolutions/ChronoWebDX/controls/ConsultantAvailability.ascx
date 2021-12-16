<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ConsultantAvailability.ascx.cs" Inherits="controls_ConsultantAvailability" %>

<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dxwschs" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.2, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register assembly="DevExpress.XtraScheduler.v9.2.Core, Version=9.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraScheduler" tagprefix="cc1" %>
<div style="float:right;">
    <dxe:ASPxRadioButtonList ID="rblGroupBy" runat="server" Text="Group Appointments By" AutoPostBack="True" SelectedIndex="0" onselectedindexchanged="rblGroupBy_SelectedIndexChanged" RepeatDirection="Horizontal">
        <Border BorderStyle="None" />
        <Items>
            <dxe:ListEditItem Text="Group By Date" Value="D" />
            <dxe:ListEditItem Text="Group by Resource" Value="R" />
            <dxe:ListEditItem Text="Don't Group" Value="N" />
        </Items>
    </dxe:ASPxRadioButtonList>
</div>
<dxwschs:ASPxScheduler ID="schedulerControl" runat="server" Start="2009-01-01" ActiveViewType="Timeline" GroupType="Date" Width="100%" ResourceDataSourceID="dsResource" AppointmentDataSourceID="dsAppointment" onactiveviewchanged="schedulerControl_ActiveViewChanged">
    <Storage>
        <Appointments>
            <Mappings AppointmentId="Id" Description="Description" End="EndTime" ResourceId="ResourceId" Start="StartTime" Label="AppointmentType" Location="Location" Status="Status" Subject="Subject" />
        </Appointments>
        <Resources>
            <Mappings Caption="Friendly_name" ResourceId="User_id" />
        </Resources>
    </Storage>
    <OptionsView ShowOnlyResourceAppointments="True">
    </OptionsView>
    <LimitInterval Duration="36158.23:59:00" Start="2009-01-01" />
    <Views>
        <WeekView>
        </WeekView>
        <MonthView>
        </MonthView>
        <DayView>
            <WorkTime End="17:00:00" Start="08:00:00" />
            <TimeSlots>
                <cc1:TimeSlot DisplayName="60 Minutes" MenuCaption="6&amp;0 Minutes" Value="01:00:00" />
                <cc1:TimeSlot DisplayName="30 Minutes" MenuCaption="&amp;30 Minutes" Value="00:30:00" />
                <cc1:TimeSlot DisplayName="15 Minutes" MenuCaption="&amp;15 Minutes" Value="00:15:00" />
            </TimeSlots>
            <TimeRulers>
                <cc1:TimeRuler>
                </cc1:TimeRuler>
            </TimeRulers>
        </DayView>
        <WorkWeekView>
            <WorkTime End="17:00:00" Start="08:00:00" />
            <TimeSlots>
                <cc1:TimeSlot DisplayName="60 Minutes" MenuCaption="6&amp;0 Minutes" Value="01:00:00" />
                <cc1:TimeSlot DisplayName="30 Minutes" MenuCaption="&amp;30 Minutes" Value="00:30:00" />
                <cc1:TimeSlot DisplayName="15 Minutes" MenuCaption="&amp;15 Minutes" Value="00:15:00" />
            </TimeSlots>
            <TimeRulers>
                <cc1:TimeRuler>
                </cc1:TimeRuler>
            </TimeRulers>
        </WorkWeekView>
        <TimelineView IntervalCount="14">
            <WorkTime End="17:00:00" Start="08:00:00" />
            <Scales>
                <cc1:TimeScaleYear />
                <cc1:TimeScaleQuarter Enabled="False" />
                <cc1:TimeScaleMonth />
                <cc1:TimeScaleWeek Enabled="False" />
                <cc1:TimeScaleDay DisplayFormat="dd" />
                <cc1:TimeScaleHour Enabled="False" />
                <cc1:TimeScaleFixedInterval Enabled="False" />
            </Scales>
            <TimelineViewStyles>
                <TimelineCellBody Height="60px">
                </TimelineCellBody>
            </TimelineViewStyles>
            <AppointmentDisplayOptions EndTimeVisibility="Never" ShowReminder="False" StartTimeVisibility="Never" StatusDisplayType="Time" AppointmentHeight="30" SnapToCellsMode="Never" />
        </TimelineView>
    </Views>
    <OptionsBehavior ShowViewSelector="true" />
    <OptionsCustomization AllowAppointmentCopy="None" AllowAppointmentCreate="None" AllowAppointmentDelete="None" AllowAppointmentDrag="None" AllowAppointmentDragBetweenResources="None" AllowAppointmentResize="None" AllowDisplayAppointmentForm="Always" />
    <ResourceNavigator Visibility="Always" />
</dxwschs:ASPxScheduler>
<asp:ObjectDataSource ID="dsAppointment" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetConsultantSchedule" TypeName="ConsultantScheduleBLL"></asp:ObjectDataSource>
<asp:ObjectDataSource ID="dsResource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetAllConsultants" TypeName="UserBLL"></asp:ObjectDataSource>
