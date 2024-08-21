using System;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int hari = 3;

            switch (hari)
            {
                case 1:
                    Console.WriteLine("Hari ini adalah Senin.");
                    break;
                case 2:
                    Console.WriteLine("Hari ini adalah Selasa.");
                    break;
                case 3:
                    Console.WriteLine("Hari ini adalah Rabu.");
                    break;
                case 4:
                    Console.WriteLine("Hari ini adalah Kamis.");
                    break;
                case 5:
                    Console.WriteLine("Hari ini adalah Jumat.");
                    break;
                default:
                    Console.WriteLine("Hari yang Anda masukkan tidak valid.");
                    break;
            }
        }
    }
}