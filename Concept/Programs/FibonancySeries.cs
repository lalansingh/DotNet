using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    public class FibonancySeries
    {
        public static void fibonancySerise()
        {
            int num = 10;
            int result = 0;
            int first = 0;
            int second = 1;

            for (int i = 0; i < num; i++)
            {
                if (i == 0)
                {
                    Console.Write(first.ToString() + " ");
                }
                else if (i == 1)
                {
                    Console.Write(second.ToString() + " ");
                }
                else
                {
                    result = first + second;
                    first = second;
                    second = result;
                    Console.Write(result.ToString() + " ");
                }
            }
        }
    }
}
