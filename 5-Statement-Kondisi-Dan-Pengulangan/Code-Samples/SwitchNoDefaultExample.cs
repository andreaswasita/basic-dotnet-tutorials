using System;

namespace SwitchNoDefaultExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulan = 8;

            switch (bulan)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Ini adalah musim dingin.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Ini adalah musim semi.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Ini adalah musim panas.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Ini adalah musim gugur.");
                    break;
            }
        }
    }
}