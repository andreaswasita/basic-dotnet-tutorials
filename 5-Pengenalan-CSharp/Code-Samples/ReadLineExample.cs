using System;

namespace ReadLineExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();
            Console.WriteLine($"Halo, {nama}!");
        }
    }
}