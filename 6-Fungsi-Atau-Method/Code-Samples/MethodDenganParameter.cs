using System;

namespace MethodDenganParameter
{
    class Program
    {
        // Method yang menerima parameter nama
        static void Sapa(string nama)
        {
            Console.WriteLine($"Halo, {nama}! Selamat datang di C#!"); // Mencetak pesan dengan nama
        }

        static void Main(string[] args)
        {
            Sapa("Andi"); // Memanggil method Sapa dengan parameter "Andi"
            Sapa("Budi"); // Memanggil method Sapa dengan parameter "Budi"
        }
    }
}