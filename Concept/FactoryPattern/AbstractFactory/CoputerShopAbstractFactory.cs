using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.FactoryPattern.AbstractFactory
{
    public class CoputerShopAbstractFactory
    {
        IMachineFactory category;

        public CoputerShopAbstractFactory(IMachineFactory _category)
        {
            category = _category;
        }

        public void AssembleMachine()
        {
            IProcessor processor = category.GetRam();
            IHardDisk hardDisk = category.GetHardDisk();
            IMonitor monitor = category.GetMonitor();

            processor.PerformOperation();
            hardDisk.StoreData();
            monitor.DisplayPicture();
        }
    }
}
