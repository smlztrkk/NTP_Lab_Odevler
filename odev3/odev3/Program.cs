using System;

namespace odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ilk sayıyı giriniz");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b && a % b == 0)
                Console.WriteLine("ilk sayı ikinci sayıya tam bölünür");
            else if (b > a && b % a == 0)
                Console.WriteLine("ikinci sayı ilk sayıya tam bölünür");
            else
                Console.WriteLine("girilen sayılar birbirlerine tam bölÜnmezler");

            Console.ReadKey();
        }
    }
}
