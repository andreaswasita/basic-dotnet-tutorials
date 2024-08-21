using System;

namespace RekursiAwal
{
    class Program
    {
        // Method rekursif dengan kondisi awal
        static void HitungMundur(int n)
        {
            if (n == 0)
                Console.WriteLine("Selesai!");
            else
            {
                Console.WriteLine(n);
                HitungMundur(n - 1); // Pemanggilan rekursif
            }
        }

        static void Main(string[] args)
        {
            int angka = 5;
            HitungMundur(angka);
        }
    }
}