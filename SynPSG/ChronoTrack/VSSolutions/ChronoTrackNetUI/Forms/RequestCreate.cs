using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynPSGNetCore.Interop;
using System.Collections;

namespace ChronoTrackNetUI.Forms
{
    public partial class RequestCreate : Form
    {
        //need a copy of the interop object
        private SynInterop interop;

        public RequestCreate(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// Routine to allow the client to bind the binding source
        /// </summary>
        /// <param name=request>DataTable</param>
        /// <param name=users>DataTable</param>
        public void SetDataSource(DataTable request, DataTable user)
        {
            //assign passed binding source
            requestBindingSource.DataSource = request;
            userBindingSource.DataSource = user;
            foreach (DataRow userRow in user.Rows)
            {
                userList.Items.Add(userRow["Full_name"]);
            }

        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
            txtStartDate.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ArrayList userArray=new ArrayList();
            for (int i = 0; i < userList.CheckedItems.Count; i++)
			{
                userArray.Add(userList.CheckedItems[i].ToString());
			}
            if(!ChronoTrackNetUICommon.RequestCreate.Handles_Save(interop, this, requestBindingSource, userBindingSource, userArray))
                txtStartDate.Focus();
            else
                Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (ChronoTrackNetUICommon.RequestCreate.Handles_Cancel(interop, this))
                Close();
        }

        private void btnSpell_Click(object sender, EventArgs e)
        {
            ultraSpellChecker.ShowSpellCheckDialog(this, txtText);
        }

        private void txtStartDate_Validated(object sender, EventArgs e)
        {
            txtEndDate.Value = txtStartDate.Value;
        }
    }
}
