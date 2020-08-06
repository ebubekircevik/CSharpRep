using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customer = new List<Customer> { //Sadece customer nesnesi alır
                new Customer { Id=1, FirstName = "Ebubekir" },
                new Customer { Id=2, FirstName= "Mehmet"}
            };

            /* //Alternatif koleksiyon tanımlama
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { Id=1, FirstName="Ebubekir" });
            customer.Add(new Customer { Id=2, FirstName="Mehmet" });
            */

            /*
            foreach (var item in customer)
            {
                Console.WriteLine(item.Id + " " + item.FirstName);
            }
            */

            //Koleksiyon Metotları

            //Console.WriteLine(customer.Count()); //Koleksiyonun eleman sayısını verir

            /*
            var customer1 = new Customer { Id=5, FirstName="Ahmet" };
            customer.Add(customer1); //Koleksiyona farklı bir eleman ekleme yontemi
            */

            /*
            customer.AddRange(new Customer[] //dizi şeklinde nesne ekler
                {
                    new Customer{ Id=10, FirstName="Ali"}, //Nesneli
                    new Customer() //Nesnesiz
                });
            */

            var customer2 = new Customer { Id = 3, FirstName = "Veli" };
            customer.Add(customer2);

            customer.AddRange(new Customer[2] //list e array ekler
            {
                new Customer{ Id=4, FirstName="John" },
                new Customer{ Id=5, FirstName="Michale" },
            });

            /*
            foreach (var item in customer)
            {
                Console.WriteLine(item.FirstName);
            }
            */

            //customer.Clear(); //list in elemanlarını siler
            //Console.WriteLine(customer[0].FirstName.Contains("John")); //içerip içermediğini dondurur
            //Console.WriteLine(customer.Count); //Dizinin eleman sayısını verir

            /*
            var index = customer.IndexOf(customer2);
            Console.WriteLine(index); //index i verir
            */

            customer.Insert(2, customer2);//istenilen index e eleman ekler

            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
