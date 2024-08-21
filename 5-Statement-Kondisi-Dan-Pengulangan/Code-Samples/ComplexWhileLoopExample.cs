using System;

namespace ComplexWhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i > 0)
            {
                Console.WriteLine($"Nilai i: {i}");
                i -= 2; // Mengurangi nilai i sebesar 2 setiap iterasi
            }
        }
    }
}