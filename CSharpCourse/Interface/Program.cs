using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalManager personal = new PersonalManager();
            /*1
            Customer customer = new Customer{ FirstName = "Mehmet", LastName = "Sensoy", Id = 66 };
            personal.Add(customer);
            */
            /*2
            Customer customer = new Customer();
            customer.FirstName = "Halil";
            customer.LastName = "Sonmez";
            customer.Id = 5;
            personal.Add(customer);
            */
            personal.Add(new Customer { Id = 1, FirstName = "Ebubekir", LastName = "Çevik" });
            personal.Add(new Student { Id = 2, FirstName = "Furkan", LastName = "ateş" });

            Console.ReadLine();
        }

        interface IPerson
        {
             int Id { get; set; } //Interface de erişim beliteçleri yazilmaz
             string FirstName { get; set; }
             string LastName { get; set; }
        }

        class Customer : IPerson
        {
           public int Id { get; set; } 
           public string FirstName { get; set; }
           public string LastName { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; } 
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class PersonalManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
            
        
    }
}
