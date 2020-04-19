using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.FactoryDesign.AbstractFactory.AbstractInterface;
using DesignPattern.FactoryDesign.AbstractFactory.AbstractProduct;

namespace DesignPattern.FactoryDesign.AbstractFactory.Client
{
    public class EmployeeSystemManager
    {
        IComputerFactory _IComputerFactory;

        public EmployeeSystemManager(IComputerFactory iComputerFactory)
        {
            _IComputerFactory = iComputerFactory;
        }

        public string GetSysteDetails()
        {
            IBrand brand = _IComputerFactory.Brand();
            IProcessor processor = _IComputerFactory.Processor();
            ISystemType system = _IComputerFactory.SystemType();
            string returnValue = string.Format("{0} {1} {2}", brand.GetBrand(), processor.GetProcessor(),
                system.GetSystemType());
            return returnValue;
        }
    }
}
