// Generated on 09-Sep-2009 2:27:52 by gencs v1.0.11.0
using System;
using System.Collections;
using System.Reflection;
using Synergex.xfnlnet;
namespace ChronoTrack
{
/// <summary>
/// Interface ChronoTrack
/// </summary>
#if POOLING
	public interface IChronoTrack : IDisposable
#else
	public interface IChronoTrack
#endif
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectActivity"></param>
		/// <returns></returns>
		bool CreateActivity (
			string UserToken
			,ref Project_activity ProjectActivity
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectAttachment"></param>
		/// <returns></returns>
		bool CreateAttachment (
			string UserToken
			,ref Project_attachment ProjectAttachment
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantFee"></param>
		/// <returns></returns>
		bool CreateConsultantFee (
			string UserToken
			,ref Consultant_fee ConsultantFee
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Country"></param>
		/// <returns></returns>
		bool CreateCountry (
			string UserToken
			,ref Country Country
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Customer"></param>
		/// <returns></returns>
		bool CreateCustomer (
			string UserToken
			,ref Customer Customer
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContact"></param>
		/// <returns></returns>
		bool CreateCustomerContact (
			string UserToken
			,ref Customer_contact CustomerContact
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContract"></param>
		/// <returns></returns>
		bool CreateCustomerContract (
			string UserToken
			,ref Customer_contract CustomerContract
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerLocation"></param>
		/// <returns></returns>
		bool CreateCustomerLocation (
			string UserToken
			,ref Customer_location CustomerLocation
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectExpense"></param>
		/// <returns></returns>
		bool CreateExpense (
			string UserToken
			,ref Project_expense ProjectExpense
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ExpenseType"></param>
		/// <returns></returns>
		bool CreateExpenseType (
			string UserToken
			,ref Expense_type ExpenseType
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="FeeType"></param>
		/// <returns></returns>
		bool CreateFeeType (
			string UserToken
			,ref Fee_type FeeType
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectNote"></param>
		/// <returns></returns>
		bool CreateNote (
			string UserToken
			,ref Project_note ProjectNote
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Project"></param>
		/// <returns></returns>
		bool CreateProject (
			string UserToken
			,ref Project Project
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectConsultant"></param>
		/// <returns></returns>
		bool CreateProjectRate (
			string UserToken
			,ref Project_consultant ProjectConsultant
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Request"></param>
		/// <returns></returns>
		bool CreateRequest (
			string UserToken
			,ref Request Request
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="State"></param>
		/// <returns></returns>
		bool CreateState (
			string UserToken
			,ref State State
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectTask"></param>
		/// <returns></returns>
		bool CreateTask (
			string UserToken
			,ref Project_task ProjectTask
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="TaskType"></param>
		/// <returns></returns>
		bool CreateTaskType (
			string UserToken
			,ref Task_type TaskType
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="User"></param>
		/// <returns></returns>
		bool CreateUser (
			string UserToken
			,ref User User
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectActivity"></param>
		/// <returns></returns>
		bool DeleteActivity (
			string UserToken
			,Project_activity ProjectActivity
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectAttachment"></param>
		/// <returns></returns>
		bool DeleteAttachment (
			string UserToken
			,Project_attachment ProjectAttachment
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantFee"></param>
		/// <returns></returns>
		bool DeleteConsultantFee (
			string UserToken
			,Consultant_fee ConsultantFee
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerId"></param>
		/// <param name="ContactId"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool DeleteContact (
			string UserToken
			,string CustomerId
			,int ContactId
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Country"></param>
		/// <returns></returns>
		bool DeleteCountry (
			string UserToken
			,Country Country
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Customer"></param>
		/// <returns></returns>
		bool DeleteCustomer (
			string UserToken
			,Customer Customer
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContact"></param>
		/// <returns></returns>
		bool DeleteCustomerContact (
			string UserToken
			,Customer_contact CustomerContact
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContract"></param>
		/// <returns></returns>
		bool DeleteCustomerContract (
			string UserToken
			,Customer_contract CustomerContract
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerLocation"></param>
		/// <returns></returns>
		bool DeleteCustomerLocation (
			string UserToken
			,Customer_location CustomerLocation
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectExpense"></param>
		/// <returns></returns>
		bool DeleteExpense (
			string UserToken
			,Project_expense ProjectExpense
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ExpenseType"></param>
		/// <returns></returns>
		bool DeleteExpenseType (
			string UserToken
			,Expense_type ExpenseType
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="FeeType"></param>
		/// <returns></returns>
		bool DeleteFeeType (
			string UserToken
			,Fee_type FeeType
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectNote"></param>
		/// <returns></returns>
		bool DeleteNote (
			string UserToken
			,Project_note ProjectNote
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Project"></param>
		/// <returns></returns>
		bool DeleteProject (
			string UserToken
			,Project Project
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectConsultant"></param>
		/// <returns></returns>
		bool DeleteProjectRate (
			string UserToken
			,Project_consultant ProjectConsultant
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Request"></param>
		/// <returns></returns>
		bool DeleteRequest (
			string UserToken
			,Request Request
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="State"></param>
		/// <returns></returns>
		bool DeleteState (
			string UserToken
			,State State
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectTask"></param>
		/// <returns></returns>
		bool DeleteTask (
			string UserToken
			,Project_task ProjectTask
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="TaskType"></param>
		/// <returns></returns>
		bool DeleteTaskType (
			string UserToken
			,Task_type TaskType
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="User"></param>
		/// <returns></returns>
		bool DeleteUser (
			string UserToken
			,User User
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="fileData"></param>
		/// <returns></returns>
		int DownloadFile (
			string fileName
			,ref byte[] fileData
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="TaskID"></param>
		/// <param name="ActivityID"></param>
		/// <param name="ProjectActivity"></param>
		/// <returns></returns>
		bool GetActivity (
			string UserToken
			,int ProjectID
			,int TaskID
			,int ActivityID
			,ref Project_activity ProjectActivity
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Consultants"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetAllConsultants (
			string UserToken
			,ref UserDT Consultants
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="TaskID"></param>
		/// <param name="AttachmentID"></param>
		/// <param name="ProjectAttachment"></param>
		/// <returns></returns>
		bool GetAttachment (
			string UserToken
			,int ProjectID
			,int TaskID
			,int AttachmentID
			,ref Project_attachment ProjectAttachment
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantID"></param>
		/// <param name="FeeID"></param>
		/// <param name="ConsultantFee"></param>
		/// <returns></returns>
		bool GetConsultantFee (
			string UserToken
			,string ConsultantID
			,int FeeID
			,ref Consultant_fee ConsultantFee
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantID"></param>
		/// <param name="ConsltantFeeTable"></param>
		/// <returns></returns>
		bool GetConsultantFeeTable (
			string UserToken
			,string ConsultantID
			,ref Consultant_feeDT ConsltantFeeTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantId"></param>
		/// <param name="Fees"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetConsultantFeesSummary (
			string UserToken
			,string ConsultantId
			,ref Consultant_fee_summaryDT Fees
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantId"></param>
		/// <param name="Projects"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetConsultantProjects (
			string UserToken
			,string ConsultantId
			,ref Project_summaryDT Projects
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="userToken"></param>
		/// <param name="scheduleData"></param>
		/// <returns></returns>
		bool GetConsultantSchedule (
			string userToken
			,ref ArrayList scheduleData
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantTable"></param>
		/// <returns></returns>
		bool GetConsultantTable (
			string UserToken
			,ref UserDT ConsultantTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ContractorTable"></param>
		/// <returns></returns>
		bool GetContractorTable (
			string UserToken
			,ref UserDT ContractorTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CountryID"></param>
		/// <param name="Country"></param>
		/// <returns></returns>
		bool GetCountry (
			string UserToken
			,string CountryID
			,ref Country Country
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CountryTable"></param>
		/// <returns></returns>
		bool GetCountryTable (
			string UserToken
			,ref CountryDT CountryTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="Customer"></param>
		/// <returns></returns>
		bool GetCustomer (
			string UserToken
			,string CustomerID
			,ref Customer Customer
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="ContactID"></param>
		/// <param name="CustomerContact"></param>
		/// <returns></returns>
		bool GetCustomerContact (
			string UserToken
			,string CustomerID
			,int ContactID
			,ref Customer_contact CustomerContact
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="CustomerContactTable"></param>
		/// <returns></returns>
		bool GetCustomerContactTable (
			string UserToken
			,string CustomerID
			,ref Customer_contactDT CustomerContactTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="ContractID"></param>
		/// <param name="CustomerContract"></param>
		/// <returns></returns>
		bool GetCustomerContract (
			string UserToken
			,string CustomerID
			,string ContractID
			,ref Customer_contract CustomerContract
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="CustomerContractTable"></param>
		/// <returns></returns>
		bool GetCustomerContractTable (
			string UserToken
			,string CustomerID
			,ref Customer_contractDT CustomerContractTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="LocationID"></param>
		/// <param name="Location"></param>
		/// <returns></returns>
		bool GetCustomerLocation (
			string UserToken
			,string CustomerID
			,int LocationID
			,ref Customer_location Location
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="LocationID"></param>
		/// <param name="CustomerContactTable"></param>
		/// <returns></returns>
		bool GetCustomerLocationContacts (
			string UserToken
			,string CustomerID
			,int LocationID
			,ref Customer_contactDT CustomerContactTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="CustomerLocationTable"></param>
		/// <returns></returns>
		bool GetCustomerLocationTable (
			string UserToken
			,string CustomerID
			,ref Customer_locationDT CustomerLocationTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerTable"></param>
		/// <returns></returns>
		bool GetCustomerTable (
			string UserToken
			,ref CustomerDT CustomerTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerTable"></param>
		/// <returns></returns>
		bool GetCustomerTableBrief (
			string UserToken
			,ref Customer_breifDT CustomerTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="EmployeeTable"></param>
		/// <returns></returns>
		bool GetEmployeeTable (
			string UserToken
			,ref UserDT EmployeeTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ExpenseTypeID"></param>
		/// <param name="ProjectExpense"></param>
		/// <returns></returns>
		bool GetExpense (
			string UserToken
			,int ProjectID
			,int ExpenseTypeID
			,ref Project_expense ProjectExpense
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ExpenseTypeTable"></param>
		/// <returns></returns>
		bool GetExpenseTypeTable (
			string UserToken
			,ref Expense_typeDT ExpenseTypeTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ExpenseTypeID"></param>
		/// <param name="ExpenseType"></param>
		/// <returns></returns>
		bool GetExpenseType (
			string UserToken
			,string ExpenseTypeID
			,ref Expense_type ExpenseType
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="FeeTypeID"></param>
		/// <param name="FeeType"></param>
		/// <returns></returns>
		bool GetFeeType (
			string UserToken
			,int FeeTypeID
			,ref Fee_type FeeType
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="FeeTypeTable"></param>
		/// <returns></returns>
		bool GetFeeTypeTable (
			string UserToken
			,ref Fee_typeDT FeeTypeTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="GanttViewTable"></param>
		/// <returns></returns>
		bool GetGanttViewTable (
			string UserToken
			,ref Gantt_viewDT GanttViewTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ManagerTable"></param>
		/// <returns></returns>
		bool GetManagerTable (
			string UserToken
			,ref UserDT ManagerTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="NoteID"></param>
		/// <param name="ProjectNote"></param>
		/// <returns></returns>
		bool GetNote (
			string UserToken
			,int ProjectID
			,int NoteID
			,ref Project_note ProjectNote
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="Project"></param>
		/// <returns></returns>
		bool GetProject (
			string UserToken
			,int ProjectID
			,ref Project Project
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Tasks"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectActivities (
			string UserToken
			,int ProjectId
			,ref Project_activityDT Tasks
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Activities"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectActivitiesSummary (
			string UserToken
			,int ProjectId
			,ref Project_activity_summaryDT Activities
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="TaskID"></param>
		/// <param name="ProjectActivityTable"></param>
		/// <returns></returns>
		bool GetProjectActivityTable (
			string UserToken
			,int ProjectID
			,int TaskID
			,ref Project_activityDT ProjectActivityTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="TaskID"></param>
		/// <param name="ProjectAttachmentTable"></param>
		/// <returns></returns>
		bool GetProjectAttachmentTable (
			string UserToken
			,int ProjectID
			,int TaskID
			,ref Project_attachmentDT ProjectAttachmentTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="ConsultantId"></param>
		/// <param name="Rates"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectConsultantRates (
			string UserToken
			,int ProjectId
			,string ConsultantId
			,ref Consultant_fee_summaryDT Rates
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ConsultantID"></param>
		/// <param name="ProjectConsultantTable"></param>
		/// <returns></returns>
		bool GetProjectConsultantTable (
			string UserToken
			,int ProjectID
			,string ConsultantID
			,ref Project_consultantDT ProjectConsultantTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Consultants"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectConsultants (
			string UserToken
			,int ProjectId
			,ref UserDT Consultants
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Project"></param>
		/// <param name="Consultants"></param>
		/// <param name="Rates"></param>
		/// <param name="Tasks"></param>
		/// <param name="Activities"></param>
		/// <param name="Expenses"></param>
		/// <param name="Notes"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectDetails (
			string UserToken
			,int ProjectId
			,ref Project_summary Project
			,ref UserDT Consultants
			,ref Project_consultantDT Rates
			,ref Project_task_summaryDT Tasks
			,ref Project_activity_summaryDT Activities
			,ref Project_expense_summaryDT Expenses
			,ref Project_note_summaryDT Notes
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ProjectExpenseTable"></param>
		/// <returns></returns>
		bool GetProjectExpenseTable (
			string UserToken
			,int ProjectID
			,ref Project_expenseDT ProjectExpenseTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Expenses"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectExpenses (
			string UserToken
			,int ProjectId
			,ref Project_expenseDT Expenses
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Expenses"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectExpensesSummary (
			string UserToken
			,int ProjectId
			,ref Project_expense_summaryDT Expenses
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Project"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectHeader (
			string UserToken
			,int ProjectId
			,ref Project Project
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ProjectNoteTable"></param>
		/// <returns></returns>
		bool GetProjectNoteTable (
			string UserToken
			,int ProjectID
			,ref Project_noteDT ProjectNoteTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Notes"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectNotes (
			string UserToken
			,int ProjectId
			,ref Project_noteDT Notes
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Notes"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectNotesSummary (
			string UserToken
			,int ProjectId
			,ref Project_note_summaryDT Notes
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ConsultantID"></param>
		/// <param name="FeeTypeID"></param>
		/// <param name="ProjectConsultant"></param>
		/// <returns></returns>
		bool GetProjectRate (
			string UserToken
			,int ProjectID
			,string ConsultantID
			,int FeeTypeID
			,ref Project_consultant ProjectConsultant
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Rates"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectRates (
			string UserToken
			,int ProjectId
			,ref Project_consultantDT Rates
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="ProjectSummary"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectSummary (
			string UserToken
			,int ProjectId
			,ref Project_summary ProjectSummary
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectTable"></param>
		/// <param name="CustomerKeySearch"></param>
		/// <param name="ProjectDateKeySearch"></param>
		/// <param name="ConsultantKeySearch">search by consultant</param>
		/// <returns></returns>
		bool GetProjectTable (
			string UserToken
			,ref ProjectDT ProjectTable
			,string CustomerKeySearch
			,DateTime ProjectDateKeySearch
			,string ConsultantKeySearch
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="projectTableCombined">combined project details</param>
		/// <param name="customerSearchKey"></param>
		/// <param name="projectDataSearchKey"></param>
		/// <param name="consultantSearchKey"></param>
		/// <returns></returns>
		bool GetProjectTableCombined (
			string UserToken
			,ref Project_combinedDT projectTableCombined
			,string customerSearchKey
			,DateTime projectDataSearchKey
			,string consultantSearchKey
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ProjectTaskTable"></param>
		/// <returns></returns>
		bool GetProjectTaskTable (
			string UserToken
			,int ProjectID
			,ref Project_taskDT ProjectTaskTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Tasks"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectTasks (
			string UserToken
			,int ProjectId
			,ref Project_taskDT Tasks
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Tasks"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetProjectTasksSummary (
			string UserToken
			,int ProjectId
			,ref Project_task_summaryDT Tasks
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="RequestID"></param>
		/// <param name="Request"></param>
		/// <returns></returns>
		bool GetRequest (
			string UserToken
			,int RequestID
			,ref Request Request
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="RequestTable"></param>
		/// <param name="startDateKeySearch"></param>
		/// <param name="createdBySearchKey"></param>
		/// <param name="resourceKeySearch"></param>
		/// <returns></returns>
		bool GetRequestTable (
			string UserToken
			,ref RequestDT RequestTable
			,DateTime startDateKeySearch
			,string createdBySearchKey
			,string resourceKeySearch
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="StateID"></param>
		/// <param name="State"></param>
		/// <returns></returns>
		bool GetState (
			string UserToken
			,string StateID
			,ref State State
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="StateTable"></param>
		/// <returns></returns>
		bool GetStateTable (
			string UserToken
			,ref StateDT StateTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="TaskID"></param>
		/// <param name="ProjectTask"></param>
		/// <returns></returns>
		bool GetTask (
			string UserToken
			,int ProjectID
			,int TaskID
			,ref Project_task ProjectTask
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="TaskId"></param>
		/// <param name="Activities"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetTaskActivities (
			string UserToken
			,int ProjectId
			,int TaskId
			,ref Project_activityDT Activities
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="TaskTypeTable"></param>
		/// <returns></returns>
		bool GetTaskTypeTable (
			string UserToken
			,ref Task_typeDT TaskTypeTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="TaskTypeID"></param>
		/// <param name="TaskType"></param>
		/// <returns></returns>
		bool GetTaskType (
			string UserToken
			,int TaskTypeID
			,ref Task_type TaskType
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="UserID"></param>
		/// <param name="User"></param>
		/// <returns></returns>
		bool GetUser (
			string UserToken
			,string UserID
			,ref User User
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="UserId"></param>
		/// <param name="User"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool GetUserMaster (
			string UserToken
			,string UserId
			,ref User User
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="UserTable"></param>
		/// <returns></returns>
		bool GetUserTable (
			string UserToken
			,ref UserDT UserTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="UserTable"></param>
		/// <returns></returns>
		bool GetUserTableBrief (
			string UserToken
			,ref User_breifDT UserTable
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Fees"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool ProjectAddConsultant (
			string UserToken
			,int ProjectId
			,Consultant_fee_summaryDT Fees
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="ConsultantId"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool ProjectRemoveConsultant (
			string UserToken
			,int ProjectId
			,string ConsultantId
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserID"></param>
		/// <param name="Password"></param>
		/// <param name="CurrentUserCount"></param>
		/// <param name="UserToken"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		bool RemoteLogin (
			string UserID
			,string Password
			,int CurrentUserCount
			,ref string UserToken
			,ref string ErrorText
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <returns></returns>
		string ReturnLastError (
			string UserToken
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectActivity"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateActivity (
			string UserToken
			,Project_activity ProjectActivity
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectAttachment"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateAttachment (
			string UserToken
			,Project_attachment ProjectAttachment
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantFee"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateConsultantFee (
			string UserToken
			,Consultant_fee ConsultantFee
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Country"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateCountry (
			string UserToken
			,Country Country
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Customer"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateCustomer (
			string UserToken
			,Customer Customer
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContact"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateCustomerContact (
			string UserToken
			,Customer_contact CustomerContact
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContract"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateCustomerContract (
			string UserToken
			,Customer_contract CustomerContract
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerLocation"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateCustomerLocation (
			string UserToken
			,Customer_location CustomerLocation
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectExpense"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateExpense (
			string UserToken
			,Project_expense ProjectExpense
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ExpenseType"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateExpenseType (
			string UserToken
			,Expense_type ExpenseType
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="FeeType"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateFeeType (
			string UserToken
			,Fee_type FeeType
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectNote"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateNote (
			string UserToken
			,Project_note ProjectNote
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Project"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateProject (
			string UserToken
			,Project Project
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectConsultant"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateProjectRate (
			string UserToken
			,Project_consultant ProjectConsultant
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Request"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateRequest (
			string UserToken
			,Request Request
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="State"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateState (
			string UserToken
			,State State
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectTask"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateTask (
			string UserToken
			,Project_task ProjectTask
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="TaskType"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateTaskType (
			string UserToken
			,Task_type TaskType
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="User"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		bool UpdateUser (
			string UserToken
			,User User
			,ref string NewGrfa
		);
		/// <summary>
		/// 
		/// </summary>
		/// <param name="fileData"></param>
		/// <param name="fileName"></param>
		/// <returns></returns>
		int UploadFile (
			byte[] fileData
			,string fileName
		);
		#region xfnlnet support methods
		/// <summary>
		/// connect to xfServerPlus
		/// </summary>
		void connect();
		/// <summary>
		/// xfServerPlus four parameter connect
		/// </summary>
		/// <param name="hostIP">IP address</param>
		/// <param name="hostPort">port number</param>
		/// <param name="minPort">minport number</param>
		/// <param name="maxPort">maxport number</param>
		void connect(string hostIP, int hostPort, int minPort, int maxPort);
		/// <summary>
		/// xfServerPlus host and port connect
		/// </summary>
		/// <param name="hostIP">IP address</param>
		/// <param name="hostPort">port number</param>
		void connect(string hostIP, int hostPort);
		/// <summary>
		/// disconnect from xfServerPlus
		/// </summary>
		void disconnect();
		/// <summary>
		/// initialize a debug session
		/// </summary>
		/// <param name="hexip">IP address</param>
		/// <param name="port">port number</param>
		void debugInit(ref string hexip, ref int port);
		/// <summary>
		/// start a debug session of xfServerPlus
		/// </summary>
		void debugStart();
#if !POOLING
		/// <summary>
		/// get the object's xfServerPlus connection
		/// </summary>
		/// <returns>xfServerPlus connection</returns>
		object getConnect();
		/// <summary>
		/// share the provided connection
		/// </summary>
		/// <param name="connect">connection to share</param>
		void shareConnect(object connect);
#endif
		/// <summary>
		/// set the call timeout in seconds
		/// </summary>
		/// <param name="seconds">timeout in seconds</param>
		void setCallTimeout(int seconds);
		/// <summary>
		/// set the user string
		/// </summary>
		/// <param name="userString">The user string</param>
		void setUserString(string userString);
		/// <summary>
		/// get the user string 
		/// </summary>
		/// <returns>User String</returns>
		string getUserString();
		#endregion
	}
}
