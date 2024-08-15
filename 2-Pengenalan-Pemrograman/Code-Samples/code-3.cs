using System;

   class Program
   {
       static void Main(string[] args)
       {
           int[] nilai = { 85, 90, 78, 92, 88 };
           int total = 0;

           for (int i = 0; i < nilai.Length; i++)
           {
               total += nilai[i];
           }

           double rataRata = (double)total / nilai.Length;
           Console.WriteLine("Rata-rata nilai: " + rataRata);
       }
   }