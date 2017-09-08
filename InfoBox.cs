using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeReference
{
    class InfoBox
    {
        public string myInfo;
        public string myName;

        public InfoBox(string info, string name)
        {
            myInfo = info;
            myName = name;
        }

        public string getMyInfo()
        {
            return myInfo;
        }

        public string getMyName()
        {
            return myName;
        }
    }
}
