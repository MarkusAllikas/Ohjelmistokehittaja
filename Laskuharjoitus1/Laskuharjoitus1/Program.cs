using System;

namespace Laskuharjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            // lasku 1: x = y + 3;
             Console.WriteLine("1. lasku");
             Console.WriteLine("Syötä yksi luku:");
             int x = int.Parse(Console.ReadLine());
             Console.WriteLine("Syötä toinen luku:");
             int y = int.Parse(Console.ReadLine());
             Console.WriteLine("x = " + (x = y + 3));

            // lasku 2: x = y - 2;
            Console.WriteLine("2. lasku");
            Console.WriteLine("Syötä yksi luku: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (x2 = y2 - 2));

            //lasku 3: x = y * 5;
            Console.WriteLine("3. lasku");
            Console.WriteLine("Syötä yksi luku: ");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku");
            int y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (x3 = y3 * 5));

            //lasku 4: x = x / y;
            Console.WriteLine("4. lasku");
            Console.WriteLine("Syötä yksi luku");
            double x4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku");
            double y4 = double.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (x4 / y4));

            //lasku 5: x = x % y;
            Console.WriteLine("5. lasku");
            Console.WriteLine("Syötä yksi luku");
            double x5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku");
            double y5 = double.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (x5 % y5));

            //lasku 6: x += y;
            Console.WriteLine("6. lasku");
            Console.WriteLine("Syötä yksi luku");
            int x6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku");
            int y6 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (x6 += y6));

            //lasku 7: x -= y;
            Console.WriteLine("7. lasku");
            Console.WriteLine("Syötä yksi luku");
            int x7 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku");
            int y7 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (x7 -= y7));

            //lasku 8: x *= y*5;
            Console.WriteLine("8. lasku");
            Console.WriteLine("Syötä yksi luku");
            int x8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä toinen luku");
            int y8 = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (x8 *= y8 * 5));

            //lasku 9: x /= y;
            Console.WriteLine("9. lasku");
            Console.WriteLine("Syötä yksi luku");
            double x9 = double.Parse(Console.ReadLine());  
            Console.WriteLine("Syötä toinen luku");
            double y9 = double.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (x9 /= y9)); //.

        }
    }
}
