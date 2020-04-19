using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.FactoryPattern
{
    class GoldCustomer: ICustomer
    {
        public void AddPoints()
        {
            Console.WriteLine("Gold Customer - Points Added");
        }

        public void AddDiscount()
        {
            Console.WriteLine("Gold Customer - Discount Added");
        }

        public void GoldOpertion()
        {
            Console.WriteLine("Gold Customer Operation");
        }
    }
}
