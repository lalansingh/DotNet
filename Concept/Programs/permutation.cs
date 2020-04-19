using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    public static class permutation
    {
        public static void permutaionTest()
        {
            permutaion("ABC", 0, 2);
        }

        public static void permutaion(string str, int start, int end)
        {
            if (start == end)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = swap(str, start, i);
                    permutaion(str, start + 1, end);
                    str = swap(str, start, i);
                }
            }
        }

        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
