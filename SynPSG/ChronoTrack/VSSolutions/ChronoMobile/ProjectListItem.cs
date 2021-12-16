using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ChronoMobile
{
    class ProjectListItem
    {
        private string mDisplayText;
        private int mItemValue;

        public ProjectListItem(string displayMember, int valueMember)
        {
            this.mDisplayText = displayMember;
            this.mItemValue = valueMember;
        }

        public string DisplayText
        {
            get { return mDisplayText; }
            set { mDisplayText = value; }
        }

        public int ItemValue
        {
            get { return mItemValue; }
            set { mItemValue = value; }
        }

    }
}
