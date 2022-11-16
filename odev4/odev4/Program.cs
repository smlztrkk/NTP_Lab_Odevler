using System;

namespace odev4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aylar = {"ocak","şubat","mart","nisan","mayıs","hazıran","temmuz","ağustos","eylül","ekim","kasım","aralık"};
            Console.WriteLine("lütfen doğum tarihinizi gg.aa.yyyy şeklinde giriniz= ");
            string tarih=Console.ReadLine();

            string [] sonay = tarih.Split(".");
            string ay = sonay[1];
            Console.WriteLine(ay);
            int aya = Convert.ToInt32(ay);
            Console.WriteLine(aylar[aya-1]+"'da doğdunuz");
            
            
            Console.ReadKey();
        }
    }
}
