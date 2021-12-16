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

namespace ChronoTrackNetUIMS.Forms
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
//            requestBindingSource.DataSource = request;
//            userBindingSource.DataSource = user;
//            foreach (DataRow userRow in user.Rows)
//            {
//                userList.Items.Add(userRow["Full_name"]);
//            }

        }

        /// <summary>
        /// SetFocus is required becuase the form controls will not
        /// accept focus until the form is dislayed after a u_update()
        /// </summary>
        public void SetFocus()
        {
//            txtStartDate.Focus();
        }
    }
}
