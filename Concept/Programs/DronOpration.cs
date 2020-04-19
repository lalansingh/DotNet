using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    class DronOpration
    {
        public void DroneOpe()
        {
            string[] result;
            char[] drons;
            string[] operations;
            char backword = '<';
            char forword = '>';

            // No of Test cases
            int t = Convert.ToInt32(Console.ReadLine());
            result = new string[t];
            for (int c = 0; c < t; c++)
            {
                // No of dropns
                int n = Convert.ToInt32(Console.ReadLine());
                drons = new char[n];
                drons = Console.ReadLine().ToArray();
                //for (int d = 0; d < n; d++)
                //{
                //    drons[d] = Console.ReadKey().KeyChar;
                //}
                // No of operations
                //Console.WriteLine();
                int o = Convert.ToInt32(Console.ReadLine());
                operations = new string[o];
                for (int i = 0; i < o; i++)
                {
                    operations[i] = Console.ReadLine();
                }

                // find the result
                if (o == 0)
                {
                    result[c] = new string(drons);
                }
                else
                {
                    for (int j = 0; j < operations.Length; j++)
                    {
                        string[] op = operations[j].Split();
                        int s = Convert.ToInt32(op[0]);
                        int e = Convert.ToInt32(op[1]);
                        for (int r = s; r <= e; r++)
                        {
                            if (drons[r] == forword)
                            {
                                drons[r] = backword;
                            }
                            else
                            {
                                drons[r] = forword;
                            }
                        }

                    }
                    result[c] = new string(drons);
                }
            }

            for (int c = 0; c < t; c++)
            {
                Console.WriteLine(result[c]);
            }
                       
        }
    }
}
