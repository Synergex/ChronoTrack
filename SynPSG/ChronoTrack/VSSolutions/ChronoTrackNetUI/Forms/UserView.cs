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
    public partial class UserView : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

        public UserView(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param>Binding source</param>
        public void SetDataSource(DataTable user, DataTable country, DataTable state)
        {
            interop.DebugMessage("binding UI data source");
            //assign passed binding source
            userBindingSource.DataSource = user;

            countryBindingSource.DataSource = country;
            stateBindingSource.DataSource = state;

            if (user.Rows.Count == 0)
                userBindingSource.AddNew();

        }

        private void UserView_Load(object sender, EventArgs e)
        {

        }

        private void openFileEditor_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Keyup");
            e.Handled = true;
        }

        private void openFileEditor_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("KeyDown");
            e.Handled = true;
        }

        private void openFileEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("KeyPress");
            e.Handled = true;
        }

        private void openFileEditor_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            openFileDialog.FileName = "wibblwe";
            openFileDialog.ShowDialog(this);
        }

    }
}
