using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDesign.SimpleFactory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int empType)
        {
            IEmployeeManager empObj = null;
            if (empType == 1)
                empObj = new ParmanentEmployeeManager();
            if (empType == 2)
                empObj = new ContractEmployeeManager();
            return empObj;
        }
    }
}
