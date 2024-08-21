using System;

namespace PerbandinganPassBy
{
    class Program
    {
        // Method pass by value
        static void PassByValue(int x)
        {
            x = 10;
        }

        // Method pass by reference
        static void PassByReference(ref int x)
        {
            x = 10;
        }

        static void Main(string[] args)
        {
            int angka1 = 5;
            int angka2 = 5;

            PassByValue(angka1); // Pass by value
            PassByReference(ref angka2); // Pass by reference

            Console.WriteLine($"Pass by value: {angka1}"); // Nilai tidak berubah
            Console.WriteLine($"Pass by reference: {angka2}"); // Nilai berubah
        }
    }
}