using System;

namespace MultipleCaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka = 2;

            switch (angka)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Angka yang Anda masukkan adalah kecil.");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Angka yang Anda masukkan adalah sedang.");
                    break;
                default:
                    Console.WriteLine("Angka yang Anda masukkan adalah besar.");
                    break;
            }
        }
    }
}