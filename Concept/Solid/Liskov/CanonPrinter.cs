using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Solid.Liskov
{
    class CanonPrinter : Printer
    {
        public override void Copy()
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
