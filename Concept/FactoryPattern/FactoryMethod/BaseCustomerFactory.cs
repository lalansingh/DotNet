using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.FactoryPattern.FactoryMethod
{
    public abstract class BaseCustomerFactory
    {
        public ICustomer GetCustomer()
        {
            ICustomer objCustomer = CreateCustomer();
            return objCustomer;
        }

        public abstract ICustomer CreateCustomer();
    }
}
