using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes //Attributes: Nesnelerin adlamlandırılması işlemidir 
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(new Customer { Id=1, FirstName="Ebubekir", LastName="Çevik", Age=25 });
            Console.ReadLine();

        }
        [ToTable("Customer")] //Veritabanı sorgularında kullanılır.//Construc ile set edilir
        [ToTable("TblCustomer")]
        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty]
            public string FirstName { get; set; } //Customer nesnesi yaratıldığında FirstName e kesin olarak atama yapılmak zorunda
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        class CustomerDal
        {
            [Obsolete("Don't use Add, instead of use AddNew")]//hazır attribute
             public void Add(Customer customer)
            {
                Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.Age);
            }

            public void AddNew(Customer customer)
            {
                Console.WriteLine(customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.Age);
            }
        }
        [AttributeUsage(AttributeTargets.Property] //sadece property lere uygulanabilir
        internal class RequiredPropertyAttribute : Attribute
        {
        }
        [AttributeUsage(AttributeTargets.Class, AllowMultiple =true)]//sadece class lara uygulanabilir ve çoklu kullanıma izin verir
        internal class ToTableAttribute : Attribute
        {
            string _tableName;
            public ToTableAttribute(string tableName)
            {
                _tableName = tableName;
            }
        }
    }

    
}
