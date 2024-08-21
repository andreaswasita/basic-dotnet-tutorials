using System;

namespace ForeachExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] buah = { "Apel", "Pisang", "Jeruk" };

            foreach (string item in buah)
            {
                Console.WriteLine($"Buah: {item}");
            }
        }
    }
}