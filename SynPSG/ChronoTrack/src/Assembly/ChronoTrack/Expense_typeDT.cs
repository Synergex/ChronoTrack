using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using System.Text;
using Synergex.xfnlnet;
namespace ChronoTrack
{
/// <summary>
/// Synergy DataTable Wrapper for Expense_type
/// </summary>
	[Serializable]
	public class Expense_typeDT : System.Data.DataTable
	{
		 
		/// <summary>
		/// Constructor
		/// </summary>
		public Expense_typeDT()
		{
			this.TableName = "Expense_type";
			DataTable tdt = this;
			Expense_type.TableHeader(ref tdt);
		}
	 
		/// <summary>
		/// ISerialization method
		/// </summary>
		public override void GetObjectData(SerializationInfo si, StreamingContext sc)
		{
			ArrayList al = this.GetRows();
			si.AddValue("SavedAL", al, typeof(System.Collections.ArrayList));
		}
	 
		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public Expense_typeDT(SerializationInfo si, StreamingContext sc)
		{
			this.TableName = "SynDataTable Expense_type";
			DataTable tdt = this;
			Expense_type.TableHeader(ref tdt);
			ArrayList al = (ArrayList)si.GetValue("SavedAL", typeof(System.Collections.ArrayList));
			this.FillDataTable(al);
		}
	 
		/// <summary>
		/// Fill the DataTable from an ArrayList of structures
		/// </summary>
		public void FillDataTable(ArrayList al)
		{
			DataTable tdt = this;
			Expense_type.FillDataTable(al, ref tdt, "A", 0);
		}
	 
		/// <summary>
		/// Get a Structure from a table
		/// </summary>
		public void GetRow(ref Expense_type str, int pos)
		{
			Expense_type.GetRow(ref str, pos, this);
		}
	 
		/// <summary>
		/// Get an ArrayList of all the structures in a table
		/// </summary>
		public ArrayList GetRows()
		{
			ArrayList al = new ArrayList();
			for (int i = 0; i < this.Rows.Count; i++)
			{
			     Expense_type str = new Expense_type();
			     Expense_type.GetRow(ref str, i, this);
			     al.Add(str);
			}
			return al;
		}
	 
		/// <summary>
		/// Add a structure to a DataTable as a row
		/// </summary>
		public void AddRow(Expense_type str)
		{
			DataTable tdt = this;
			ArrayList al = new ArrayList();
			al.Add(str);
			Expense_type.FillDataTable(al, ref tdt, "A", 0);
		}
	 
		/// <summary>
		/// Insert a structure into a DataTable
		/// </summary>
		public void AddRow(Expense_type str, int pos)
		{
			DataTable tdt = this;
			ArrayList al = new ArrayList();
			al.Add(str);
			Expense_type.FillDataTable(al, ref tdt, "I", pos);
		}
	 
	}
}
