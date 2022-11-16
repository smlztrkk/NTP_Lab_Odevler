using System;

namespace odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir tam çember yayının 400 de 1 ini gören merkez açının ölçüsüne 1 grad denir
            //ve ile gösterilir. Birim çemberin çevresi 360° veya 2π radyan veya 400 grad olduğu için
            // 360° = 2π radyan = 400 grad veya 180° = π radyan = 200 grad dır.

            int d, r, g;
            double pi = 3.14;

            Console.WriteLine("Bir derece değeri giriniz = ");
            d = Convert.ToInt32(Console.ReadLine());

            r = Convert.ToInt32(d * pi / 180);
            g = d * 200 / 180;

            Console.WriteLine("Radyan = " + r);
            Console.WriteLine("Gradyan = " + g);
            Console.ReadKey();

        }
    }
}
