using System;

namespace MultiDimensionalForeachExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriks = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            foreach (int item in matriks)
            {
                Console.WriteLine($"Elemen matriks: {item}");
            }
        }
    }
}