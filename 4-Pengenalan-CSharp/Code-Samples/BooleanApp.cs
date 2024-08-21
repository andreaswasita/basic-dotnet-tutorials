using System;

namespace BooleanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEven = 4 % 2 == 0;

            if (isEven)
            {
                Console.WriteLine("Angka tersebut adalah genap.");
            }
            else
            {
                Console.WriteLine("Angka tersebut adalah ganjil.");
            }
            Console.ReadLine();
        }
    }
}