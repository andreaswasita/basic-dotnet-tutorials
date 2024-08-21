using System;

namespace KalkulatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            int num2 = int.Parse(Console.ReadLine());

            int hasil = num1 + num2;
            Console.WriteLine($"Hasil penjumlahan: {hasil}");
            Console.ReadLine();
        }
    }
}