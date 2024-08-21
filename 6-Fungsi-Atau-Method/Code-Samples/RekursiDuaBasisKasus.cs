using System;

namespace RekursiDuaBasisKasus
{
    class Program
    {
        // Method rekursif dengan dua basis kasus
        static int GanjilGenap(int n)
        {
            if (n == 0)
                return 0; // Basis kasus ganjil
            else if (n == 1)
                return 1; // Basis kasus genap
            else
                return GanjilGenap(n - 2); // Pemanggilan rekursif
        }

        static void Main(string[] args)
        {
            int angka = 5;
            Console.WriteLine($"Ganjil/Genap dari {angka} adalah {GanjilGenap(angka)}");
        }
    }
}