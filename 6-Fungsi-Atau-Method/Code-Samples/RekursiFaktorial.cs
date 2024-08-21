using System;

namespace RekursiFaktorial
{
    class Program
    {
        // Method rekursif untuk menghitung faktorial
        static int Faktorial(int n)
        {
            if (n == 0)
                return 1; // Basis kasus
            else
                return n * Faktorial(n - 1); // Pemanggilan rekursif
        }

        static void Main(string[] args)
        {
            int angka = 5;
            Console.WriteLine($"Faktorial dari {angka} adalah {Faktorial(angka)}");
        }
    }
}