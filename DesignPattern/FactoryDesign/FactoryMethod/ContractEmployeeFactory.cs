using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDesign.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(EmployeeModel emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            //_emp.Bonus = manager.GetBonus();
            //_emp.Pay = manager.GetPay();
            //_emp.HouseAllowance = manager.GetAllowence();
            return manager;
        }
    }
}
