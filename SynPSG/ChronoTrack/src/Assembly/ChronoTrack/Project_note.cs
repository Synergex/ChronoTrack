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
	[XFAttr(size=860)]
	[Serializable]
	public class Project_note : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[10];
		static Project_note()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,4);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.ALPHA,700);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.ALPHA,20);
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
		 
		private int f_Note_id=0;
		 
		/// <summary>
		/// Project note number (sequence)
		/// </summary>
		public int Note_id
		{
			get{ return f_Note_id;}
			set { 
			    if(f_Note_id != value) 
			       m_changed = true; 
			    f_Note_id = value;
			} 
		}
		 
		private string f_Description="";
		 
		/// <summary>
		/// Short description of note
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
		 
		private string f_Created_by="";
		 
		/// <summary>
		/// Note originally created by
		/// </summary>
		public string Created_by
		{
			get{ return f_Created_by;}
		}
		 
		private DateTime f_Created_date=new DateTime();
		 
		/// <summary>
		/// Date created
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
		/// Note text
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
		public Project_note Clone()
		{
			Project_note tmp = new Project_note();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Note_id = this.f_Note_id;
			tmp.f_Description = this.f_Description;
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
		public bool Equals(Project_note str)
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
			if (this.Note_id != str.Note_id)
			{
				eq = false;
				return eq;
			}
			if (!this.Description.Equals(str.Description))
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
		public Project_note() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[10]860%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Note_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Created_by,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Created_date,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Modified_by,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Modified_date,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_Text,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_Replication_key,fieldAttributes[9]));
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
			f_Note_id = XFProtocol.wireToint(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Created_by = XFProtocol.wireTostring(reply);
			f_Created_date = XFProtocol.wireToDateTime(reply,fieldAttributes[5]);
			f_Modified_by = XFProtocol.wireTostring(reply);
			f_Modified_date = XFProtocol.wireToDateTime(reply,fieldAttributes[7]);
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
		public static void GetRow(ref Project_note str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Note_id = (int)dr["Note_id"];
			str.f_Description = (string)dr["Description"];
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
			dtclm = new DataColumn("Note_id",typeof(int));
			dtclm.Caption = "Note #";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Description",typeof(string));
			dtclm.Caption = "Description";
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
			dtclm.Caption = "Note Text";
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
				Project_note str = (Project_note)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["Project_id"] = str.Project_id;
				dr["Note_id"] = str.Note_id;
				dr["Description"] = str.Description;
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
