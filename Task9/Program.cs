using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
        Step1:
            Console.WriteLine("0 ve 13 arasinda bir eded daxil edin: ");
            int Months = Convert.ToInt32(Console.ReadLine());

            if (Months >= 1 && Months <= 12)
            {
                switch (Months)
                {
                    case 1:
                        Console.WriteLine("Yanvar");
                        break;
                    case 2:
                        Console.WriteLine("Fevral");
                        break;
                    case 3:
                        Console.WriteLine("Mart");
                        break;
                    case 4:
                        Console.WriteLine("Aprel");
                        break;
                    case 5:
                        Console.WriteLine("May");
                        break;
                    case 6:
                        Console.WriteLine("Iyun");
                        break;
                    case 7:
                        Console.WriteLine("Iyul");
                        break;
                    case8:
                        Console.WriteLine("Avqust");
                        break;
                    case 9:
                        Console.WriteLine("Sentyabr");
                        break;
                    case 10:
                        Console.WriteLine("Oktyabr");
                        break;
                    case 11:
                        Console.WriteLine("Noyabr");
                        break;
                    case 12:
                        Console.WriteLine("Dekabr");
                        break;
                }
            }
            else
            {
                goto Step1;
            }
        }
    }
}
