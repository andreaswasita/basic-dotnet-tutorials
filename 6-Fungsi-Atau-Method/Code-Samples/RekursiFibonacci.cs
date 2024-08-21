using System;

namespace RekursiFibonacci
{
    class Program
    {
        // Method rekursif untuk menghitung bilangan Fibonacci
        static int Fibonacci(int n)
        {
            if (n == 0)
                return 0; // Basis kasus
            else if (n == 1)
                return 1; // Basis kasus
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2); // Pemanggilan rekursif
        }

        static void Main(string[] args)
        {
            int angka = 6;
            Console.WriteLine($"Bilangan Fibonacci ke-{angka} adalah {Fibonacci(angka)}");
        }
    }
}