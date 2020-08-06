using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //KOLEKSİYONLAR
            //Diziler bir kere oluşturulur ve eleman sayısı girilir. Daha sonra eleman sayısı yetersiz geldiğinde yeni bir dizi oluşturulmalıdır. Boyle bir durumun onune geçmek için koleksiyonlar oluştutulmuştur

            //ArrayList objects = new ArrayList {"Ankara", 1, 'A', true};
            ArrayList objects = new ArrayList(); //ArrayList ler her tipte veri alır
            objects.Add("İstanbul");
            objects.Add(1);
            objects.Add(true);
            objects.Add('A');

            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }

            /*
            //List<string> cities = new List<string> {"Istanbul", "Ankara", "Mersin" };
            List<string> cities = new List<string>(); //Içine sadece string türünde nesne alır
            cities.Add("Istanbul");
            cities.Add("Ankara");
            cities.Add("Izmir");
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
            */

            Console.ReadLine();
        }
    }
}
