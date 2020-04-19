using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class AbstractFactory
    {
        public static int Count;
        public static void GetName()
        {
            Console.WriteLine("Factory Class");
        }

        public abstract void Test();
    }
}
