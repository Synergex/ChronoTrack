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
	[XFAttr(size=108)]
	[Serializable]
	public class Customer : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[7];
		static Customer()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,40);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,10);
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
		 
		private string f_Company="";
		 
		/// <summary>
		/// Company name
		/// </summary>
		public string Company
		{
			get{ return f_Company;}
			set { 
			    if(!f_Company.Equals(value)) 
			       m_changed = true; 
			    f_Company = value;
			} 
		}
		 
		private int f_Tech_contact_id=0;
		 
		/// <summary>
		/// Tech Contact ID
		/// </summary>
		public int Tech_contact_id
		{
			get{ return f_Tech_contact_id;}
			set { 
			    if(f_Tech_contact_id != value) 
			       m_changed = true; 
			    f_Tech_contact_id = value;
			} 
		}
		 
		private int f_Legal_contact_id=0;
		 
		/// <summary>
		/// Primary legal contact ID
		/// </summary>
		public int Legal_contact_id
		{
			get{ return f_Legal_contact_id;}
			set { 
			    if(f_Legal_contact_id != value) 
			       m_changed = true; 
			    f_Legal_contact_id = value;
			} 
		}
		 
		private string f_Current_contract="";
		 
		/// <summary>
		/// Current contract number
		/// </summary>
		public string Current_contract
		{
			get{ return f_Current_contract;}
			set { 
			    if(!f_Current_contract.Equals(value)) 
			       m_changed = true; 
			    f_Current_contract = value;
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
		public Customer Clone()
		{
			Customer tmp = new Customer();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_Customer_id = this.f_Customer_id;
			tmp.f_Company = this.f_Company;
			tmp.f_Tech_contact_id = this.f_Tech_contact_id;
			tmp.f_Legal_contact_id = this.f_Legal_contact_id;
			tmp.f_Current_contract = this.f_Current_contract;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Customer str)
		{
			bool eq = true;
			if (!this.Synergygrfa.Equals(str.Synergygrfa))
			{
				eq = false;
				return eq;
			}
			if (!this.Customer_id.Equals(str.Customer_id))
			{
				eq = false;
				return eq;
			}
			if (!this.Company.Equals(str.Company))
			{
				eq = false;
				return eq;
			}
			if (this.Tech_contact_id != str.Tech_contact_id)
			{
				eq = false;
				return eq;
			}
			if (this.Legal_contact_id != str.Legal_contact_id)
			{
				eq = false;
				return eq;
			}
			if (!this.Current_contract.Equals(str.Current_contract))
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
		public Customer() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[7]108%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Customer_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Company,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Tech_contact_id,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Legal_contact_id,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Current_contract,fieldAttributes[5]));
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
			f_Customer_id = XFProtocol.wireTostring(reply);
			f_Company = XFProtocol.wireTostring(reply);
			f_Tech_contact_id = XFProtocol.wireToint(reply);
			f_Legal_contact_id = XFProtocol.wireToint(reply);
			f_Current_contract = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Customer str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_Customer_id = (string)dr["Customer_id"];
			str.f_Company = (string)dr["Company"];
			str.f_Tech_contact_id = (int)dr["Tech_contact_id"];
			str.f_Legal_contact_id = (int)dr["Legal_contact_id"];
			str.f_Current_contract = (string)dr["Current_contract"];
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
			dtclm = new DataColumn("Customer_id",typeof(string));
			dtclm.Caption = "Customer #";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Company",typeof(string));
			dtclm.Caption = "Company";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Tech_contact_id",typeof(int));
			dtclm.Caption = "Technical Contact";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Legal_contact_id",typeof(int));
			dtclm.Caption = "Legal Contact";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Current_contract",typeof(string));
			dtclm.Caption = "Contract #";
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
				Customer str = (Customer)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["Customer_id"] = str.Customer_id;
				dr["Company"] = str.Company;
				dr["Tech_contact_id"] = str.Tech_contact_id;
				dr["Legal_contact_id"] = str.Legal_contact_id;
				dr["Current_contract"] = str.Current_contract;
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
