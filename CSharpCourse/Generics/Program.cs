using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {       
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();

            List<string> result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { Name = "Ebubekir" }, new Customer { Name = "Mehmet" });
            foreach (var item in result2)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
        //Generic metotlar
        class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }
        }
        //Generic sınıflar
        class Product : IEntity
        {

        }
        class ProductDal : IProductDal
        {
            public void Add(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product entity)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }
        }
        interface IProductDal: IRepository<Product>
        {
            
        }

        class Customer : IEntity
        {
            public string Name { get; set; }
        }
        class CustomerDal : ICustomerDal
        {
            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }
        }
        interface ICustomerDal:IRepository<Customer>
        {
            
        }
        interface IEntity
        {

        }
        //GENERIC KISITLARI
        interface IRepository<T> where T:class,IEntity , new() //T refarans tip ve new yapılabilir bir turden olmalıdır komutu. Yani T, int string türden olamaz. IEntity->sadece veri tabanı nesneleri alabilir
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T entity);
            void Delete(T entity);
            void Update(T entity);
        }
    }
}
