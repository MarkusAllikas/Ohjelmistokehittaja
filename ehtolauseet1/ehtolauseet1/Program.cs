using System;

namespace ehtolauseet1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä 1: Ehtolause, joka vertaa kahta annettua lukua ja tulostaa ne suuruusjärjestyksessä
            Console.WriteLine("Tehtävä 1");
            Console.WriteLine("Anna yksi luku");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku");
            int y1 = int.Parse(Console.ReadLine());
            if (x1 < y1)
            {
                Console.WriteLine("Suuruusjärjestyksessä: " + x1 + " " + y1);
            } else
            {
                Console.WriteLine("Suuruusjärjestyksessä: " + y1 + " , " + x1);
            }


            // Tehtävä 2: Kysyy 3 lukua ja tulostaa niistä isoimman.
            Console.WriteLine("Tehtävä 2");
            Console.WriteLine("Anna yksi luku");
            int x2 = int.Parse(Console.ReadLine());
            int isoin = x2;
            Console.WriteLine("Anna toinen luku");
            int y2 = int.Parse(Console.ReadLine());
            if (y2 > x2) 
            { 
                isoin = y2;
            }
            Console.WriteLine("Anna kolmas luku");
            int z2 = int.Parse(Console.ReadLine());
            if (z2 > y2 && z2 > x2)
            { 
                isoin = z2;
            }
            Console.WriteLine("Isoin luku: " + isoin);


            // Tehtävä 3: Kysyy luvun 0-9 ja riippuen luvusta tulostaa sen sanana.
            Console.WriteLine("Tehtävä 3");
            Console.WriteLine("Anna numero 0-9");
            string nro09 = Console.ReadLine();
            switch(nro09)
            {
                case "0":
                    Console.WriteLine("nolla");
                    break;
                case "1":
                    Console.WriteLine("yksi");
                    break;
                case "2":
                    Console.WriteLine("kaksi");
                    break;
                case "3":
                    Console.WriteLine("kolme");
                    break;
                case "4":
                    Console.WriteLine("neljä");
                    break;
                case "5":
                    Console.WriteLine("viisi");
                    break;
                case "6":
                    Console.WriteLine("kuusi");
                    break;
                case "7":
                    Console.WriteLine("seitsemän");
                    break;
                case "8":
                    Console.WriteLine("kahdeksan");
                    break;
                case "9":
                    Console.WriteLine("yhdeksän");
                    break;
                default:
                    Console.WriteLine("Syöttö ei kelpaa. Anna numero 0 - 9");
                    break;
            }

            // Tehtävä 4: Ohjelma kysyy 5 kokonaislukua ja kertoo mikä on isoin.
            //keskeN  
        }
    }
}
