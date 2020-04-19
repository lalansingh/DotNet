using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.FactoryDesign;

namespace DesignPattern.FactoryDesign.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected EmployeeModel _emp;

        protected BaseEmployeeFactory(EmployeeModel emp)
        {
            _emp = emp;
        }

        public EmployeeModel ApplySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HouseAllowance = manager.GetAllowence();
            _emp.Pay = manager.GetPay();

            return _emp;
        }

        public abstract IEmployeeManager Create();
    }
}
