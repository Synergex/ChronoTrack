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
	[XFAttr(size=269)]
	[Serializable]
	public class Project_summary : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[9];
		static Project_summary()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,40);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.ALPHA,60);
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
		 
		private string f_Customer_name="";
		 
		/// <summary>
		/// Company name
		/// </summary>
		public string Customer_name
		{
			get{ return f_Customer_name;}
			set { 
			    if(!f_Customer_name.Equals(value)) 
			       m_changed = true; 
			    f_Customer_name = value;
			} 
		}
		 
		private string f_Work_location="";
		 
		/// <summary>
		/// Work location name
		/// </summary>
		public string Work_location
		{
			get{ return f_Work_location;}
			set { 
			    if(!f_Work_location.Equals(value)) 
			       m_changed = true; 
			    f_Work_location = value;
			} 
		}
		 
		private string f_Status="";
		 
		/// <summary>
		/// Current status text
		/// </summary>
		public string Status
		{
			get{ return f_Status;}
			set { 
			    if(!f_Status.Equals(value)) 
			       m_changed = true; 
			    f_Status = value;
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
		 
		private string f_Subject="";
		 
		/// <summary>
		/// Short project description
		/// </summary>
		public string Subject
		{
			get{ return f_Subject;}
			set { 
			    if(!f_Subject.Equals(value)) 
			       m_changed = true; 
			    f_Subject = value;
			} 
		}
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public Project_summary Clone()
		{
			Project_summary tmp = new Project_summary();
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Customer_id = this.f_Customer_id;
			tmp.f_Customer_name = this.f_Customer_name;
			tmp.f_Work_location = this.f_Work_location;
			tmp.f_Status = this.f_Status;
			tmp.f_Start_date = this.f_Start_date;
			tmp.f_End_date = this.f_End_date;
			tmp.f_Lead_consultant = this.f_Lead_consultant;
			tmp.f_Subject = this.f_Subject;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project_summary str)
		{
			bool eq = true;
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
			if (!this.Customer_name.Equals(str.Customer_name))
			{
				eq = false;
				return eq;
			}
			if (!this.Work_location.Equals(str.Work_location))
			{
				eq = false;
				return eq;
			}
			if (!this.Status.Equals(str.Status))
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
			if (!this.Lead_consultant.Equals(str.Lead_consultant))
			{
				eq = false;
				return eq;
			}
			if (!this.Subject.Equals(str.Subject))
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public Project_summary() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[9]269%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Customer_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Customer_name,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Work_location,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Status,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Start_date,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_End_date,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Lead_consultant,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_Subject,fieldAttributes[8]));
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
			f_Customer_id = XFProtocol.wireTostring(reply);
			f_Customer_name = XFProtocol.wireTostring(reply);
			f_Work_location = XFProtocol.wireTostring(reply);
			f_Status = XFProtocol.wireTostring(reply);
			f_Start_date = XFProtocol.wireToDateTime(reply,fieldAttributes[5]);
			f_End_date = XFProtocol.wireToDateTime(reply,fieldAttributes[6]);
			f_Lead_consultant = XFProtocol.wireTostring(reply);
			f_Subject = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Project_summary str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Customer_id = (string)dr["Customer_id"];
			str.f_Customer_name = (string)dr["Customer_name"];
			str.f_Work_location = (string)dr["Work_location"];
			str.f_Status = (string)dr["Status"];
			str.f_Start_date = (DateTime)dr["Start_date"];
			str.f_End_date = (DateTime)dr["End_date"];
			str.f_Lead_consultant = (string)dr["Lead_consultant"];
			str.f_Subject = (string)dr["Subject"];
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
			dtclm = new DataColumn("Customer_id",typeof(string));
			dtclm.Caption = "Customer #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Customer_name",typeof(string));
			dtclm.Caption = "Company";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Work_location",typeof(string));
			dtclm.Caption = "Location";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Status",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Start_date",typeof(DateTime));
			dtclm.Caption = "Start Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("End_date",typeof(DateTime));
			dtclm.Caption = "End Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Lead_consultant",typeof(string));
			dtclm.Caption = "Lead Consultant";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Subject",typeof(string));
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
				Project_summary str = (Project_summary)al[i];
				dr["Project_id"] = str.Project_id;
				dr["Customer_id"] = str.Customer_id;
				dr["Customer_name"] = str.Customer_name;
				dr["Work_location"] = str.Work_location;
				dr["Status"] = str.Status;
				dr["Start_date"] = str.Start_date;
				dr["End_date"] = str.End_date;
				dr["Lead_consultant"] = str.Lead_consultant;
				dr["Subject"] = str.Subject;
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
