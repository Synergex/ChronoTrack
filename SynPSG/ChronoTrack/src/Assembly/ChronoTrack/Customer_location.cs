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
	[XFAttr(size=268)]
	[Serializable]
	public class Customer_location : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[13];
		static Customer_location()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.ALPHA,2);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[10]= new XFAttr(XFAttr.xftype.ALPHA,2);
			fieldAttributes[11]= new XFAttr(XFAttr.xftype.ALPHA,20);
			fieldAttributes[12]= new XFAttr(XFAttr.xftype.ALPHA,20);
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
		 
		private int f_Location_id=0;
		 
		/// <summary>
		/// Customer location number
		/// </summary>
		public int Location_id
		{
			get{ return f_Location_id;}
			set { 
			    if(f_Location_id != value) 
			       m_changed = true; 
			    f_Location_id = value;
			} 
		}
		 
		private string f_Description="";
		 
		/// <summary>
		/// Description (e.g. New York Office)
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
		 
		private string f_Addr1="";
		 
		/// <summary>
		/// Address line 1
		/// </summary>
		public string Addr1
		{
			get{ return f_Addr1;}
			set { 
			    if(!f_Addr1.Equals(value)) 
			       m_changed = true; 
			    f_Addr1 = value;
			} 
		}
		 
		private string f_Addr2="";
		 
		/// <summary>
		/// Address line
		/// </summary>
		public string Addr2
		{
			get{ return f_Addr2;}
			set { 
			    if(!f_Addr2.Equals(value)) 
			       m_changed = true; 
			    f_Addr2 = value;
			} 
		}
		 
		private string f_Addr3="";
		 
		/// <summary>
		/// Address line
		/// </summary>
		public string Addr3
		{
			get{ return f_Addr3;}
			set { 
			    if(!f_Addr3.Equals(value)) 
			       m_changed = true; 
			    f_Addr3 = value;
			} 
		}
		 
		private string f_Addr4="";
		 
		/// <summary>
		/// Address line
		/// </summary>
		public string Addr4
		{
			get{ return f_Addr4;}
			set { 
			    if(!f_Addr4.Equals(value)) 
			       m_changed = true; 
			    f_Addr4 = value;
			} 
		}
		 
		private string f_State="";
		 
		/// <summary>
		/// Address State
		/// </summary>
		public string State
		{
			get{ return f_State;}
			set { 
			    if(!f_State.Equals(value)) 
			       m_changed = true; 
			    f_State = value;
			} 
		}
		 
		private string f_Zip="";
		 
		/// <summary>
		/// Zip Code
		/// </summary>
		public string Zip
		{
			get{ return f_Zip;}
			set { 
			    if(!f_Zip.Equals(value)) 
			       m_changed = true; 
			    f_Zip = value;
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
		 
		private string f_Phone="";
		 
		/// <summary>
		/// Office phone number
		/// </summary>
		public string Phone
		{
			get{ return f_Phone;}
			set { 
			    if(!f_Phone.Equals(value)) 
			       m_changed = true; 
			    f_Phone = value;
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
		public Customer_location Clone()
		{
			Customer_location tmp = new Customer_location();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_Customer_id = this.f_Customer_id;
			tmp.f_Location_id = this.f_Location_id;
			tmp.f_Description = this.f_Description;
			tmp.f_Addr1 = this.f_Addr1;
			tmp.f_Addr2 = this.f_Addr2;
			tmp.f_Addr3 = this.f_Addr3;
			tmp.f_Addr4 = this.f_Addr4;
			tmp.f_State = this.f_State;
			tmp.f_Zip = this.f_Zip;
			tmp.f_Country_id = this.f_Country_id;
			tmp.f_Phone = this.f_Phone;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Customer_location str)
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
			if (this.Location_id != str.Location_id)
			{
				eq = false;
				return eq;
			}
			if (!this.Description.Equals(str.Description))
			{
				eq = false;
				return eq;
			}
			if (!this.Addr1.Equals(str.Addr1))
			{
				eq = false;
				return eq;
			}
			if (!this.Addr2.Equals(str.Addr2))
			{
				eq = false;
				return eq;
			}
			if (!this.Addr3.Equals(str.Addr3))
			{
				eq = false;
				return eq;
			}
			if (!this.Addr4.Equals(str.Addr4))
			{
				eq = false;
				return eq;
			}
			if (!this.State.Equals(str.State))
			{
				eq = false;
				return eq;
			}
			if (!this.Zip.Equals(str.Zip))
			{
				eq = false;
				return eq;
			}
			if (!this.Country_id.Equals(str.Country_id))
			{
				eq = false;
				return eq;
			}
			if (!this.Phone.Equals(str.Phone))
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
		public Customer_location() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[13]268%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Customer_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Location_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Addr1,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Addr2,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Addr3,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Addr4,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_State,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_Zip,fieldAttributes[9]));
			body.Append(XFProtocol.fieldToWire(f_Country_id,fieldAttributes[10]));
			body.Append(XFProtocol.fieldToWire(f_Phone,fieldAttributes[11]));
			body.Append(XFProtocol.fieldToWire(f_Replication_key,fieldAttributes[12]));
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
			f_Location_id = XFProtocol.wireToint(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Addr1 = XFProtocol.wireTostring(reply);
			f_Addr2 = XFProtocol.wireTostring(reply);
			f_Addr3 = XFProtocol.wireTostring(reply);
			f_Addr4 = XFProtocol.wireTostring(reply);
			f_State = XFProtocol.wireTostring(reply);
			f_Zip = XFProtocol.wireTostring(reply);
			f_Country_id = XFProtocol.wireTostring(reply);
			f_Phone = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Customer_location str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_Customer_id = (string)dr["Customer_id"];
			str.f_Location_id = (int)dr["Location_id"];
			str.f_Description = (string)dr["Description"];
			str.f_Addr1 = (string)dr["Addr1"];
			str.f_Addr2 = (string)dr["Addr2"];
			str.f_Addr3 = (string)dr["Addr3"];
			str.f_Addr4 = (string)dr["Addr4"];
			str.f_State = (string)dr["State"];
			str.f_Zip = (string)dr["Zip"];
			str.f_Country_id = (string)dr["Country_id"];
			str.f_Phone = (string)dr["Phone"];
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
			dtclm = new DataColumn("Location_id",typeof(int));
			dtclm.Caption = "Location #";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Description",typeof(string));
			dtclm.Caption = "Description";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Addr1",typeof(string));
			dtclm.Caption = "Address 1";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Addr2",typeof(string));
			dtclm.Caption = "Address 2";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Addr3",typeof(string));
			dtclm.Caption = "Address 3";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Addr4",typeof(string));
			dtclm.Caption = "Address 4";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("State",typeof(string));
			dtclm.Caption = "State";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Zip",typeof(string));
			dtclm.Caption = "Zip Code";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Country_id",typeof(string));
			dtclm.Caption = "Country Code";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Phone",typeof(string));
			dtclm.Caption = "Office Phone";
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
				Customer_location str = (Customer_location)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["Customer_id"] = str.Customer_id;
				dr["Location_id"] = str.Location_id;
				dr["Description"] = str.Description;
				dr["Addr1"] = str.Addr1;
				dr["Addr2"] = str.Addr2;
				dr["Addr3"] = str.Addr3;
				dr["Addr4"] = str.Addr4;
				dr["State"] = str.State;
				dr["Zip"] = str.Zip;
				dr["Country_id"] = str.Country_id;
				dr["Phone"] = str.Phone;
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
