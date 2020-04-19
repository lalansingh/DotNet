using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Solid.Liskov
{
    class ClientClass
    {
        /*
         If program module is using a base class, then the reference to the base class can be 
         replaced with a drived calss without affecting the funcionality of the program module

         */
        // To print multi tast
        List<Printer> printMulti = new List<Printer>() { new HpPrinter(), new CanonPrinter() };

        // to print single task
        List<IPrinterSingleTask> printSingle = new List<IPrinterSingleTask>() { new LgPrinter(), new HpPrinter(), new CanonPrinter() };

    }
}
