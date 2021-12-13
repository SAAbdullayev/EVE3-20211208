using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bir eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 10 == 7)
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
