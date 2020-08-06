using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); //buradaki boş parantez boş constructor ı temsil eder. nesne ilk oluşturulduğunda çalışırlar. Overloading(aşırı yuklenme) edilebilirler.
            customerManager.Add();

            Product product = new Product { Id = 1, Name = "Laptop" }; //Nesne değişkenlerine bu şekilde deger atanabilir.
            product.Show();
            Product product2 = new Product(2 , "Pencil"); //Constructor sayesinde bu şekkilde değer gönderilebilir
            product2.Show();

            Console.ReadLine();
        }
        class CustomerManager
        {
            int _count = 15;
            public CustomerManager() 
            {

            }
            public CustomerManager(int count)
            {
                _count = count;
            }
            public void Add()
            {
                Console.WriteLine("Count : {0}", _count);
            }
            void Update()
            {

            }
            void Delete()
            {

            }
        }

        class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Product()
            {

            }
            public Product(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public void Show()
            {
                Console.WriteLine(Id);
                Console.WriteLine(Name);
            }
        }
    }
}
