using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemoCSharp_47
{
    public class Person
    {        

        //Fields - a variable inside of a class (camel case)
        public int wallet;
        public string clothes;

        //Properties - things that define the class (pascal case)
        public string Name { get; set; }
        public int Age { get; set; }
        public string HairColor { get; set; }

        //Methods (non static for now)
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }

        //Constructors

        //Default constructor
        public Person()
        {

        }

        //Custom constructor
        public Person(string name, int age, string hairColor)
        {
            Name = name;
            Age = age;
            HairColor = hairColor;
        }
    }
}
