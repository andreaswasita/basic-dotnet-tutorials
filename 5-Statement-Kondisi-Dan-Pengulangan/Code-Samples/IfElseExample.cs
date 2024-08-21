using System;

namespace IfElseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int nilai = 50;

            // Mengecek apakah nilai lebih besar atau sama dengan 60
            if (nilai >= 60)
            {
                Console.WriteLine("Anda lulus!");
            }
            else
            {
                Console.WriteLine("Anda tidak lulus."); // Ini akan dieksekusi jika kondisi false
            }
        }
    }
}