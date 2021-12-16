using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynPSGNetCore.Interop;

namespace ChronoTrackNetUIMS.Forms
{
    public partial class StateMaintenance : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

        public StateMaintenance(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param>Binding source</param>
        public void SetDataSource(DataTable state)
        {
            //assign passed binding source
            bindingSource1.DataSource = state;
            SetFocus();
        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("MB_COMMIT");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interop.SendMenuSignal("MB_EXIT");
        }
    }
}
