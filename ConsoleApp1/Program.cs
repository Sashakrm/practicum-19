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
            int n = 4;
            int sum = 1;
            int x = 1;
            Console.Write("1 ");
            for(int a=2; a<=5;a++)
            {
                x = x + n;
                Console.Write($"{x} ");
                sum = sum + x;
            }
            Console.WriteLine($", sum={sum}");
        }
    }
}
