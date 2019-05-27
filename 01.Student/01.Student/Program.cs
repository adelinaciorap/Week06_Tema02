using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student123
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Andrei", "Marian", "Cretu", 123456, "Nicolina", 074343488, "andreic@gmail.com", 4, Speciality.Law, University.Cuza, Faculty.Law);
            Student student2 = new Student("Anton", "Gica", "Stan", 113123, "Copou", 07656561, "stan@mail.ro", 6, Speciality.Law, University.Oxford, Faculty.Law);

            Console.WriteLine("First student equal to second student? {0}", Student.Equals(student1, student2)); // False
            Console.WriteLine("First student == second student? {0}", student1 == student2); 

            Console.WriteLine("First student != second student? {0}", student1 != student2); 

            Console.WriteLine();

            Student student3 = new Student("Andrei", "Marian", "Cretu", 123456, "Nicolina", 074343488, "andreic@gmail.com", 4, Speciality.Law, University.Cuza, Faculty.Law);

            Console.WriteLine("First student equal to third student? {0}", student1 == student3); 

            Console.WriteLine("First student == third student? {0}", student1 == student3); 

            Console.WriteLine("First student != third student? {0}", student1 != student3); 

            Console.WriteLine();

            Student cloned = student2.Clone();
            Console.WriteLine("Cloned: ");
            Console.WriteLine(cloned);
        }
    }

}
