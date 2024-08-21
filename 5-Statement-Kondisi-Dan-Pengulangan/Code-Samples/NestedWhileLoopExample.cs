using System;

namespace NestedWhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 3)
            {
                int j = 1;

                while (j <= 2)
                {
                    Console.WriteLine($"i: {i}, j: {j}");
                    j++;
                }

                i++;
            }
        }
    }
}