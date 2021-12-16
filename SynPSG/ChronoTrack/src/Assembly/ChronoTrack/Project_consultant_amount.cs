// Generated on 18-May-2009 1:37:26 by gencs v1.0.11.0
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
	[XFAttr(size=26)]
	[Serializable]
	public class Project_consultant_amount : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[2];
		static Project_consultant_amount()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.DECIMAL,11,2);
		}
		private string f_Consultant_id="";
		 
		/// <summary>
		/// User Name
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
		 
		private decimal f_Amount=0;
		 
		/// <summary>
		/// Price or amount
		/// </summary>
		public decimal Amount
		{
			get{ return f_Amount;}
			set { 
			    if(f_Amount != value) 
			       m_changed = true; 
			    f_Amount = value;
			} 
		}
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public Project_consultant_amount Clone()
		{
			Project_consultant_amount tmp = new Project_consultant_amount();
			tmp.f_Consultant_id = this.f_Consultant_id;
			tmp.f_Amount = this.f_Amount;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project_consultant_amount str)
		{
			bool eq = true;
			if (!this.Consultant_id.Equals(str.Consultant_id))
			{
				eq = false;
				return eq;
			}
			if (this.Amount != str.Amount)
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public Project_consultant_amount() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[2]26%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Consultant_id,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Amount,fieldAttributes[1]));
			body.Append("^");
			sb.Append(body.Length+"#"+body.ToString()+";");
			return sb.ToString();
		}
 
		/// <summary>
		/// deserialize structure
		/// </summary>
		public void wireToStruct(SynMessage reply)
		{
			f_Consultant_id = XFProtocol.wireTostring(reply);
			f_Amount = XFProtocol.wireTodecimal(reply);
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
		public static void GetRow(ref Project_consultant_amount str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Consultant_id = (string)dr["Consultant_id"];
			str.f_Amount = (decimal)dr["Amount"];
			str.m_changed = false;
		}
		 
		/// <summary>
		/// Create the DataTable column header
		/// </summary>
		public static void TableHeader(ref DataTable dt)
		{
			DataColumn dtclm;
			ArrayList pkal = new ArrayList();
			dtclm = new DataColumn("Consultant_id",typeof(string));
			dtclm.Caption = "Username";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Amount",typeof(decimal));
			dtclm.Caption = "Price";
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
				Project_consultant_amount str = (Project_consultant_amount)al[i];
				dr["Consultant_id"] = str.Consultant_id;
				dr["Amount"] = str.Amount;
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
