using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());


            if (a % 2 == 0)
            {
                Console.WriteLine("Eded cut ededdir!");
            }
            else
            {
                Console.WriteLine("Eded tek ededdir!");
            }
        }
    }
}
