using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    class Palindrom
    {
        public static void palindromWay1()
        {
            string str = "lalan";
            string reversStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversStr += str[i];
            }

            if (str == reversStr)
            {
                Console.WriteLine(str + " is a palindrop");
            }
            else
            {
                Console.WriteLine(str + " is not a palindrop");
            }
        }

        public static void palindromWay2()
        {
            string str = "jahnhaj";
            int first = 0;
            int last = str.Length - 1;
            bool isPalindrom = true;
            while (last != first)
            {
                if (str[first] == str[last])
                {
                    first++;
                    last--;
                }
                else
                {
                    isPalindrom = false;
                    break;
                }
            }

            if (isPalindrom)
            {
                Console.WriteLine(str + " is a palindrop");
            }
            else
            {
                Console.WriteLine(str + " is not a palindrop");
            }

        }
    }
}
