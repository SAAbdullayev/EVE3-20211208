using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1-365 intervalinda bir eded secin: ");
            int day = Convert.ToInt32(Console.ReadLine());
            if(day>=1 && day<=31)   
            {
                Console.WriteLine("Ay: Yanvar");
                if(day >= 1 && day <= 20)
                {
                    Console.WriteLine("Bürc: Oğlaq");
                }
                else if(day >= 21 && day <= 31)
                {
                    Console.WriteLine("Bürc: Dolça");
                }
            }
            else if(day>=32 && day<=59)             
            {
                Console.WriteLine("Ay: Fevral");
                if (day >= 32 && day <= 50)
                {
                    Console.WriteLine("Bürc: Dolça");
                }
                else if (day >= 51 && day <= 59)
                {
                    Console.WriteLine("Bürc: Balıq");
                }
            }
            else if (day >= 60 && day <= 90)             
            {
                Console.WriteLine("Ay: Mart");
                if (day >= 60 && day <= 79)
                {
                    Console.WriteLine("Bürc: Balıq");
                }
                else if (day >= 80 && day <= 90)
                {
                    Console.WriteLine("Bürc: Qoç");
                }
            }
            else if (day >= 91 && day <= 120)             
            {
                Console.WriteLine("Ay: Aprel");
                if (day >= 91 && day <= 110)
                {
                    Console.WriteLine("Bürc: Qoç");
                }
                else if (day >= 111 && day <= 120)
                {
                    Console.WriteLine("Bürc: Buğa");
                }
            }
            else if (day >= 121 && day <= 151)             
            {
                Console.WriteLine("Ay: May");
                if (day >= 121 && day <= 140)
                {
                    Console.WriteLine("Bürc: Buğa");
                }
                else if (day >= 141 && day <= 151)
                {
                    Console.WriteLine("Bürc: Ekizlər");
                }
            }
            else if (day >= 152 && day <= 181)             
            {
                Console.WriteLine("Ay: İyun");
                if (day >= 152 && day <= 172)
                {
                    Console.WriteLine("Bürc: Ekizlər");
                }
                else if (day >= 173 && day <= 181)
                {
                    Console.WriteLine("Bürc: Xərçəng");
                }
            }
            else if (day >= 182 && day <= 212)             
            {
                Console.WriteLine("Ay: İyul");
                if (day >= 182 && day <= 204)
                {
                    Console.WriteLine("Bürc: Ekizlər");
                }
                else if (day >= 205 && day <= 212)
                {
                    Console.WriteLine("Bürc: Aslan");
                }
            }
            else if (day >= 213 && day <= 243)             
            {
                Console.WriteLine("Ay: Avqust");
                if (day >= 213 && day <= 235)
                {
                    Console.WriteLine("Bürc: Aslan");
                }
                else if (day >= 236 && day <= 243)
                {
                    Console.WriteLine("Bürc: Qız");
                }
            }
            else if (day >= 244 && day <= 273)             
            {
                Console.WriteLine("Ay: Sentyabr");
                if (day >= 244 && day <= 266)
                {
                    Console.WriteLine("Bürc: Qız");
                }
                else if (day >= 267 && day <= 273)
                {
                    Console.WriteLine("Bürc: Tərazi");
                }
            }
            else if (day >= 274 && day <= 304)             
            {
                Console.WriteLine("Ay: Oktyabr");
                if (day >= 274 && day <= 296)
                {
                    Console.WriteLine("Bürc: Tərazi");
                }
                else if (day >= 297 && day <= 304)
                {
                    Console.WriteLine("Bürc: Əqrəb");
                }
            }
            else if (day >= 305 && day <= 334)             
            {
                Console.WriteLine("Ay: Noyabr");
                if (day >= 305 && day <= 326)
                {
                    Console.WriteLine("Bürc: Əqrəb");
                }
                else if (day >= 327 && day <= 334)
                {
                    Console.WriteLine("Bürc: Yay");
                }
            }
            else if (day >= 335 && day <= 365)             
            {
                Console.WriteLine("Ay: Dekabr");
                if (day >= 335 && day <= 356)
                {
                    Console.WriteLine("Bürc: Yay");
                }
                else if (day >= 357 && day <= 365)
                {
                    Console.WriteLine("Bürc: Oğlaq");
                }
            }
            

        }
    }
}
