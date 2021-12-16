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
	[XFAttr(size=70)]
	[Serializable]
	public class Consultant_fee : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[5];
		static Consultant_fee()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.DECIMAL,11,2);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,20);
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
		 
		private string f_User_id="";
		 
		/// <summary>
		/// Consultant username
		/// </summary>
		public string User_id
		{
			get{ return f_User_id;}
			set { 
			    if(!f_User_id.Equals(value)) 
			       m_changed = true; 
			    f_User_id = value;
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
		 
		private decimal f_Cost=0;
		 
		/// <summary>
		/// Cost of consultant, by fee type
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
		public Consultant_fee Clone()
		{
			Consultant_fee tmp = new Consultant_fee();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_User_id = this.f_User_id;
			tmp.f_Fee_type_id = this.f_Fee_type_id;
			tmp.f_Cost = this.f_Cost;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Consultant_fee str)
		{
			bool eq = true;
			if (!this.Synergygrfa.Equals(str.Synergygrfa))
			{
				eq = false;
				return eq;
			}
			if (!this.User_id.Equals(str.User_id))
			{
				eq = false;
				return eq;
			}
			if (this.Fee_type_id != str.Fee_type_id)
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
		public Consultant_fee() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[5]70%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_User_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Fee_type_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Cost,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Replication_key,fieldAttributes[4]));
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
			f_User_id = XFProtocol.wireTostring(reply);
			f_Fee_type_id = XFProtocol.wireToint(reply);
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
		public static void GetRow(ref Consultant_fee str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_User_id = (string)dr["User_id"];
			str.f_Fee_type_id = (int)dr["Fee_type_id"];
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
			dtclm = new DataColumn("User_id",typeof(string));
			dtclm.Caption = "Username";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Fee_type_id",typeof(int));
			dtclm.Caption = "Fee Type";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Cost",typeof(decimal));
			dtclm.Caption = "Cost";
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
				Consultant_fee str = (Consultant_fee)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["User_id"] = str.User_id;
				dr["Fee_type_id"] = str.Fee_type_id;
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
