using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Person
{

    public class Person
    {
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int? Age { get; }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Name is: " + this.Name);
            if (this.Age == null)
            {
                stringBuilder.AppendLine("Age is null");
            }
            else
            {
                stringBuilder.AppendLine("Age is : " + this.Age);
            }
            return stringBuilder.ToString();
        }
    }
}

