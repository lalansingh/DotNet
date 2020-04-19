using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.FactoryPattern.AbstractFactory
{
    public class HighResolutionMonitor:IMonitor
    {
        public void DisplayPicture()
        {
            Console.WriteLine("Picture quality is best");
        }
    }
}
