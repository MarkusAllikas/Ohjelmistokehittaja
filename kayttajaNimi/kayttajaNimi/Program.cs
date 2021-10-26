using System;

namespace kayttajaNimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, kuka olet?");
            string nimi = Console.ReadLine();
            Console.WriteLine("Hei " + nimi + ", Tervetuloa!");
        }
    }
}
