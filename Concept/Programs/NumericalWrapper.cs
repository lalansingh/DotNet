using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    class NumericalWrapper
    {
        public static void numericalWrapper()
        {

            int num = 5;

            for (int i = num; i >= 1; i--)
            {
                int temp = num;
                for (int j = 0; j < (num - i); j++)
                {
                    Console.Write(temp--);
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write(i);
                }

                int length = (i);
                for (int k = 1; k < (num); k++)
                {
                    if (k < length)
                    {
                        Console.Write(length);
                    }
                    else
                    {
                        Console.Write(k + 1);
                    }
                }
                Console.WriteLine();
            }

            for (int i = 2; i <= num; i++)
            {
                int last = 0;
                int tempNum = (num);
                for (int n = 0; n < num; n++)
                {
                    if (n >= (num - i))
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(tempNum--);
                    }
                    last = n;
                }

                for (int n = 1; n <= last; n++)
                {
                    if (n < i)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write((n + 1));
                    }
                }
                Console.WriteLine();
            }
        }

        public static void crossNumeric()
        {
            int num = 40;
            int tempNum = (num + (num - 1));
            int index = 1;
            for (int i = 1; i <= tempNum; i++)
            {
               
                for (int j = 1; j <= tempNum; j++)
                {
                    if (i == j || j == (tempNum - i) + 1)
                    {
                        Console.Write(index);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                if (i >= num)
                {
                    index--;
                }
                else
                {
                    index++;
                }

                Console.WriteLine();
            }
        }
    }
}
