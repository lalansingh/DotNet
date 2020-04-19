using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.FactoryDesign.AbstractFactory.AbstractProduct;

namespace DesignPattern.FactoryDesign.AbstractFactory.ConcreateProduct
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Enumeration.Processor.I7.ToString();
        }
    }
}
