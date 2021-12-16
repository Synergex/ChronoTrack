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
	[XFAttr(size=572)]
	[Serializable]
	public class Customer_contact : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[13];
		static Customer_contact()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,3);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.ALPHA,20);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.ALPHA,20);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.ALPHA,70);
			fieldAttributes[10]= new XFAttr(XFAttr.xftype.ALPHA,255);
			fieldAttributes[11]= new XFAttr(XFAttr.xftype.ALPHA,60);
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
		 
		private int f_Contact_id=0;
		 
		/// <summary>
		/// Contact ID
		/// </summary>
		public int Contact_id
		{
			get{ return f_Contact_id;}
			set { 
			    if(f_Contact_id != value) 
			       m_changed = true; 
			    f_Contact_id = value;
			} 
		}
		 
		private string f_First_name="";
		 
		/// <summary>
		/// First name
		/// </summary>
		public string First_name
		{
			get{ return f_First_name;}
			set { 
			    if(!f_First_name.Equals(value)) 
			       m_changed = true; 
			    f_First_name = value;
			} 
		}
		 
		private string f_Last_name="";
		 
		/// <summary>
		/// Last name
		/// </summary>
		public string Last_name
		{
			get{ return f_Last_name;}
			set { 
			    if(!f_Last_name.Equals(value)) 
			       m_changed = true; 
			    f_Last_name = value;
			} 
		}
		 
		private string f_Title="";
		 
		/// <summary>
		/// Job Title
		/// </summary>
		public string Title
		{
			get{ return f_Title;}
			set { 
			    if(!f_Title.Equals(value)) 
			       m_changed = true; 
			    f_Title = value;
			} 
		}
		 
		private int f_Current_location=0;
		 
		/// <summary>
		/// Contacts cuttent location
		/// </summary>
		public int Current_location
		{
			get{ return f_Current_location;}
			set { 
			    if(f_Current_location != value) 
			       m_changed = true; 
			    f_Current_location = value;
			} 
		}
		 
		private string f_Office_phone="";
		 
		/// <summary>
		/// Office phone number
		/// </summary>
		public string Office_phone
		{
			get{ return f_Office_phone;}
			set { 
			    if(!f_Office_phone.Equals(value)) 
			       m_changed = true; 
			    f_Office_phone = value;
			} 
		}
		 
		private string f_Mobile_phone="";
		 
		/// <summary>
		/// Mobile phone number
		/// </summary>
		public string Mobile_phone
		{
			get{ return f_Mobile_phone;}
			set { 
			    if(!f_Mobile_phone.Equals(value)) 
			       m_changed = true; 
			    f_Mobile_phone = value;
			} 
		}
		 
		private string f_Email="";
		 
		/// <summary>
		/// Email Address
		/// </summary>
		public string Email
		{
			get{ return f_Email;}
			set { 
			    if(!f_Email.Equals(value)) 
			       m_changed = true; 
			    f_Email = value;
			} 
		}
		 
		private string f_Picture_file="";
		 
		/// <summary>
		/// Path to contact image file
		/// </summary>
		public string Picture_file
		{
			get{ return f_Picture_file;}
			set { 
			    if(!f_Picture_file.Equals(value)) 
			       m_changed = true; 
			    f_Picture_file = value;
			} 
		}
		 
		private string f_Friendly_name="";
		 
		/// <summary>
		/// Friendly name (e.g. First Last)
		/// </summary>
		public string Friendly_name
		{
			get{ return f_Friendly_name;}
			set { 
			    if(!f_Friendly_name.Equals(value)) 
			       m_changed = true; 
			    f_Friendly_name = value;
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
		public Customer_contact Clone()
		{
			Customer_contact tmp = new Customer_contact();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_Customer_id = this.f_Customer_id;
			tmp.f_Contact_id = this.f_Contact_id;
			tmp.f_First_name = this.f_First_name;
			tmp.f_Last_name = this.f_Last_name;
			tmp.f_Title = this.f_Title;
			tmp.f_Current_location = this.f_Current_location;
			tmp.f_Office_phone = this.f_Office_phone;
			tmp.f_Mobile_phone = this.f_Mobile_phone;
			tmp.f_Email = this.f_Email;
			tmp.f_Picture_file = this.f_Picture_file;
			tmp.f_Friendly_name = this.f_Friendly_name;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Customer_contact str)
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
			if (this.Contact_id != str.Contact_id)
			{
				eq = false;
				return eq;
			}
			if (!this.First_name.Equals(str.First_name))
			{
				eq = false;
				return eq;
			}
			if (!this.Last_name.Equals(str.Last_name))
			{
				eq = false;
				return eq;
			}
			if (!this.Title.Equals(str.Title))
			{
				eq = false;
				return eq;
			}
			if (this.Current_location != str.Current_location)
			{
				eq = false;
				return eq;
			}
			if (!this.Office_phone.Equals(str.Office_phone))
			{
				eq = false;
				return eq;
			}
			if (!this.Mobile_phone.Equals(str.Mobile_phone))
			{
				eq = false;
				return eq;
			}
			if (!this.Email.Equals(str.Email))
			{
				eq = false;
				return eq;
			}
			if (!this.Picture_file.Equals(str.Picture_file))
			{
				eq = false;
				return eq;
			}
			if (!this.Friendly_name.Equals(str.Friendly_name))
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
		public Customer_contact() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[13]572%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Customer_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Contact_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_First_name,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Last_name,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Title,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Current_location,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Office_phone,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_Mobile_phone,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_Email,fieldAttributes[9]));
			body.Append(XFProtocol.fieldToWire(f_Picture_file,fieldAttributes[10]));
			body.Append(XFProtocol.fieldToWire(f_Friendly_name,fieldAttributes[11]));
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
			f_Contact_id = XFProtocol.wireToint(reply);
			f_First_name = XFProtocol.wireTostring(reply);
			f_Last_name = XFProtocol.wireTostring(reply);
			f_Title = XFProtocol.wireTostring(reply);
			f_Current_location = XFProtocol.wireToint(reply);
			f_Office_phone = XFProtocol.wireTostring(reply);
			f_Mobile_phone = XFProtocol.wireTostring(reply);
			f_Email = XFProtocol.wireTostring(reply);
			f_Picture_file = XFProtocol.wireTostring(reply);
			f_Friendly_name = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Customer_contact str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_Customer_id = (string)dr["Customer_id"];
			str.f_Contact_id = (int)dr["Contact_id"];
			str.f_First_name = (string)dr["First_name"];
			str.f_Last_name = (string)dr["Last_name"];
			str.f_Title = (string)dr["Title"];
			str.f_Current_location = (int)dr["Current_location"];
			str.f_Office_phone = (string)dr["Office_phone"];
			str.f_Mobile_phone = (string)dr["Mobile_phone"];
			str.f_Email = (string)dr["Email"];
			str.f_Picture_file = (string)dr["Picture_file"];
			str.f_Friendly_name = (string)dr["Friendly_name"];
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
			dtclm = new DataColumn("Contact_id",typeof(int));
			dtclm.Caption = "Contact ID";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("First_name",typeof(string));
			dtclm.Caption = "First Name";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Last_name",typeof(string));
			dtclm.Caption = "Last Name";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Title",typeof(string));
			dtclm.Caption = "Job Title";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Current_location",typeof(int));
			dtclm.Caption = "Current Location";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Office_phone",typeof(string));
			dtclm.Caption = "Office Phone";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Mobile_phone",typeof(string));
			dtclm.Caption = "Mobile Phone";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Email",typeof(string));
			dtclm.Caption = "Email";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Picture_file",typeof(string));
			dtclm.Caption = "Picture File";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Friendly_name",typeof(string));
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
				Customer_contact str = (Customer_contact)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["Customer_id"] = str.Customer_id;
				dr["Contact_id"] = str.Contact_id;
				dr["First_name"] = str.First_name;
				dr["Last_name"] = str.Last_name;
				dr["Title"] = str.Title;
				dr["Current_location"] = str.Current_location;
				dr["Office_phone"] = str.Office_phone;
				dr["Mobile_phone"] = str.Mobile_phone;
				dr["Email"] = str.Email;
				dr["Picture_file"] = str.Picture_file;
				dr["Friendly_name"] = str.Friendly_name;
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
