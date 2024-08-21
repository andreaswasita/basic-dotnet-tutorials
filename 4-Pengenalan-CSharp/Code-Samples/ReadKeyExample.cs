using System;

namespace ReadKeyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tekan sembarang tombol: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine($"\nAnda menekan tombol: {keyInfo.KeyChar}");
        }
    }
}