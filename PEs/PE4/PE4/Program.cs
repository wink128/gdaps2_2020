using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4
{
    // delegate creation
    public delegate bool IsValidString(string str);

    class Program
    {
        static void Main(string[] args)
        {
            // object creation
            Checker check = new Checker();

            TestString test = new TestString();

            // run tests
            test.TestMyString("123456789", check.NoSSN); // true
            test.TestMyString("iPhone", check.NoApple); // true

            test.TestMyString("43", check.NoSSN); // false
            test.TestMyString("youtube", check.NoApple); // false
        }
    }
}
