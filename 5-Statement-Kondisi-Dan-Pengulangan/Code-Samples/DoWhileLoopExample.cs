using System;

namespace DoWhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {
                Console.WriteLine($"Ini adalah perulangan ke-{i}");
                i++; // Increment i setiap kali loop berjalan
            }
            while (i <= 5);
        }
    }
}