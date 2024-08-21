using System;

namespace BreakDoWhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {
                if (i == 3)
                {
                    break; // Loop akan berhenti ketika i sama dengan 3
                }
                Console.WriteLine($"Perulangan ke-{i}");
                i++;
            }
            while (i <= 5);
        }
    }
}