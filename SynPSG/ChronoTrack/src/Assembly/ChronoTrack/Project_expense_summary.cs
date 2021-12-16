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
	[XFAttr(size=180)]
	[Serializable]
	public class Project_expense_summary : IStructWire
	{
		/// <summary>
		/// Attributes for fields
		/// </summary>
		public readonly static XFAttr[] fieldAttributes = new XFAttr[10];
		static Project_expense_summary()
		{
			fieldAttributes[0]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,8);
			fieldAttributes[1]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.INT,6);
			fieldAttributes[2]= new XFAttr(XFAttr.xftype.DATE,XFAttr.xftype.DATETIME,XFAttr.xfformat.YYYYMMDD,8);
			fieldAttributes[3]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[4]= new XFAttr(XFAttr.xftype.ALPHA,60);
			fieldAttributes[5]= new XFAttr(XFAttr.xftype.ALPHA,2);
			fieldAttributes[6]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.DECIMAL,11,2);
			fieldAttributes[7]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.DECIMAL,6,2);
			fieldAttributes[8]= new XFAttr(XFAttr.xftype.DECIMAL,XFAttr.xftype.DECIMAL,16,2);
			fieldAttributes[9]= new XFAttr(XFAttr.xftype.ALPHA,3);
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
		 
		private decimal f_Total_price=0;
		 
		/// <summary>
		/// Total price
		/// </summary>
		public decimal Total_price
		{
			get{ return f_Total_price;}
			set { 
			    if(f_Total_price != value) 
			       m_changed = true; 
			    f_Total_price = value;
			} 
		}
		 
		private string f_Is_estimate="";
		 
		/// <summary>
		/// Is this an estimated value
		/// </summary>
		public string Is_estimate
		{
			get{ return f_Is_estimate;}
			set { 
			    if(!f_Is_estimate.Equals(value)) 
			       m_changed = true; 
			    f_Is_estimate = value;
			} 
		}
		 
		/// <summary>
		/// structure clone
		/// </summary>
		public Project_expense_summary Clone()
		{
			Project_expense_summary tmp = new Project_expense_summary();
			tmp.f_Project_id = this.f_Project_id;
			tmp.f_Expense_id = this.f_Expense_id;
			tmp.f_Expense_date = this.f_Expense_date;
			tmp.f_Expensed_by = this.f_Expensed_by;
			tmp.f_Description = this.f_Description;
			tmp.f_Currency_code = this.f_Currency_code;
			tmp.f_Unit_price = this.f_Unit_price;
			tmp.f_Quantity = this.f_Quantity;
			tmp.f_Total_price = this.f_Total_price;
			tmp.f_Is_estimate = this.f_Is_estimate;
			return tmp;
		}
		/// <summary>
		/// structure equals
		/// </summary>
		public bool Equals(Project_expense_summary str)
		{
			bool eq = true;
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
			if (!this.Expensed_by.Equals(str.Expensed_by))
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
			if (this.Total_price != str.Total_price)
			{
				eq = false;
				return eq;
			}
			if (!this.Is_estimate.Equals(str.Is_estimate))
			{
				eq = false;
				return eq;
			}
			return eq;
		}
		/// <summary>
		/// Constructor
		/// </summary>
		public Project_expense_summary() {
		}
		/// <summary>
		/// serialize structure
		/// </summary>
		public string structToWire()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("ST[10]180%");
			StringBuilder body = new StringBuilder();
			body.Append(XFProtocol.fieldToWire(f_Project_id,fieldAttributes[0]));
			body.Append(XFProtocol.fieldToWire(f_Expense_id,fieldAttributes[1]));
			body.Append(XFProtocol.fieldToWire(f_Expense_date,fieldAttributes[2]));
			body.Append(XFProtocol.fieldToWire(f_Expensed_by,fieldAttributes[3]));
			body.Append(XFProtocol.fieldToWire(f_Description,fieldAttributes[4]));
			body.Append(XFProtocol.fieldToWire(f_Currency_code,fieldAttributes[5]));
			body.Append(XFProtocol.fieldToWire(f_Unit_price,fieldAttributes[6]));
			body.Append(XFProtocol.fieldToWire(f_Quantity,fieldAttributes[7]));
			body.Append(XFProtocol.fieldToWire(f_Total_price,fieldAttributes[8]));
			body.Append(XFProtocol.fieldToWire(f_Is_estimate,fieldAttributes[9]));
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
			f_Expense_id = XFProtocol.wireToint(reply);
			f_Expense_date = XFProtocol.wireToDateTime(reply,fieldAttributes[2]);
			f_Expensed_by = XFProtocol.wireTostring(reply);
			f_Description = XFProtocol.wireTostring(reply);
			f_Currency_code = XFProtocol.wireTostring(reply);
			f_Unit_price = XFProtocol.wireTodecimal(reply);
			f_Quantity = XFProtocol.wireTodecimal(reply);
			f_Total_price = XFProtocol.wireTodecimal(reply);
			f_Is_estimate = XFProtocol.wireTostring(reply);
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
		public static void GetRow(ref Project_expense_summary str, int pos, DataTable dt)
		{
			DataRow dr = dt.Rows[pos];
			str.f_Project_id = (int)dr["Project_id"];
			str.f_Expense_id = (int)dr["Expense_id"];
			str.f_Expense_date = (DateTime)dr["Expense_date"];
			str.f_Expensed_by = (string)dr["Expensed_by"];
			str.f_Description = (string)dr["Description"];
			str.f_Currency_code = (string)dr["Currency_code"];
			str.f_Unit_price = (decimal)dr["Unit_price"];
			str.f_Quantity = (decimal)dr["Quantity"];
			str.f_Total_price = (decimal)dr["Total_price"];
			str.f_Is_estimate = (string)dr["Is_estimate"];
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
			dtclm = new DataColumn("Expense_id",typeof(int));
			dtclm.Caption = "Expense #";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Expense_date",typeof(DateTime));
			dtclm.Caption = "Expense Date";
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Expensed_by",typeof(string));
			dtclm.Caption = "Expensed By";
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
			dtclm = new DataColumn("Total_price",typeof(decimal));
			dt.Columns.Add(dtclm);
			dtclm = new DataColumn("Is_estimate",typeof(string));
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
				Project_expense_summary str = (Project_expense_summary)al[i];
				dr["Project_id"] = str.Project_id;
				dr["Expense_id"] = str.Expense_id;
				dr["Expense_date"] = str.Expense_date;
				dr["Expensed_by"] = str.Expensed_by;
				dr["Description"] = str.Description;
				dr["Currency_code"] = str.Currency_code;
				dr["Unit_price"] = str.Unit_price;
				dr["Quantity"] = str.Quantity;
				dr["Total_price"] = str.Total_price;
				dr["Is_estimate"] = str.Is_estimate;
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
