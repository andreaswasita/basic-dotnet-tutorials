using System;

namespace BreakForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    break; // Loop akan berhenti ketika i sama dengan 3
                }
                Console.WriteLine($"Perulangan ke-{i}");
            }
        }
    }
}