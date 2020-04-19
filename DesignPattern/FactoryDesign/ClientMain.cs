using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.FactoryDesign.AbstractFactory.AbstractInterface;
using DesignPattern.FactoryDesign.AbstractFactory.Client;
using DesignPattern.FactoryDesign.FactoryMethod;
using DesignPattern.FactoryDesign.SimpleFactory;

namespace DesignPattern.FactoryDesign
{
    public class ClientMain
    {
        public void MainMethodFactory()
        {
            //empTypep as Parmanent Employee or Contract Employee - 1,2
            #region Simple factory design
            ////->The Object needs to be extended to subclasses
            ////->The Classes doesn't know what exact sub-classes it has to create
            ////->The Product implementation tend to change over time and the client remains unchanged
            //int empType = 1;
            //EmployeeManagerFactory empMgrFactory = new EmployeeManagerFactory();
            //var objFactory = empMgrFactory.GetEmployeeManager(empType);
            //var bonus = objFactory.GetBonus();
            //var pay = objFactory.GetPay();
            //Console.WriteLine("Employee Type: {0} has bonus: {1} and pay: {2}", empType, bonus, pay);

            #endregion

            #region Factory Method
            //EmployeeModel emp = new EmployeeModel();
            //emp.EmployeeId = 2;
            //BaseEmployeeFactory employeeFactory = new DesignPattern.FactoryDesign.FactoryMethod.EmployeeManagerFactory()
            //    .CreateFactory(emp);
            //employeeFactory.ApplySalary();

            //Console.WriteLine("Employee Type: {0} has bonus: {1} and pay: {2}", emp.EmployeeId, emp.Bonus, emp.Pay);
            #endregion

            #region Abstract Factory
            EmployeeModel emp = new EmployeeModel();
            emp.EmployeeId = 1;
            emp.JobDescription = "Manger";
            IComputerFactory factory = new EmployeeSystemFactory().Create(emp);
            EmployeeSystemManager manager = new EmployeeSystemManager(factory);
            var res = manager.GetSysteDetails();
            Console.WriteLine(res);

            #endregion
        }
    }
}
