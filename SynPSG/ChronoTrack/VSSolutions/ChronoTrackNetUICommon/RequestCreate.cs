using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynPSGNetCore.Interop;
using System.Collections;
using System.Data;

namespace ChronoTrackNetUICommon
{
    public static class RequestCreate
    {
        private static SynInterop _interop;

        public static Boolean Handles_Save(SynInterop interop, Form userForm, BindingSource requestBindingSource, BindingSource userBindingSource, ArrayList userList)
        {
            _interop=interop;

            interop.DebugMessage("Save button clicked");
            //validate the user controls
            if (!userForm.ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                return false;
            }
            try
            {
                if (userList.Count == 0)
                {
                    MessageBox.Show("You must select at leastone resource"
                        , userForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                requestBindingSource.EndEdit();

                saveAdditionalResources(requestBindingSource, userBindingSource, userList);

                interop.SendMenuSignal("MB_COMMIT");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, string.Concat("ChronoTrack - ", userForm.Text));
                return false;
            }
        }

        public static Boolean Handles_Cancel(SynInterop interop, Form userForm)
        {
            if (MessageBox.Show("Cancel all changes, are you sure?",
                string.Concat("ChronoTrack - ", userForm.Text),
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return false;
            }
            interop.SendMenuSignal("MB_CANCEL");
            return true;
        }
        
        
        private static void saveAdditionalResources(BindingSource requestBindingSource, BindingSource userBindingSource, ArrayList userList)
        {               
            //because of the way the request data area is structured
            //we only hold one resource (consultant) against a request
            //therefore this logic itterates through the userList checked 
            //list box and creates additional request rows.

            DataTable requests = (DataTable)requestBindingSource.DataSource;
            DataTable users = (DataTable)userBindingSource.DataSource;

            //this is our first row
            bool first = true;
            //need to have differenct indexes for additional rows
            int index = 1;

            for (int i = 0; i < userList.Count; i++)
            {
                DataRow requestRow;
                string name = userList[i].ToString();
                _interop.DebugMessage(name);
                string sql = string.Concat("Full_name='", name, "'");
                _interop.DebugMessage(sql);
                DataRow[] userRow = users.Select(sql);
                _interop.DebugMessage(userRow.Length.ToString());
                if (first)
                {
                    DataRow row = userRow[0];
                    _interop.DebugMessage(row[0].ToString());
                    requestRow = requests.Rows[0];
                    requestRow["Resource"] = row["User_ID"].ToString();
                    first = false;
                }
                else
                {
                    DataRow row = userRow[0];
                    _interop.DebugMessage(userRow[0].ToString());
                    requestRow = requests.NewRow();
                    requestRow.ItemArray = requests.Rows[0].ItemArray;
                    requestRow["Request_id"] = index;
                    index++;
                    requestRow["Resource"] = row["User_ID"].ToString();
                    requests.Rows.Add(requestRow);
                }
            }

        }

    }
}
