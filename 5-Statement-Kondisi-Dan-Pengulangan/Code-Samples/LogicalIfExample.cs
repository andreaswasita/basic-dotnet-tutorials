using System;

namespace LogicalIfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int nilai = 85;
            bool tugasSelesai = true;

            // Mengecek apakah nilai cukup dan tugas selesai
            if (nilai >= 80 && tugasSelesai)
            {
                Console.WriteLine("Anda mendapatkan nilai baik dan tugas selesai.");
            }
            else
            {
                Console.WriteLine("Anda perlu memperbaiki nilai atau menyelesaikan tugas.");
            }
        }
    }
}