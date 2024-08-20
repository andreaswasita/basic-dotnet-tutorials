using System;

namespace DeretBilanganGanjilApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deret bilangan ganjil dari 1 hingga 10:");
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}