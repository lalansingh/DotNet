using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.FactoryPattern.SimpleFactory
{
    public class CustomerFactory
    {
        public static ICustomer GetCustomer(string objectName)
        {
            switch (objectName)
            {
                case "gold":
                    return new GoldCustomer();
                case "silver":
                    return new SilverCustomer();
                default:
                    return null;
            }
        }
    }
}
