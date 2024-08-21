using System;

namespace EnumSwitchExample
{
    class Program
    {
        enum Hari { Senin

, Selasa, Rabu, Kamis, Jumat, Sabtu, Minggu }

        static void Main(string[] args)
        {
            Hari hariIni = Hari.Rabu;

            switch (hariIni)
            {
                case Hari.Senin:
                    Console.WriteLine("Awal minggu.");
                    break;
                case Hari.Rabu:
                    Console.WriteLine("Tengah minggu.");
                    break;
                case Hari.Jumat:
                    Console.WriteLine("Akhir minggu.");
                    break;
                default:
                    Console.WriteLine("Hari biasa.");
                    break;
            }
        }
    }
}