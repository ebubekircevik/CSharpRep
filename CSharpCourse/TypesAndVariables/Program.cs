using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                City = "Istanbul", ID = 1, FirstName = "Ebubekir", LastName = "Cevik"
            };
            Console.WriteLine(customer1.FirstName);

            Customer customer2 = new Customer();
            customer2.ID = 2;
            customer2.FirstName = "Ahmet";
            customer2.LastName = "Yılmaz";
            customer2.City = "Ankara";
            Console.WriteLine(customer2.City);
            

        Console.ReadLine();
        }

       

    }
}
