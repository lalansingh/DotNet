using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.FactoryPattern.FactoryMethod
{
   public class GoldCustomerFactory: BaseCustomerFactory
    {
        public override ICustomer CreateCustomer()
        {
           return  new GoldCustomer();
        }
    }
}
