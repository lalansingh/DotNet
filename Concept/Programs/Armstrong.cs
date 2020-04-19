using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    class Armstrong
    {
        public static void armstrongNumner()
        {
            int num = 153; // 8208, 9474
            int length = num.ToString().Length;

            int sumOfDigitPower = 0;

            int digit = 0;
            int tempNum = num;

            while (tempNum != 0)
            {
                digit = tempNum % 10;
                tempNum = tempNum / 10;
                sumOfDigitPower += (int)(Math.Pow(digit, length));
            }
            if (num == sumOfDigitPower)
            {
                Console.WriteLine("A number " + num + " is a Armstrong");
            }
            else
            {
                Console.WriteLine("A number " + num + " is not a Armstrong");
            }
        }
    }
}
