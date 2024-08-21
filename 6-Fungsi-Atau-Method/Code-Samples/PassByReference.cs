using System;

namespace PassByReference
{
    class Program
    {
        // Method yang menggunakan pass by reference
        static void UbahNilai(ref int x)
        {
            x = 10; // Mengubah nilai x
            Console.WriteLine($"Nilai dalam method: {x}"); // Mencetak nilai x dalam method
        }

        static void Main(string[] args)
        {
            int angka = 5;
            UbahNilai(ref angka); // Memanggil method dengan pass by reference
            Console.WriteLine($"Nilai setelah method: {angka}"); // Nilai asli berubah
        }
    }
}