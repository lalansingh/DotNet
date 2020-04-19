using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.FactoryDesign.AbstractFactory.AbstractProduct;

namespace DesignPattern.FactoryDesign.AbstractFactory.ConcreateProduct
{
    public class Mac : IBrand
    {
        public string GetBrand()
        {
            return Enumeration.Brand.Apple.ToString();
        }
    }
}
