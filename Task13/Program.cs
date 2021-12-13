using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Step1:
            Console.WriteLine("7 reqemli bir eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num>=1000000 && num<=9999999)  
            {
                int num1 = num / 10000;   
                int num2 = num % 1000;    
                int b = 0;
                int c = 0;

                while(num2>0)
                {
                    c = num2 % 10;
                    num2 /= 10;
                    b = c + b;
                    b = b * 10; 
                }
                b = b / 10;
                
                if (b==num1)
                {
                    int e;
                    
                    int f = 0;
                    while(num>0)
                    {
                        e = num % 10;
                        if(e==0)
                        {
                            f++;
                        }
                        num /= 10;
                    }
                        
                Console.WriteLine($"eded polindromdur ve {f} dene 0 var");
                }
            }
            else
            {
                goto Step1;
            }


        }
    }
}
