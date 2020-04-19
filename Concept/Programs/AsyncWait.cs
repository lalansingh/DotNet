using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    public class AsyncWait
    {
        public string method1()
        {
            Thread.Sleep(2000); // 2 sec
            return "Mehod 1";
        }

        public string method2()
        {
            Thread.Sleep(5000); // 5 sec
            return "Mehod 2";
        }

        public async Task<string> method3()
        {
            Thread.Sleep(2000); // 2 sec
            return await Task.FromResult("Mehod 3");
        }

        public async Task<string> method4()
        {
            Thread.Sleep(5000); // 5 sec
            return await Task.FromResult("Mehod 4");
        }

        public async Task<string> method5()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000); // 2 sec               

            });
            return await Task.FromResult("Mehod 5");
        }

        public async Task<string> method6()
        {
            await Task.Run(() =>
             {
                 Thread.Sleep(5000); // 5 sec               

             });
            return await Task.FromResult("Mehod 6");
        }
    }

    public class CallAyncWaitClass
    {
        public static void calledAyncWait()
        {
            var startTime = DateTime.Now;
            var obj = new AsyncWait();
            var res1 = obj.method1();
            var res2 = obj.method2();
            var endTime = DateTime.Now;
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine("Total time taken" + (endTime - startTime));

            startTime = DateTime.Now;
            List<Task<string>> task = new List<Task<string>>();
            task.Add(Task.Run(() => obj.method3()));
            task.Add(Task.Run(() => obj.method4()));
            //var res = Task.WhenAll(task);
            //res.Wait();
            Task.WaitAll(task.ToArray());
            endTime = DateTime.Now;
            //Console.WriteLine(res.Result[0]);
            //Console.WriteLine(res.Result[1]);
            Console.WriteLine("Total time taken" + (endTime - startTime));


            startTime = DateTime.Now;
            var res5 = obj.method5();
            var res6 = obj.method6();           
            Console.WriteLine(res5.Result);
            Console.WriteLine(res6.Result);
            endTime = DateTime.Now;
            Console.WriteLine("Total time taken" + (endTime - startTime));

        }
    }
}
