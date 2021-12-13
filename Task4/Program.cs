using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iki reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 10 && a <= 99 && a % 11 == 0)
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyr");
            }
        }
    }
}
