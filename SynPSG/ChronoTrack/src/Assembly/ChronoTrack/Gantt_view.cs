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
	[XFAttr(size=134)]
	[Serializable]
	public class Gantt_view : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[39];
		static Gantt_view()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,2);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,1);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,1);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[10]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[11]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[12]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[13]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[14]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[15]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[16]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[17]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[18]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[19]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[20]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[21]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[22]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[23]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[24]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[25]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[26]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[27]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[28]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[29]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[30]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[31]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[32]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[33]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[34]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[35]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[36]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[37]= new XFAttr(XFAttr.xftype.ALPHA,1);
			fieldAttributes[38]= new XFAttr(XFAttr.xftype.ALPHA,1);
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
		 
		private int f_Project_type=0;
		 
		/// <summary>
		/// Type of project/request
		/// </summary>
		public int Project_type
		{
			get{ return f_Project_type;}
			set { 
			    if(f_Project_type != value) 
			       m_changed = true; 
			    f_Project_type = value;
			} 
		}
		 
		private string f_Description="";
		 
		/// <summary>
		/// Short description
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
		/// Date
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
		/// Date
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
		 
		private int f_Outbound_travel_days=0;
		 
		/// <summary>
		/// Outbound travel days
		/// </summary>
		public int Outbound_travel_days
		{
			get{ return f_Outbound_travel_days;}
			set { 
			    if(f_Outbound_travel_days != value) 
			       m_changed = true; 
			    f_Outbound_travel_days = value;
			} 
		}
		 
		private int f_Inbound_travel_days=0;
		 
		/// <summary>
		/// Inbound travel days
		/// </summary>
		public int Inbound_travel_days
		{
			get{ return f_Inbound_travel_days;}
			set { 
			    if(f_Inbound_travel_days != value) 
			       m_changed = true; 
			    f_Inbound_travel_days = value;
			} 
		}
		 
		private string f_Day1="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day1
		{
			get{ return f_Day1;}
			set { 
			    if(!f_Day1.Equals(value)) 
			       m_changed = true; 
			    f_Day1 = value;
			} 
		}
		 
		private string f_Day2="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day2
		{
			get{ return f_Day2;}
			set { 
			    if(!f_Day2.Equals(value)) 
			       m_changed = true; 
			    f_Day2 = value;
			} 
		}
		 
		private string f_Day3="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day3
		{
			get{ return f_Day3;}
			set { 
			    if(!f_Day3.Equals(value)) 
			       m_changed = true; 
			    f_Day3 = value;
			} 
		}
		 
		private string f_Day4="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day4
		{
			get{ return f_Day4;}
			set { 
			    if(!f_Day4.Equals(value)) 
			       m_changed = true; 
			    f_Day4 = value;
			} 
		}
		 
		private string f_Day5="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day5
		{
			get{ return f_Day5;}
			set { 
			    if(!f_Day5.Equals(value)) 
			       m_changed = true; 
			    f_Day5 = value;
			} 
		}
		 
		private string f_Day6="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day6
		{
			get{ return f_Day6;}
			set { 
			    if(!f_Day6.Equals(value)) 
			       m_changed = true; 
			    f_Day6 = value;
			} 
		}
		 
		private string f_Day7="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day7
		{
			get{ return f_Day7;}
			set { 
			    if(!f_Day7.Equals(value)) 
			       m_changed = true; 
			    f_Day7 = value;
			} 
		}
		 
		private string f_Day8="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day8
		{
			get{ return f_Day8;}
			set { 
			    if(!f_Day8.Equals(value)) 
			       m_changed = true; 
			    f_Day8 = value;
			} 
		}
		 
		private string f_Day9="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day9
		{
			get{ return f_Day9;}
			set { 
			    if(!f_Day9.Equals(value)) 
			       m_changed = true; 
			    f_Day9 = value;
			} 
		}
		 
		private string f_Day10="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day10
		{
			get{ return f_Day10;}
			set { 
			    if(!f_Day10.Equals(value)) 
			       m_changed = true; 
			    f_Day10 = value;
			} 
		}
		 
		private string f_Day11="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day11
		{
			get{ return f_Day11;}
			set { 
			    if(!f_Day11.Equals(value)) 
			       m_changed = true; 
			    f_Day11 = value;
			} 
		}
		 
		private string f_Day12="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day12
		{
			get{ return f_Day12;}
			set { 
			    if(!f_Day12.Equals(value)) 
			       m_changed = true; 
			    f_Day12 = value;
			} 
		}
		 
		private string f_Day13="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day13
		{
			get{ return f_Day13;}
			set { 
			    if(!f_Day13.Equals(value)) 
			       m_changed = true; 
			    f_Day13 = value;
			} 
		}
		 
		private string f_Day14="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day14
		{
			get{ return f_Day14;}
			set { 
			    if(!f_Day14.Equals(value)) 
			       m_changed = true; 
			    f_Day14 = value;
			} 
		}
		 
		private string f_Day15="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day15
		{
			get{ return f_Day15;}
			set { 
			    if(!f_Day15.Equals(value)) 
			       m_changed = true; 
			    f_Day15 = value;
			} 
		}
		 
		private string f_Day16="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day16
		{
			get{ return f_Day16;}
			set { 
			    if(!f_Day16.Equals(value)) 
			       m_changed = true; 
			    f_Day16 = value;
			} 
		}
		 
		private string f_Day17="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day17
		{
			get{ return f_Day17;}
			set { 
			    if(!f_Day17.Equals(value)) 
			       m_changed = true; 
			    f_Day17 = value;
			} 
		}
		 
		private string f_Day18="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day18
		{
			get{ return f_Day18;}
			set { 
			    if(!f_Day18.Equals(value)) 
			       m_changed = true; 
			    f_Day18 = value;
			} 
		}
		 
		private string f_Day19="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day19
		{
			get{ return f_Day19;}
			set { 
			    if(!f_Day19.Equals(value)) 
			       m_changed = true; 
			    f_Day19 = value;
			} 
		}
		 
		private string f_Day20="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day20
		{
			get{ return f_Day20;}
			set { 
			    if(!f_Day20.Equals(value)) 
			       m_changed = true; 
			    f_Day20 = value;
			} 
		}
		 
		private string f_Day21="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day21
		{
			get{ return f_Day21;}
			set { 
			    if(!f_Day21.Equals(value)) 
			       m_changed = true; 
			    f_Day21 = value;
			} 
		}
		 
		private string f_Day22="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day22
		{
			get{ return f_Day22;}
			set { 
			    if(!f_Day22.Equals(value)) 
			       m_changed = true; 
			    f_Day22 = value;
			} 
		}
		 
		private string f_Day23="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day23
		{
			get{ return f_Day23;}
			set { 
			    if(!f_Day23.Equals(value)) 
			       m_changed = true; 
			    f_Day23 = value;
			} 
		}
		 
		private string f_Day24="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day24
		{
			get{ return f_Day24;}
			set { 
			    if(!f_Day24.Equals(value)) 
			       m_changed = true; 
			    f_Day24 = value;
			} 
		}
		 
		private string f_Day25="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day25
		{
			get{ return f_Day25;}
			set { 
			    if(!f_Day25.Equals(value)) 
			       m_changed = true; 
			    f_Day25 = value;
			} 
		}
		 
		private string f_Day26="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day26
		{
			get{ return f_Day26;}
			set { 
			    if(!f_Day26.Equals(value)) 
			       m_changed = true; 
			    f_Day26 = value;
			} 
		}
		 
		private string f_Day27="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day27
		{
			get{ return f_Day27;}
			set { 
			    if(!f_Day27.Equals(value)) 
			       m_changed = true; 
			    f_Day27 = value;
			} 
		}
		 
		private string f_Day28="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day28
		{
			get{ return f_Day28;}
			set { 
			    if(!f_Day28.Equals(value)) 
			       m_changed = true; 
			    f_Day28 = value;
			} 
		}
		 
		private string f_Day29="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day29
		{
			get{ return f_Day29;}
			set { 
			    if(!f_Day29.Equals(value)) 
			       m_changed = true; 
			    f_Day29 = value;
			} 
		}
		 
		private string f_Day30="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day30
		{
			get{ return f_Day30;}
			set { 
			    if(!f_Day30.Equals(value)) 
			       m_changed = true; 
			    f_Day30 = value;
			} 
		}
		 
		private string f_Day31="";
		 
		/// <summary>
		/// Day column type for gantt chart
		/// </summary>
		public string Day31
		{
			get{ return f_Day31;}
			set { 
			    if(!f_Day31.Equals(value)) 
			       m_changed = true; 
			    f_Day31 = value;
			} 
		}
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public Gantt_view Clone()
		{
			Gantt_view tmp = new Gantt_view();
			tmp.f_User_id = this.f_User_id;
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Project_type = this.f_Project_type;
			tmp.f_Description = this.f_Description;
			tmp.f_Start_date = this.f_Start_date;
			tmp.f_End_date = this.f_End_date;
			tmp.f_Outbound_travel_days = this.f_Outbound_travel_days;
			tmp.f_Inbound_travel_days = this.f_Inbound_travel_days;
			tmp.f_Day1 = this.f_Day1;
			tmp.f_Day2 = this.f_Day2;
			tmp.f_Day3 = this.f_Day3;
			tmp.f_Day4 = this.f_Day4;
			tmp.f_Day5 = this.f_Day5;
			tmp.f_Day6 = this.f_Day6;
			tmp.f_Day7 = this.f_Day7;
			tmp.f_Day8 = this.f_Day8;
			tmp.f_Day9 = this.f_Day9;
			tmp.f_Day10 = this.f_Day10;
			tmp.f_Day11 = this.f_Day11;
			tmp.f_Day12 = this.f_Day12;
			tmp.f_Day13 = this.f_Day13;
			tmp.f_Day14 = this.f_Day14;
			tmp.f_Day15 = this.f_Day15;
			tmp.f_Day16 = this.f_Day16;
			tmp.f_Day17 = this.f_Day17;
			tmp.f_Day18 = this.f_Day18;
			tmp.f_Day19 = this.f_Day19;
			tmp.f_Day20 = this.f_Day20;
			tmp.f_Day21 = this.f_Day21;
			tmp.f_Day22 = this.f_Day22;
			tmp.f_Day23 = this.f_Day23;
			tmp.f_Day24 = this.f_Day24;
			tmp.f_Day25 = this.f_Day25;
			tmp.f_Day26 = this.f_Day26;
			tmp.f_Day27 = this.f_Day27;
			tmp.f_Day28 = this.f_Day28;
			tmp.f_Day29 = this.f_Day29;
			tmp.f_Day30 = this.f_Day30;
			tmp.f_Day31 = this.f_Day31;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Gantt_view str)
		{
			bool eq = true;
			if (!this.User_id.Equals(str.User_id))
			{
				eq = false;
				return eq;
			}
			if (this.Project_id != str.Project_id)
			{
				eq = false;
				return eq;
			}
			if (this.Project_type != str.Project_type)
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
			if (this.Outbound_travel_days != str.Outbound_travel_days)
			{
				eq = false;
				return eq;
			}
			if (this.Inbound_travel_days != str.Inbound_travel_days)
			{
				eq = false;
				return eq;
			}
			if (!this.Day1.Equals(str.Day1))
			{
				eq = false;
				return eq;
			}
			if (!this.Day2.Equals(str.Day2))
			{
				eq = false;
				return eq;
			}
			if (!this.Day3.Equals(str.Day3))
			{
				eq = false;
				return eq;
			}
			if (!this.Day4.Equals(str.Day4))
			{
				eq = false;
				return eq;
			}
			if (!this.Day5.Equals(str.Day5))
			{
				eq = false;
				return eq;
			}
			if (!this.Day6.Equals(str.Day6))
			{
				eq = false;
				return eq;
			}
			if (!this.Day7.Equals(str.Day7))
			{
				eq = false;
				return eq;
			}
			if (!this.Day8.Equals(str.Day8))
			{
				eq = false;
				return eq;
			}
			if (!this.Day9.Equals(str.Day9))
			{
				eq = false;
				return eq;
			}
			if (!this.Day10.Equals(str.Day10))
			{
				eq = false;
				return eq;
			}
			if (!this.Day11.Equals(str.Day11))
			{
				eq = false;
				return eq;
			}
			if (!this.Day12.Equals(str.Day12))
			{
				eq = false;
				return eq;
			}
			if (!this.Day13.Equals(str.Day13))
			{
				eq = false;
				return eq;
			}
			if (!this.Day14.Equals(str.Day14))
			{
				eq = false;
				return eq;
			}
			if (!this.Day15.Equals(str.Day15))
			{
				eq = false;
				return eq;
			}
			if (!this.Day16.Equals(str.Day16))
			{
				eq = false;
				return eq;
			}
			if (!this.Day17.Equals(str.Day17))
			{
				eq = false;
				return eq;
			}
			if (!this.Day18.Equals(str.Day18))
			{
				eq = false;
				return eq;
			}
			if (!this.Day19.Equals(str.Day19))
			{
				eq = false;
				return eq;
			}
			if (!this.Day20.Equals(str.Day20))
			{
				eq = false;
				return eq;
			}
			if (!this.Day21.Equals(str.Day21))
			{
				eq = false;
				return eq;
			}
			if (!this.Day22.Equals(str.Day22))
			{
				eq = false;
				return eq;
			}
			if (!this.Day23.Equals(str.Day23))
			{
				eq = false;
				return eq;
			}
			if (!this.Day24.Equals(str.Day24))
			{
				eq = false;
				return eq;
			}
			if (!this.Day25.Equals(str.Day25))
			{
				eq = false;
				return eq;
			}
			if (!this.Day26.Equals(str.Day26))
			{
				eq = false;
				return eq;
			}
			if (!this.Day27.Equals(str.Day27))
			{
				eq = false;
				return eq;
			}
			if (!this.Day28.Equals(str.Day28))
			{
				eq = false;
				return eq;
			}
			if (!this.Day29.Equals(str.Day29))
			{
				eq = false;
				return eq;
			}
			if (!this.Day30.Equals(str.Day30))
			{
				eq = false;
				return eq;
			}
			if (!this.Day31.Equals(str.Day31))
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public Gantt_view() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[39]134%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_User_id,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Project_type,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Start_date,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_End_date,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Outbound_travel_days,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Inbound_travel_days,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_Day1,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_Day2,fieldAttributes[9]));
			body.Append(XFProtocol.fieldToWire(f_Day3,fieldAttributes[10]));
			body.Append(XFProtocol.fieldToWire(f_Day4,fieldAttributes[11]));
			body.Append(XFProtocol.fieldToWire(f_Day5,fieldAttributes[12]));
			body.Append(XFProtocol.fieldToWire(f_Day6,fieldAttributes[13]));
			body.Append(XFProtocol.fieldToWire(f_Day7,fieldAttributes[14]));
			body.Append(XFProtocol.fieldToWire(f_Day8,fieldAttributes[15]));
			body.Append(XFProtocol.fieldToWire(f_Day9,fieldAttributes[16]));
			body.Append(XFProtocol.fieldToWire(f_Day10,fieldAttributes[17]));
			body.Append(XFProtocol.fieldToWire(f_Day11,fieldAttributes[18]));
			body.Append(XFProtocol.fieldToWire(f_Day12,fieldAttributes[19]));
			body.Append(XFProtocol.fieldToWire(f_Day13,fieldAttributes[20]));
			body.Append(XFProtocol.fieldToWire(f_Day14,fieldAttributes[21]));
			body.Append(XFProtocol.fieldToWire(f_Day15,fieldAttributes[22]));
			body.Append(XFProtocol.fieldToWire(f_Day16,fieldAttributes[23]));
			body.Append(XFProtocol.fieldToWire(f_Day17,fieldAttributes[24]));
			body.Append(XFProtocol.fieldToWire(f_Day18,fieldAttributes[25]));
			body.Append(XFProtocol.fieldToWire(f_Day19,fieldAttributes[26]));
			body.Append(XFProtocol.fieldToWire(f_Day20,fieldAttributes[27]));
			body.Append(XFProtocol.fieldToWire(f_Day21,fieldAttributes[28]));
			body.Append(XFProtocol.fieldToWire(f_Day22,fieldAttributes[29]));
			body.Append(XFProtocol.fieldToWire(f_Day23,fieldAttributes[30]));
			body.Append(XFProtocol.fieldToWire(f_Day24,fieldAttributes[31]));
			body.Append(XFProtocol.fieldToWire(f_Day25,fieldAttributes[32]));
			body.Append(XFProtocol.fieldToWire(f_Day26,fieldAttributes[33]));
			body.Append(XFProtocol.fieldToWire(f_Day27,fieldAttributes[34]));
			body.Append(XFProtocol.fieldToWire(f_Day28,fieldAttributes[35]));
			body.Append(XFProtocol.fieldToWire(f_Day29,fieldAttributes[36]));
			body.Append(XFProtocol.fieldToWire(f_Day30,fieldAttributes[37]));
			body.Append(XFProtocol.fieldToWire(f_Day31,fieldAttributes[38]));
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
			f_Project_id = XFProtocol.wireToint(reply);
			f_Project_type = XFProtocol.wireToint(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Start_date = XFProtocol.wireToDateTime(reply,fieldAttributes[4]);
			f_End_date = XFProtocol.wireToDateTime(reply,fieldAttributes[5]);
			f_Outbound_travel_days = XFProtocol.wireToint(reply);
			f_Inbound_travel_days = XFProtocol.wireToint(reply);
			f_Day1 = XFProtocol.wireTostring(reply);
			f_Day2 = XFProtocol.wireTostring(reply);
			f_Day3 = XFProtocol.wireTostring(reply);
			f_Day4 = XFProtocol.wireTostring(reply);
			f_Day5 = XFProtocol.wireTostring(reply);
			f_Day6 = XFProtocol.wireTostring(reply);
			f_Day7 = XFProtocol.wireTostring(reply);
			f_Day8 = XFProtocol.wireTostring(reply);
			f_Day9 = XFProtocol.wireTostring(reply);
			f_Day10 = XFProtocol.wireTostring(reply);
			f_Day11 = XFProtocol.wireTostring(reply);
			f_Day12 = XFProtocol.wireTostring(reply);
			f_Day13 = XFProtocol.wireTostring(reply);
			f_Day14 = XFProtocol.wireTostring(reply);
			f_Day15 = XFProtocol.wireTostring(reply);
			f_Day16 = XFProtocol.wireTostring(reply);
			f_Day17 = XFProtocol.wireTostring(reply);
			f_Day18 = XFProtocol.wireTostring(reply);
			f_Day19 = XFProtocol.wireTostring(reply);
			f_Day20 = XFProtocol.wireTostring(reply);
			f_Day21 = XFProtocol.wireTostring(reply);
			f_Day22 = XFProtocol.wireTostring(reply);
			f_Day23 = XFProtocol.wireTostring(reply);
			f_Day24 = XFProtocol.wireTostring(reply);
			f_Day25 = XFProtocol.wireTostring(reply);
			f_Day26 = XFProtocol.wireTostring(reply);
			f_Day27 = XFProtocol.wireTostring(reply);
			f_Day28 = XFProtocol.wireTostring(reply);
			f_Day29 = XFProtocol.wireTostring(reply);
			f_Day30 = XFProtocol.wireTostring(reply);
			f_Day31 = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Gantt_view str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_User_id = (string)dr["User_id"];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Project_type = (int)dr["Project_type"];
			str.f_Description = (string)dr["Description"];
			str.f_Start_date = (DateTime)dr["Start_date"];
			str.f_End_date = (DateTime)dr["End_date"];
			str.f_Outbound_travel_days = (int)dr["Outbound_travel_days"];
			str.f_Inbound_travel_days = (int)dr["Inbound_travel_days"];
			str.f_Day1 = (string)dr["Day1"];
			str.f_Day2 = (string)dr["Day2"];
			str.f_Day3 = (string)dr["Day3"];
			str.f_Day4 = (string)dr["Day4"];
			str.f_Day5 = (string)dr["Day5"];
			str.f_Day6 = (string)dr["Day6"];
			str.f_Day7 = (string)dr["Day7"];
			str.f_Day8 = (string)dr["Day8"];
			str.f_Day9 = (string)dr["Day9"];
			str.f_Day10 = (string)dr["Day10"];
			str.f_Day11 = (string)dr["Day11"];
			str.f_Day12 = (string)dr["Day12"];
			str.f_Day13 = (string)dr["Day13"];
			str.f_Day14 = (string)dr["Day14"];
			str.f_Day15 = (string)dr["Day15"];
			str.f_Day16 = (string)dr["Day16"];
			str.f_Day17 = (string)dr["Day17"];
			str.f_Day18 = (string)dr["Day18"];
			str.f_Day19 = (string)dr["Day19"];
			str.f_Day20 = (string)dr["Day20"];
			str.f_Day21 = (string)dr["Day21"];
			str.f_Day22 = (string)dr["Day22"];
			str.f_Day23 = (string)dr["Day23"];
			str.f_Day24 = (string)dr["Day24"];
			str.f_Day25 = (string)dr["Day25"];
			str.f_Day26 = (string)dr["Day26"];
			str.f_Day27 = (string)dr["Day27"];
			str.f_Day28 = (string)dr["Day28"];
			str.f_Day29 = (string)dr["Day29"];
			str.f_Day30 = (string)dr["Day30"];
			str.f_Day31 = (string)dr["Day31"];
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
			dtclm = new DataColumn("Project_id",typeof(int));
			dtclm.Caption = "Project #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Project_type",typeof(int));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Description",typeof(string));
			dtclm.Caption = "Description";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Start_date",typeof(DateTime));
			dtclm.Caption = "Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("End_date",typeof(DateTime));
			dtclm.Caption = "Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Outbound_travel_days",typeof(int));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Inbound_travel_days",typeof(int));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day1",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day2",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day3",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day4",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day5",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day6",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day7",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day8",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day9",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day10",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day11",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day12",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day13",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day14",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day15",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day16",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day17",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day18",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day19",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day20",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day21",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day22",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day23",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day24",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day25",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day26",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day27",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day28",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day29",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day30",typeof(string));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Day31",typeof(string));
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
				Gantt_view str = (Gantt_view)al[i];
				dr["User_id"] = str.User_id;
				dr["Project_id"] = str.Project_id;
				dr["Project_type"] = str.Project_type;
				dr["Description"] = str.Description;
				dr["Start_date"] = str.Start_date;
				dr["End_date"] = str.End_date;
				dr["Outbound_travel_days"] = str.Outbound_travel_days;
				dr["Inbound_travel_days"] = str.Inbound_travel_days;
				dr["Day1"] = str.Day1;
				dr["Day2"] = str.Day2;
				dr["Day3"] = str.Day3;
				dr["Day4"] = str.Day4;
				dr["Day5"] = str.Day5;
				dr["Day6"] = str.Day6;
				dr["Day7"] = str.Day7;
				dr["Day8"] = str.Day8;
				dr["Day9"] = str.Day9;
				dr["Day10"] = str.Day10;
				dr["Day11"] = str.Day11;
				dr["Day12"] = str.Day12;
				dr["Day13"] = str.Day13;
				dr["Day14"] = str.Day14;
				dr["Day15"] = str.Day15;
				dr["Day16"] = str.Day16;
				dr["Day17"] = str.Day17;
				dr["Day18"] = str.Day18;
				dr["Day19"] = str.Day19;
				dr["Day20"] = str.Day20;
				dr["Day21"] = str.Day21;
				dr["Day22"] = str.Day22;
				dr["Day23"] = str.Day23;
				dr["Day24"] = str.Day24;
				dr["Day25"] = str.Day25;
				dr["Day26"] = str.Day26;
				dr["Day27"] = str.Day27;
				dr["Day28"] = str.Day28;
				dr["Day29"] = str.Day29;
				dr["Day30"] = str.Day30;
				dr["Day31"] = str.Day31;
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
