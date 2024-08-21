using System;

namespace NestedIfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int umur = 20;
            bool memilikiSIM = true;

            // Mengecek umur dan status kepemilikan SIM
            if (umur >= 18)
            {
                if (memilikiSIM)
                {
                    Console.WriteLine("Anda boleh mengemudi.");
                }
                else
                {
                    Console.WriteLine("Anda tidak boleh mengemudi tanpa SIM.");
                }
            }
            else
            {
                Console.WriteLine("Anda terlalu muda untuk mengemudi.");
            }
        }
    }
}