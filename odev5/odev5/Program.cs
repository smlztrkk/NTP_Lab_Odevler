using System;

namespace odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta, x1, x2;

            Console.Write("a değerini giriniz:");
            a = int.Parse(Console.ReadLine());

            Console.Write("b değerini giriniz:");
            b = int.Parse(Console.ReadLine());

            Console.Write("c değerini giriniz:");
            c = int.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;
            if (delta == 0)
            {
                Console.WriteLine("Kökler eşit");
            }
            else if (delta < 0)
            {
                Console.WriteLine("Kökler reel değil");
            }
            else
            {
                x1 = ((-1) * b + Math.Sqrt(delta)) / (2 * a);
                x2 = ((-1) * b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1={0}\nx2={1}", x1, x2);

                
            }
            Console.ReadKey();
        }
    }
}
