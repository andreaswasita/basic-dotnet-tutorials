   using System;

   namespace MyFirstConsoleApp
   {
       class Program
       {
           static void Main(string[] args)
           {
               Console.WriteLine("Selamat datang di .NET 8!");

               // Contoh menggunakan pengkondisian sederhana di C#
               Console.Write("Masukkan umur anda: ");
               int age = int.Parse(Console.ReadLine());

               if (age >= 18)
               {
                   Console.WriteLine("Anda sudah dewasa.");
               }
               else
               {
                   Console.WriteLine("Anda belum dewasa.");
               }
           }
       }
   }