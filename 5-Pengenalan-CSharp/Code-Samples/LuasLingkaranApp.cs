using System;

namespace LuasLingkaranApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan jari-jari lingkaran: ");
            double jariJari = double.Parse(Console.ReadLine());

            double luas = Math.PI * jariJari * jariJari;
            Console.WriteLine($"Luas lingkaran: {luas}");
            Console.ReadLine();
        }
    }
}