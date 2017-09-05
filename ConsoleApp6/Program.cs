using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.field1 = 8;
            dc.showValue();
            BaseClass bc = (BaseClass)dc;
            bc.field1 = 5;
            bc.showValue();
            Console.ReadLine();
        }
    }

    public class BaseClass
    {
        public int field1;
        public void showValue()
        {
            Console.WriteLine(field1);
        }
    };
    public class DerivedClass : BaseClass

    {
        new public int field1;
        new public void showValue()
        {
            Console.WriteLine(field1);
        }


    }

}
