using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Iterasi {i}");
                Console.WriteLine($"Pangkat dari {i} adalah {i * i}");
            }
        }
    }
}