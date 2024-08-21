using System;

namespace WhileUserInputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while (input != "keluar")
            {
                Console.WriteLine("Masukkan perintah ('keluar' untuk berhenti): ");
                input = Console.ReadLine();
            }
        }
    }
}