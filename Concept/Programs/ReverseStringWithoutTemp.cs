using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    class ReverseStringWithoutTemp
    {
        public static void ReverseStringWithoutTempVar()
        {
            string str = "lalan";
            Char[] strChar = str.ToCharArray();
            int first = 0;
            int last = str.Length - 1;

            while (first != last)
            {
                strChar[first] ^= strChar[last];
                strChar[last] ^= strChar[first];
                strChar[first] ^= strChar[last];
                first++;
                last--;
            }

            Console.WriteLine("A Reversed string of " + str + " is - " + String.Join("", strChar));
        }
    }
}
