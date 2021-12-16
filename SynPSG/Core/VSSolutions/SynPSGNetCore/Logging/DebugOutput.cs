using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SynPSGNetCore.Logging
{
    public partial class DebugOutput : Form
    {
        public DebugOutput()
        {
            InitializeComponent();
        }

        public enum MessageTypes
        {
            Error,
            Info
        }

        int indexCount;
        DataTable messageTable;
        DataTable errorTable;
        DataSet gridData;

        /// <summary>
        /// 
        /// Output the passed message to the debug window
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Output(MessageTypes type, string routine, int line, int error, string message)
        {
            indexCount++;

            switch (type)
            {
                case MessageTypes.Error:
                    if (!includeErrorsToolStripMenuItem.Checked) return;
                    break;
                case MessageTypes.Info:
                    if (!includeInformatonToolStripMenuItem.Checked) return;
                    break;
                default:
                    break;
            }
            DataRow row = messageTable.NewRow();

            row[0] = indexCount;

            switch (type)
            {
                case MessageTypes.Error:
                    row[1] = Properties.Resources.error;
                    break;
                case MessageTypes.Info:
                    row[1] = Properties.Resources.info;
                    break;
                default:
                    break;
            }
            row[2] = message;
            messageTable.Rows.Add(row);
            debugGrid1.Update();

            int moveRow = debugGrid1.Rows.Count - 1;
            debugGrid1.Rows[moveRow].Visible = true;

            row = errorTable.NewRow();

            row[0] = indexCount;
            row[1] = line;
            row[2] = error;
            row[3] = routine;

            errorTable.Rows.Add(row);

        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            errorTable.Rows.Clear();
            messageTable.Rows.Clear();
        }

        private void includeErrorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            includeErrorsToolStripMenuItem.Checked = !includeErrorsToolStripMenuItem.Checked;
        }

        private void includeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            includeInformatonToolStripMenuItem.Checked = !includeInformatonToolStripMenuItem.Checked;
        }

        private void DebugOutput_Load(object sender, EventArgs e)
        {
            //build the error message table
            messageTable = new DataTable("MessageTable");
            DataColumn col;

            col = new DataColumn("Index", typeof(System.Int32));
            messageTable.Columns.Add(col);

           
            col = new DataColumn("MsgType", typeof(System.Drawing.Bitmap));
            col.Caption = "Type";
            col.ReadOnly = true;
            messageTable.Columns.Add(col);

            col = new DataColumn("MsgText", typeof(System.String));
            col.Caption = "Information";
            col.ReadOnly = true;
            messageTable.Columns.Add(col);

            errorTable = new DataTable("ErrorTable");

            col = new DataColumn("Index", typeof(System.Int32));
            errorTable.Columns.Add(col);

            col = new DataColumn("LineNumber", typeof(System.Int32));
            col.Caption = "Line";
            col.ReadOnly = true;
            errorTable.Columns.Add(col);

            col = new DataColumn("ErrorNumber", typeof(System.Int32));
            col.Caption = "Error";
            col.ReadOnly = true;
            errorTable.Columns.Add(col);

            col = new DataColumn("Routine", typeof(System.String));
            col.Caption = "Routine";
            col.ReadOnly = true;
            errorTable.Columns.Add(col);

            gridData = new DataSet("GridData");
            gridData.Tables.Add(messageTable);
            gridData.Tables.Add(errorTable);

            //define a relationship

            DataRelation rel = new DataRelation("Primary", messageTable.Columns[0], errorTable.Columns[0]);
            gridData.Relations.Add(rel);

            debugGrid1.DataSource = gridData;
            debugGrid1.DataMember = "MessageTable";
            debugGrid1.Columns[0].Visible = false;
            debugGrid1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            debugGrid1.Columns[1].Width = 50; 
            debugGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            includeErrorsToolStripMenuItem.Checked = true;
            includeInformatonToolStripMenuItem.Checked = true;

        }
    }
}
