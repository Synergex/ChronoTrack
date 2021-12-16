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
	[XFAttr(size=1052)]
	[Serializable]
	public class Project_combined : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[13];
		static Project_combined()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.ALPHA,40);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,40);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.ALPHA,30);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,20);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[10]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[11]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[12]= new XFAttr(XFAttr.xftype.ALPHA,700);
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
		 
		private string f_Customer_name="";
		 
		/// <summary>
		/// Company name
		/// </summary>
		public string Customer_name
		{
			get{ return f_Customer_name;}
			set { 
			    if(!f_Customer_name.Equals(value)) 
			       m_changed = true; 
			    f_Customer_name = value;
			} 
		}
		 
		private string f_Customer_location="";
		 
		/// <summary>
		/// *** Field To Do ***
		/// </summary>
		public string Customer_location
		{
			get{ return f_Customer_location;}
			set { 
			    if(!f_Customer_location.Equals(value)) 
			       m_changed = true; 
			    f_Customer_location = value;
			} 
		}
		 
		private string f_Customer_contact="";
		 
		/// <summary>
		/// *** Field To Do ***
		/// </summary>
		public string Customer_contact
		{
			get{ return f_Customer_contact;}
			set { 
			    if(!f_Customer_contact.Equals(value)) 
			       m_changed = true; 
			    f_Customer_contact = value;
			} 
		}
		 
		private string f_Contact_phone="";
		 
		/// <summary>
		/// Phone Number
		/// </summary>
		public string Contact_phone
		{
			get{ return f_Contact_phone;}
			set { 
			    if(!f_Contact_phone.Equals(value)) 
			       m_changed = true; 
			    f_Contact_phone = value;
			} 
		}
		 
		private string f_Description="";
		 
		/// <summary>
		/// Short project description
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
		 
		private DateTime f_Start_date=new DateTime();
		 
		/// <summary>
		/// Start date
		/// </summary>
		public DateTime Start_date
		{
			get{ return f_Start_date;}
			set { 
			    if(f_Start_date != value) 
			       m_changed = true; 
			    f_Start_date = value;
			} 
		}
		 
		private DateTime f_End_date=new DateTime();
		 
		/// <summary>
		/// End date
		/// </summary>
		public DateTime End_date
		{
			get{ return f_End_date;}
			set { 
			    if(f_End_date != value) 
			       m_changed = true; 
			    f_End_date = value;
			} 
		}
		 
		private string f_Current_status="";
		 
		/// <summary>
		/// Project Status
		/// </summary>
		public string Current_status
		{
			get{ return f_Current_status;}
			set { 
			    if(!f_Current_status.Equals(value)) 
			       m_changed = true; 
			    f_Current_status = value;
			} 
		}
		 
		private DateTime f_Status_date=new DateTime();
		 
		/// <summary>
		/// Last status change
		/// </summary>
		public DateTime Status_date
		{
			get{ return f_Status_date;}
		}
		 
		private string f_Consultant_full_name="";
		 
		/// <summary>
		/// *** Field To Do ***
		/// </summary>
		public string Consultant_full_name
		{
			get{ return f_Consultant_full_name;}
			set { 
			    if(!f_Consultant_full_name.Equals(value)) 
			       m_changed = true; 
			    f_Consultant_full_name = value;
			} 
		}
		 
		private string f_Coordinator_full_name="";
		 
		/// <summary>
		/// *** Field To Do ***
		/// </summary>
		public string Coordinator_full_name
		{
			get{ return f_Coordinator_full_name;}
			set { 
			    if(!f_Coordinator_full_name.Equals(value)) 
			       m_changed = true; 
			    f_Coordinator_full_name = value;
			} 
		}
		 
		private string f_Text="";
		 
		/// <summary>
		/// Long description
		/// </summary>
		public string Text
		{
			get{ return f_Text;}
			set { 
			    if(!f_Text.Equals(value)) 
			       m_changed = true; 
			    f_Text = value;
			} 
		}
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public Project_combined Clone()
		{
			Project_combined tmp = new Project_combined();
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Customer_name = this.f_Customer_name;
			tmp.f_Customer_location = this.f_Customer_location;
			tmp.f_Customer_contact = this.f_Customer_contact;
			tmp.f_Contact_phone = this.f_Contact_phone;
			tmp.f_Description = this.f_Description;
			tmp.f_Start_date = this.f_Start_date;
			tmp.f_End_date = this.f_End_date;
			tmp.f_Current_status = this.f_Current_status;
			tmp.f_Status_date = this.f_Status_date;
			tmp.f_Consultant_full_name = this.f_Consultant_full_name;
			tmp.f_Coordinator_full_name = this.f_Coordinator_full_name;
			tmp.f_Text = this.f_Text;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project_combined str)
		{
			bool eq = true;
			if (this.Project_id != str.Project_id)
			{
				eq = false;
				return eq;
			}
			if (!this.Customer_name.Equals(str.Customer_name))
			{
				eq = false;
				return eq;
			}
			if (!this.Customer_location.Equals(str.Customer_location))
			{
				eq = false;
				return eq;
			}
			if (!this.Customer_contact.Equals(str.Customer_contact))
			{
				eq = false;
				return eq;
			}
			if (!this.Contact_phone.Equals(str.Contact_phone))
			{
				eq = false;
				return eq;
			}
			if (!this.Description.Equals(str.Description))
			{
				eq = false;
				return eq;
			}
			if (this.Start_date != str.Start_date)
			{
				eq = false;
				return eq;
			}
			if (this.End_date != str.End_date)
			{
				eq = false;
				return eq;
			}
			if (!this.Current_status.Equals(str.Current_status))
			{
				eq = false;
				return eq;
			}
			if (this.Status_date != str.Status_date)
			{
				eq = false;
				return eq;
			}
			if (!this.Consultant_full_name.Equals(str.Consultant_full_name))
			{
				eq = false;
				return eq;
			}
			if (!this.Coordinator_full_name.Equals(str.Coordinator_full_name))
			{
				eq = false;
				return eq;
			}
			if (!this.Text.Equals(str.Text))
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public Project_combined() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[13]1052%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Customer_name,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Customer_location,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Customer_contact,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Contact_phone,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Start_date,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_End_date,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_Current_status,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_Status_date,fieldAttributes[9]));
			body.Append(XFProtocol.fieldToWire(f_Consultant_full_name,fieldAttributes[10]));
			body.Append(XFProtocol.fieldToWire(f_Coordinator_full_name,fieldAttributes[11]));
			body.Append(XFProtocol.fieldToWire(f_Text,fieldAttributes[12]));
			body.Append("^");
			sb.Append(body.Length+"#"+body.ToString()+";");
			return sb.ToString();
		}
 
		/// <summary>
		/// deserialize structure
		/// </summary>
		public void wireToStruct(SynMessage reply)
		{
			f_Project_id = XFProtocol.wireToint(reply);
			f_Customer_name = XFProtocol.wireTostring(reply);
			f_Customer_location = XFProtocol.wireTostring(reply);
			f_Customer_contact = XFProtocol.wireTostring(reply);
			f_Contact_phone = XFProtocol.wireTostring(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Start_date = XFProtocol.wireToDateTime(reply,fieldAttributes[6]);
			f_End_date = XFProtocol.wireToDateTime(reply,fieldAttributes[7]);
			f_Current_status = XFProtocol.wireTostring(reply);
			f_Status_date = XFProtocol.wireToDateTime(reply,fieldAttributes[9]);
			f_Consultant_full_name = XFProtocol.wireTostring(reply);
			f_Coordinator_full_name = XFProtocol.wireTostring(reply);
			f_Text = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Project_combined str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Customer_name = (string)dr["Customer_name"];
			str.f_Customer_location = (string)dr["Customer_location"];
			str.f_Customer_contact = (string)dr["Customer_contact"];
			str.f_Contact_phone = (string)dr["Contact_phone"];
			str.f_Description = (string)dr["Description"];
			str.f_Start_date = (DateTime)dr["Start_date"];
			str.f_End_date = (DateTime)dr["End_date"];
			str.f_Current_status = (string)dr["Current_status"];
			str.f_Status_date = (DateTime)dr["Status_date"];
			str.f_Consultant_full_name = (string)dr["Consultant_full_name"];
			str.f_Coordinator_full_name = (string)dr["Coordinator_full_name"];
			str.f_Text = (string)dr["Text"];
			str.m_changed = false;
		}
		 
		/// <summary>
		/// Create the DataTable column header
		/// </summary>
		public static void TableHeader(ref DataTable dt)
		{
			DataColumn dtclm;
			ArrayList pkal = new ArrayList();
			dtclm = new DataColumn("Project_id",typeof(int));
			dtclm.Caption = "Project #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Customer_name",typeof(string));
			dtclm.Caption = "Company";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Customer_location",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Customer_contact",typeof(string));
			dtclm.Caption = "Contract #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Contact_phone",typeof(string));
			dtclm.Caption = "Phone #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Description",typeof(string));
			dtclm.Caption = "Description";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Start_date",typeof(DateTime));
			dtclm.Caption = "Start Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("End_date",typeof(DateTime));
			dtclm.Caption = "End Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Current_status",typeof(string));
			dtclm.Caption = "Status";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Status_date",typeof(DateTime));
			dtclm.Caption = "Status Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Consultant_full_name",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Coordinator_full_name",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Text",typeof(string));
			dtclm.Caption = "Project Overview";
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
				Project_combined str = (Project_combined)al[i];
				dr["Project_id"] = str.Project_id;
				dr["Customer_name"] = str.Customer_name;
				dr["Customer_location"] = str.Customer_location;
				dr["Customer_contact"] = str.Customer_contact;
				dr["Contact_phone"] = str.Contact_phone;
				dr["Description"] = str.Description;
				dr["Start_date"] = str.Start_date;
				dr["End_date"] = str.End_date;
				dr["Current_status"] = str.Current_status;
				dr["Status_date"] = str.Status_date;
				dr["Consultant_full_name"] = str.Consultant_full_name;
				dr["Coordinator_full_name"] = str.Coordinator_full_name;
				dr["Text"] = str.Text;
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
