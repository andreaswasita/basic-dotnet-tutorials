using System;

namespace KategoriUmurApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umur Anda: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur < 18)
            {
                Console.WriteLine("Anda termasuk kategori remaja.");
            }
            else
            {
                Console.WriteLine("Anda termasuk kategori dewasa.");
            }
            Console.ReadLine();
        }
    }
}