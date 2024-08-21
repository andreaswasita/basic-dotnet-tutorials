using System;

namespace ConditionalForeachExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] angka = { 1, 2, 3, 4, 5 };

            foreach (int item in angka)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"Angka genap: {item}");
                }
            }
        }
    }
}