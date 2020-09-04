using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary creation
            Dictionary<string, string> list = new Dictionary<string, string>();

            // Dictionary population
            list.Add("book", "a bound collection of paper used to write in.");
            list.Add("leg", "something used to support weight and move around.");
            list.Add("food", "something that living beings require for sustenance.");
            list.Add("study", "something that I don't know how to do.");
            list.Add("video game", "a very pleasant pastime.");

            // loop to cycle through words
            string response = null;
            string edit = null;

            while (response != "EXIT")
            {
                // user input
                Console.Write("Enter a word to locate: ");
                response = Console.ReadLine().Trim();

                // input handling
                if(response == null || response == " ")
                {
                    // prompt again if null
                    Console.Write("Enter a word to locate: ");
                    response = Console.ReadLine().Trim();
                }
                
                if (response != null && response != " ")
                {
                    // sanitization for key verification
                    edit = response.ToLower();
                }
                
                if (list.ContainsKey(edit) == true)
                {
                    // write definition
                    Console.WriteLine("A {0} is {1}\n", edit, list[edit]);
                }
                else if (response == "EXIT")
                {
                    // exit
                    break;
                }
                else
                {
                    // error prompt
                    Console.WriteLine("No definition found.\n");
                }

            } 
        }
    }
}
