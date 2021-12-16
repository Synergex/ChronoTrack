// Generated on 18-May-2009 1:37:26 by gencs v1.0.11.0
using System;
using System.Text;
using Synergex.xfnlnet;
namespace ChronoTrack
{
/// <summary>
/// Structural Interface Class ChronoTrack
/// </summary>
	[XFAttr(size=51)]
	[Serializable]
	public class Project_filter : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[6];
		static Project_filter()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,15);
		}
		private DateTime f_Lower_date=new DateTime();
		 
		/// <summary>
		/// Lower date filter
		/// </summary>
		public DateTime Lower_date
		{
			get{ return f_Lower_date;}
			set { 
			    if(f_Lower_date != value) 
			       m_changed = true; 
			    f_Lower_date = value;
			} 
		}
		 
		private DateTime f_Upper_date=new DateTime();
		 
		/// <summary>
		/// Upper date filter
		/// </summary>
		public DateTime Upper_date
		{
			get{ return f_Upper_date;}
			set { 
			    if(f_Upper_date != value) 
			       m_changed = true; 
			    f_Upper_date = value;
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
		 
		private int f_Project_status=0;
		 
		/// <summary>
		/// Project Status
		/// </summary>
		public int Project_status
		{
			get{ return f_Project_status;}
			set { 
			    if(f_Project_status != value) 
			       m_changed = true; 
			    f_Project_status = value;
			} 
		}
		 
		private string f_Consultant_id="";
		 
		/// <summary>
		/// Consultant ID
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
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public Project_filter Clone()
		{
			Project_filter tmp = new Project_filter();
			tmp.f_Lower_date = this.f_Lower_date;
			tmp.f_Upper_date = this.f_Upper_date;
			tmp.f_Customer_id = this.f_Customer_id;
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Project_status = this.f_Project_status;
			tmp.f_Consultant_id = this.f_Consultant_id;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project_filter str)
		{
			bool eq = true;
			if (this.Lower_date != str.Lower_date)
			{
				eq = false;
				return eq;
			}
			if (this.Upper_date != str.Upper_date)
			{
				eq = false;
				return eq;
			}
			if (!this.Customer_id.Equals(str.Customer_id))
			{
				eq = false;
				return eq;
			}
			if (this.Project_id != str.Project_id)
			{
				eq = false;
				return eq;
			}
			if (this.Project_status != str.Project_status)
			{
				eq = false;
				return eq;
			}
			if (!this.Consultant_id.Equals(str.Consultant_id))
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public Project_filter() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[6]51%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Lower_date,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Upper_date,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Customer_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Project_status,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Consultant_id,fieldAttributes[5]));
			body.Append("^");
			sb.Append(body.Length+"#"+body.ToString()+";");
			return sb.ToString();
		}
 
		/// <summary>
		/// deserialize structure
		/// </summary>
		public void wireToStruct(SynMessage reply)
		{
			f_Lower_date = XFProtocol.wireToDateTime(reply,fieldAttributes[0]);
			f_Upper_date = XFProtocol.wireToDateTime(reply,fieldAttributes[1]);
			f_Customer_id = XFProtocol.wireTostring(reply);
			f_Project_id = XFProtocol.wireToint(reply);
			f_Project_status = XFProtocol.wireToint(reply);
			f_Consultant_id = XFProtocol.wireTostring(reply);
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
 
	}
}
