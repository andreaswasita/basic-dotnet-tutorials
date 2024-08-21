using System;
using System.Collections.Generic;

namespace ForeachListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> angka = new List<int> { 10, 20, 30 };

            foreach (int item in angka)
            {
                Console.WriteLine($"Angka: {item}");
            }
        }
    }
}