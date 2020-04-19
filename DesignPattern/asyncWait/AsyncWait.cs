using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.asyncWait
{
    public class AsyncWait
    {
        public async Task<int> GetTotalEmployee()
        {
            Console.WriteLine("waiting for 5 sec...");
            Thread.Sleep(5000);
            int count = 0;
            await Task.Run(() => count += 10);
            return count;
        }

        public int GetTotalDepartment()
        {
            Console.WriteLine("waiting for 5 sec...");
            Thread.Sleep(5000);
            return 5;
        }
    }
}
