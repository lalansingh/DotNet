using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpConcept.FactoryPattern.AbstractFactory;
using CsharpConcept.FactoryPattern.FactoryMethod;
using CsharpConcept.FactoryPattern.SimpleFactory;

namespace CsharpConcept.FactoryPattern
{
    public  class MainMethodFactory
    {
        public void MainMethod()
        {
            /* Simple Factory*/
            var obj = CustomerFactory.GetCustomer("gold");

            /* Factory Method*/
            BaseCustomerFactory baseCustomer = new GoldCustomerFactory();
            var obj1 = baseCustomer.GetCustomer();
            
            obj1.AddDiscount();

            IMachineFactory factory = new LowBudgetMachine(); // or LowBudgetMachine()
            CoputerShopAbstractFactory shop = new CoputerShopAbstractFactory(factory);
            shop.AssembleMachine();

            Console.ReadLine();
        }
    }
}
