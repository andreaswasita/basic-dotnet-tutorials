using System;

namespace PenjumlahanInputApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            int angka1 = int.Parse(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            int angka2 = int.Parse(Console.ReadLine());

            int hasil = angka1 + angka2;
            Console.WriteLine($"Hasil penjumlahan: {hasil}");
            Console.ReadLine();
        }
    }
}