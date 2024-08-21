using System;

namespace SwitchStringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string warna = "merah";

            switch (warna)
            {
                case "merah":
                    Console.WriteLine("Warna favorit Anda adalah merah.");
                    break;
                case "biru":
                    Console.WriteLine("Warna favorit Anda adalah biru.");
                    break;
                case "hijau":
                    Console.WriteLine("Warna favorit Anda adalah hijau.");
                    break;
                default:
                    Console.WriteLine("Warna tidak dikenali.");
                    break;
            }
        }
    }
}