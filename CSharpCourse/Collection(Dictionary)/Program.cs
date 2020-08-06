using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("pc", "bilgisaray");

            //Console.WriteLine(dictionary["book"]);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                //Console.WriteLine(item.Value);               
            }

            Console.ReadLine();
        }
    }
}
