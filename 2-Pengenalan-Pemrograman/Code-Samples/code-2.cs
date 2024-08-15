using System;
   using System.Timers;

   class Program
   {
       static void Main(string[] args)
       {
           Timer timer = new Timer(5000); // Set timer to trigger every 5 seconds
           timer.Elapsed += SendEmail;
           timer.Start();

           Console.WriteLine("Press Enter to exit...");
           Console.ReadLine();
       }

       private static void SendEmail(object source, ElapsedEventArgs e)
       {
           Console.WriteLine("Email sent at: " + DateTime.Now);
           // Logic to send email
       }
   }