using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.OopsPractice
{
    public class BaseClass
    {
        public int Amount = 100;
        public int Salary = 25000;

        public BaseClass()
        {

        }
    }

    interface I1
    {
        void MyMethod();
    }
    interface I2
    {
        void MyMethod();
    }


    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base()
        {

        }
        public new int Amount = 500;
    }

    class Temp : I1, I2
    {
        public void MyMethod()
        {
            Console.WriteLine("Hi");
        }

    }

    public class VartualClass
    {
        public virtual string Name { get; set; }
    }

    public class TestVartualProp : VartualClass
    {
        public override string Name { get; set; }
    }

    public class MainClass
    {
        public void MainFunction()
        {
            //var obj = new DerivedClass();
            BaseClass Base = new DerivedClass();
            var result = Base.Amount;
            // var res = DerivedClass.Amount;
            Temp t = new Temp();
            t.MyMethod();
            Console.ReadLine();
        }
    }
}
