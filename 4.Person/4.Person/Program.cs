using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Person
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Oana", 34);
            Person secondPerson = new Person("Ionut", null);

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
