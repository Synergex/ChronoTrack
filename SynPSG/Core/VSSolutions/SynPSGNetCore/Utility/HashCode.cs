using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SynPSGNetCore
{
    /// <summary>
    /// the HashCode class allows for the generations of 
    /// a hash code for a string of characters
    /// </summary>
    public static class Utility
    {
        public static Int32 SynHashCode(string inString)
        {
            return inString.GetHashCode();
        }


    }

    public struct SynergyGRFA
    {
        public int RFAPart1;
        public short RFAPart2;
        public Int32 HashCode;
    }
}
