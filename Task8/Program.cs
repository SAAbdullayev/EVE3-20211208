using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
        Step1:
            Console.WriteLine("0 ve 8 arasinda bir eded daxil edin: ");
            int DaysofWeek = Convert.ToInt32(Console.ReadLine());

            if (DaysofWeek >= 1 && DaysofWeek <= 7)
            {
                switch (DaysofWeek)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday	");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
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
