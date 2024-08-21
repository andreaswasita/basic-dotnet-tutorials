using System;

namespace ComplexDoWhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine($"Nilai i: {i}");
                i -= 2; // Mengurangi nilai i sebesar 2 setiap iterasi
            }
            while (i > 0);
        }
    }
}