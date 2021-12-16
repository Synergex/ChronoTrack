using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynPSGNetCore.Interop; 

namespace ChronoTrackNetUI.Forms
{
    public partial class MainMenu : Form
    {
        private SynInterop interop;

        public MainMenu(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                interop.SendMenuSignal(listView.SelectedItems[0].Tag.ToString());
            }
        }

    }
}
