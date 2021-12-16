// Generated on 09-Sep-2009 2:27:52 by gencs v1.0.11.0
using System;
using System.Data;
using System.Collections;
using System.Text;
using Synergex.xfnlnet;
namespace ChronoTrack
{
/// <summary>
/// Structural Interface Class ChronoTrack
/// </summary>
	[XFAttr(size=953)]
	[Serializable]
	public class Project : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[23];
		static Project()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[10]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[11]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[12]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[13]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[14]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[15]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[16]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[17]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[18]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[19]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[20]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[21]= new XFAttr(XFAttr.xftype.ALPHA,700);
			fieldAttributes[22]= new XFAttr(XFAttr.xftype.ALPHA,20);
		}
		private string f_Synergygrfa="";
		 
		/// <summary>
		/// Unique GRFA field
		/// </summary>
		public string Synergygrfa
		{
			get{ return f_Synergygrfa;}
			set { 
			    if(!f_Synergygrfa.Equals(value)) 
			       m_changed = true; 
			    f_Synergygrfa = value;
			} 
		}
		 
		private int f_Project_id=0;
		 
		/// <summary>
		/// Project number
		/// </summary>
		public int Project_id
		{
			get{ return f_Project_id;}
			set { 
			    if(f_Project_id != value) 
			       m_changed = true; 
			    f_Project_id = value;
			} 
		}
		 
		private string f_Customer_id="";
		 
		/// <summary>
		/// Customer Number
		/// </summary>
		public string Customer_id
		{
			get{ return f_Customer_id;}
			set { 
			    if(!f_Customer_id.Equals(value)) 
			       m_changed = true; 
			    f_Customer_id = value;
			} 
		}
		 
		private string f_Contract_id="";
		 
		/// <summary>
		/// Contract Number
		/// </summary>
		public string Contract_id
		{
			get{ return f_Contract_id;}
			set { 
			    if(!f_Contract_id.Equals(value)) 
			       m_changed = true; 
			    f_Contract_id = value;
			} 
		}
		 
		private int f_Contract_project_id=0;
		 
		/// <summary>
		/// Project number within contract
		/// </summary>
		public int Contract_project_id
		{
			get{ return f_Contract_project_id;}
			set { 
			    if(f_Contract_project_id != value) 
			       m_changed = true; 
			    f_Contract_project_id = value;
			} 
		}
		 
		private string f_Description="";
		 
		/// <summary>
		/// Short project description
		/// </summary>
		public string Description
		{
			get{ return f_Description;}
			set { 
			    if(!f_Description.Equals(value)) 
			       m_changed = true; 
			    f_Description = value;
			} 
		}
		 
		private DateTime f_Start_date=new DateTime();
		 
		/// <summary>
		/// Start date
		/// </summary>
		public DateTime Start_date
		{
			get{ return f_Start_date;}
			set { 
			    if(f_Start_date != value) 
			       m_changed = true; 
			    f_Start_date = value;
			} 
		}
		 
		private DateTime f_End_date=new DateTime();
		 
		/// <summary>
		/// End date
		/// </summary>
		public DateTime End_date
		{
			get{ return f_End_date;}
			set { 
			    if(f_End_date != value) 
			       m_changed = true; 
			    f_End_date = value;
			} 
		}
		 
		private int f_Current_status=0;
		 
		/// <summary>
		/// Project Status
		/// </summary>
		public int Current_status
		{
			get{ return f_Current_status;}
			set { 
			    if(f_Current_status != value) 
			       m_changed = true; 
			    f_Current_status = value;
			} 
		}
		 
		private DateTime f_Status_date=new DateTime();
		 
		/// <summary>
		/// Last status change
		/// </summary>
		public DateTime Status_date
		{
			get{ return f_Status_date;}
		}
		 
		private string f_Lead_consultant="";
		 
		/// <summary>
		/// Consultant username
		/// </summary>
		public string Lead_consultant
		{
			get{ return f_Lead_consultant;}
			set { 
			    if(!f_Lead_consultant.Equals(value)) 
			       m_changed = true; 
			    f_Lead_consultant = value;
			} 
		}
		 
		private string f_Coordinator="";
		 
		/// <summary>
		/// Project coordinator
		/// </summary>
		public string Coordinator
		{
			get{ return f_Coordinator;}
			set { 
			    if(!f_Coordinator.Equals(value)) 
			       m_changed = true; 
			    f_Coordinator = value;
			} 
		}
		 
		private int f_Approved_by_first=0;
		 
		/// <summary>
		/// First approved by contact
		/// </summary>
		public int Approved_by_first
		{
			get{ return f_Approved_by_first;}
			set { 
			    if(f_Approved_by_first != value) 
			       m_changed = true; 
			    f_Approved_by_first = value;
			} 
		}
		 
		private int f_Approved_by_last=0;
		 
		/// <summary>
		/// Last approved by contact
		/// </summary>
		public int Approved_by_last
		{
			get{ return f_Approved_by_last;}
			set { 
			    if(f_Approved_by_last != value) 
			       m_changed = true; 
			    f_Approved_by_last = value;
			} 
		}
		 
		private DateTime f_Approved_date=new DateTime();
		 
		/// <summary>
		/// Date approved by customer
		/// </summary>
		public DateTime Approved_date
		{
			get{ return f_Approved_date;}
			set { 
			    if(f_Approved_date != value) 
			       m_changed = true; 
			    f_Approved_date = value;
			} 
		}
		 
		private int f_Approval_location=0;
		 
		/// <summary>
		/// Location for approval processing
		/// </summary>
		public int Approval_location
		{
			get{ return f_Approval_location;}
			set { 
			    if(f_Approval_location != value) 
			       m_changed = true; 
			    f_Approval_location = value;
			} 
		}
		 
		private int f_Work_location_id=0;
		 
		/// <summary>
		/// Location for task execution
		/// </summary>
		public int Work_location_id
		{
			get{ return f_Work_location_id;}
			set { 
			    if(f_Work_location_id != value) 
			       m_changed = true; 
			    f_Work_location_id = value;
			} 
		}
		 
		private string f_Created_by="";
		 
		/// <summary>
		/// Project created by
		/// </summary>
		public string Created_by
		{
			get{ return f_Created_by;}
		}
		 
		private DateTime f_Created_date=new DateTime();
		 
		/// <summary>
		/// Date project created
		/// </summary>
		public DateTime Created_date
		{
			get{ return f_Created_date;}
		}
		 
		private string f_Modified_by="";
		 
		/// <summary>
		/// Last modified by
		/// </summary>
		public string Modified_by
		{
			get{ return f_Modified_by;}
		}
		 
		private DateTime f_Modified_date=new DateTime();
		 
		/// <summary>
		/// Last modified date
		/// </summary>
		public DateTime Modified_date
		{
			get{ return f_Modified_date;}
		}
		 
		private string f_Text="";
		 
		/// <summary>
		/// Long description
		/// </summary>
		public string Text
		{
			get{ return f_Text;}
			set { 
			    if(!f_Text.Equals(value)) 
			       m_changed = true; 
			    f_Text = value;
			} 
		}
		 
		private string f_Replication_key="";
		 
		/// <summary>
		/// SQL Replication Timestamp
		/// </summary>
		public string Replication_key
		{
			get{ return f_Replication_key;}
			set { 
			    if(!f_Replication_key.Equals(value)) 
			       m_changed = true; 
			    f_Replication_key = value;
			} 
		}
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public Project Clone()
		{
			Project tmp = new Project();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Customer_id = this.f_Customer_id;
			tmp.f_Contract_id = this.f_Contract_id;
			tmp.f_Contract_project_id = this.f_Contract_project_id;
			tmp.f_Description = this.f_Description;
			tmp.f_Start_date = this.f_Start_date;
			tmp.f_End_date = this.f_End_date;
			tmp.f_Current_status = this.f_Current_status;
			tmp.f_Status_date = this.f_Status_date;
			tmp.f_Lead_consultant = this.f_Lead_consultant;
			tmp.f_Coordinator = this.f_Coordinator;
			tmp.f_Approved_by_first = this.f_Approved_by_first;
			tmp.f_Approved_by_last = this.f_Approved_by_last;
			tmp.f_Approved_date = this.f_Approved_date;
			tmp.f_Approval_location = this.f_Approval_location;
			tmp.f_Work_location_id = this.f_Work_location_id;
			tmp.f_Created_by = this.f_Created_by;
			tmp.f_Created_date = this.f_Created_date;
			tmp.f_Modified_by = this.f_Modified_by;
			tmp.f_Modified_date = this.f_Modified_date;
			tmp.f_Text = this.f_Text;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project str)
		{
			bool eq = true;
			if (!this.Synergygrfa.Equals(str.Synergygrfa))
			{
				eq = false;
				return eq;
			}
			if (this.Project_id != str.Project_id)
			{
				eq = false;
				return eq;
			}
			if (!this.Customer_id.Equals(str.Customer_id))
			{
				eq = false;
				return eq;
			}
			if (!this.Contract_id.Equals(str.Contract_id))
			{
				eq = false;
				return eq;
			}
			if (this.Contract_project_id != str.Contract_project_id)
			{
				eq = false;
				return eq;
			}
			if (!this.Description.Equals(str.Description))
			{
				eq = false;
				return eq;
			}
			if (this.Start_date != str.Start_date)
			{
				eq = false;
				return eq;
			}
			if (this.End_date != str.End_date)
			{
				eq = false;
				return eq;
			}
			if (this.Current_status != str.Current_status)
			{
				eq = false;
				return eq;
			}
			if (this.Status_date != str.Status_date)
			{
				eq = false;
				return eq;
			}
			if (!this.Lead_consultant.Equals(str.Lead_consultant))
			{
				eq = false;
				return eq;
			}
			if (!this.Coordinator.Equals(str.Coordinator))
			{
				eq = false;
				return eq;
			}
			if (this.Approved_by_first != str.Approved_by_first)
			{
				eq = false;
				return eq;
			}
			if (this.Approved_by_last != str.Approved_by_last)
			{
				eq = false;
				return eq;
			}
			if (this.Approved_date != str.Approved_date)
			{
				eq = false;
				return eq;
			}
			if (this.Approval_location != str.Approval_location)
			{
				eq = false;
				return eq;
			}
			if (this.Work_location_id != str.Work_location_id)
			{
				eq = false;
				return eq;
			}
			if (!this.Created_by.Equals(str.Created_by))
			{
				eq = false;
				return eq;
			}
			if (this.Created_date != str.Created_date)
			{
				eq = false;
				return eq;
			}
			if (!this.Modified_by.Equals(str.Modified_by))
			{
				eq = false;
				return eq;
			}
			if (this.Modified_date != str.Modified_date)
			{
				eq = false;
				return eq;
			}
			if (!this.Text.Equals(str.Text))
			{
				eq = false;
				return eq;
			}
			if (!this.Replication_key.Equals(str.Replication_key))
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public Project() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[23]953%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Customer_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Contract_id,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Contract_project_id,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Start_date,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_End_date,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_Current_status,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_Status_date,fieldAttributes[9]));
			body.Append(XFProtocol.fieldToWire(f_Lead_consultant,fieldAttributes[10]));
			body.Append(XFProtocol.fieldToWire(f_Coordinator,fieldAttributes[11]));
			body.Append(XFProtocol.fieldToWire(f_Approved_by_first,fieldAttributes[12]));
			body.Append(XFProtocol.fieldToWire(f_Approved_by_last,fieldAttributes[13]));
			body.Append(XFProtocol.fieldToWire(f_Approved_date,fieldAttributes[14]));
			body.Append(XFProtocol.fieldToWire(f_Approval_location,fieldAttributes[15]));
			body.Append(XFProtocol.fieldToWire(f_Work_location_id,fieldAttributes[16]));
			body.Append(XFProtocol.fieldToWire(f_Created_by,fieldAttributes[17]));
			body.Append(XFProtocol.fieldToWire(f_Created_date,fieldAttributes[18]));
			body.Append(XFProtocol.fieldToWire(f_Modified_by,fieldAttributes[19]));
			body.Append(XFProtocol.fieldToWire(f_Modified_date,fieldAttributes[20]));
			body.Append(XFProtocol.fieldToWire(f_Text,fieldAttributes[21]));
			body.Append(XFProtocol.fieldToWire(f_Replication_key,fieldAttributes[22]));
			body.Append("^");
			sb.Append(body.Length+"#"+body.ToString()+";");
			return sb.ToString();
		}
 
		/// <summary>
		/// deserialize structure
		/// </summary>
		public void wireToStruct(SynMessage reply)
		{
			f_Synergygrfa = XFProtocol.wireTostring(reply);
			f_Project_id = XFProtocol.wireToint(reply);
			f_Customer_id = XFProtocol.wireTostring(reply);
			f_Contract_id = XFProtocol.wireTostring(reply);
			f_Contract_project_id = XFProtocol.wireToint(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Start_date = XFProtocol.wireToDateTime(reply,fieldAttributes[6]);
			f_End_date = XFProtocol.wireToDateTime(reply,fieldAttributes[7]);
			f_Current_status = XFProtocol.wireToint(reply);
			f_Status_date = XFProtocol.wireToDateTime(reply,fieldAttributes[9]);
			f_Lead_consultant = XFProtocol.wireTostring(reply);
			f_Coordinator = XFProtocol.wireTostring(reply);
			f_Approved_by_first = XFProtocol.wireToint(reply);
			f_Approved_by_last = XFProtocol.wireToint(reply);
			f_Approved_date = XFProtocol.wireToDateTime(reply,fieldAttributes[14]);
			f_Approval_location = XFProtocol.wireToint(reply);
			f_Work_location_id = XFProtocol.wireToint(reply);
			f_Created_by = XFProtocol.wireTostring(reply);
			f_Created_date = XFProtocol.wireToDateTime(reply,fieldAttributes[18]);
			f_Modified_by = XFProtocol.wireTostring(reply);
			f_Modified_date = XFProtocol.wireToDateTime(reply,fieldAttributes[20]);
			f_Text = XFProtocol.wireTostring(reply);
			f_Replication_key = XFProtocol.wireTostring(reply);
		}
 
		private bool m_changed = false;
 
		/// <summary>
		/// Structure Changed 
		/// </summary>
		/// <returns>true if structure has been changed</returns>
		public bool Changed
		{
		    get{ return m_changed;}
		}
 
		/// <summary>
		/// Returns a (structure) row from a DataTable
		/// </summary>
		public static void GetRow(ref Project str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Customer_id = (string)dr["Customer_id"];
			str.f_Contract_id = (string)dr["Contract_id"];
			str.f_Contract_project_id = (int)dr["Contract_project_id"];
			str.f_Description = (string)dr["Description"];
			str.f_Start_date = (DateTime)dr["Start_date"];
			str.f_End_date = (DateTime)dr["End_date"];
			str.f_Current_status = (int)dr["Current_status"];
			str.f_Status_date = (DateTime)dr["Status_date"];
			str.f_Lead_consultant = (string)dr["Lead_consultant"];
			str.f_Coordinator = (string)dr["Coordinator"];
			str.f_Approved_by_first = (int)dr["Approved_by_first"];
			str.f_Approved_by_last = (int)dr["Approved_by_last"];
			str.f_Approved_date = (DateTime)dr["Approved_date"];
			str.f_Approval_location = (int)dr["Approval_location"];
			str.f_Work_location_id = (int)dr["Work_location_id"];
			str.f_Created_by = (string)dr["Created_by"];
			str.f_Created_date = (DateTime)dr["Created_date"];
			str.f_Modified_by = (string)dr["Modified_by"];
			str.f_Modified_date = (DateTime)dr["Modified_date"];
			str.f_Text = (string)dr["Text"];
			str.f_Replication_key = (string)dr["Replication_key"];
			str.m_changed = false;
		}
		 
		/// <summary>
		/// Create the DataTable column header
		/// </summary>
		public static void TableHeader(ref DataTable dt)
		{
			DataColumn dtclm;
			ArrayList pkal = new ArrayList();
			dtclm = new DataColumn("Synergygrfa",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Project_id",typeof(int));
			dtclm.Caption = "Project #";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Customer_id",typeof(string));
			dtclm.Caption = "Customer #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Contract_id",typeof(string));
			dtclm.Caption = "Contract #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Contract_project_id",typeof(int));
			dtclm.Caption = "Contract Project #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Description",typeof(string));
			dtclm.Caption = "Description";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Start_date",typeof(DateTime));
			dtclm.Caption = "Start Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("End_date",typeof(DateTime));
			dtclm.Caption = "End Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Current_status",typeof(int));
			dtclm.Caption = "Status";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Status_date",typeof(DateTime));
			dtclm.Caption = "Status Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Lead_consultant",typeof(string));
			dtclm.Caption = "Lead Consultant";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Coordinator",typeof(string));
			dtclm.Caption = "Coordinator";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Approved_by_first",typeof(int));
			dtclm.Caption = "Approved By (First)";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Approved_by_last",typeof(int));
			dtclm.Caption = "Approved By (Last)";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Approved_date",typeof(DateTime));
			dtclm.Caption = "Approved Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Approval_location",typeof(int));
			dtclm.Caption = "Approval Location";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Work_location_id",typeof(int));
			dtclm.Caption = "Work Location ID";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Created_by",typeof(string));
			dtclm.Caption = "Created By";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Created_date",typeof(DateTime));
			dtclm.Caption = "Created";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Modified_by",typeof(string));
			dtclm.Caption = "Modified By";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Modified_date",typeof(DateTime));
			dtclm.Caption = "Modified";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Text",typeof(string));
			dtclm.Caption = "Project Overview";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Replication_key",typeof(string));
			dt.Columns.Add(dtclm);
			DataColumn[] pkary = new DataColumn[pkal.Count];
			for (int i=0;i<pkal.Count;i++)
			{
			   pkary[i] = (DataColumn)pkal[i];
			}
			dt.PrimaryKey = pkary;
		}
		 
		/// <summary>
		/// Fill a DataRow
		/// </summary>
		public static void FillDataTable(ArrayList al, ref DataTable dt, string type, int pos)
		{
			DataRow dr = null;
			for (int i=0;i<al.Count;i++)
			{
				dr = dt.NewRow();
				Project str = (Project)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["Project_id"] = str.Project_id;
				dr["Customer_id"] = str.Customer_id;
				dr["Contract_id"] = str.Contract_id;
				dr["Contract_project_id"] = str.Contract_project_id;
				dr["Description"] = str.Description;
				dr["Start_date"] = str.Start_date;
				dr["End_date"] = str.End_date;
				dr["Current_status"] = str.Current_status;
				dr["Status_date"] = str.Status_date;
				dr["Lead_consultant"] = str.Lead_consultant;
				dr["Coordinator"] = str.Coordinator;
				dr["Approved_by_first"] = str.Approved_by_first;
				dr["Approved_by_last"] = str.Approved_by_last;
				dr["Approved_date"] = str.Approved_date;
				dr["Approval_location"] = str.Approval_location;
				dr["Work_location_id"] = str.Work_location_id;
				dr["Created_by"] = str.Created_by;
				dr["Created_date"] = str.Created_date;
				dr["Modified_by"] = str.Modified_by;
				dr["Modified_date"] = str.Modified_date;
				dr["Text"] = str.Text;
				dr["Replication_key"] = str.Replication_key;
				switch (type) 
				{
				  case "A" :    // Add
				     dt.Rows.Add(dr);
				     break;
				  case "I" :    // Insert
				     dt.Rows.InsertAt(dr, pos);
				     break;
				  default :       // Add
				     dt.Rows.Add(dr);
				     break;
				}
			}
		}
		 
	}
}
