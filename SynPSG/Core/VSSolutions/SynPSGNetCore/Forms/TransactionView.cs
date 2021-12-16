using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SynPSGNetCore.Forms
{
    public partial class TransactionView : Form
    {
        /// <summary>
        /// default constructr accepts the interop reference
        /// </summary>
        /// <param name="i"></param>
        public TransactionView()
        {
            InitializeComponent();
        }

        public new string Text
        {
            set
            {
                dataGridView1.Rows.Add(value);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
