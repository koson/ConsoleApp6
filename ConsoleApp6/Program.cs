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
            SecondDerived sd = new SecondDerived();
            sd.report();
        }
    }

    class Base
    {
        protected string name = "My name";
    }
    class Derived : Base
    {

    }
    class SecondDerived : Derived
    {
        public void report()
        {
            Console.WriteLine(name);
        }

    }



}
