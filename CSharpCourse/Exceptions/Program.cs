using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] array = new string[] { "ali", "Veli", "mehmet" };
                array[3] = "burhan";
            }
            catch(Exception exception) //hatanın sebebini verir
            {

                Console.WriteLine(exception.Message);
                //Console.WriteLine("EXCEPTION");
            }

            Console.ReadLine();
        }
    }
}
