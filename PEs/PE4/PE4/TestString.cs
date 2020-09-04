using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4
{
    class TestString
    {
        public bool TestMyString(string str, IsValidString stringTest)
        {
            return stringTest(str);
        }
    }
}
