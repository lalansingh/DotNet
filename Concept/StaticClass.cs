using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept
{
    public class StaticClass
    {
        public int num;
        public string name;

        static StaticClass()
        {
            Console.WriteLine("Static constructor!");
        }
       
        public StaticClass()
        {
           
            Console.WriteLine("Normal constructor!");
        }
    }
    public class MainClassStatic
    {
        public void MainMethod()
        {
            StaticClass objStaticClass = new StaticClass();
            StaticClass objStaticClass1 = new StaticClass();
            StaticClass objStaticClass2 = new StaticClass();

            Console.ReadLine();
        }
    }
}
