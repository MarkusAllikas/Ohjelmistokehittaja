using System;

namespace omanimi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei, kuka olet?");
            Console.WriteLine("(syötä nimesi)");
            string nimi = Console.ReadLine();

            Console.WriteLine("Tervetuloa " + nimi + "!"); // .
        }
    }
}
