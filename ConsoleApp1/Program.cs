using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cicle();
            Console.Read();
        }
        static void Cicle()
        {
            double a1 = -200;
            double d=0.2;
            double x = -200;
            for(int a=2; a<=150;a++)
            {
                a1 = a1 - d;
                x = x + a1;
            }
            Console.WriteLine($"сумма:{x:F2}");
        }
    }
}
