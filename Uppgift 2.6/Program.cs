using System;

namespace uppgift_2._6
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening med tre ord.");
            string mening = Console.ReadLine();
            int mellanslag1 = mening.IndexOf(" ");
            int mellanslag2 = mening.IndexOf(" ",mellanslag1 + 1);
            int punkt = mening.IndexOf(".");
            string ord1 = mening[..mellanslag1];
            string ord2 = mening[(mellanslag1 + 1)..mellanslag2];
            string ord3 = mening[(mellanslag2 + 1)..punkt];
            Console.WriteLine(ord3 + " " + ord1 + " " + ord2 + ".");

            Console.ReadKey();
        }
    }
}