using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SynPSGNetCore.Interop;

namespace ChronoTrackNetUICommon
{
    /// <summary>
    /// Generic class to handle common activites across UI componenets
    /// </summary>
    public static class Generic
    {
        /// <summary>
        /// Method to handle save button events
        /// </summary>
        /// <remarks>
        /// when a form has a basic binding source this method can handle the processing when the user wishes 
        /// to commit the form details after presseing the Save/Update buttons.  The
        /// form argument is used to validate child controls.  The bindingSource argument is used
        /// to commit the data.  Any errors encountered are reported and will return a status of FALSE
        /// </remarks>
        /// <param name="interop">pass in the synergy/.NET interop class</param>
        /// <param name="customForm">the form containing the fields/controls to validate</param>
        /// <param name="boundData">Binding source containing the bound data</param>
        /// <returns>TRUE if the form/data is validand can be comminted for processing, otherwise FALSE</returns>
        public static Boolean Handles_Save(SynInterop interop, Form customForm, BindingSource boundData)
        {
            interop.DebugMessage("Save button clicked");
            //validate the user controls
            if (!customForm.ValidateChildren(ValidationConstraints.Enabled | ValidationConstraints.Visible))
            {
                interop.DebugMessage("Some fields failed validation");
                return false;
            }
            try
            {
                interop.DebugMessage("Controls valid, commit");
                boundData.EndEdit();
                interop.SendMenuSignal("MB_COMMIT");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, string.Concat("ChronoTrack - ", customForm.Text));
                return false;
            }
        }

        /// <summary>
        /// Method to hadle cancel button events
        /// </summary>
        /// <remarks>
        /// When the user selects to cancel changes this method requests confirmation.
        /// </remarks>
        /// <param name="interop">pass in the synergy/.NET interop class</param>
        /// <param name="customForm">the form containing the fields/controls to validate</param>
        /// <param name="boundData">Binding source containing the bound data</param>
        /// <returns>TRUE if the user continues to cancel, otherwise FALSE</returns>
        public static Boolean Handles_Cancel(SynInterop interop, Form customForm, BindingSource boundData)
        {
            interop.DebugMessage("Cancel button clicked");
            boundData.CancelEdit();
            interop.SendMenuSignal("MB_CANCEL");

            return true;
        }

        /// <summary>
        /// Overridden. Method to hadle cancel button events
        /// </summary>
        /// <remarks>
        /// When the user selects to cancel changes this method requests confirmation.
        /// </remarks>
        /// <param name="interop">pass in the synergy/.NET interop class</param>
        /// <param name="customForm">the form containing the fields/controls to validate</param>
        /// <returns>TRUE if the user continues to cancel, otherwise FALSE</returns>
        public static Boolean Handles_Cancel(SynInterop interop, Form customForm)
        {
            interop.DebugMessage("Cancel button clicked");
            if (MessageBox.Show("Cancel all changes, are you sure?",
                string.Concat("ChronoTrack - ", customForm.Text),
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return false;
            }

            interop.SendMenuSignal("MB_CANCEL");

            return true;
        }
    }
}
