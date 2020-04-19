using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public interface ICustomer
    {
        void GetCustomerAddress();

    }
    public class CustomerA : ICustomer
    {
        public void GetCustomerAddress()
        {
            Console.WriteLine("CustomerA Address");
        }
    }

    public class CustomerB : ICustomer
    {
        public void GetCustomerAddress()
        {
            Console.WriteLine("CustomerB Address");
        }
    }

    public abstract class FactoryMethod
    {
        public abstract ICustomer GetFactoryMethod(string type);
    }

    public class FactoryClass : FactoryMethod
    {
        public override ICustomer GetFactoryMethod(string type)
        {
            if (type == "A") return new CustomerA();
            if (type == "B") return new CustomerB();

            return null;
        }
    }
}
