using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    class findCharectors
    {
        public static void findCharectorsInString()
        {
            string str = "lal4f634#@^jm)4";
            var rjx = new Regex(@"\d");
           
            var rs = rjx.Replace(str, "");
            var result = str.Length - rs.Length;
            Console.WriteLine("Total no of digit in string " + str + " is - " + result);
        }
    }
}
