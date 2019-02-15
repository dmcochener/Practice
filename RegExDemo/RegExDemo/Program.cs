using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex Spaces = new Regex(@"\s{2,}");
            string Input1 = " Backpacks   always   seem to hold unnecessary items. Textbooks, pencils,  worksheets, and that doesn't even include sports or extracurricular activities.  But yet, students everywhere carry them, for TWELVE  years in a row! You sprint down the halls and jump up the stairs with them, leaving a sore ache in your legs at the end of a school day. But nobody ever questions this    ridiculous concept. Backpacks are like a mysterious bruise;  You don't know how you ended up with it and you're not quite sure what to do with it. ";
            //string Input2 = "";
            ProcessInput(Spaces, Input1);
            //ProcessInput(Search, Input2);
            Console.Read();
        }

        private static void ProcessInput(Regex Search, string Input)
        {
            int repCount = 0;
            Console.Write("Original Input:  ");
            Console.WriteLine(Input);
            Console.WriteLine("");
            foreach (var match in Search.Matches(Input))
            {
                repCount++;
            }
            Console.Write("Finished Output:  ");
            Console.WriteLine(Search.Replace(Input, " "));
            Console.WriteLine("Instances fixed:  {0}", repCount);
        }
    }
}
