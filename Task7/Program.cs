using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
        Step1:
            Console.Write("uc reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b;
            int c;
            int d;
            int e;
            if (a >= 100 && a <= 999)
            {
                b = a / 100;
                c = a % 10;
                d = (a / 10) - (b * 10);
                e = b + c + d;
                if (b * b == e)
                {
                    Console.WriteLine("Beli");
                }
                else
                {
                    Console.WriteLine("Xeyr");
                }
            }
            else
            {
                goto Step1;
            }
        }
    }
}
