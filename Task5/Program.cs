using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
        Step1:
            Console.WriteLine("Iki reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b;
            int c;
            int d;
            int e;
            if (a >= 10 && a <= 99)
            {
                b = a % 10;
                a /= 10;
                d = (a % 10);
                c = b + d;

                if (c % 2 == 0)
                {
                    e = b * d;
                    Console.WriteLine(e);
                }
            }
            else
            {
                goto Step1;
            }
        }
    }
}
