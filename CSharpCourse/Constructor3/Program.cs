using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Console.ReadLine();
        }
        class BaseClass
        {
            string _entity;

            public BaseClass(string entity)
            {
                _entity = entity;
            }
            public void Message()
            {
                Console.WriteLine("{0} Message" , _entity);
            }
        }
        class PersonManager : BaseClass
        {
            public PersonManager(string entity) :base (entity) //Baseclass da cunstructor olduğu için yazıldı. entity degeri baseclass a gonderildi
            {
                    
            }
            public void Add()
            {
                Message();
                Console.WriteLine("Added");
            }
        }
    }
}
