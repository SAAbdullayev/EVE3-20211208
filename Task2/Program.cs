using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iki eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            if (a % b == 0)
            {
                c = a / b;
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("bolunmur");
            }
        }
    }
}
