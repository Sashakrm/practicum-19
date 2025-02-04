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
            int n = 50;
            int sum = 100;
            int x = 100;
            for(int a=2; a<=10;a++)
            {
                x = x + n;
                
                sum = sum + x;
            }
            Console.WriteLine($", sum={sum}");
        }
    }
}
