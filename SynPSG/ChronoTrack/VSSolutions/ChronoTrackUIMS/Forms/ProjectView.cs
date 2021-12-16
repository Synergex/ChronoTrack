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
    public partial class ProjectView : Form
    {
        private SynInterop interop;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="i"></param>
        public ProjectView(SynInterop i)
        {
            InitializeComponent();
            interop = i;
        }

        /// <summary>
        /// set the required data sources
        /// </summary>
        /// <param name="user"></param>
        /// <param name="gantt"></param>
        public void SetDataSource(DataTable user, DataTable gantt)
        {
        }

        /// <summary>
        /// allow synergy to set the focus
        /// </summary>
        public void SetFocus(int setView)
        {
        }

        public void RefreshFormData()
        {
        }



    }
}
