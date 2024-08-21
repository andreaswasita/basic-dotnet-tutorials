using System;

namespace PassByValue
{
    class Program
    {
        // Method yang menggunakan pass by value
        static void UbahNilai(int x)
        {
            x = 10; // Mengubah nilai x
            Console.WriteLine($"Nilai dalam method: {x}"); // Mencetak nilai x dalam method
        }

        static void Main(string[] args)
        {
            int angka = 5;
            UbahNilai(angka); // Memanggil method dengan pass by value
            Console.WriteLine($"Nilai setelah method: {angka}"); // Nilai asli tidak berubah
        }
    }
}