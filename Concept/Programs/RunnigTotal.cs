using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    class RunnigTotal
    {
        public void RunnignTotalWay1()
        {
            int num = 3;
            for (int i = num; i >= 1; i--)
            {
                int totalCount = 0;
                for (int j = 1; j <= i; j++)
                {
                    totalCount += j;
                }
                for (int k = (totalCount - i) + 1; k <= totalCount; k++)
                {
                    Console.Write(k.ToString() + ' ');
                }
                Console.WriteLine();
            }
        }

        public void RunnitTotalWay2()
        {
            int num = 4;
            int runnitTatal = 0;
            for (int i = 1; i <= num; i++)
            {
                runnitTatal += i;
            }

            for (int j = num; j >= 1; j--)
            {
                runnitTatal = runnitTatal - j;
                for (int i = (runnitTatal + 1); i <= runnitTatal + j; i++)
                {

                    Console.Write(i.ToString() + ' ');
                }

                Console.WriteLine();
            }
        }

        public void RunningTotalWay3()
        {
            int num = 4;
            int tempNum = 0;
            int start = 0; ;
            int end = 0;

            for (int i = num; i >= 1; i--)
            {
                tempNum = (i * (i - 1)) / 2;
                start = tempNum + 1;
                end = tempNum + i;

                for (int j = start; j <= end; j++)
                {
                    Console.Write(j.ToString() + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
