// Generated on 09-Sep-2009 2:27:52 by gencs v1.0.11.0
using System;
using System.Collections;
using System.Reflection;
#if POOLING
using System.EnterpriseServices;
#endif
using Synergex.xfnlnet;
namespace ChronoTrack
{
/// <summary>
/// Procedural Interface Class ChronoTrack
/// </summary>
#if POOLING
	[ObjectPooling()]
	public class ChronoTrack : ServicedComponent, IChronoTrack
#else
	public class ChronoTrack : IChronoTrack
#endif
	{
		/// <summary>
		/// constructor
		/// </summary>
		public ChronoTrack()
		{
			m_xfnet = new XFNet(this);
			m_xfnet.initialize();
		}
#if POOLING
		/// <summary>
		/// release method for pooling
		/// </summary>
		~ChronoTrack()
		{
			Dispose(false);
		}
		private new void Dispose(Boolean disposing)
		{
			m_xfnet.disconnect(disposing);
		}
#endif
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectActivity"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateActivity (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Project_activity ProjectActivity
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectActivity;
			bool ret=(bool)m_xfnet.callUserMethod("CreateActivity",ref pa);
			ProjectActivity=(Project_activity)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectAttachment"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateAttachment (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Project_attachment ProjectAttachment
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectAttachment;
			bool ret=(bool)m_xfnet.callUserMethod("CreateAttachment",ref pa);
			ProjectAttachment=(Project_attachment)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantFee"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateConsultantFee (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Consultant_fee ConsultantFee
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ConsultantFee;
			bool ret=(bool)m_xfnet.callUserMethod("CreateConsultantFee",ref pa);
			ConsultantFee=(Consultant_fee)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Country"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateCountry (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Country Country
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=Country;
			bool ret=(bool)m_xfnet.callUserMethod("CreateCountry",ref pa);
			Country=(Country)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Customer"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateCustomer (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Customer Customer
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=Customer;
			bool ret=(bool)m_xfnet.callUserMethod("CreateCustomer",ref pa);
			Customer=(Customer)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContact"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateCustomerContact (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Customer_contact CustomerContact
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=CustomerContact;
			bool ret=(bool)m_xfnet.callUserMethod("CreateCustomerContact",ref pa);
			CustomerContact=(Customer_contact)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContract"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateCustomerContract (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Customer_contract CustomerContract
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=CustomerContract;
			bool ret=(bool)m_xfnet.callUserMethod("CreateCustomerContract",ref pa);
			CustomerContract=(Customer_contract)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerLocation"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateCustomerLocation (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Customer_location CustomerLocation
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=CustomerLocation;
			bool ret=(bool)m_xfnet.callUserMethod("CreateCustomerLocation",ref pa);
			CustomerLocation=(Customer_location)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectExpense"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateExpense (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Project_expense ProjectExpense
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectExpense;
			bool ret=(bool)m_xfnet.callUserMethod("CreateExpense",ref pa);
			ProjectExpense=(Project_expense)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ExpenseType"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateExpenseType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Expense_type ExpenseType
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ExpenseType;
			bool ret=(bool)m_xfnet.callUserMethod("CreateExpenseType",ref pa);
			ExpenseType=(Expense_type)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="FeeType"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateFeeType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Fee_type FeeType
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=FeeType;
			bool ret=(bool)m_xfnet.callUserMethod("CreateFeeType",ref pa);
			FeeType=(Fee_type)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectNote"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateNote (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Project_note ProjectNote
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectNote;
			bool ret=(bool)m_xfnet.callUserMethod("CreateNote",ref pa);
			ProjectNote=(Project_note)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Project"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateProject (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Project Project
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=Project;
			bool ret=(bool)m_xfnet.callUserMethod("CreateProject",ref pa);
			Project=(Project)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectConsultant"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateProjectRate (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Project_consultant ProjectConsultant
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectConsultant;
			bool ret=(bool)m_xfnet.callUserMethod("CreateProjectRate",ref pa);
			ProjectConsultant=(Project_consultant)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Request"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateRequest (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Request Request
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=Request;
			bool ret=(bool)m_xfnet.callUserMethod("CreateRequest",ref pa);
			Request=(Request)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="State"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateState (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref State State
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=State;
			bool ret=(bool)m_xfnet.callUserMethod("CreateState",ref pa);
			State=(State)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectTask"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateTask (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Project_task ProjectTask
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectTask;
			bool ret=(bool)m_xfnet.callUserMethod("CreateTask",ref pa);
			ProjectTask=(Project_task)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="TaskType"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateTaskType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref Task_type TaskType
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=TaskType;
			bool ret=(bool)m_xfnet.callUserMethod("CreateTaskType",ref pa);
			TaskType=(Task_type)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="User"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool CreateUser (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(dir=XFAttr.xfdir.INOUT)]ref User User
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=User;
			bool ret=(bool)m_xfnet.callUserMethod("CreateUser",ref pa);
			User=(User)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectActivity"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteActivity (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_activity ProjectActivity
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectActivity;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteActivity",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectAttachment"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteAttachment (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_attachment ProjectAttachment
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectAttachment;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteAttachment",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantFee"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteConsultantFee (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Consultant_fee ConsultantFee
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ConsultantFee;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteConsultantFee",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerId"></param>
		/// <param name="ContactId"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteContact (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string CustomerId
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=3)]int ContactId
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=CustomerId;
			pa[2]=ContactId;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteContact",ref pa);
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Country"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteCountry (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Country Country
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=Country;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteCountry",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Customer"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteCustomer (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Customer Customer
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=Customer;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteCustomer",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContact"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteCustomerContact (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Customer_contact CustomerContact
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=CustomerContact;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteCustomerContact",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContract"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteCustomerContract (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Customer_contract CustomerContract
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=CustomerContract;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteCustomerContract",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerLocation"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteCustomerLocation (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Customer_location CustomerLocation
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=CustomerLocation;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteCustomerLocation",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectExpense"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteExpense (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_expense ProjectExpense
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectExpense;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteExpense",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ExpenseType"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteExpenseType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Expense_type ExpenseType
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ExpenseType;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteExpenseType",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="FeeType"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteFeeType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Fee_type FeeType
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=FeeType;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteFeeType",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectNote"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteNote (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_note ProjectNote
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectNote;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteNote",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Project"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteProject (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project Project
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=Project;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteProject",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectConsultant"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteProjectRate (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_consultant ProjectConsultant
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectConsultant;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteProjectRate",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Request"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteRequest (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Request Request
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=Request;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteRequest",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="State"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteState (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,State State
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=State;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteState",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectTask"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteTask (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_task ProjectTask
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=ProjectTask;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteTask",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="TaskType"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteTaskType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Task_type TaskType
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=TaskType;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteTaskType",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="User"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool DeleteUser (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,User User
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			pa[1]=User;
			bool ret=(bool)m_xfnet.callUserMethod("DeleteUser",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="fileName"></param>
		/// <param name="fileData"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.VALUE,size=4)]
		public int DownloadFile (
			[XFAttr(type=XFAttr.xftype.STRING,size=0)]string fileName
			,[XFAttr(type=XFAttr.xftype.BINARYARRAY,size=0,dir=XFAttr.xfdir.OUT)]ref byte[] fileData
		)
		{
			object[] pa = new object[2];
			pa[0]=fileName;
			pa[1]=fileData;
			int ret=(int)m_xfnet.callUserMethod("DownloadFile",ref pa);
			fileData=(byte[])pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="TaskID"></param>
		/// <param name="ActivityID"></param>
		/// <param name="ProjectActivity"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetActivity (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=3)]int TaskID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=4)]int ActivityID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Project_activity ProjectActivity
		)
		{
			object[] pa = new object[5];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			pa[2]=TaskID;
			pa[3]=ActivityID;
			pa[4]=ProjectActivity;
			bool ret=(bool)m_xfnet.callUserMethod("GetActivity",ref pa);
			ProjectActivity=(Project_activity)pa[4];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Consultants"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetAllConsultants (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=725,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref UserDT Consultants
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			User xfStr1 = new User();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			pa[2]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetAllConsultants",ref pa);
			tmpAL12=(ArrayList)pa[1];
			Consultants.FillDataTable(tmpAL12);
			Consultants.AcceptChanges();
			ErrorText=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="TaskID"></param>
		/// <param name="AttachmentID"></param>
		/// <param name="ProjectAttachment"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetAttachment (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=3)]int TaskID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=3)]int AttachmentID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Project_attachment ProjectAttachment
		)
		{
			object[] pa = new object[5];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			pa[2]=TaskID;
			pa[3]=AttachmentID;
			pa[4]=ProjectAttachment;
			bool ret=(bool)m_xfnet.callUserMethod("GetAttachment",ref pa);
			ProjectAttachment=(Project_attachment)pa[4];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantID"></param>
		/// <param name="FeeID"></param>
		/// <param name="ConsultantFee"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetConsultantFee (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string ConsultantID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=2)]int FeeID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Consultant_fee ConsultantFee
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ConsultantID;
			pa[2]=FeeID;
			pa[3]=ConsultantFee;
			bool ret=(bool)m_xfnet.callUserMethod("GetConsultantFee",ref pa);
			ConsultantFee=(Consultant_fee)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantID"></param>
		/// <param name="ConsltantFeeTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetConsultantFeeTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string ConsultantID
			,[XFAttr(size=70,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Consultant_feeDT ConsltantFeeTable
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ConsultantID;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Consultant_fee xfStr2 = new Consultant_fee();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			bool ret=(bool)m_xfnet.callUserMethod("GetConsultantFeeTable",ref pa);
			tmpAL123=(ArrayList)pa[2];
			ConsltantFeeTable.FillDataTable(tmpAL123);
			ConsltantFeeTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantId"></param>
		/// <param name="Fees"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetConsultantFeesSummary (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string ConsultantId
			,[XFAttr(size=63,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Consultant_fee_summaryDT Fees
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ConsultantId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Consultant_fee_summary xfStr2 = new Consultant_fee_summary();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetConsultantFeesSummary",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Fees.FillDataTable(tmpAL123);
			Fees.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantId"></param>
		/// <param name="Projects"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetConsultantProjects (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string ConsultantId
			,[XFAttr(size=269,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_summaryDT Projects
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ConsultantId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_summary xfStr2 = new Project_summary();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetConsultantProjects",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Projects.FillDataTable(tmpAL123);
			Projects.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="userToken"></param>
		/// <param name="scheduleData"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetConsultantSchedule (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string userToken
			,[XFAttr(size=868,sysal=true,dir=XFAttr.xfdir.OUT)]ref ArrayList scheduleData
		)
		{
			object[] pa = new object[2];
			pa[0]=userToken;
			scheduleData.Clear();
			Consultant_schedule xfStr1 = new Consultant_schedule();
			scheduleData.Add(xfStr1);
			pa[1]=scheduleData;
			bool ret=(bool)m_xfnet.callUserMethod("GetConsultantSchedule",ref pa);
			scheduleData=(ArrayList)pa[1];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetConsultantTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=725,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref UserDT ConsultantTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			User xfStr1 = new User();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetConsultantTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			ConsultantTable.FillDataTable(tmpAL12);
			ConsultantTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ContractorTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetContractorTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=725,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref UserDT ContractorTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			User xfStr1 = new User();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetContractorTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			ContractorTable.FillDataTable(tmpAL12);
			ContractorTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CountryID"></param>
		/// <param name="Country"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCountry (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=2)]string CountryID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Country Country
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=CountryID;
			pa[2]=Country;
			bool ret=(bool)m_xfnet.callUserMethod("GetCountry",ref pa);
			Country=(Country)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CountryTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCountryTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=81,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref CountryDT CountryTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			Country xfStr1 = new Country();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetCountryTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			CountryTable.FillDataTable(tmpAL12);
			CountryTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="Customer"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCustomer (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string CustomerID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Customer Customer
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=CustomerID;
			pa[2]=Customer;
			bool ret=(bool)m_xfnet.callUserMethod("GetCustomer",ref pa);
			Customer=(Customer)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="ContactID"></param>
		/// <param name="CustomerContact"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCustomerContact (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string CustomerID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=3)]int ContactID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Customer_contact CustomerContact
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=CustomerID;
			pa[2]=ContactID;
			pa[3]=CustomerContact;
			bool ret=(bool)m_xfnet.callUserMethod("GetCustomerContact",ref pa);
			CustomerContact=(Customer_contact)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="CustomerContactTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCustomerContactTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string CustomerID
			,[XFAttr(size=572,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Customer_contactDT CustomerContactTable
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=CustomerID;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Customer_contact xfStr2 = new Customer_contact();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			bool ret=(bool)m_xfnet.callUserMethod("GetCustomerContactTable",ref pa);
			tmpAL123=(ArrayList)pa[2];
			CustomerContactTable.FillDataTable(tmpAL123);
			CustomerContactTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="ContractID"></param>
		/// <param name="CustomerContract"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCustomerContract (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string CustomerID
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string ContractID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Customer_contract CustomerContract
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=CustomerID;
			pa[2]=ContractID;
			pa[3]=CustomerContract;
			bool ret=(bool)m_xfnet.callUserMethod("GetCustomerContract",ref pa);
			CustomerContract=(Customer_contract)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="CustomerContractTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCustomerContractTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string CustomerID
			,[XFAttr(size=374,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Customer_contractDT CustomerContractTable
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=CustomerID;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Customer_contract xfStr2 = new Customer_contract();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			bool ret=(bool)m_xfnet.callUserMethod("GetCustomerContractTable",ref pa);
			tmpAL123=(ArrayList)pa[2];
			CustomerContractTable.FillDataTable(tmpAL123);
			CustomerContractTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="LocationID"></param>
		/// <param name="Location"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCustomerLocation (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string CustomerID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=2)]int LocationID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Customer_location Location
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=CustomerID;
			pa[2]=LocationID;
			pa[3]=Location;
			bool ret=(bool)m_xfnet.callUserMethod("GetCustomerLocation",ref pa);
			Location=(Customer_location)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="LocationID"></param>
		/// <param name="CustomerContactTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCustomerLocationContacts (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string CustomerID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=2)]int LocationID
			,[XFAttr(size=572,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Customer_contactDT CustomerContactTable
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=CustomerID;
			pa[2]=LocationID;
			ArrayList tmpAL1234 = new ArrayList();
			tmpAL1234.Clear();
			Customer_contact xfStr3 = new Customer_contact();
			tmpAL1234.Add(xfStr3);
			pa[3]=tmpAL1234;
			bool ret=(bool)m_xfnet.callUserMethod("GetCustomerLocationContacts",ref pa);
			tmpAL1234=(ArrayList)pa[3];
			CustomerContactTable.FillDataTable(tmpAL1234);
			CustomerContactTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerID"></param>
		/// <param name="CustomerLocationTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCustomerLocationTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string CustomerID
			,[XFAttr(size=268,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Customer_locationDT CustomerLocationTable
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=CustomerID;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Customer_location xfStr2 = new Customer_location();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			bool ret=(bool)m_xfnet.callUserMethod("GetCustomerLocationTable",ref pa);
			tmpAL123=(ArrayList)pa[2];
			CustomerLocationTable.FillDataTable(tmpAL123);
			CustomerLocationTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCustomerTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=108,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref CustomerDT CustomerTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			Customer xfStr1 = new Customer();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetCustomerTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			CustomerTable.FillDataTable(tmpAL12);
			CustomerTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetCustomerTableBrief (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=72,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Customer_breifDT CustomerTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			Customer_breif xfStr1 = new Customer_breif();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetCustomerTableBrief",ref pa);
			tmpAL12=(ArrayList)pa[1];
			CustomerTable.FillDataTable(tmpAL12);
			CustomerTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="EmployeeTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetEmployeeTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=725,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref UserDT EmployeeTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			User xfStr1 = new User();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetEmployeeTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			EmployeeTable.FillDataTable(tmpAL12);
			EmployeeTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ExpenseTypeID"></param>
		/// <param name="ProjectExpense"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetExpense (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=6)]int ExpenseTypeID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Project_expense ProjectExpense
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			pa[2]=ExpenseTypeID;
			pa[3]=ProjectExpense;
			bool ret=(bool)m_xfnet.callUserMethod("GetExpense",ref pa);
			ProjectExpense=(Project_expense)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ExpenseTypeTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1,id="GetExpenseTable")]
		public bool GetExpenseTypeTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=88,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Expense_typeDT ExpenseTypeTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			Expense_type xfStr1 = new Expense_type();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetExpenseTypeTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			ExpenseTypeTable.FillDataTable(tmpAL12);
			ExpenseTypeTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ExpenseTypeID"></param>
		/// <param name="ExpenseType"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetExpenseType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string ExpenseTypeID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Expense_type ExpenseType
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ExpenseTypeID;
			pa[2]=ExpenseType;
			bool ret=(bool)m_xfnet.callUserMethod("GetExpenseType",ref pa);
			ExpenseType=(Expense_type)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="FeeTypeID"></param>
		/// <param name="FeeType"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetFeeType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=2)]int FeeTypeID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Fee_type FeeType
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=FeeTypeID;
			pa[2]=FeeType;
			bool ret=(bool)m_xfnet.callUserMethod("GetFeeType",ref pa);
			FeeType=(Fee_type)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="FeeTypeTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetFeeTypeTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=80,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Fee_typeDT FeeTypeTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			Fee_type xfStr1 = new Fee_type();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetFeeTypeTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			FeeTypeTable.FillDataTable(tmpAL12);
			FeeTypeTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="GanttViewTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetGanttViewTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=134,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Gantt_viewDT GanttViewTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			Gantt_view xfStr1 = new Gantt_view();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetGanttViewTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			GanttViewTable.FillDataTable(tmpAL12);
			GanttViewTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ManagerTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetManagerTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=725,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref UserDT ManagerTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			User xfStr1 = new User();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetManagerTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			ManagerTable.FillDataTable(tmpAL12);
			ManagerTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="NoteID"></param>
		/// <param name="ProjectNote"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetNote (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=4)]int NoteID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Project_note ProjectNote
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			pa[2]=NoteID;
			pa[3]=ProjectNote;
			bool ret=(bool)m_xfnet.callUserMethod("GetNote",ref pa);
			ProjectNote=(Project_note)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="Project"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProject (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Project Project
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			pa[2]=Project;
			bool ret=(bool)m_xfnet.callUserMethod("GetProject",ref pa);
			Project=(Project)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Tasks"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectActivities (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(size=887,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_activityDT Tasks
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_activity xfStr2 = new Project_activity();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectActivities",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Tasks.FillDataTable(tmpAL123);
			Tasks.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Activities"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectActivitiesSummary (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(size=143,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_activity_summaryDT Activities
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_activity_summary xfStr2 = new Project_activity_summary();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectActivitiesSummary",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Activities.FillDataTable(tmpAL123);
			Activities.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="TaskID"></param>
		/// <param name="ProjectActivityTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectActivityTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=3)]int TaskID
			,[XFAttr(size=887,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_activityDT ProjectActivityTable
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			pa[2]=TaskID;
			ArrayList tmpAL1234 = new ArrayList();
			tmpAL1234.Clear();
			Project_activity xfStr3 = new Project_activity();
			tmpAL1234.Add(xfStr3);
			pa[3]=tmpAL1234;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectActivityTable",ref pa);
			tmpAL1234=(ArrayList)pa[3];
			ProjectActivityTable.FillDataTable(tmpAL1234);
			ProjectActivityTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="TaskID"></param>
		/// <param name="ProjectAttachmentTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectAttachmentTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=3)]int TaskID
			,[XFAttr(size=373,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_attachmentDT ProjectAttachmentTable
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			pa[2]=TaskID;
			ArrayList tmpAL1234 = new ArrayList();
			tmpAL1234.Clear();
			Project_attachment xfStr3 = new Project_attachment();
			tmpAL1234.Add(xfStr3);
			pa[3]=tmpAL1234;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectAttachmentTable",ref pa);
			tmpAL1234=(ArrayList)pa[3];
			ProjectAttachmentTable.FillDataTable(tmpAL1234);
			ProjectAttachmentTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="ConsultantId"></param>
		/// <param name="Rates"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectConsultantRates (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string ConsultantId
			,[XFAttr(size=63,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Consultant_fee_summaryDT Rates
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[5];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			pa[2]=ConsultantId;
			ArrayList tmpAL1234 = new ArrayList();
			tmpAL1234.Clear();
			Consultant_fee_summary xfStr3 = new Consultant_fee_summary();
			tmpAL1234.Add(xfStr3);
			pa[3]=tmpAL1234;
			pa[4]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectConsultantRates",ref pa);
			tmpAL1234=(ArrayList)pa[3];
			Rates.FillDataTable(tmpAL1234);
			Rates.AcceptChanges();
			ErrorText=(string)pa[4];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ConsultantID"></param>
		/// <param name="ProjectConsultantTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectConsultantTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string ConsultantID
			,[XFAttr(size=89,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_consultantDT ProjectConsultantTable
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			pa[2]=ConsultantID;
			ArrayList tmpAL1234 = new ArrayList();
			tmpAL1234.Clear();
			Project_consultant xfStr3 = new Project_consultant();
			tmpAL1234.Add(xfStr3);
			pa[3]=tmpAL1234;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectConsultantTable",ref pa);
			tmpAL1234=(ArrayList)pa[3];
			ProjectConsultantTable.FillDataTable(tmpAL1234);
			ProjectConsultantTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Consultants"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectConsultants (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(size=725,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref UserDT Consultants
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			User xfStr2 = new User();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectConsultants",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Consultants.FillDataTable(tmpAL123);
			Consultants.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
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
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectDetails (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Project_summary Project
			,[XFAttr(size=725,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref UserDT Consultants
			,[XFAttr(size=89,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_consultantDT Rates
			,[XFAttr(size=172,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_task_summaryDT Tasks
			,[XFAttr(size=143,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_activity_summaryDT Activities
			,[XFAttr(size=180,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_expense_summaryDT Expenses
			,[XFAttr(size=140,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_note_summaryDT Notes
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[10];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			pa[2]=Project;
			ArrayList tmpAL1234 = new ArrayList();
			tmpAL1234.Clear();
			User xfStr3 = new User();
			tmpAL1234.Add(xfStr3);
			pa[3]=tmpAL1234;
			ArrayList tmpAL12345 = new ArrayList();
			tmpAL12345.Clear();
			Project_consultant xfStr4 = new Project_consultant();
			tmpAL12345.Add(xfStr4);
			pa[4]=tmpAL12345;
			ArrayList tmpAL123456 = new ArrayList();
			tmpAL123456.Clear();
			Project_task_summary xfStr5 = new Project_task_summary();
			tmpAL123456.Add(xfStr5);
			pa[5]=tmpAL123456;
			ArrayList tmpAL1234567 = new ArrayList();
			tmpAL1234567.Clear();
			Project_activity_summary xfStr6 = new Project_activity_summary();
			tmpAL1234567.Add(xfStr6);
			pa[6]=tmpAL1234567;
			ArrayList tmpAL12345678 = new ArrayList();
			tmpAL12345678.Clear();
			Project_expense_summary xfStr7 = new Project_expense_summary();
			tmpAL12345678.Add(xfStr7);
			pa[7]=tmpAL12345678;
			ArrayList tmpAL123456789 = new ArrayList();
			tmpAL123456789.Clear();
			Project_note_summary xfStr8 = new Project_note_summary();
			tmpAL123456789.Add(xfStr8);
			pa[8]=tmpAL123456789;
			pa[9]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectDetails",ref pa);
			Project=(Project_summary)pa[2];
			tmpAL1234=(ArrayList)pa[3];
			Consultants.FillDataTable(tmpAL1234);
			Consultants.AcceptChanges();
			tmpAL12345=(ArrayList)pa[4];
			Rates.FillDataTable(tmpAL12345);
			Rates.AcceptChanges();
			tmpAL123456=(ArrayList)pa[5];
			Tasks.FillDataTable(tmpAL123456);
			Tasks.AcceptChanges();
			tmpAL1234567=(ArrayList)pa[6];
			Activities.FillDataTable(tmpAL1234567);
			Activities.AcceptChanges();
			tmpAL12345678=(ArrayList)pa[7];
			Expenses.FillDataTable(tmpAL12345678);
			Expenses.AcceptChanges();
			tmpAL123456789=(ArrayList)pa[8];
			Notes.FillDataTable(tmpAL123456789);
			Notes.AcceptChanges();
			ErrorText=(string)pa[9];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ProjectExpenseTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectExpenseTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(size=215,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_expenseDT ProjectExpenseTable
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_expense xfStr2 = new Project_expense();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectExpenseTable",ref pa);
			tmpAL123=(ArrayList)pa[2];
			ProjectExpenseTable.FillDataTable(tmpAL123);
			ProjectExpenseTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Expenses"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectExpenses (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(size=215,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_expenseDT Expenses
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_expense xfStr2 = new Project_expense();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectExpenses",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Expenses.FillDataTable(tmpAL123);
			Expenses.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Expenses"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectExpensesSummary (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(size=180,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_expense_summaryDT Expenses
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_expense_summary xfStr2 = new Project_expense_summary();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectExpensesSummary",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Expenses.FillDataTable(tmpAL123);
			Expenses.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Project"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectHeader (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Project Project
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			pa[2]=Project;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectHeader",ref pa);
			Project=(Project)pa[2];
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ProjectNoteTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectNoteTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(size=860,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_noteDT ProjectNoteTable
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_note xfStr2 = new Project_note();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectNoteTable",ref pa);
			tmpAL123=(ArrayList)pa[2];
			ProjectNoteTable.FillDataTable(tmpAL123);
			ProjectNoteTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Notes"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectNotes (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(size=860,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_noteDT Notes
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_note xfStr2 = new Project_note();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectNotes",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Notes.FillDataTable(tmpAL123);
			Notes.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Notes"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectNotesSummary (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(size=140,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_note_summaryDT Notes
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_note_summary xfStr2 = new Project_note_summary();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectNotesSummary",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Notes.FillDataTable(tmpAL123);
			Notes.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ConsultantID"></param>
		/// <param name="FeeTypeID"></param>
		/// <param name="ProjectConsultant"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectRate (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string ConsultantID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=2)]int FeeTypeID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Project_consultant ProjectConsultant
		)
		{
			object[] pa = new object[5];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			pa[2]=ConsultantID;
			pa[3]=FeeTypeID;
			pa[4]=ProjectConsultant;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectRate",ref pa);
			ProjectConsultant=(Project_consultant)pa[4];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Rates"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectRates (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(size=89,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_consultantDT Rates
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_consultant xfStr2 = new Project_consultant();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectRates",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Rates.FillDataTable(tmpAL123);
			Rates.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="ProjectSummary"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectSummary (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Project_summary ProjectSummary
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			pa[2]=ProjectSummary;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectSummary",ref pa);
			ProjectSummary=(Project_summary)pa[2];
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectTable"></param>
		/// <param name="CustomerKeySearch"></param>
		/// <param name="ProjectDateKeySearch"></param>
		/// <param name="ConsultantKeySearch">search by consultant</param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=953,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref ProjectDT ProjectTable
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string CustomerKeySearch
			,[XFAttr(type=XFAttr.xftype.DECIMAL,coerce=XFAttr.xftype.DATETIME,format=XFAttr.xfformat.YYYYMMDD,size=8)]DateTime ProjectDateKeySearch
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string ConsultantKeySearch
		)
		{
			object[] pa = new object[5];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			Project xfStr1 = new Project();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			pa[2]=CustomerKeySearch;
			pa[3]=ProjectDateKeySearch;
			pa[4]=ConsultantKeySearch;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			ProjectTable.FillDataTable(tmpAL12);
			ProjectTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="projectTableCombined">combined project details</param>
		/// <param name="customerSearchKey"></param>
		/// <param name="projectDataSearchKey"></param>
		/// <param name="consultantSearchKey"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectTableCombined (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=1052,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_combinedDT projectTableCombined
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=10)]string customerSearchKey
			,[XFAttr(type=XFAttr.xftype.DECIMAL,coerce=XFAttr.xftype.DATETIME,format=XFAttr.xfformat.YYYYMMDD,size=8)]DateTime projectDataSearchKey
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string consultantSearchKey
		)
		{
			object[] pa = new object[5];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			Project_combined xfStr1 = new Project_combined();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			pa[2]=customerSearchKey;
			pa[3]=projectDataSearchKey;
			pa[4]=consultantSearchKey;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectTableCombined",ref pa);
			tmpAL12=(ArrayList)pa[1];
			projectTableCombined.FillDataTable(tmpAL12);
			projectTableCombined.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="ProjectTaskTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectTaskTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(size=908,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_taskDT ProjectTaskTable
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_task xfStr2 = new Project_task();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectTaskTable",ref pa);
			tmpAL123=(ArrayList)pa[2];
			ProjectTaskTable.FillDataTable(tmpAL123);
			ProjectTaskTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Tasks"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectTasks (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(size=908,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_taskDT Tasks
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_task xfStr2 = new Project_task();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectTasks",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Tasks.FillDataTable(tmpAL123);
			Tasks.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Tasks"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetProjectTasksSummary (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(size=172,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_task_summaryDT Tasks
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			ArrayList tmpAL123 = new ArrayList();
			tmpAL123.Clear();
			Project_task_summary xfStr2 = new Project_task_summary();
			tmpAL123.Add(xfStr2);
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetProjectTasksSummary",ref pa);
			tmpAL123=(ArrayList)pa[2];
			Tasks.FillDataTable(tmpAL123);
			Tasks.AcceptChanges();
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="RequestID"></param>
		/// <param name="Request"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetRequest (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=6)]int RequestID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Request Request
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=RequestID;
			pa[2]=Request;
			bool ret=(bool)m_xfnet.callUserMethod("GetRequest",ref pa);
			Request=(Request)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="RequestTable"></param>
		/// <param name="startDateKeySearch"></param>
		/// <param name="createdBySearchKey"></param>
		/// <param name="resourceKeySearch"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetRequestTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=893,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref RequestDT RequestTable
			,[XFAttr(type=XFAttr.xftype.DECIMAL,coerce=XFAttr.xftype.DATETIME,format=XFAttr.xfformat.YYYYMMDD,size=8)]DateTime startDateKeySearch
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string createdBySearchKey
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string resourceKeySearch
		)
		{
			object[] pa = new object[5];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			Request xfStr1 = new Request();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			pa[2]=startDateKeySearch;
			pa[3]=createdBySearchKey;
			pa[4]=resourceKeySearch;
			bool ret=(bool)m_xfnet.callUserMethod("GetRequestTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			RequestTable.FillDataTable(tmpAL12);
			RequestTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="StateID"></param>
		/// <param name="State"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetState (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=2)]string StateID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref State State
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=StateID;
			pa[2]=State;
			bool ret=(bool)m_xfnet.callUserMethod("GetState",ref pa);
			State=(State)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="StateTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetStateTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=74,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref StateDT StateTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			State xfStr1 = new State();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetStateTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			StateTable.FillDataTable(tmpAL12);
			StateTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectID"></param>
		/// <param name="TaskID"></param>
		/// <param name="ProjectTask"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetTask (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectID
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=3)]int TaskID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Project_task ProjectTask
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectID;
			pa[2]=TaskID;
			pa[3]=ProjectTask;
			bool ret=(bool)m_xfnet.callUserMethod("GetTask",ref pa);
			ProjectTask=(Project_task)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="TaskId"></param>
		/// <param name="Activities"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetTaskActivities (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=3)]int TaskId
			,[XFAttr(size=887,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Project_activityDT Activities
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[5];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			pa[2]=TaskId;
			ArrayList tmpAL1234 = new ArrayList();
			tmpAL1234.Clear();
			Project_activity xfStr3 = new Project_activity();
			tmpAL1234.Add(xfStr3);
			pa[3]=tmpAL1234;
			pa[4]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetTaskActivities",ref pa);
			tmpAL1234=(ArrayList)pa[3];
			Activities.FillDataTable(tmpAL1234);
			Activities.AcceptChanges();
			ErrorText=(string)pa[4];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="TaskTypeTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1,id="GetTaskTable")]
		public bool GetTaskTypeTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=80,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref Task_typeDT TaskTypeTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			Task_type xfStr1 = new Task_type();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetTaskTypeTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			TaskTypeTable.FillDataTable(tmpAL12);
			TaskTypeTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="TaskTypeID"></param>
		/// <param name="TaskType"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetTaskType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=3)]int TaskTypeID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref Task_type TaskType
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=TaskTypeID;
			pa[2]=TaskType;
			bool ret=(bool)m_xfnet.callUserMethod("GetTaskType",ref pa);
			TaskType=(Task_type)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="UserID"></param>
		/// <param name="User"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetUser (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string UserID
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref User User
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=UserID;
			pa[2]=User;
			bool ret=(bool)m_xfnet.callUserMethod("GetUser",ref pa);
			User=(User)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="UserId"></param>
		/// <param name="User"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetUserMaster (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string UserId
			,[XFAttr(dir=XFAttr.xfdir.OUT)]ref User User
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=UserId;
			pa[2]=User;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("GetUserMaster",ref pa);
			User=(User)pa[2];
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="UserTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetUserTable (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=725,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref UserDT UserTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			User xfStr1 = new User();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetUserTable",ref pa);
			tmpAL12=(ArrayList)pa[1];
			UserTable.FillDataTable(tmpAL12);
			UserTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="UserTable"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool GetUserTableBrief (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(size=332,sysal=true,datatable=true,dir=XFAttr.xfdir.OUT)]ref User_breifDT UserTable
		)
		{
			object[] pa = new object[2];
			pa[0]=UserToken;
			ArrayList tmpAL12 = new ArrayList();
			tmpAL12.Clear();
			User_breif xfStr1 = new User_breif();
			tmpAL12.Add(xfStr1);
			pa[1]=tmpAL12;
			bool ret=(bool)m_xfnet.callUserMethod("GetUserTableBrief",ref pa);
			tmpAL12=(ArrayList)pa[1];
			UserTable.FillDataTable(tmpAL12);
			UserTable.AcceptChanges();
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="Fees"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool ProjectAddConsultant (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(size=63,sysal=true,datatable=true)]Consultant_fee_summaryDT Fees
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			ArrayList tmpAL123 = new ArrayList();
			for (int i = 0; i < Fees.Rows.Count; i++)
			{
			  Consultant_fee_summary xfStr2 = new Consultant_fee_summary();
			  Fees.GetRow(ref xfStr2, i);
			  tmpAL123.Add(xfStr2);
			}
			pa[2]=tmpAL123;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("ProjectAddConsultant",ref pa);
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectId"></param>
		/// <param name="ConsultantId"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool ProjectRemoveConsultant (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=8)]int ProjectId
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string ConsultantId
			,[XFAttr(type=XFAttr.xftype.STRING,size=0,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[4];
			pa[0]=UserToken;
			pa[1]=ProjectId;
			pa[2]=ConsultantId;
			pa[3]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("ProjectRemoveConsultant",ref pa);
			ErrorText=(string)pa[3];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserID"></param>
		/// <param name="Password"></param>
		/// <param name="CurrentUserCount"></param>
		/// <param name="UserToken"></param>
		/// <param name="ErrorText"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool RemoteLogin (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string UserID
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=15)]string Password
			,[XFAttr(type=XFAttr.xftype.DECIMAL,size=6)]int CurrentUserCount
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string UserToken
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=255,dir=XFAttr.xfdir.OUT)]ref string ErrorText
		)
		{
			object[] pa = new object[5];
			pa[0]=UserID;
			pa[1]=Password;
			pa[2]=CurrentUserCount;
			pa[3]=UserToken;
			pa[4]=ErrorText;
			bool ret=(bool)m_xfnet.callUserMethod("RemoteLogin",ref pa);
			UserToken=(string)pa[3];
			ErrorText=(string)pa[4];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.STRING,size=0)]
		public string ReturnLastError (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
		)
		{
			object[] pa = new object[1];
			pa[0]=UserToken;
			string ret=(string)m_xfnet.callUserMethod("ReturnLastError",ref pa);
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectActivity"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateActivity (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_activity ProjectActivity
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ProjectActivity;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateActivity",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectAttachment"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateAttachment (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_attachment ProjectAttachment
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ProjectAttachment;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateAttachment",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ConsultantFee"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateConsultantFee (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Consultant_fee ConsultantFee
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ConsultantFee;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateConsultantFee",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Country"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateCountry (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Country Country
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=Country;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateCountry",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Customer"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateCustomer (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Customer Customer
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=Customer;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateCustomer",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContact"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateCustomerContact (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Customer_contact CustomerContact
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=CustomerContact;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateCustomerContact",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerContract"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateCustomerContract (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Customer_contract CustomerContract
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=CustomerContract;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateCustomerContract",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="CustomerLocation"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateCustomerLocation (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Customer_location CustomerLocation
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=CustomerLocation;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateCustomerLocation",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectExpense"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateExpense (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_expense ProjectExpense
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ProjectExpense;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateExpense",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ExpenseType"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateExpenseType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Expense_type ExpenseType
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ExpenseType;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateExpenseType",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="FeeType"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateFeeType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Fee_type FeeType
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=FeeType;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateFeeType",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectNote"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateNote (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_note ProjectNote
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ProjectNote;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateNote",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Project"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateProject (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project Project
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=Project;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateProject",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectConsultant"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateProjectRate (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_consultant ProjectConsultant
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ProjectConsultant;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateProjectRate",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="Request"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateRequest (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Request Request
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=Request;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateRequest",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="State"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateState (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,State State
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=State;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateState",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="ProjectTask"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateTask (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Project_task ProjectTask
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=ProjectTask;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateTask",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="TaskType"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateTaskType (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,Task_type TaskType
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=TaskType;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateTaskType",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="UserToken"></param>
		/// <param name="User"></param>
		/// <param name="NewGrfa"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.INTEGER,coerce=XFAttr.xftype.BOOLEAN,size=1)]
		public bool UpdateUser (
			[XFAttr(type=XFAttr.xftype.ALPHA,size=22)]string UserToken
			,User User
			,[XFAttr(type=XFAttr.xftype.ALPHA,size=22,dir=XFAttr.xfdir.OUT)]ref string NewGrfa
		)
		{
			object[] pa = new object[3];
			pa[0]=UserToken;
			pa[1]=User;
			pa[2]=NewGrfa;
			bool ret=(bool)m_xfnet.callUserMethod("UpdateUser",ref pa);
			NewGrfa=(string)pa[2];
			return ret;
		}
		/// <summary>
		/// *** To Do ***
		/// </summary>
		/// <param name="fileData"></param>
		/// <param name="fileName"></param>
		/// <returns></returns>
		[XFAttr(type=XFAttr.xftype.VALUE,size=4)]
		public int UploadFile (
			[XFAttr(type=XFAttr.xftype.BINARYARRAY,size=0)]byte[] fileData
			,[XFAttr(type=XFAttr.xftype.STRING,size=0)]string fileName
		)
		{
			object[] pa = new object[2];
			pa[0]=fileData;
			pa[1]=fileName;
			int ret=(int)m_xfnet.callUserMethod("UploadFile",ref pa);
			return ret;
		}
		#region xfnlnet support methods
		/// <summary>
		/// connect to xfServerPlus
		/// </summary>
		public void connect()
		{
			m_xfnet.connect();
		}
		/// <summary>
		/// xfServerPlus four parameter connect
		/// </summary>
		/// <param name="hostIP">IP address</param>
		/// <param name="hostPort">port number</param>
		/// <param name="minPort">minport number</param>
		/// <param name="maxPort">maxport number</param>
		public void connect(string hostIP, int hostPort, int minPort, int maxPort)
		{
			m_xfnet.connect(hostIP, hostPort, minPort, maxPort);
		}
		/// <summary>
		/// xfServerPlus host and port connect
		/// </summary>
		/// <param name="hostIP">IP address</param>
		/// <param name="hostPort">port number</param>
		public void connect(string hostIP, int hostPort)
		{
			m_xfnet.connect(hostIP, hostPort);
		}
		/// <summary>
		/// disconnect from xfServerPlus
		/// </summary>
		public void disconnect()
		{
			m_xfnet.disconnect();
		}
		/// <summary>
		/// initialize a debug session
		/// </summary>
		/// <param name="hexip">IP address</param>
		/// <param name="port">port number</param>
		public void debugInit(ref string hexip, ref int port)
		{
			m_xfnet.debugInit(ref hexip, ref port);
		}
		/// <summary>
		/// start a debug session of xfServerPlus
		/// </summary>
		public void debugStart()
		{
			m_xfnet.debugStart();
		}
#if !POOLING
		/// <summary>
		/// get the object's xfServerPlus connection
		/// </summary>
		/// <returns>xfServerPlus connection</returns>
		public object getConnect()
		{
			return m_xfnet.getConnect();
		}
		/// <summary>
		/// share the provided connection
		/// </summary>
		/// <param name="connect">connection to share</param>
		public void shareConnect(object connect)
		{
			m_xfnet.shareConnect(connect);
		}
#endif
		/// <summary>
		/// set the call timeout in seconds
		/// </summary>
		/// <param name="seconds">timeout in seconds</param>
		public void setCallTimeout(int seconds)
		{
			m_xfnet.setCallTimeout(seconds);
		}
		/// <summary>
		/// set the user string
		/// </summary>
		/// <param name="userString">The user string</param>
		public void setUserString(string userString)
		{
			m_xfnet.setUserString(userString);
		}
		/// <summary>
		/// get the user string 
		/// </summary>
		/// <returns>User String</returns>
		public string getUserString()
		{
			return m_xfnet.getUserString();
		}
		/// <summary>
		/// indicate if an object can be put back into the pool
		/// </summary>
		/// <returns>true if object can be returned to pool</returns>
		[XFAttr(type=XFAttr.xftype.INTEGER, size=1)]
#if POOLING
		protected override bool CanBePooled()
#else
		public bool CanBePooled()
#endif
		{
			bool ret = m_xfnet.CanBePooled();
			return ret;
		}
		#endregion
		private XFNet m_xfnet = null;
	}
}
