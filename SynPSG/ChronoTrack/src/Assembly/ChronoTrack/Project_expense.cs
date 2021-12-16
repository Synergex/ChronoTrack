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
	[XFAttr(size=215)]
	[Serializable]
	public class Project_expense : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[16];
		static Project_expense()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.ALPHA,22);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,6);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,10);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.ALPHA,2);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.DECIMAL,11,2);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.DECIMAL,6,2);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[10]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[11]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[12]= new XFAttr(XFAttr.xftype.ALPHA,15);
			fieldAttributes[13]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[14]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.BOOLEAN,1);
			fieldAttributes[15]= new XFAttr(XFAttr.xftype.ALPHA,20);
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
		 
		private int f_Expense_id=0;
		 
		/// <summary>
		/// Expense # (sequence in project)
		/// </summary>
		public int Expense_id
		{
			get{ return f_Expense_id;}
			set { 
			    if(f_Expense_id != value) 
			       m_changed = true; 
			    f_Expense_id = value;
			} 
		}
		 
		private DateTime f_Expense_date=new DateTime();
		 
		/// <summary>
		/// Date of expense
		/// </summary>
		public DateTime Expense_date
		{
			get{ return f_Expense_date;}
			set { 
			    if(f_Expense_date != value) 
			       m_changed = true; 
			    f_Expense_date = value;
			} 
		}
		 
		private string f_Expense_type="";
		 
		/// <summary>
		/// Expense Type
		/// </summary>
		public string Expense_type
		{
			get{ return f_Expense_type;}
			set { 
			    if(!f_Expense_type.Equals(value)) 
			       m_changed = true; 
			    f_Expense_type = value;
			} 
		}
		 
		private string f_Description="";
		 
		/// <summary>
		/// Short description of expense
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
		 
		private string f_Currency_code="";
		 
		/// <summary>
		/// Currency Code
		/// </summary>
		public string Currency_code
		{
			get{ return f_Currency_code;}
			set { 
			    if(!f_Currency_code.Equals(value)) 
			       m_changed = true; 
			    f_Currency_code = value;
			} 
		}
		 
		private decimal f_Unit_price=0;
		 
		/// <summary>
		/// Price per each
		/// </summary>
		public decimal Unit_price
		{
			get{ return f_Unit_price;}
			set { 
			    if(f_Unit_price != value) 
			       m_changed = true; 
			    f_Unit_price = value;
			} 
		}
		 
		private decimal f_Quantity=0;
		 
		/// <summary>
		/// Quantity
		/// </summary>
		public decimal Quantity
		{
			get{ return f_Quantity;}
			set { 
			    if(f_Quantity != value) 
			       m_changed = true; 
			    f_Quantity = value;
			} 
		}
		 
		private string f_Expensed_by="";
		 
		/// <summary>
		/// User submitting expense
		/// </summary>
		public string Expensed_by
		{
			get{ return f_Expensed_by;}
			set { 
			    if(!f_Expensed_by.Equals(value)) 
			       m_changed = true; 
			    f_Expensed_by = value;
			} 
		}
		 
		private string f_Entered_by="";
		 
		/// <summary>
		/// Expense entered by
		/// </summary>
		public string Entered_by
		{
			get{ return f_Entered_by;}
		}
		 
		private DateTime f_Entered_date=new DateTime();
		 
		/// <summary>
		/// Date entered
		/// </summary>
		public DateTime Entered_date
		{
			get{ return f_Entered_date;}
		}
		 
		private string f_Modified_by="";
		 
		/// <summary>
		/// User who last modified entry
		/// </summary>
		public string Modified_by
		{
			get{ return f_Modified_by;}
		}
		 
		private DateTime f_Modified_date=new DateTime();
		 
		/// <summary>
		/// Last modification date
		/// </summary>
		public DateTime Modified_date
		{
			get{ return f_Modified_date;}
		}
		 
		private bool f_Is_estimate=new bool();
		 
		/// <summary>
		/// Expense is an estimate
		/// </summary>
		public bool Is_estimate
		{
			get{ return f_Is_estimate;}
			set { 
			    if(f_Is_estimate != value) 
			       m_changed = true; 
			    f_Is_estimate = value;
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
		public Project_expense Clone()
		{
			Project_expense tmp = new Project_expense();
			tmp.f_Synergygrfa = this.f_Synergygrfa;
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Expense_id = this.f_Expense_id;
			tmp.f_Expense_date = this.f_Expense_date;
			tmp.f_Expense_type = this.f_Expense_type;
			tmp.f_Description = this.f_Description;
			tmp.f_Currency_code = this.f_Currency_code;
			tmp.f_Unit_price = this.f_Unit_price;
			tmp.f_Quantity = this.f_Quantity;
			tmp.f_Expensed_by = this.f_Expensed_by;
			tmp.f_Entered_by = this.f_Entered_by;
			tmp.f_Entered_date = this.f_Entered_date;
			tmp.f_Modified_by = this.f_Modified_by;
			tmp.f_Modified_date = this.f_Modified_date;
			tmp.f_Is_estimate = this.f_Is_estimate;
			tmp.f_Replication_key = this.f_Replication_key;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project_expense str)
		{
			bool eq = true;
			if (!this.Synergygrfa.Equals(str.Synergygrfa))
			{
				eq = false;
				return eq;
			}
			if (this.Project_id != str.Project_id)
			{
				eq = false;
				return eq;
			}
			if (this.Expense_id != str.Expense_id)
			{
				eq = false;
				return eq;
			}
			if (this.Expense_date != str.Expense_date)
			{
				eq = false;
				return eq;
			}
			if (!this.Expense_type.Equals(str.Expense_type))
			{
				eq = false;
				return eq;
			}
			if (!this.Description.Equals(str.Description))
			{
				eq = false;
				return eq;
			}
			if (!this.Currency_code.Equals(str.Currency_code))
			{
				eq = false;
				return eq;
			}
			if (this.Unit_price != str.Unit_price)
			{
				eq = false;
				return eq;
			}
			if (this.Quantity != str.Quantity)
			{
				eq = false;
				return eq;
			}
			if (!this.Expensed_by.Equals(str.Expensed_by))
			{
				eq = false;
				return eq;
			}
			if (!this.Entered_by.Equals(str.Entered_by))
			{
				eq = false;
				return eq;
			}
			if (this.Entered_date != str.Entered_date)
			{
				eq = false;
				return eq;
			}
			if (!this.Modified_by.Equals(str.Modified_by))
			{
				eq = false;
				return eq;
			}
			if (this.Modified_date != str.Modified_date)
			{
				eq = false;
				return eq;
			}
			if (this.Is_estimate != str.Is_estimate)
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
		public Project_expense() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[16]215%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Synergygrfa,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Expense_id,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Expense_date,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Expense_type,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Currency_code,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Unit_price,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_Quantity,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_Expensed_by,fieldAttributes[9]));
			body.Append(XFProtocol.fieldToWire(f_Entered_by,fieldAttributes[10]));
			body.Append(XFProtocol.fieldToWire(f_Entered_date,fieldAttributes[11]));
			body.Append(XFProtocol.fieldToWire(f_Modified_by,fieldAttributes[12]));
			body.Append(XFProtocol.fieldToWire(f_Modified_date,fieldAttributes[13]));
			body.Append(XFProtocol.fieldToWire(f_Is_estimate,fieldAttributes[14]));
			body.Append(XFProtocol.fieldToWire(f_Replication_key,fieldAttributes[15]));
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
			f_Project_id = XFProtocol.wireToint(reply);
			f_Expense_id = XFProtocol.wireToint(reply);
			f_Expense_date = XFProtocol.wireToDateTime(reply,fieldAttributes[3]);
			f_Expense_type = XFProtocol.wireTostring(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Currency_code = XFProtocol.wireTostring(reply);
			f_Unit_price = XFProtocol.wireTodecimal(reply);
			f_Quantity = XFProtocol.wireTodecimal(reply);
			f_Expensed_by = XFProtocol.wireTostring(reply);
			f_Entered_by = XFProtocol.wireTostring(reply);
			f_Entered_date = XFProtocol.wireToDateTime(reply,fieldAttributes[11]);
			f_Modified_by = XFProtocol.wireTostring(reply);
			f_Modified_date = XFProtocol.wireToDateTime(reply,fieldAttributes[13]);
			f_Is_estimate = XFProtocol.wireTobool(reply);
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
		public static void GetRow(ref Project_expense str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Synergygrfa = (string)dr["Synergygrfa"];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Expense_id = (int)dr["Expense_id"];
			str.f_Expense_date = (DateTime)dr["Expense_date"];
			str.f_Expense_type = (string)dr["Expense_type"];
			str.f_Description = (string)dr["Description"];
			str.f_Currency_code = (string)dr["Currency_code"];
			str.f_Unit_price = (decimal)dr["Unit_price"];
			str.f_Quantity = (decimal)dr["Quantity"];
			str.f_Expensed_by = (string)dr["Expensed_by"];
			str.f_Entered_by = (string)dr["Entered_by"];
			str.f_Entered_date = (DateTime)dr["Entered_date"];
			str.f_Modified_by = (string)dr["Modified_by"];
			str.f_Modified_date = (DateTime)dr["Modified_date"];
			str.f_Is_estimate = (bool)dr["Is_estimate"];
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
			dtclm = new DataColumn("Project_id",typeof(int));
			dtclm.Caption = "Project #";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Expense_id",typeof(int));
			dtclm.Caption = "Expense #";
			dt.Columns.Add(dtclm);
			pkal.Add(dtclm);
			dtclm = new DataColumn("Expense_date",typeof(DateTime));
			dtclm.Caption = "Expense Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Expense_type",typeof(string));
			dtclm.Caption = "Expense Type";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Description",typeof(string));
			dtclm.Caption = "Description";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Currency_code",typeof(string));
			dtclm.Caption = "Currency";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Unit_price",typeof(decimal));
			dtclm.Caption = "Unit Price";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Quantity",typeof(decimal));
			dtclm.Caption = "Quantity";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Expensed_by",typeof(string));
			dtclm.Caption = "Expensed By";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Entered_by",typeof(string));
			dtclm.Caption = "Entered By";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Entered_date",typeof(DateTime));
			dtclm.Caption = "Entered";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Modified_by",typeof(string));
			dtclm.Caption = "Modified By";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Modified_date",typeof(DateTime));
			dtclm.Caption = "Modified";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Is_estimate",typeof(bool));
			dtclm.Caption = "Estimate";
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
				Project_expense str = (Project_expense)al[i];
				dr["Synergygrfa"] = str.Synergygrfa;
				dr["Project_id"] = str.Project_id;
				dr["Expense_id"] = str.Expense_id;
				dr["Expense_date"] = str.Expense_date;
				dr["Expense_type"] = str.Expense_type;
				dr["Description"] = str.Description;
				dr["Currency_code"] = str.Currency_code;
				dr["Unit_price"] = str.Unit_price;
				dr["Quantity"] = str.Quantity;
				dr["Expensed_by"] = str.Expensed_by;
				dr["Entered_by"] = str.Entered_by;
				dr["Entered_date"] = str.Entered_date;
				dr["Modified_by"] = str.Modified_by;
				dr["Modified_date"] = str.Modified_date;
				dr["Is_estimate"] = str.Is_estimate;
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
