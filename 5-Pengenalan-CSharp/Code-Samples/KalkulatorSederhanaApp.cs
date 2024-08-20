using System;

namespace KalkulatorSederhanaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka pertama: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Pilih operasi (+, -, *, /): ");
            char operasi = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int hasil = 0;
            switch (operasi)
            {
                case '+':
                    hasil = num1 + num2;
                    break;
                case '-':
                    hasil = num1 - num2;
                    break;
                case '*':
                    hasil = num1 * num2;
                    break;
                case '/':
                    hasil = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Operasi tidak valid.");
                    return;
            }

            Console.WriteLine($"Hasil: {hasil}");
            Console.ReadLine();
        }
    }
}