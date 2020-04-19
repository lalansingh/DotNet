using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssembly;

namespace DesignPattern.FactoryDesign.FactoryMethod
{
    public class ParmanentEmployeeFactory : BaseEmployeeFactory
    {
        public ParmanentEmployeeFactory(EmployeeModel emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            ParmanentEmployeeManager manager = new ParmanentEmployeeManager();
            //_emp.Bonus = manager.GetBonus();
            //_emp.Pay = manager.GetPay();
            //_emp.HouseAllowance = manager.GetAllowence();
            return manager;
        }
    }
}
