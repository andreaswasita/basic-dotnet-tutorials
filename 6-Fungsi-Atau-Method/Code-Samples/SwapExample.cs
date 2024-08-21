using System;

namespace SwapExample
{
    class Program
    {
        // Method untuk menukar nilai dengan pass by reference
        static void Tukar(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int angka1 = 3;
            int angka2 = 8;

            Console.WriteLine($"Sebelum tukar: angka1 = {angka1}, angka2 = {angka2}");
            Tukar(ref angka1, ref angka2); // Memanggil method untuk menukar
            Console.WriteLine($"Setelah tukar: angka1 = {angka1}, angka2 = {angka2}");
        }
    }
}