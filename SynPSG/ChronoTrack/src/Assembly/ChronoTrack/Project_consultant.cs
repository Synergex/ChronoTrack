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
	[XFAttr(size=89)]
	[Serializable]
	public class Project_consultant : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[7];
		static Project_consultant()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.DECIMAL,11,2);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.DECIMAL,11,2);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.ALPHA,20);
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
		 
		private string f_Consultant_id="";
		 
		/// <summary>
		/// Consultant Username
		/// </summary>
		public string Consultant_id
		{
			get{ return f_Consultant_id;}
			set { 
			    if(!f_Consultant_id.Equals(value)) 
			       m_changed = true; 
			    f_Consultant_id = value;
			} 
		}
		 
		private int f_Fee_type_id=0;
		 
		/// <summary>
		/// Fee Type
		/// </summary>
		public int Fee_type_id
		{
			get{ return f_Fee_type_id;}
			set { 
			    if(f_Fee_type_id != value) 
			       m_changed = true; 
			    f_Fee_type_id = value;
			} 
		}
		 
		private decimal f_Fee=0;
		 
		/// <summary>
		/// Price or amount of consultant, by type
		/// </summary>
		public decimal Fee
		{
			get{ return f_Fee;}
			set { 
			    if(f_Fee != value) 
			       m_changed = true; 
			    f_Fee = value;
			} 
		}
		 
		private decimal f_Cost=0;
		 
		/// <summary>
		/// Actual cost of consultant to Synergex
		/// </summary>
		public decimal Cost
		{
			get{ return f_Cost;}
			set { 
			    if(f_Cost != value) 
			       m_changed = true; 
			    f_Cost = value;
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
		public Project_consultant Clone()
		{
			Project_consultant tmp = new Project_consultant();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Consultant_id = this.f_Consultant_id;
			tmp.f_Fee_type_id = this.f_Fee_type_id;
			tmp.f_Fee = this.f_Fee;
			tmp.f_Cost = this.f_Cost;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project_consultant str)
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
			if (!this.Consultant_id.Equals(str.Consultant_id))
			{
				eq = false;
				return eq;
			}
			if (this.Fee_type_id != str.Fee_type_id)
			{
				eq = false;
				return eq;
			}
			if (this.Fee != str.Fee)
			{
				eq = false;
				return eq;
			}
			if (this.Cost != str.Cost)
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
		public Project_consultant() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[7]89%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Consultant_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Fee_type_id,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Fee,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Cost,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Replication_key,fieldAttributes[6]));
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
			f_Consultant_id = XFProtocol.wireTostring(reply);
			f_Fee_type_id = XFProtocol.wireToint(reply);
			f_Fee = XFProtocol.wireTodecimal(reply);
			f_Cost = XFProtocol.wireTodecimal(reply);
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
		public static void GetRow(ref Project_consultant str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Consultant_id = (string)dr["Consultant_id"];
			str.f_Fee_type_id = (int)dr["Fee_type_id"];
			str.f_Fee = (decimal)dr["Fee"];
			str.f_Cost = (decimal)dr["Cost"];
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
			dtclm = new DataColumn("Consultant_id",typeof(string));
			dtclm.Caption = "Consultant";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Fee_type_id",typeof(int));
			dtclm.Caption = "Fee Type";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Fee",typeof(decimal));
			dtclm.Caption = "Customer Fee";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Cost",typeof(decimal));
			dtclm.Caption = "Synergex Cost";
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
				Project_consultant str = (Project_consultant)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["Project_id"] = str.Project_id;
				dr["Consultant_id"] = str.Consultant_id;
				dr["Fee_type_id"] = str.Fee_type_id;
				dr["Fee"] = str.Fee;
				dr["Cost"] = str.Cost;
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
