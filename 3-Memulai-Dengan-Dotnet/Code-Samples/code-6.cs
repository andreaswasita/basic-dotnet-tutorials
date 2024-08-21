 using System;

   namespace MyCLIApp
   {
       class Program
       {
           static void Main(string[] args)
           {
               Console.WriteLine("Hallo, Dunia CLI!");

               // Contoh sederhana menggunakan array dan loop di C#
               string[] fruits = { "Apel", "Pisang", "Nanas","Jeruk" };
               foreach (string fruit in fruits)
               {
                   Console.WriteLine(fruit);
               }
           }
       }
   }