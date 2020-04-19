using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.FactoryDesign.AbstractFactory.AbstractProduct;

namespace DesignPattern.FactoryDesign.AbstractFactory.AbstractInterface
{
    public interface IComputerFactory
    {
        IBrand Brand();
        IProcessor Processor();
        ISystemType SystemType();
    }
}
