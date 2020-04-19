using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.FactoryPattern.AbstractFactory
{
    public class LowBudgetMachine:IMachineFactory
    {
        public IProcessor GetRam()
        {
            return new CheapProcessor();
        }

        public IHardDisk GetHardDisk()
        {
            return  new CheapHardDisk();
        }

        public IMonitor GetMonitor()
        {
            return  new LowResolutionMonitor();
        }
    }
}
