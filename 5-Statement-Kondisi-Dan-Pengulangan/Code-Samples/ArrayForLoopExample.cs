using System;

namespace ArrayForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] angka = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < angka.Length; i++)
            {
                Console.WriteLine($"Angka: {angka[i]}");
            }
        }
    }
}