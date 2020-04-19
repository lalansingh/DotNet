using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.FactoryPattern.AbstractFactory
{
    public class HighBudgetMachine:IMachineFactory
    {
        public IProcessor GetRam()
        {
            return new ExpensiveProcessor();
        }

        public IHardDisk GetHardDisk()
        {
            return new ExpensiveHardDisk();
        }

        public IMonitor GetMonitor()
        {
            return new HighResolutionMonitor();
        }
    }
}
