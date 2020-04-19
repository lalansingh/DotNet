using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept
{

    public sealed class abc
    {
        public string methodExt()
        {
            return "Extende method called";
        }
    }

    public static class ExtClass
    {
        public static string mthExtention(this abc obj)
        {
            return "Custom Extention";
        }
    }

    public abstract class AbstractClass
    {
        public AbstractClass()
        {
            Console.WriteLine("Abstract constructor called");
        }

        public virtual void methodVirtual()
        {
            Console.WriteLine("Method virtual called");
        }

        public void method1()
        {
            Console.WriteLine("Method 1");
        }
    }

    public abstract class AbstractClass2 : AbstractClass
    {
        public AbstractClass2()
        {
            Console.WriteLine("Abstract2 constructor called");
        }
        public void method2()
        {

        }
    }
    public static class aa { }
    public class ConcreteClass : AbstractClass2
    {
        public override void methodVirtual()
        {

        }
    }

    public static class mainMethod
    {
        public static void callMethod()
        {
            Console.WriteLine(new abc().mthExtention());
            AbstractClass2 obj = new ConcreteClass();
            obj.method1();
        }
    }

}
