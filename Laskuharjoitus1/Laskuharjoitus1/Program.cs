using System;

namespace Laskuharjoitus1
{
    class Program
    {
        public static class StringConversion
        {
            static void Main()
            {

                // Lasku 1: x = y + 3;
                Console.WriteLine("Lasku 1");
                Console.WriteLine("Anna x:lle arvo");
                string x = Console.ReadLine();
                Console.WriteLine("Anna y:lle arvo");
                string y = Console.ReadLine();
                int XY1 = int.Parse(x = y);
                Console.WriteLine(XY1 += 3);
                Console.WriteLine(" ");


                // Lasku 2: x = y - 2;
                Console.WriteLine("Lasku 2");
                Console.WriteLine("Anna x:lle arvo");
                string x2 = Console.ReadLine();
                Console.WriteLine("Anna y:lle arvo");
                string y2 = Console.ReadLine();
                int XY2 = int.Parse(x2 = y2);
                Console.WriteLine(XY2 -= 2);
                Console.WriteLine(" ");


                // Lasku 3: x = y * 5;
                Console.WriteLine("Lasku 3");
                Console.WriteLine("Anna x:lle arvo");
                string x3 = Console.ReadLine();
                Console.WriteLine("Anna y:lle arvo");
                string y3 = Console.ReadLine();
                int XY3 = int.Parse(x3 = y3);
                Console.WriteLine(XY3 *= 5);
                Console.WriteLine(" ");


                // Lasku 4: x = x / y; Kesken;
                /*Console.WriteLine("Lasku 4");
                Console.WriteLine("Anna x:lle arvo");
                string x4 = Console.ReadLine();
                Console.WriteLine("Anna y:lle arvo");
                string y4 = Console.ReadLine();
                int XY4 = int.Parse(x4);
                Console.WriteLine(XY4 / y4);*/


                // Lasku 5: x = x % y;


                // Lasku 6: x += y;


                // Lasku 7: x -= y;


                // Lasku 8: x *= y*5;


                // Lasku 9: x /= y;
            }
        }
    }
}
