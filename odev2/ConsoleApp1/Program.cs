using System;

namespace odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = 20;
            y = 13;
            z = 42;
            if (23 == 55 && 76 > 45 && 5 < 12)
                Console.WriteLine("doğru");
            else 
                Console.WriteLine("yanlış");
            if (23 >= 23 && 45 != 18)
                Console.WriteLine("doğru");
            else
                Console.WriteLine("yanlış");
            if (x > y && z == y && z < x)
                Console.WriteLine("doğru");
            else
                Console.WriteLine("yanlış");
            if (z > x && y < x)
                Console.WriteLine("doğru");
            else
                Console.WriteLine("yanlış");
            if (x != z || y <= z)
                Console.WriteLine("doğru");
            else 
                Console.WriteLine("yanlış");
            
            Console.ReadKey();
        }
    }
}
