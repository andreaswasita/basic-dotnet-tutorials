using System;

namespace OperasiMatematikaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

            int penjumlahan = a + b;
            int pengurangan = a - b;
            int perkalian = a * b;
            double pembagian = (double)a / b;

            Console.WriteLine($"Penjumlahan: {penjumlahan}, Pengurangan: {pengurangan}, Perkalian: {perkalian}, Pembagian: {pembagian}");
            Console.ReadLine();
        }
    }
}