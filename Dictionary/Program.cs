using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary sınıfı sizin belirlediğiniz anahtara uygun olarak bir değer tutar 
            //anahtarın değerini belirlemek zorundasınız (int,string...vb)

            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            AdYas.Add("seref", 17);
            AdYas.Add("arda", 18);
            AdYas.Add("engin", 35);
            AdYas.Add("salih", 25);

            foreach (var itemValue in AdYas)
            {
                Console.WriteLine(itemValue);
            }
            //veri sayını ekrana yazdırma
            var item = AdYas.Count();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("veri sayısı : "+item);

            //veri silme

            AdYas.Remove("seref");
            Console.WriteLine("---------------------------------------");
            foreach (var itemRemove in AdYas)
            {
                Console.WriteLine(itemRemove);
            }

            //kodlar bana ait değil ama keni tarzımda yazdım umarım yararlu olmuştur.




        }
    }
}
