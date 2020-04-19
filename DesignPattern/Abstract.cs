using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class AbstractBaseClass
    {
        public abstract void Show();

        public void Print()
        {
            
        }

        public virtual void Display()
        {
            
        }

        public static void OutPut()
        {
            
        }
    }

    public class Derived:AbstractBaseClass
    {
        public override void Show()
        {
            var obj = new Test();
            obj.Result(3, 4, 5);
            throw new NotImplementedException();
        }
    }

    public class Test
    {
        public void Result(int d, params int[] b)
        {
            AbstractBaseClass.OutPut();
        }
    }
}
