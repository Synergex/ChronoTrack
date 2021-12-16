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
	[XFAttr(size=143)]
	[Serializable]
	public class Project_activity_summary : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[6];
		static Project_activity_summary()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,4);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,60);
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
		 
		private int f_Activity_id=0;
		 
		/// <summary>
		/// Activity number (sequence in project)
		/// </summary>
		public int Activity_id
		{
			get{ return f_Activity_id;}
			set { 
			    if(f_Activity_id != value) 
			       m_changed = true; 
			    f_Activity_id = value;
			} 
		}
		 
		private string f_Created_by="";
		 
		/// <summary>
		/// Activity originally entered by
		/// </summary>
		public string Created_by
		{
			get{ return f_Created_by;}
			set { 
			    if(!f_Created_by.Equals(value)) 
			       m_changed = true; 
			    f_Created_by = value;
			} 
		}
		 
		private DateTime f_Start_date=new DateTime();
		 
		/// <summary>
		/// Date activity started
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
		 
		private string f_Description="";
		 
		/// <summary>
		/// Short description (for lists)
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
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public Project_activity_summary Clone()
		{
			Project_activity_summary tmp = new Project_activity_summary();
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Task_id = this.f_Task_id;
			tmp.f_Activity_id = this.f_Activity_id;
			tmp.f_Created_by = this.f_Created_by;
			tmp.f_Start_date = this.f_Start_date;
			tmp.f_Description = this.f_Description;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project_activity_summary str)
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
			if (this.Activity_id != str.Activity_id)
			{
				eq = false;
				return eq;
			}
			if (!this.Created_by.Equals(str.Created_by))
			{
				eq = false;
				return eq;
			}
			if (this.Start_date != str.Start_date)
			{
				eq = false;
				return eq;
			}
			if (!this.Description.Equals(str.Description))
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public Project_activity_summary() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[6]143%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Task_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Activity_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Created_by,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Start_date,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[5]));
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
			f_Activity_id = XFProtocol.wireToint(reply);
			f_Created_by = XFProtocol.wireTostring(reply);
			f_Start_date = XFProtocol.wireToDateTime(reply,fieldAttributes[4]);
			f_Description = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Project_activity_summary str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Task_id = (int)dr["Task_id"];
			str.f_Activity_id = (int)dr["Activity_id"];
			str.f_Created_by = (string)dr["Created_by"];
			str.f_Start_date = (DateTime)dr["Start_date"];
			str.f_Description = (string)dr["Description"];
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
			dtclm = new DataColumn("Activity_id",typeof(int));
			dtclm.Caption = "Activity #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Created_by",typeof(string));
			dtclm.Caption = "Created By";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Start_date",typeof(DateTime));
			dtclm.Caption = "Start Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Description",typeof(string));
			dtclm.Caption = "Description";
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
				Project_activity_summary str = (Project_activity_summary)al[i];
				dr["Project_id"] = str.Project_id;
				dr["Task_id"] = str.Task_id;
				dr["Activity_id"] = str.Activity_id;
				dr["Created_by"] = str.Created_by;
				dr["Start_date"] = str.Start_date;
				dr["Description"] = str.Description;
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
