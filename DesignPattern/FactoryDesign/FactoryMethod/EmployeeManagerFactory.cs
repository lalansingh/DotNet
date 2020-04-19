using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDesign.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(EmployeeModel emp)
        {
            BaseEmployeeFactory returnValue = null;
            if (emp.EmployeeId == 1)
            {
                returnValue = new ParmanentEmployeeFactory(emp);
            }
            else if (emp.EmployeeId == 2)
            {
                returnValue = new ContractEmployeeFactory(emp);
            }

            return returnValue;
        }
    }
}
