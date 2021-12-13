using System;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("6 reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            int q = 0;
            int s = 0;
            int m = 0;
            int t = 0;
            int v = 0;

            while (a>0)   
            {
                t = a % 10;
                switch (t)
                {
                    
                    case 1:
                        if (c == 1)
                        {
                            a /= 10;
                            continue;
                        }
                        else
                        {
                            c++;
                        }
                        break;
                    case 2:
                        if (d == 1)
                        {
                            a /= 10;
                            continue;
                        }
                        else
                        {
                            d++;
                        }
                        break;
                    case 3:
                        if (b == 1)
                        {
                            a /= 10;
                            continue;
                        }
                        else
                        {
                            b++;
                        }
                        break;
                    case 4:
                        if (e == 1)
                        {
                            a /= 10;
                            continue;
                        }
                        else
                        {
                            e++;
                        }
                        break;
                    case 5:
                        if (f == 1)
                        {
                            a /= 10;
                            continue;
                        }
                        else
                        {
                            f++;
                        }
                        break;
                    case 6:
                        
                        if (g == 1)
                        {
                            a /= 10;
                            continue;
                        }
                        else
                        {
                            g++;
                        }
                        break;
                    case 7:
                        
                        if (h == 1)
                        {
                            a /= 10;
                            continue;
                        }
                        else
                        {
                            h++;
                        }
                        break;
                    case 8:
                        
                        if (m == 1)
                        {
                            a /= 10;
                            continue;
                        }
                        else
                        {
                            m++;
                        }
                        break;
                    case 9:
                        
                        if (q == 1)
                        {
                            a /= 10;
                            continue;
                        }
                        else
                        {
                            q++;
                        }
                        break;
                    case 0:

                        if (v == 1)
                        {
                            a /= 10;
                            continue;
                        }
                        else
                        {
                            v++;
                        }
                        break;
                }
                a /= 10;
            }
            s = b + c + d + e + g + h + m + v + f + q;
            Console.WriteLine($"daxil etdiyiniz eded icinde: {s}-dene unikal eded var");
        }
    }
}
