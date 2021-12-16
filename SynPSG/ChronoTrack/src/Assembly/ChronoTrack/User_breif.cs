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
	[XFAttr(size=332)]
	[Serializable]
	public class User_breif : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[5];
		static User_breif()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,255);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.INTEGER,XFAttr.xftype.INT,1);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.BOOLEAN,1);
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
		 
		private string f_Full_name="";
		 
		/// <summary>
		/// *** Field To Do ***
		/// </summary>
		public string Full_name
		{
			get{ return f_Full_name;}
			set { 
			    if(!f_Full_name.Equals(value)) 
			       m_changed = true; 
			    f_Full_name = value;
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
		 
		private int f_Visible=0;
		 
		/// <summary>
		/// display user in project view
		/// </summary>
		public int Visible
		{
			get{ return f_Visible;}
			set { 
			    if(f_Visible != value) 
			       m_changed = true; 
			    f_Visible = value;
			} 
		}
		 
		private bool f_Is_consultant=new bool();
		 
		/// <summary>
		/// Boolean
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
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public User_breif Clone()
		{
			User_breif tmp = new User_breif();
			tmp.f_User_id = this.f_User_id;
			tmp.f_Full_name = this.f_Full_name;
			tmp.f_Picture_file = this.f_Picture_file;
			tmp.f_Visible = this.f_Visible;
			tmp.f_Is_consultant = this.f_Is_consultant;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(User_breif str)
		{
			bool eq = true;
			if (!this.User_id.Equals(str.User_id))
			{
				eq = false;
				return eq;
			}
			if (!this.Full_name.Equals(str.Full_name))
			{
				eq = false;
				return eq;
			}
			if (!this.Picture_file.Equals(str.Picture_file))
			{
				eq = false;
				return eq;
			}
			if (this.Visible != str.Visible)
			{
				eq = false;
				return eq;
			}
			if (this.Is_consultant != str.Is_consultant)
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public User_breif() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[5]332%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_User_id,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Full_name,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Picture_file,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Visible,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Is_consultant,fieldAttributes[4]));
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
			f_Full_name = XFProtocol.wireTostring(reply);
			f_Picture_file = XFProtocol.wireTostring(reply);
			f_Visible = XFProtocol.wireToint(reply);
			f_Is_consultant = XFProtocol.wireTobool(reply);
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
		public static void GetRow(ref User_breif str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_User_id = (string)dr["User_id"];
			str.f_Full_name = (string)dr["Full_name"];
			str.f_Picture_file = (string)dr["Picture_file"];
			str.f_Visible = (int)dr["Visible"];
			str.f_Is_consultant = (bool)dr["Is_consultant"];
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
			dtclm = new DataColumn("Full_name",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Picture_file",typeof(string));
			dtclm.Caption = "Picture File";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Visible",typeof(int));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Is_consultant",typeof(bool));
			dtclm.Caption = "Boolean";
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
				User_breif str = (User_breif)al[i];
				dr["User_id"] = str.User_id;
				dr["Full_name"] = str.Full_name;
				dr["Picture_file"] = str.Picture_file;
				dr["Visible"] = str.Visible;
				dr["Is_consultant"] = str.Is_consultant;
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
