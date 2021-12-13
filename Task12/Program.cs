using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
        Step1:
            Console.Write("6 reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 100000 && a <= 999999)
            {
                a = (8 * 10000000) + (a * 10) + 8;
                int b;
                int c;
                int d;             //a = 25483695
                b = a / 10000;     //2548
                c = a % 10000;     //3695
                d = c * 10000 + b; //36952548



            }
            else
            {
                goto Step1;
            }
        }
    }
}
