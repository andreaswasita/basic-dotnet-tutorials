   using Newtonsoft.Json;
   using System;

   namespace MyCLIApp
   {
       class Program
       {
           static void Main(string[] args)
           {
               var person = new { Name = "Rara Anjani", Age = 30 };
               string json = JsonConvert.SerializeObject(person);
               Console.WriteLine($"JSON: {json}");
           }
       }
   }