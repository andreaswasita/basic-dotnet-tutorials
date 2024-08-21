using System;

namespace MethodDenganReturn
{
    class Program
    {
        // Method yang menghitung penjumlahan dua angka dan mengembalikan hasilnya
        static int Jumlahkan(int a, int b)
        {
            return a + b; // Mengembalikan hasil penjumlahan
        }

        static void Main(string[] args)
        {
            int hasil = Jumlahkan(3, 4); // Memanggil method Jumlahkan dengan dua parameter
            Console.WriteLine($"Hasil penjumlahan: {hasil}"); // Mencetak hasil
        }
    }
}