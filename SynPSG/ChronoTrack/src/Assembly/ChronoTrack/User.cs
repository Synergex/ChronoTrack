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
	[XFAttr(size=725)]
	[Serializable]
	public class User : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[23];
		static User()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.BOOLEAN,1);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[10]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[11]= new XFAttr(XFAttr.xftype.ALPHA,2);
			fieldAttributes[12]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[13]= new XFAttr(XFAttr.xftype.ALPHA,2);
			fieldAttributes[14]= new XFAttr(XFAttr.xftype.ALPHA,20);
			fieldAttributes[15]= new XFAttr(XFAttr.xftype.ALPHA,20);
			fieldAttributes[16]= new XFAttr(XFAttr.xftype.ALPHA,70);
			fieldAttributes[17]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.BOOLEAN,1);
			fieldAttributes[18]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.BOOLEAN,1);
			fieldAttributes[19]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.BOOLEAN,1);
			fieldAttributes[20]= new XFAttr(XFAttr.xftype.ALPHA,255);
			fieldAttributes[21]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[22]= new XFAttr(XFAttr.xftype.ALPHA,20);
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
		/// User Name
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
		 
		private string f_Password="";
		 
		/// <summary>
		/// User password
		/// </summary>
		public string Password
		{
			get{ return f_Password;}
			set { 
			    if(!f_Password.Equals(value)) 
			       m_changed = true; 
			    f_Password = value;
			} 
		}
		 
		private bool f_Inactive=new bool();
		 
		/// <summary>
		/// User is inactive
		/// </summary>
		public bool Inactive
		{
			get{ return f_Inactive;}
			set { 
			    if(f_Inactive != value) 
			       m_changed = true; 
			    f_Inactive = value;
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
		 
		private bool f_Is_employee=new bool();
		 
		/// <summary>
		/// Is user an employee?
		/// </summary>
		public bool Is_employee
		{
			get{ return f_Is_employee;}
			set { 
			    if(f_Is_employee != value) 
			       m_changed = true; 
			    f_Is_employee = value;
			} 
		}
		 
		private bool f_Is_manager=new bool();
		 
		/// <summary>
		/// Is user a manager?
		/// </summary>
		public bool Is_manager
		{
			get{ return f_Is_manager;}
			set { 
			    if(f_Is_manager != value) 
			       m_changed = true; 
			    f_Is_manager = value;
			} 
		}
		 
		private bool f_Is_consultant=new bool();
		 
		/// <summary>
		/// Is user a consultant?
		/// </summary>
		public bool Is_consultant
		{
			get{ return f_Is_consultant;}
			set { 
			    if(f_Is_consultant != value) 
			       m_changed = true; 
			    f_Is_consultant = value;
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
		public User Clone()
		{
			User tmp = new User();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_User_id = this.f_User_id;
			tmp.f_Password = this.f_Password;
			tmp.f_Inactive = this.f_Inactive;
			tmp.f_First_name = this.f_First_name;
			tmp.f_Last_name = this.f_Last_name;
			tmp.f_Title = this.f_Title;
			tmp.f_Addr1 = this.f_Addr1;
			tmp.f_Addr2 = this.f_Addr2;
			tmp.f_Addr3 = this.f_Addr3;
			tmp.f_Addr4 = this.f_Addr4;
			tmp.f_State = this.f_State;
			tmp.f_Zip = this.f_Zip;
			tmp.f_Country_id = this.f_Country_id;
			tmp.f_Office_phone = this.f_Office_phone;
			tmp.f_Mobile_phone = this.f_Mobile_phone;
			tmp.f_Email = this.f_Email;
			tmp.f_Is_employee = this.f_Is_employee;
			tmp.f_Is_manager = this.f_Is_manager;
			tmp.f_Is_consultant = this.f_Is_consultant;
			tmp.f_Picture_file = this.f_Picture_file;
			tmp.f_Friendly_name = this.f_Friendly_name;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(User str)
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
			if (!this.Password.Equals(str.Password))
			{
				eq = false;
				return eq;
			}
			if (this.Inactive != str.Inactive)
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
			if (this.Is_employee != str.Is_employee)
			{
				eq = false;
				return eq;
			}
			if (this.Is_manager != str.Is_manager)
			{
				eq = false;
				return eq;
			}
			if (this.Is_consultant != str.Is_consultant)
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
		public User() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[23]725%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_User_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Password,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Inactive,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_First_name,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Last_name,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Title,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Addr1,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_Addr2,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_Addr3,fieldAttributes[9]));
			body.Append(XFProtocol.fieldToWire(f_Addr4,fieldAttributes[10]));
			body.Append(XFProtocol.fieldToWire(f_State,fieldAttributes[11]));
			body.Append(XFProtocol.fieldToWire(f_Zip,fieldAttributes[12]));
			body.Append(XFProtocol.fieldToWire(f_Country_id,fieldAttributes[13]));
			body.Append(XFProtocol.fieldToWire(f_Office_phone,fieldAttributes[14]));
			body.Append(XFProtocol.fieldToWire(f_Mobile_phone,fieldAttributes[15]));
			body.Append(XFProtocol.fieldToWire(f_Email,fieldAttributes[16]));
			body.Append(XFProtocol.fieldToWire(f_Is_employee,fieldAttributes[17]));
			body.Append(XFProtocol.fieldToWire(f_Is_manager,fieldAttributes[18]));
			body.Append(XFProtocol.fieldToWire(f_Is_consultant,fieldAttributes[19]));
			body.Append(XFProtocol.fieldToWire(f_Picture_file,fieldAttributes[20]));
			body.Append(XFProtocol.fieldToWire(f_Friendly_name,fieldAttributes[21]));
			body.Append(XFProtocol.fieldToWire(f_Replication_key,fieldAttributes[22]));
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
			f_Password = XFProtocol.wireTostring(reply);
			f_Inactive = XFProtocol.wireTobool(reply);
			f_First_name = XFProtocol.wireTostring(reply);
			f_Last_name = XFProtocol.wireTostring(reply);
			f_Title = XFProtocol.wireTostring(reply);
			f_Addr1 = XFProtocol.wireTostring(reply);
			f_Addr2 = XFProtocol.wireTostring(reply);
			f_Addr3 = XFProtocol.wireTostring(reply);
			f_Addr4 = XFProtocol.wireTostring(reply);
			f_State = XFProtocol.wireTostring(reply);
			f_Zip = XFProtocol.wireTostring(reply);
			f_Country_id = XFProtocol.wireTostring(reply);
			f_Office_phone = XFProtocol.wireTostring(reply);
			f_Mobile_phone = XFProtocol.wireTostring(reply);
			f_Email = XFProtocol.wireTostring(reply);
			f_Is_employee = XFProtocol.wireTobool(reply);
			f_Is_manager = XFProtocol.wireTobool(reply);
			f_Is_consultant = XFProtocol.wireTobool(reply);
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
		public static void GetRow(ref User str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_User_id = (string)dr["User_id"];
			str.f_Password = (string)dr["Password"];
			str.f_Inactive = (bool)dr["Inactive"];
			str.f_First_name = (string)dr["First_name"];
			str.f_Last_name = (string)dr["Last_name"];
			str.f_Title = (string)dr["Title"];
			str.f_Addr1 = (string)dr["Addr1"];
			str.f_Addr2 = (string)dr["Addr2"];
			str.f_Addr3 = (string)dr["Addr3"];
			str.f_Addr4 = (string)dr["Addr4"];
			str.f_State = (string)dr["State"];
			str.f_Zip = (string)dr["Zip"];
			str.f_Country_id = (string)dr["Country_id"];
			str.f_Office_phone = (string)dr["Office_phone"];
			str.f_Mobile_phone = (string)dr["Mobile_phone"];
			str.f_Email = (string)dr["Email"];
			str.f_Is_employee = (bool)dr["Is_employee"];
			str.f_Is_manager = (bool)dr["Is_manager"];
			str.f_Is_consultant = (bool)dr["Is_consultant"];
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
			dtclm = new DataColumn("User_id",typeof(string));
			dtclm.Caption = "Username";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Password",typeof(string));
			dtclm.Caption = "Password";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Inactive",typeof(bool));
			dtclm.Caption = "Inavtive";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("First_name",typeof(string));
			dtclm.Caption = "First Name";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Last_name",typeof(string));
			dtclm.Caption = "Last Name";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Title",typeof(string));
			dtclm.Caption = "Job Title";
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
			dtclm.Caption = "Country";
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
			dtclm = new DataColumn("Is_employee",typeof(bool));
			dtclm.Caption = "Employee";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Is_manager",typeof(bool));
			dtclm.Caption = "Manager";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Is_consultant",typeof(bool));
			dtclm.Caption = "Consultant";
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
				User str = (User)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["User_id"] = str.User_id;
				dr["Password"] = str.Password;
				dr["Inactive"] = str.Inactive;
				dr["First_name"] = str.First_name;
				dr["Last_name"] = str.Last_name;
				dr["Title"] = str.Title;
				dr["Addr1"] = str.Addr1;
				dr["Addr2"] = str.Addr2;
				dr["Addr3"] = str.Addr3;
				dr["Addr4"] = str.Addr4;
				dr["State"] = str.State;
				dr["Zip"] = str.Zip;
				dr["Country_id"] = str.Country_id;
				dr["Office_phone"] = str.Office_phone;
				dr["Mobile_phone"] = str.Mobile_phone;
				dr["Email"] = str.Email;
				dr["Is_employee"] = str.Is_employee;
				dr["Is_manager"] = str.Is_manager;
				dr["Is_consultant"] = str.Is_consultant;
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
