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
	[XFAttr(size=81)]
	[Serializable]
	public class Country : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[6];
		static Country()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.ALPHA,2);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,5);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,2);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,20);
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
		 
		private string f_Country_id="";
		 
		/// <summary>
		/// 2-letter country code
		/// </summary>
		public string Country_id
		{
			get{ return f_Country_id;}
			set { 
			    if(!f_Country_id.Equals(value)) 
			       m_changed = true; 
			    f_Country_id = value;
			} 
		}
		 
		private string f_Country_name="";
		 
		/// <summary>
		/// Country name
		/// </summary>
		public string Country_name
		{
			get{ return f_Country_name;}
			set { 
			    if(!f_Country_name.Equals(value)) 
			       m_changed = true; 
			    f_Country_name = value;
			} 
		}
		 
		private int f_Dialing_code=0;
		 
		/// <summary>
		/// International calling code
		/// </summary>
		public int Dialing_code
		{
			get{ return f_Dialing_code;}
			set { 
			    if(f_Dialing_code != value) 
			       m_changed = true; 
			    f_Dialing_code = value;
			} 
		}
		 
		private string f_Currency_code="";
		 
		/// <summary>
		/// Currency Code
		/// </summary>
		public string Currency_code
		{
			get{ return f_Currency_code;}
			set { 
			    if(!f_Currency_code.Equals(value)) 
			       m_changed = true; 
			    f_Currency_code = value;
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
		public Country Clone()
		{
			Country tmp = new Country();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_Country_id = this.f_Country_id;
			tmp.f_Country_name = this.f_Country_name;
			tmp.f_Dialing_code = this.f_Dialing_code;
			tmp.f_Currency_code = this.f_Currency_code;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Country str)
		{
			bool eq = true;
			if (!this.Synergygrfa.Equals(str.Synergygrfa))
			{
				eq = false;
				return eq;
			}
			if (!this.Country_id.Equals(str.Country_id))
			{
				eq = false;
				return eq;
			}
			if (!this.Country_name.Equals(str.Country_name))
			{
				eq = false;
				return eq;
			}
			if (this.Dialing_code != str.Dialing_code)
			{
				eq = false;
				return eq;
			}
			if (!this.Currency_code.Equals(str.Currency_code))
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
		public Country() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[6]81%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Country_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Country_name,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Dialing_code,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Currency_code,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Replication_key,fieldAttributes[5]));
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
			f_Country_id = XFProtocol.wireTostring(reply);
			f_Country_name = XFProtocol.wireTostring(reply);
			f_Dialing_code = XFProtocol.wireToint(reply);
			f_Currency_code = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Country str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_Country_id = (string)dr["Country_id"];
			str.f_Country_name = (string)dr["Country_name"];
			str.f_Dialing_code = (int)dr["Dialing_code"];
			str.f_Currency_code = (string)dr["Currency_code"];
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
			dtclm = new DataColumn("Country_id",typeof(string));
			dtclm.Caption = "Country Code";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Country_name",typeof(string));
			dtclm.Caption = "Country Name";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Dialing_code",typeof(int));
			dtclm.Caption = "Dialling Code";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Currency_code",typeof(string));
			dtclm.Caption = "Currency";
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
				Country str = (Country)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["Country_id"] = str.Country_id;
				dr["Country_name"] = str.Country_name;
				dr["Dialing_code"] = str.Dialing_code;
				dr["Currency_code"] = str.Currency_code;
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
