using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;

            Console.WriteLine(a++ + b++);

            int c = 7;
            int d = 9;

            Console.WriteLine(--c + --d);
        }
    }
}
