using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabaseLogger();
            customerManager.Add();
            Console.ReadLine();
        }
        class CustomerManager
        {
            public ILog Logger { get; set; }
            public void Add()
            {
                Logger.Log();
                Console.WriteLine("Customer added !");
            }
        }
        class DatabaseLogger: ILog
        {
            public void Log()
            {
                Console.WriteLine("Logged to database");
            }
        }

        class FileLogger : ILog
        {
            public void Log()
            {
                Console.WriteLine("Logged to file");
            }
        }

        interface ILog
        {
            void Log();
        }
    }
}
