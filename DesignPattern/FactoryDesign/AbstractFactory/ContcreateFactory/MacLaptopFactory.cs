using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.FactoryDesign.AbstractFactory.AbstractInterface;
using DesignPattern.FactoryDesign.AbstractFactory.AbstractProduct;
using DesignPattern.FactoryDesign.AbstractFactory.ConcreateProduct;

namespace DesignPattern.FactoryDesign.AbstractFactory.ContcreateFactory
{
    public class MacLaptopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Mac();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
