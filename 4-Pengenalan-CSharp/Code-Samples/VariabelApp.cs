using System;

namespace VariabelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int umur = 25;
            string nama = "Budi";
            double suhu = 36.6;
            bool isValid = true;

            Console.WriteLine($"Nama: {nama}, Umur: {umur}, Suhu: {suhu}, Valid: {isValid}");
            Console.ReadLine();
        }
    }
}