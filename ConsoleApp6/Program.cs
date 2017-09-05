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
            Foo(2);
            Console.ReadLine();
        }
        static void Foo(int x)
        {
            Console.WriteLine("Foo(int {0})",x);
        }

        static void Foo(double x)
        {
            Console.WriteLine("Foo(double {0})", x);
        }

    }


}
