using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDesign.AbstractFactory
{
    public class Enumeration
    {
        public enum Brand
        {
            Apple,
            Dell
        }

        public enum SystemType
        {
            Laptop,
            Desktop
        }

        public enum Processor
        {
            I3,
            I5,
            I7
        }
    }
}
