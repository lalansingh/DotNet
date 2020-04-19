using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.FactoryPattern.AbstractFactory
{
    public class CheapHardDisk:IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Data will take less time to store");
        }
    }
}
