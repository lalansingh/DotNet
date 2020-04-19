using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpConcept.FactoryPattern.SimpleFactory;

namespace CsharpConcept.FactoryPattern
{
    public class SilverCustomer: ICustomer
    {
        public void AddPoints()
        {
            Console.WriteLine("Silver Customer - Points Added");
        }

        public void AddDiscount()
        {
            Console.WriteLine("Silver Customer - Discount Added");
        }

        public void GoldOpertion()
        {
            Console.WriteLine("Silver Customer Operation");
        }
    }
}
