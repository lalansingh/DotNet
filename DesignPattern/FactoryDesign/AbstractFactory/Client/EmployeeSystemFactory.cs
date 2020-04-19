using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.FactoryDesign.AbstractFactory.AbstractInterface;
using DesignPattern.FactoryDesign.AbstractFactory.ContcreateFactory;

namespace DesignPattern.FactoryDesign.AbstractFactory.Client
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(EmployeeModel emp)
        {
            IComputerFactory returnvalue = null;
            if (emp.EmployeeId == 1)
            {
                if (emp.JobDescription == "Manger")
                    returnvalue = new MacLaptopFactory();
                else
                    returnvalue = new MacDesktopFactory();
            }
            else if (emp.EmployeeId == 2)
            {
                if (emp.JobDescription == "Manger")
                    returnvalue = new DellLaptopFactory();
                else
                    returnvalue = new DellDesktopFactory();
            }

            return returnvalue;
        }
    }
}
