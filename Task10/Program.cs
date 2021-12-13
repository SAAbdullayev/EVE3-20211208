using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1ci ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("2ci ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("3ci ededi daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("4ci ededi daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("5ci ededi daxil edin: ");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.Write("6ci ededi daxil edin: ");
            int f = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c && a > d && a > e && a > f)
            {
                Console.WriteLine($"En Boyuk Eded: {a}");
            }

            else if (b > a && b > c && b > d && b > e && b > f)
            {
                Console.WriteLine($"En Boyuk Eded: {b}");
            }

            else if (c > a && c > b && c > d && c > e && c > f)
            {
                Console.WriteLine($"En Boyuk Eded: {c}");
            }

            else if (d > a && d > b && d > c && d > e && d > f)
            {
                Console.WriteLine($"En Boyuk Eded: {d}");
            }

            else if (e > a && e > b && e > c && e > d && e > f)
            {
                Console.WriteLine($"En Boyuk Eded: {e}");
            }

            else if (f > a && f > b && f > c && f > d && f > e)
            {
                Console.WriteLine($"En Boyuk Eded: {f}");
            }
        }
    }
}
