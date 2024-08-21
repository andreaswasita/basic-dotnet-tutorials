using System;

namespace DoWhileUserInputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.WriteLine("Masukkan perintah ('keluar' untuk berhenti): ");
                input = Console.ReadLine();
            }
            while (input != "keluar");
        }
    }
}