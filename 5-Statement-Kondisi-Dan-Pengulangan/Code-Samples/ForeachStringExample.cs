using System;

namespace ForeachStringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string kata = "Halo";

            foreach (char huruf in kata)
            {
                Console.WriteLine($"Huruf: {huruf}");
            }
        }
    }
}