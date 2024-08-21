using System;

namespace PengenalanFungsi
{
    class Program
    {
        // Method sederhana yang tidak menerima parameter dan tidak mengembalikan nilai
        static void Sapa()
        {
            Console.WriteLine("Halo, selamat datang di C#!"); // Mencetak pesan ke konsol
        }

        static void Main(string[] args)
        {
            Sapa(); // Memanggil method Sapa
        }
    }
}