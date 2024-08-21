using System;

namespace BreakWhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 5)
            {
                if (i == 3)
                {
                    break; // Loop akan berhenti ketika i sama dengan 3
                }
                Console.WriteLine($"Perulangan ke-{i}");
                i++;
            }
        }
    }
}