using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class DelegateAnonymous
    {
        public delegate int GetNumber(int x, int y);
    }

    public class Calculator : BaseClass
    {
        public Calculator() : base()
        {
            Console.WriteLine("Derived Class");
        }
        public int Add(int x, int y)
        {
            Console.WriteLine("add");
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }

    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base Class");
        }
        public BaseClass(int x)
        {
            Console.WriteLine(x);
        }
    }

    public class IndexerClass<T>
    {
        public T[] Items = new T[4];
        public T[] Price = new T[4];

        //public string this[int i] => items[i];

        public T this[long x]
        {
            get { return Price[x]; }
            set { Price[x] = value; }
        }

        public T this[int y]
        {
            get { return Items[y]; }
            set { Items[y] = value; }
        }
    }

    public partial class Pclass1
    {
        partial void Add();
    }

    public partial class Pclass1
    {
        public void Sub()
        {
            Console.WriteLine("sjdkf");
        }

        partial void Add()
        {
            Console.WriteLine("");
        }
    }
}
