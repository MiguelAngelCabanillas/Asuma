using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asuma
{
    class Commons
    {
        public static string LongToBytesMagnitude(float size){
            int i = -1;
            string s = "";
            while (size > 1)
            {
                i++;
                size = size / 1000;
            }
            size *= 1000;
            s += size;
            switch (i)
            {
                case 0: s += " B";
                    break;
                case 1: s += " KB";
                    break;
                case 2: s += " MB";
                    break;
                case 3: s+= " GB";
                    break;
                case 4: s += " TB";
                    break;
                default: s = "false";
                    break;
            }

            return s;

        }
    }
}
