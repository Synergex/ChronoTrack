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
	[XFAttr(size=172)]
	[Serializable]
	public class Project_task_summary : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[8];
		static Project_task_summary()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.ALPHA,3);
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
		 
		private string f_Task_type="";
		 
		/// <summary>
		/// Task type
		/// </summary>
		public string Task_type
		{
			get{ return f_Task_type;}
			set { 
			    if(!f_Task_type.Equals(value)) 
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
		 
		private string f_Completed="";
		 
		/// <summary>
		/// Task completed?
		/// </summary>
		public string Completed
		{
			get{ return f_Completed;}
			set { 
			    if(!f_Completed.Equals(value)) 
			       m_changed = true; 
			    f_Completed = value;
			} 
		}
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public Project_task_summary Clone()
		{
			Project_task_summary tmp = new Project_task_summary();
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Task_id = this.f_Task_id;
			tmp.f_Task_type = this.f_Task_type;
			tmp.f_Description = this.f_Description;
			tmp.f_Assigned_to = this.f_Assigned_to;
			tmp.f_Start_date = this.f_Start_date;
			tmp.f_End_date = this.f_End_date;
			tmp.f_Completed = this.f_Completed;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project_task_summary str)
		{
			bool eq = true;
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
			if (!this.Task_type.Equals(str.Task_type))
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
			if (this.End_date != str.End_date)
			{
				eq = false;
				return eq;
			}
			if (!this.Completed.Equals(str.Completed))
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public Project_task_summary() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[8]172%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Task_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Task_type,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Assigned_to,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Start_date,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_End_date,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Completed,fieldAttributes[7]));
			body.Append("^");
			sb.Append(body.Length+"#"+body.ToString()+";");
			return sb.ToString();
		}
 
		/// <summary>
		/// deserialize structure
		/// </summary>
		public void wireToStruct(SynMessage reply)
		{
			f_Project_id = XFProtocol.wireToint(reply);
			f_Task_id = XFProtocol.wireToint(reply);
			f_Task_type = XFProtocol.wireTostring(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Assigned_to = XFProtocol.wireTostring(reply);
			f_Start_date = XFProtocol.wireToDateTime(reply,fieldAttributes[5]);
			f_End_date = XFProtocol.wireToDateTime(reply,fieldAttributes[6]);
			f_Completed = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Project_task_summary str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Task_id = (int)dr["Task_id"];
			str.f_Task_type = (string)dr["Task_type"];
			str.f_Description = (string)dr["Description"];
			str.f_Assigned_to = (string)dr["Assigned_to"];
			str.f_Start_date = (DateTime)dr["Start_date"];
			str.f_End_date = (DateTime)dr["End_date"];
			str.f_Completed = (string)dr["Completed"];
			str.m_changed = false;
		}
		 
		/// <summary>
		/// Create the DataTable column header
		/// </summary>
		public static void TableHeader(ref DataTable dt)
		{
			DataColumn dtclm;
			ArrayList pkal = new ArrayList();
			dtclm = new DataColumn("Project_id",typeof(int));
			dtclm.Caption = "Project #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Task_id",typeof(int));
			dtclm.Caption = "Task #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Task_type",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Description",typeof(string));
			dtclm.Caption = "Description";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Assigned_to",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Start_date",typeof(DateTime));
			dtclm.Caption = "Start Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("End_date",typeof(DateTime));
			dtclm.Caption = "End Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Completed",typeof(string));
			dt.Columns.Add(dtclm);
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
				Project_task_summary str = (Project_task_summary)al[i];
				dr["Project_id"] = str.Project_id;
				dr["Task_id"] = str.Task_id;
				dr["Task_type"] = str.Task_type;
				dr["Description"] = str.Description;
				dr["Assigned_to"] = str.Assigned_to;
				dr["Start_date"] = str.Start_date;
				dr["End_date"] = str.End_date;
				dr["Completed"] = str.Completed;
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
