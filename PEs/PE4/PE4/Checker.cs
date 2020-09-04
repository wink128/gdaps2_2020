using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4
{
    class Checker
    {
        public bool NoSSN(string str)
        {
            if (str.Length == 9)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool NoApple(string str)
        {
            if (str == "iPhone" || str == "iPod" || str == "Macintosh")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
