using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interface2.OracleCustomerDal;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customer = new CustomerManager();
            customer.Add(new SqlServerCustomerDal());

            Console.ReadLine();
        }
    }
}
