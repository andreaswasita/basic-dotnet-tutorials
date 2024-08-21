using System;

namespace FalseConditionDoWhileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 6;

            do
            {
                Console.WriteLine($"Ini adalah perulangan ke-{i}");
                i++;
            }
            while (i <= 5);
        }
    }
}