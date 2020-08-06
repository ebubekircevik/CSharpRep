using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            MySql mySql = new MySql();

            sqlServer.Add();
            mySql.Deleted();

            Console.ReadLine();
        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default");
            }

            public virtual void Deleted()
            {
                Console.WriteLine("Deleted by default");
            }
        }
        
        class SqlServer: Database
        {
            public override void Add() //database classının add metodu ezildi
            {
                Console.WriteLine("SqlServer added");
                //base.Add();
            }
        }
        class MySql: Database
        {
            public override void Deleted()
            {
                Console.WriteLine("MySqlServer deleted");
                //base.Deleted();
            }
        }
    }
}
