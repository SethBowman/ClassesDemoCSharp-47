using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemoCSharp_47
{
    public class Classroom
    {
        //Properties can be of type List or Array
        public List<Person> CodingClass { get; set; } = new List<Person>();

        //Method (non static for now)
        public void GreetEveryone()
        {
            foreach(var person in CodingClass)
            {
                //Calling a method from the Person class using each person
                person.Greet();
            }
        }
    }
}
