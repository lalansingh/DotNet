using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Solid.Liskov
{
    abstract class Printer : IPrinterMultiTast, IPrinterSingleTask
    {
        public abstract void Copy();

        public abstract void Print();

        public abstract void Scan();
    }
}
