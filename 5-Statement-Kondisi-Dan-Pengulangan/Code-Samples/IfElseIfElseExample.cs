using System;

namespace IfElseIfElseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int nilai = 85;

            // Mengecek nilai untuk memberikan grade
            if (nilai >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (nilai >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if (nilai >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade D");
            }
        }
    }
}