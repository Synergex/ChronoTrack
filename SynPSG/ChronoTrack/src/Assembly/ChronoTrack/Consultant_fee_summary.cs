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
	[XFAttr(size=63)]
	[Serializable]
	public class Consultant_fee_summary : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[4];
		static Consultant_fee_summary()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,35);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.DECIMAL,11,2);
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
		 
		private string f_Description="";
		 
		/// <summary>
		/// Description
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
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public Consultant_fee_summary Clone()
		{
			Consultant_fee_summary tmp = new Consultant_fee_summary();
			tmp.f_User_id = this.f_User_id;
			tmp.f_Fee_type_id = this.f_Fee_type_id;
			tmp.f_Description = this.f_Description;
			tmp.f_Cost = this.f_Cost;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Consultant_fee_summary str)
		{
			bool eq = true;
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
			if (!this.Description.Equals(str.Description))
			{
				eq = false;
				return eq;
			}
			if (this.Cost != str.Cost)
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public Consultant_fee_summary() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[4]63%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_User_id,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Fee_type_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Cost,fieldAttributes[3]));
			body.Append("^");
			sb.Append(body.Length+"#"+body.ToString()+";");
			return sb.ToString();
		}
 
		/// <summary>
		/// deserialize structure
		/// </summary>
		public void wireToStruct(SynMessage reply)
		{
			f_User_id = XFProtocol.wireTostring(reply);
			f_Fee_type_id = XFProtocol.wireToint(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Cost = XFProtocol.wireTodecimal(reply);
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
		public static void GetRow(ref Consultant_fee_summary str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_User_id = (string)dr["User_id"];
			str.f_Fee_type_id = (int)dr["Fee_type_id"];
			str.f_Description = (string)dr["Description"];
			str.f_Cost = (decimal)dr["Cost"];
			str.m_changed = false;
		}
		 
		/// <summary>
		/// Create the DataTable column header
		/// </summary>
		public static void TableHeader(ref DataTable dt)
		{
			DataColumn dtclm;
			ArrayList pkal = new ArrayList();
			dtclm = new DataColumn("User_id",typeof(string));
			dtclm.Caption = "Username";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Fee_type_id",typeof(int));
			dtclm.Caption = "Fee Type";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Description",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Cost",typeof(decimal));
			dtclm.Caption = "Cost";
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
				Consultant_fee_summary str = (Consultant_fee_summary)al[i];
				dr["User_id"] = str.User_id;
				dr["Fee_type_id"] = str.Fee_type_id;
				dr["Description"] = str.Description;
				dr["Cost"] = str.Cost;
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
