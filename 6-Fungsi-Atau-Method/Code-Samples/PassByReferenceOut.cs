using System;

namespace PassByReferenceOut
{
    class Program
    {
        // Method yang menggunakan out
        static void Hitung(out int hasil)
        {
            hasil = 25; // Menginisialisasi nilai hasil
        }

        static void Main(string[] args)
        {
            int angka;
            Hitung(out angka); // Memanggil method dengan out
            Console.WriteLine($"Nilai dari method: {angka}"); // Nilai asli diubah
        }
    }
}