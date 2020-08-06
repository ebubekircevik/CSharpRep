using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3] 
            {
                new Person {FirstName = "Ebubekir" },
                new Customer{FirstName = "Mehmet" },
                new Student{ FirstName = "Ali"}
            };

            foreach (var item in person)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public void Write()
            {
                Console.WriteLine(FirstName);
            }
        }
        class Customer:Person //bir class tekbir class inherite alabilir. Ancak bir birden fazla interfaceten inherite alabilir. Classların tek başına bir anlamı vardır ama interfacelerin yoktur
        {
            public string City { get; set; }
        }
        class Student:Person
        {
            public string Department { get; set; }
        }
    }
}
