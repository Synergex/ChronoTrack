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
	[XFAttr(size=373)]
	[Serializable]
	public class Project_attachment : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[8];
		static Project_attachment()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.ALPHA,255);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.ALPHA,20);
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
		 
		private int f_Attachment_id=0;
		 
		/// <summary>
		/// Attachment # (sequence in project task)
		/// </summary>
		public int Attachment_id
		{
			get{ return f_Attachment_id;}
			set { 
			    if(f_Attachment_id != value) 
			       m_changed = true; 
			    f_Attachment_id = value;
			} 
		}
		 
		private string f_Description="";
		 
		/// <summary>
		/// Short description of attachment
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
		 
		private int f_Doc_type=0;
		 
		/// <summary>
		/// Document type
		/// </summary>
		public int Doc_type
		{
			get{ return f_Doc_type;}
			set { 
			    if(f_Doc_type != value) 
			       m_changed = true; 
			    f_Doc_type = value;
			} 
		}
		 
		private string f_Filespec="";
		 
		/// <summary>
		/// Path and filename of attachment
		/// </summary>
		public string Filespec
		{
			get{ return f_Filespec;}
			set { 
			    if(!f_Filespec.Equals(value)) 
			       m_changed = true; 
			    f_Filespec = value;
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
		public Project_attachment Clone()
		{
			Project_attachment tmp = new Project_attachment();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Task_id = this.f_Task_id;
			tmp.f_Attachment_id = this.f_Attachment_id;
			tmp.f_Description = this.f_Description;
			tmp.f_Doc_type = this.f_Doc_type;
			tmp.f_Filespec = this.f_Filespec;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project_attachment str)
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
			if (this.Attachment_id != str.Attachment_id)
			{
				eq = false;
				return eq;
			}
			if (!this.Description.Equals(str.Description))
			{
				eq = false;
				return eq;
			}
			if (this.Doc_type != str.Doc_type)
			{
				eq = false;
				return eq;
			}
			if (!this.Filespec.Equals(str.Filespec))
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
		public Project_attachment() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[8]373%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Task_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Attachment_id,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Doc_type,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Filespec,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Replication_key,fieldAttributes[7]));
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
			f_Attachment_id = XFProtocol.wireToint(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Doc_type = XFProtocol.wireToint(reply);
			f_Filespec = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Project_attachment str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Task_id = (int)dr["Task_id"];
			str.f_Attachment_id = (int)dr["Attachment_id"];
			str.f_Description = (string)dr["Description"];
			str.f_Doc_type = (int)dr["Doc_type"];
			str.f_Filespec = (string)dr["Filespec"];
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
			dtclm = new DataColumn("Attachment_id",typeof(int));
			dtclm.Caption = "Attachment #";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Description",typeof(string));
			dtclm.Caption = "Description";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Doc_type",typeof(int));
			dtclm.Caption = "Document Type";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Filespec",typeof(string));
			dtclm.Caption = "File";
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
				Project_attachment str = (Project_attachment)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["Project_id"] = str.Project_id;
				dr["Task_id"] = str.Task_id;
				dr["Attachment_id"] = str.Attachment_id;
				dr["Description"] = str.Description;
				dr["Doc_type"] = str.Doc_type;
				dr["Filespec"] = str.Filespec;
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
