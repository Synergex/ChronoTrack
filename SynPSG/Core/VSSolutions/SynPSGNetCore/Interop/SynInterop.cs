using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SynPSGNetCore.Interop
{
    public class SynInterop
    {
        ///
        /// these events allow the .NET applicaitons to communicate
        /// back to the synergy hosting program.
        /// 
        #region Events and delegates

        /// <summary>
        /// Allow the form to signal a menu entry
        /// </summary>
        /// <param name="message"></param>
        public delegate void MenuSignalEventHandler(string menuName);
        public event MenuSignalEventHandler MenuSignal;

        /// <summary>
        /// delegate to allow UI client to display debug messages
        /// </summary>
        /// <param name="message"></param>
        public delegate void DebugOutputEventHandler(string message);
        public event DebugOutputEventHandler DebugOutput;

        #endregion

        ///
        /// These methods are designed to be executed by the .NET 
        /// client and allow interop with the synergy applciaiton
        /// 
        #region .NET methods

        /// <summary>
        /// send a menu signal back to Synergy
        /// </summary>
        /// <param name="menuText">the menu string to send back</param>
        public void SendMenuSignal(string menuText)
        {
            MenuSignal(menuText);
        }

        /// <summary>
        /// send a message back so Synergy can display it into the debug window
        /// </summary>
        /// <param name="message"></param>
        public void DebugMessage(string message)
        {
            DebugOutput(message);
        }

        #endregion

    }
}
