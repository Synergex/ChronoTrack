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
	[XFAttr(size=374)]
	[Serializable]
	public class Customer_contract : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[11];
		static Customer_contract()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.ALPHA,255);
			fieldAttributes[10]= new XFAttr(XFAttr.xftype.ALPHA,20);
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
		 
		private string f_Contract_id="";
		 
		/// <summary>
		/// Contract Number
		/// </summary>
		public string Contract_id
		{
			get{ return f_Contract_id;}
			set { 
			    if(!f_Contract_id.Equals(value)) 
			       m_changed = true; 
			    f_Contract_id = value;
			} 
		}
		 
		private string f_Issued_by="";
		 
		/// <summary>
		/// User Name
		/// </summary>
		public string Issued_by
		{
			get{ return f_Issued_by;}
			set { 
			    if(!f_Issued_by.Equals(value)) 
			       m_changed = true; 
			    f_Issued_by = value;
			} 
		}
		 
		private DateTime f_Issued_date=new DateTime();
		 
		/// <summary>
		/// Date issued
		/// </summary>
		public DateTime Issued_date
		{
			get{ return f_Issued_date;}
			set { 
			    if(f_Issued_date != value) 
			       m_changed = true; 
			    f_Issued_date = value;
			} 
		}
		 
		private int f_Signed_by=0;
		 
		/// <summary>
		/// Contract signed by (customer contact)
		/// </summary>
		public int Signed_by
		{
			get{ return f_Signed_by;}
			set { 
			    if(f_Signed_by != value) 
			       m_changed = true; 
			    f_Signed_by = value;
			} 
		}
		 
		private DateTime f_Signed_date=new DateTime();
		 
		/// <summary>
		/// Date contract was signed by contact
		/// </summary>
		public DateTime Signed_date
		{
			get{ return f_Signed_date;}
			set { 
			    if(f_Signed_date != value) 
			       m_changed = true; 
			    f_Signed_date = value;
			} 
		}
		 
		private string f_Created_by="";
		 
		/// <summary>
		/// Contract record created by (username)
		/// </summary>
		public string Created_by
		{
			get{ return f_Created_by;}
		}
		 
		private DateTime f_Created_date=new DateTime();
		 
		/// <summary>
		/// Date contract entered into system
		/// </summary>
		public DateTime Created_date
		{
			get{ return f_Created_date;}
		}
		 
		private string f_Contract_document="";
		 
		/// <summary>
		/// Contract file spec
		/// </summary>
		public string Contract_document
		{
			get{ return f_Contract_document;}
			set { 
			    if(!f_Contract_document.Equals(value)) 
			       m_changed = true; 
			    f_Contract_document = value;
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
		public Customer_contract Clone()
		{
			Customer_contract tmp = new Customer_contract();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_Customer_id = this.f_Customer_id;
			tmp.f_Contract_id = this.f_Contract_id;
			tmp.f_Issued_by = this.f_Issued_by;
			tmp.f_Issued_date = this.f_Issued_date;
			tmp.f_Signed_by = this.f_Signed_by;
			tmp.f_Signed_date = this.f_Signed_date;
			tmp.f_Created_by = this.f_Created_by;
			tmp.f_Created_date = this.f_Created_date;
			tmp.f_Contract_document = this.f_Contract_document;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Customer_contract str)
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
			if (!this.Contract_id.Equals(str.Contract_id))
			{
				eq = false;
				return eq;
			}
			if (!this.Issued_by.Equals(str.Issued_by))
			{
				eq = false;
				return eq;
			}
			if (this.Issued_date != str.Issued_date)
			{
				eq = false;
				return eq;
			}
			if (this.Signed_by != str.Signed_by)
			{
				eq = false;
				return eq;
			}
			if (this.Signed_date != str.Signed_date)
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
			if (!this.Contract_document.Equals(str.Contract_document))
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
		public Customer_contract() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[11]374%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Customer_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Contract_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Issued_by,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Issued_date,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Signed_by,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Signed_date,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Created_by,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_Created_date,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_Contract_document,fieldAttributes[9]));
			body.Append(XFProtocol.fieldToWire(f_Replication_key,fieldAttributes[10]));
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
			f_Contract_id = XFProtocol.wireTostring(reply);
			f_Issued_by = XFProtocol.wireTostring(reply);
			f_Issued_date = XFProtocol.wireToDateTime(reply,fieldAttributes[4]);
			f_Signed_by = XFProtocol.wireToint(reply);
			f_Signed_date = XFProtocol.wireToDateTime(reply,fieldAttributes[6]);
			f_Created_by = XFProtocol.wireTostring(reply);
			f_Created_date = XFProtocol.wireToDateTime(reply,fieldAttributes[8]);
			f_Contract_document = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Customer_contract str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_Customer_id = (string)dr["Customer_id"];
			str.f_Contract_id = (string)dr["Contract_id"];
			str.f_Issued_by = (string)dr["Issued_by"];
			str.f_Issued_date = (DateTime)dr["Issued_date"];
			str.f_Signed_by = (int)dr["Signed_by"];
			str.f_Signed_date = (DateTime)dr["Signed_date"];
			str.f_Created_by = (string)dr["Created_by"];
			str.f_Created_date = (DateTime)dr["Created_date"];
			str.f_Contract_document = (string)dr["Contract_document"];
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
			dtclm = new DataColumn("Contract_id",typeof(string));
			dtclm.Caption = "Contract #";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Issued_by",typeof(string));
			dtclm.Caption = "Issued By";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Issued_date",typeof(DateTime));
			dtclm.Caption = "Issued Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Signed_by",typeof(int));
			dtclm.Caption = "Signed By";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Signed_date",typeof(DateTime));
			dtclm.Caption = "Signed Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Created_by",typeof(string));
			dtclm.Caption = "Created By";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Created_date",typeof(DateTime));
			dtclm.Caption = "Created Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Contract_document",typeof(string));
			dtclm.Caption = "Contract Document";
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
				Customer_contract str = (Customer_contract)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["Customer_id"] = str.Customer_id;
				dr["Contract_id"] = str.Contract_id;
				dr["Issued_by"] = str.Issued_by;
				dr["Issued_date"] = str.Issued_date;
				dr["Signed_by"] = str.Signed_by;
				dr["Signed_date"] = str.Signed_date;
				dr["Created_by"] = str.Created_by;
				dr["Created_date"] = str.Created_date;
				dr["Contract_document"] = str.Contract_document;
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
