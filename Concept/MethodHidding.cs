using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept
{
    public class MethodHiddingBase
    {
        public void Display()
        {
            Console.WriteLine("Method Hidding Base Method!");
        }
    }

    public class MehodHiddingDerived : MethodHiddingBase
    {
        //if you call Display method from object of Derived class without providing new keyword, 
        //then this will print only derived method not Base class method
        //if you providing new keyword to Display method of derived class and calling from object of derived class, 
        //then this will only derived method not base class method.

        //basically new keyword you use to remove warning message of hidding base class method
        //but functionality will remain same with or without new key word
        public new void Display()
        {
            Console.WriteLine("Method Hidding Derived Method!");
        }
    }

    public class MainClassMethodHidding
    {
        public void MainMethod()
        {
            /*to call only derived class method*/
           // MehodHiddingDerived objDerived = new MehodHiddingDerived();

            /*to call only base class method*/
            MethodHiddingBase objDerived = new MehodHiddingDerived();

            objDerived.Display();

            Console.ReadLine();
        }
    }
}
