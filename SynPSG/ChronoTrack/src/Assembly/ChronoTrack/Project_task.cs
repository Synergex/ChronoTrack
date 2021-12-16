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
	[XFAttr(size=908)]
	[Serializable]
	public class Project_task : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[19];
		static Project_task()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.TIME,XFAttr.xftype.DATETIME,XFAttr.xfformat.HHMM,4);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.TIME,XFAttr.xftype.DATETIME,XFAttr.xfformat.HHMM,4);
			fieldAttributes[10]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[11]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.DECIMAL,4,1);
			fieldAttributes[12]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[13]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[14]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[15]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[16]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.BOOLEAN,1);
			fieldAttributes[17]= new XFAttr(XFAttr.xftype.ALPHA,700);
			fieldAttributes[18]= new XFAttr(XFAttr.xftype.ALPHA,20);
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
		 
		private int f_Task_id=0;
		 
		/// <summary>
		/// Task number
		/// </summary>
		public int Task_id
		{
			get{ return f_Task_id;}
			set { 
			    if(f_Task_id != value) 
			       m_changed = true; 
			    f_Task_id = value;
			} 
		}
		 
		private int f_Task_type=0;
		 
		/// <summary>
		/// Type of Project Task
		/// </summary>
		public int Task_type
		{
			get{ return f_Task_type;}
			set { 
			    if(f_Task_type != value) 
			       m_changed = true; 
			    f_Task_type = value;
			} 
		}
		 
		private string f_Description="";
		 
		/// <summary>
		/// Short description of task
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
		 
		private string f_Assigned_to="";
		 
		/// <summary>
		/// Task assigned to (username)
		/// </summary>
		public string Assigned_to
		{
			get{ return f_Assigned_to;}
			set { 
			    if(!f_Assigned_to.Equals(value)) 
			       m_changed = true; 
			    f_Assigned_to = value;
			} 
		}
		 
		private DateTime f_Start_date=new DateTime();
		 
		/// <summary>
		/// Task start date
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
		 
		private DateTime f_Start_time=new DateTime();
		 
		/// <summary>
		/// Start time
		/// </summary>
		public DateTime Start_time
		{
			get{ return f_Start_time;}
			set { 
			    if(f_Start_time != value) 
			       m_changed = true; 
			    f_Start_time = value;
			} 
		}
		 
		private DateTime f_End_date=new DateTime();
		 
		/// <summary>
		/// Task end date
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
		 
		private DateTime f_End_time=new DateTime();
		 
		/// <summary>
		/// End time
		/// </summary>
		public DateTime End_time
		{
			get{ return f_End_time;}
			set { 
			    if(f_End_time != value) 
			       m_changed = true; 
			    f_End_time = value;
			} 
		}
		 
		private int f_Location=0;
		 
		/// <summary>
		/// Location task to be completed at
		/// </summary>
		public int Location
		{
			get{ return f_Location;}
			set { 
			    if(f_Location != value) 
			       m_changed = true; 
			    f_Location = value;
			} 
		}
		 
		private decimal f_Billable_hours=0;
		 
		/// <summary>
		/// Number of billable hours
		/// </summary>
		public decimal Billable_hours
		{
			get{ return f_Billable_hours;}
			set { 
			    if(f_Billable_hours != value) 
			       m_changed = true; 
			    f_Billable_hours = value;
			} 
		}
		 
		private string f_Created_by="";
		 
		/// <summary>
		/// Task created by
		/// </summary>
		public string Created_by
		{
			get{ return f_Created_by;}
		}
		 
		private DateTime f_Created_date=new DateTime();
		 
		/// <summary>
		/// Date that the task was created
		/// </summary>
		public DateTime Created_date
		{
			get{ return f_Created_date;}
		}
		 
		private string f_Modified_by="";
		 
		/// <summary>
		/// Task last modified by
		/// </summary>
		public string Modified_by
		{
			get{ return f_Modified_by;}
		}
		 
		private DateTime f_Modified_date=new DateTime();
		 
		/// <summary>
		/// Date task last modified
		/// </summary>
		public DateTime Modified_date
		{
			get{ return f_Modified_date;}
		}
		 
		private bool f_Completed=new bool();
		 
		/// <summary>
		/// Task completed?
		/// </summary>
		public bool Completed
		{
			get{ return f_Completed;}
			set { 
			    if(f_Completed != value) 
			       m_changed = true; 
			    f_Completed = value;
			} 
		}
		 
		private string f_Text="";
		 
		/// <summary>
		/// Description of task
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
		public Project_task Clone()
		{
			Project_task tmp = new Project_task();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Task_id = this.f_Task_id;
			tmp.f_Task_type = this.f_Task_type;
			tmp.f_Description = this.f_Description;
			tmp.f_Assigned_to = this.f_Assigned_to;
			tmp.f_Start_date = this.f_Start_date;
			tmp.f_Start_time = this.f_Start_time;
			tmp.f_End_date = this.f_End_date;
			tmp.f_End_time = this.f_End_time;
			tmp.f_Location = this.f_Location;
			tmp.f_Billable_hours = this.f_Billable_hours;
			tmp.f_Created_by = this.f_Created_by;
			tmp.f_Created_date = this.f_Created_date;
			tmp.f_Modified_by = this.f_Modified_by;
			tmp.f_Modified_date = this.f_Modified_date;
			tmp.f_Completed = this.f_Completed;
			tmp.f_Text = this.f_Text;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project_task str)
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
			if (this.Task_id != str.Task_id)
			{
				eq = false;
				return eq;
			}
			if (this.Task_type != str.Task_type)
			{
				eq = false;
				return eq;
			}
			if (!this.Description.Equals(str.Description))
			{
				eq = false;
				return eq;
			}
			if (!this.Assigned_to.Equals(str.Assigned_to))
			{
				eq = false;
				return eq;
			}
			if (this.Start_date != str.Start_date)
			{
				eq = false;
				return eq;
			}
			if (this.Start_time != str.Start_time)
			{
				eq = false;
				return eq;
			}
			if (this.End_date != str.End_date)
			{
				eq = false;
				return eq;
			}
			if (this.End_time != str.End_time)
			{
				eq = false;
				return eq;
			}
			if (this.Location != str.Location)
			{
				eq = false;
				return eq;
			}
			if (this.Billable_hours != str.Billable_hours)
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
			if (this.Completed != str.Completed)
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
		public Project_task() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[19]908%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Task_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Task_type,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Assigned_to,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Start_date,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Start_time,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_End_date,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_End_time,fieldAttributes[9]));
			body.Append(XFProtocol.fieldToWire(f_Location,fieldAttributes[10]));
			body.Append(XFProtocol.fieldToWire(f_Billable_hours,fieldAttributes[11]));
			body.Append(XFProtocol.fieldToWire(f_Created_by,fieldAttributes[12]));
			body.Append(XFProtocol.fieldToWire(f_Created_date,fieldAttributes[13]));
			body.Append(XFProtocol.fieldToWire(f_Modified_by,fieldAttributes[14]));
			body.Append(XFProtocol.fieldToWire(f_Modified_date,fieldAttributes[15]));
			body.Append(XFProtocol.fieldToWire(f_Completed,fieldAttributes[16]));
			body.Append(XFProtocol.fieldToWire(f_Text,fieldAttributes[17]));
			body.Append(XFProtocol.fieldToWire(f_Replication_key,fieldAttributes[18]));
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
			f_Task_id = XFProtocol.wireToint(reply);
			f_Task_type = XFProtocol.wireToint(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Assigned_to = XFProtocol.wireTostring(reply);
			f_Start_date = XFProtocol.wireToDateTime(reply,fieldAttributes[6]);
			f_Start_time = XFProtocol.wireToDateTime(reply,fieldAttributes[7]);
			f_End_date = XFProtocol.wireToDateTime(reply,fieldAttributes[8]);
			f_End_time = XFProtocol.wireToDateTime(reply,fieldAttributes[9]);
			f_Location = XFProtocol.wireToint(reply);
			f_Billable_hours = XFProtocol.wireTodecimal(reply);
			f_Created_by = XFProtocol.wireTostring(reply);
			f_Created_date = XFProtocol.wireToDateTime(reply,fieldAttributes[13]);
			f_Modified_by = XFProtocol.wireTostring(reply);
			f_Modified_date = XFProtocol.wireToDateTime(reply,fieldAttributes[15]);
			f_Completed = XFProtocol.wireTobool(reply);
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
		public static void GetRow(ref Project_task str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Task_id = (int)dr["Task_id"];
			str.f_Task_type = (int)dr["Task_type"];
			str.f_Description = (string)dr["Description"];
			str.f_Assigned_to = (string)dr["Assigned_to"];
			str.f_Start_date = (DateTime)dr["Start_date"];
			str.f_Start_time = (DateTime)dr["Start_time"];
			str.f_End_date = (DateTime)dr["End_date"];
			str.f_End_time = (DateTime)dr["End_time"];
			str.f_Location = (int)dr["Location"];
			str.f_Billable_hours = (decimal)dr["Billable_hours"];
			str.f_Created_by = (string)dr["Created_by"];
			str.f_Created_date = (DateTime)dr["Created_date"];
			str.f_Modified_by = (string)dr["Modified_by"];
			str.f_Modified_date = (DateTime)dr["Modified_date"];
			str.f_Completed = (bool)dr["Completed"];
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
			dtclm = new DataColumn("Task_id",typeof(int));
			dtclm.Caption = "Task #";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Task_type",typeof(int));
			dtclm.Caption = "Task Type";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Description",typeof(string));
			dtclm.Caption = "Description";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Assigned_to",typeof(string));
			dtclm.Caption = "Assigned To";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Start_date",typeof(DateTime));
			dtclm.Caption = "Start Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Start_time",typeof(DateTime));
			dtclm.Caption = "Start Time";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("End_date",typeof(DateTime));
			dtclm.Caption = "End Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("End_time",typeof(DateTime));
			dtclm.Caption = "End Time";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Location",typeof(int));
			dtclm.Caption = "Location #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Billable_hours",typeof(decimal));
			dtclm.Caption = "Billable Hours";
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
			dtclm = new DataColumn("Completed",typeof(bool));
			dtclm.Caption = "Complete";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Text",typeof(string));
			dtclm.Caption = "Task Detail";
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
				Project_task str = (Project_task)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["Project_id"] = str.Project_id;
				dr["Task_id"] = str.Task_id;
				dr["Task_type"] = str.Task_type;
				dr["Description"] = str.Description;
				dr["Assigned_to"] = str.Assigned_to;
				dr["Start_date"] = str.Start_date;
				dr["Start_time"] = str.Start_time;
				dr["End_date"] = str.End_date;
				dr["End_time"] = str.End_time;
				dr["Location"] = str.Location;
				dr["Billable_hours"] = str.Billable_hours;
				dr["Created_by"] = str.Created_by;
				dr["Created_date"] = str.Created_date;
				dr["Modified_by"] = str.Modified_by;
				dr["Modified_date"] = str.Modified_date;
				dr["Completed"] = str.Completed;
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
