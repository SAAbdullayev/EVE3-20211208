using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("6 reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 100000 && a <= 999999)
            {
                int b;
                double c;
                double d = 0;
                int e;
                double f;
                double g;


                b = (a / 100000);
                b = (b + ((a / 10000) - ((a / 100000) * 10)));
                b = (b + (a / 1000) - ((a / 10000) * 10));
                int num = a;
                while (a > 999)
                {

                    c = a % 10;
                    a /= 10;
                    d = Convert.ToDouble(d + c);
                }

                if (b == d)
                {
                    e = num / 10000;
                    num = (num * 100) + e;


                    d = (num / 1000) - ((num / 100000)) * 100;
                    num = Convert.ToInt32(num + d);
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraber deyil!");
                }
            }
        }
    }
}
