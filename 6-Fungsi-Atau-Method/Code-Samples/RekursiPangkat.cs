using System;

namespace RekursiPangkat
{
    class Program
    {
        // Method rekursif untuk menghitung pangkat
        static int Pangkat(int a, int b)
        {
            if (b == 0)
                return 1; // Basis kasus
            else
                return a * Pangkat(a, b - 1); // Pemanggilan rekursif
        }

        static void Main(string[] args)
        {
            int angka = 2;
            int pangkat = 3;
            Console.WriteLine($"{angka} pangkat {pangkat} adalah {Pangkat(angka, pangkat)}");
        }
    }
}