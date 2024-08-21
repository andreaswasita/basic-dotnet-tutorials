using System;

namespace WhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine($"Ini adalah perulangan ke-{i}");
                i++; // Increment i setiap kali loop berjalan
            }
        }
    }
}