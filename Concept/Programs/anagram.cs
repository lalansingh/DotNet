using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    class anagram
    {
        public static void checkStringIsAnagram()
        {
            string firstStr = "LISTEN";
            string secondStr = "SILENT";

            //int length = 0;
            //while (true)
            //{
            //    try
            //    {
            //        var s = firstStr[length];
            //        length++;
            //    }
            //    catch(IndexOutOfRangeException ex)
            //    {
            //        break;
            //    }
            //}

            if (firstStr.Length != secondStr.Length)
            {
                Console.WriteLine("Strins are not anagram each other");
            }
            else
            {
                var sortedStr1 = sortString(firstStr);
                var sortedStr2 = sortString(secondStr);

                if (sortedStr1 == sortedStr2)
                {
                    Console.WriteLine("Strins are anagram each other");
                }
                else
                {
                    Console.WriteLine("Strins are not anagram each other");
                }
            }
        }

        private static string sortString(string str)
        {
            var strChar = str.ToCharArray();
            for (int i = 0; i < strChar.Length; i++)
            {
                for (int j = 0; j < (strChar.Length - i) - 1; j++)
                {
                    if (strChar[j] > strChar[j + 1])
                    {
                        var temp = strChar[j];
                        strChar[j] = strChar[j + 1];
                        strChar[j + 1] = temp;
                    }
                }
            }
            return String.Join("", strChar);
        }
    }
}
