using System;

namespace MethodMultiParameter
{
    class Program
    {
        // Method yang menghitung rata-rata dari tiga angka
        static double RataRata(double a, double b, double c)
        {
            return (a + b + c) / 3; // Mengembalikan hasil rata-rata
        }

        static void Main(string[] args)
        {
            double hasil = RataRata(5.5, 7.0, 8.5); // Memanggil method RataRata
            Console.WriteLine($"Rata-rata: {hasil}"); // Mencetak hasil
        }
    }
}