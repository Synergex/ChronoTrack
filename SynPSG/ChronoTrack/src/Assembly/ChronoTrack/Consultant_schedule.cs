// Generated on 09-Sep-2009 2:27:52 by gencs v1.0.11.0
using System;
using System.Text;
using Synergex.xfnlnet;
namespace ChronoTrack
{
/// <summary>
/// Structural Interface Class ChronoTrack
/// </summary>
	[XFAttr(size=868)]
	[Serializable]
	public class Consultant_schedule : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[11];
		static Consultant_schedule()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,6);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.TIME,XFAttr.xftype.DATETIME,XFAttr.xfformat.HHMM,4);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.TIME,XFAttr.xftype.DATETIME,XFAttr.xfformat.HHMM,4);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.ALPHA,700);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,1);
			fieldAttributes[10]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
		}
		private int f_Id=0;
		 
		/// <summary>
		/// Unique ID for schedule entry
		/// </summary>
		public int Id
		{
			get{ return f_Id;}
			set { 
			    if(f_Id != value) 
			       m_changed = true; 
			    f_Id = value;
			} 
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
		 
		private DateTime f_Start_date=new DateTime();
		 
		/// <summary>
		/// Appointment start date
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
		 
		private DateTime f_Start_time=new DateTime();
		 
		/// <summary>
		/// Appointment start time
		/// </summary>
		public DateTime Start_time
		{
			get{ return f_Start_time;}
			set { 
			    if(f_Start_time != value) 
			       m_changed = true; 
			    f_Start_time = value;
			} 
		}
		 
		private DateTime f_End_date=new DateTime();
		 
		/// <summary>
		/// Appointment end date
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
		 
		private DateTime f_End_time=new DateTime();
		 
		/// <summary>
		/// Appointment end time
		/// </summary>
		public DateTime End_time
		{
			get{ return f_End_time;}
			set { 
			    if(f_End_time != value) 
			       m_changed = true; 
			    f_End_time = value;
			} 
		}
		 
		private string f_Subject="";
		 
		/// <summary>
		/// Short description
		/// </summary>
		public string Subject
		{
			get{ return f_Subject;}
			set { 
			    if(!f_Subject.Equals(value)) 
			       m_changed = true; 
			    f_Subject = value;
			} 
		}
		 
		private string f_Description="";
		 
		/// <summary>
		/// Long description
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
		 
		private string f_Location="";
		 
		/// <summary>
		/// Location name
		/// </summary>
		public string Location
		{
			get{ return f_Location;}
			set { 
			    if(!f_Location.Equals(value)) 
			       m_changed = true; 
			    f_Location = value;
			} 
		}
		 
		private int f_Status=0;
		 
		/// <summary>
		/// Time slot status
		/// </summary>
		public int Status
		{
			get{ return f_Status;}
			set { 
			    if(f_Status != value) 
			       m_changed = true; 
			    f_Status = value;
			} 
		}
		 
		private int f_Appointment_type=0;
		 
		/// <summary>
		/// Appointment type (business etc.)
		/// </summary>
		public int Appointment_type
		{
			get{ return f_Appointment_type;}
			set { 
			    if(f_Appointment_type != value) 
			       m_changed = true; 
			    f_Appointment_type = value;
			} 
		}
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public Consultant_schedule Clone()
		{
			Consultant_schedule tmp = new Consultant_schedule();
			tmp.f_Id = this.f_Id;
			tmp.f_Consultant_id = this.f_Consultant_id;
			tmp.f_Start_date = this.f_Start_date;
			tmp.f_Start_time = this.f_Start_time;
			tmp.f_End_date = this.f_End_date;
			tmp.f_End_time = this.f_End_time;
			tmp.f_Subject = this.f_Subject;
			tmp.f_Description = this.f_Description;
			tmp.f_Location = this.f_Location;
			tmp.f_Status = this.f_Status;
			tmp.f_Appointment_type = this.f_Appointment_type;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Consultant_schedule str)
		{
			bool eq = true;
			if (this.Id != str.Id)
			{
				eq = false;
				return eq;
			}
			if (!this.Consultant_id.Equals(str.Consultant_id))
			{
				eq = false;
				return eq;
			}
			if (this.Start_date != str.Start_date)
			{
				eq = false;
				return eq;
			}
			if (this.Start_time != str.Start_time)
			{
				eq = false;
				return eq;
			}
			if (this.End_date != str.End_date)
			{
				eq = false;
				return eq;
			}
			if (this.End_time != str.End_time)
			{
				eq = false;
				return eq;
			}
			if (!this.Subject.Equals(str.Subject))
			{
				eq = false;
				return eq;
			}
			if (!this.Description.Equals(str.Description))
			{
				eq = false;
				return eq;
			}
			if (!this.Location.Equals(str.Location))
			{
				eq = false;
				return eq;
			}
			if (this.Status != str.Status)
			{
				eq = false;
				return eq;
			}
			if (this.Appointment_type != str.Appointment_type)
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public Consultant_schedule() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[11]868%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Id,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Consultant_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Start_date,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Start_time,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_End_date,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_End_time,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Subject,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_Location,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_Status,fieldAttributes[9]));
			body.Append(XFProtocol.fieldToWire(f_Appointment_type,fieldAttributes[10]));
			body.Append("^");
			sb.Append(body.Length+"#"+body.ToString()+";");
			return sb.ToString();
		}
 
		/// <summary>
		/// deserialize structure
		/// </summary>
		public void wireToStruct(SynMessage reply)
		{
			f_Id = XFProtocol.wireToint(reply);
			f_Consultant_id = XFProtocol.wireTostring(reply);
			f_Start_date = XFProtocol.wireToDateTime(reply,fieldAttributes[2]);
			f_Start_time = XFProtocol.wireToDateTime(reply,fieldAttributes[3]);
			f_End_date = XFProtocol.wireToDateTime(reply,fieldAttributes[4]);
			f_End_time = XFProtocol.wireToDateTime(reply,fieldAttributes[5]);
			f_Subject = XFProtocol.wireTostring(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Location = XFProtocol.wireTostring(reply);
			f_Status = XFProtocol.wireToint(reply);
			f_Appointment_type = XFProtocol.wireToint(reply);
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
