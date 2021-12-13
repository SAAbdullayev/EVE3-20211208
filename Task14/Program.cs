using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Maksimum 8 reqemli olmaqla bir eded daxil edin: ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a > 0 && a < 10)
            {
                a = a + 1;
                Console.WriteLine(a);
            }
            else if (a >= 10 && a <= 99)
            {
                a = a + 10;
                Console.WriteLine(a);
            }
            else if (a >= 100 && a <= 999)
            {
                a = a + 100;
                Console.WriteLine(a);
            }
            else if (a >= 1000 && a <= 9999)
            {
                a = a + 1000;
                Console.WriteLine(a);
            }
            else if (a >= 10000 && a <= 99999)
            {
                a = a + 10000;
                Console.WriteLine(a);
            }
            else if (a >= 100000 && a <= 999999)
            {
                a = a + 100000;
                Console.WriteLine(a);
            }
            else if (a >= 1000000 && a <= 9999999)
            {
                a = a + 1000000;
                Console.WriteLine(a);
            }
            else if (a >= 10000000 && a <= 99999999)
            {
                a = a + 10000000;
                Console.WriteLine(a);
            }
        }
    }
}
