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
    public partial class Working : Form
    {
        public Working()
        {
            InitializeComponent();
        }

        public string Message
        {
            set { this.label1.Text = value; }
        }
    }
}
