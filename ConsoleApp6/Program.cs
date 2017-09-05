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
            // Person Benjamin = new Person();
            // Person Benjamin = new Person("Benjamin", "Franklin");
            Person Benjamin = new Person("Benjamin");
            Console.ReadLine();

        }
    }

    public class Person
    {
        public string last;
        public string first;
        public Person(string firstName, string lastName)
        {
            last = lastName;
            first = firstName;
            Console.Write("Hi, \"{0}  {1}\" thank you for registering.", first, last);
        }

        public Person(string firstName)
        {
            first = firstName;
            Console.Write("\"{0}\", please enter your last name :", first);
            last = Console.ReadLine();
            Console.Write("Well done, \"{0}  {1}\" thank you for your input.", first, last);
        }

        public Person()
        {
            Console.Write("Hi, please enter your name :");
            first = Console.ReadLine();
            Console.Write("\"{0}\", please enter your last name :", first);
            last = Console.ReadLine();
            Console.Write("Well done, \"{0}  {1}\" thank you for your input.", first, last);

        }
    }

}
