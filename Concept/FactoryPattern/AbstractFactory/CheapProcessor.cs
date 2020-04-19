using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.FactoryPattern.AbstractFactory
{
    public class CheapProcessor: IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation will perform slowly");
        }
    }
}
