using System;

namespace NestedForLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine($"i: {i}, j: {j}");
                }
            }
        }
    }
}