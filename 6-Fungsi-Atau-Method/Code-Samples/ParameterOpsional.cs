using System;

namespace ParameterOpsional
{
    class Program
    {
        // Method dengan parameter opsional
        static void Perkenalan(string nama, int umur = 18)
        {
            Console.WriteLine($"Halo, nama saya {nama} dan saya berumur {umur} tahun."); // Mencetak perkenalan
        }

        static void Main(string[] args)
        {
            Perkenalan("Andi"); // Memanggil method dengan parameter default
            Perkenalan("Budi", 25); // Memanggil method dengan parameter yang diberikan
        }
    }
}