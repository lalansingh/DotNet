using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.FactoryPattern.AbstractFactory
{
    public interface IMachineFactory
    {
        IProcessor GetRam();
        IHardDisk GetHardDisk();
        IMonitor GetMonitor();
    }
}
