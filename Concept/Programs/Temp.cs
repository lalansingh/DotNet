using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    public class Temp
    {
        public static void TestMethod()
        {

            string str = "aALala@!^54*jKNsIngh{}[/=zZ";
            string result = "";
            char[] chars = str.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                int asciNum = chars[i];
                if (asciNum >= 97 && asciNum <= 122)
                {
                    int tempAsciNum = asciNum - 32;
                    result += (char)tempAsciNum;
                }
                else if (asciNum >= 65 && asciNum < 97)
                {
                    int tempAsciNum = asciNum + 32;
                    result += (char)tempAsciNum;
                }
                else
                {
                    result += chars[i];

                }
            }
            Console.WriteLine("Original string :- " + str);
            Console.WriteLine("Vise versa string :- " + result);

            // count no of digit in string
            string res = Regex.Replace(str, "[\\d]", "");


            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };

            string[] tempstr = new string[] { };

            var gh = names1.Concat(names2);
            var gj = gh.Distinct();

            names1.Union(names2).Select(x=>x).ToArray();

            Console.WriteLine(string.Join(", ", names1.Union(names2))); // should print Ava, Emma, Olivia, Sophia

            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());
        }

    }

    public class TextInput
    {

        public string res;

        public virtual void Add(char p)
        {

        }

        public string GetValue()
        {
            return res;
        }
    }

    public class NumericInput : TextInput
    {

        public override void Add(char p)
        {

            if (Char.IsNumber(p))
            {
                res += p;
            }
        }

        //public override string GetValue()
        //{
        //    return res;
        //}


    }
    
}
