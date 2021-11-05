using System;

namespace ehtolauseet1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä 1:
            // Kirjoita ehtolause, joka pyytää käyttäjältä kahta kokonaislukuarvoa
            // ja vaihtaa niiden paikkaa, mikäli ensimmäinen on suurempi kuin toinen
            // (eli tulostaa suuruusjärj.)

            Console.WriteLine("Tehtävä 1: ");
            Console.WriteLine("Sinulta kysytään 2 lukua ja sitten ne tulostetaan suuruusjärjestyksessä");
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
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            // Tehtävä 2:
            // Kirjoita ohjelma, joka etsii suurimman kolmesta kokonaisluvusta

            Console.WriteLine("Tehtävä 2: ");
            Console.WriteLine("Sinulta kysytään 3 kokonaislukua ja sitten sulle kerrotaan mikä niistä oli isoin luku.");
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
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            // Tehtävä 3:
            // Kirjoita ohjelma, joka pyytää kokonaislukua (0-9)
            // ja riippuen annetusta luvusta, tulostaa sen sanana.
            // Käytä switch komentoa

            Console.WriteLine("Tehtävä 3: ");
            Console.WriteLine("Sinulta kysytään numero 0-9 ja sitten ohjelma tulostaa sen sanana.");
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
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            // Tehtävä 4:
            // Kirjoita ohjelma, joka etsii suurimman annetuista 5 kokonaisluvusta

            Console.WriteLine("Tehtävä 4: ");
            Console.WriteLine("Sinulta kysytään viisi kokonaislukua yksi kerrallaan ja lopulta ohjelma kertoo mikä luku niistä oli isoin.");
            Console.WriteLine("Syötä 1. kokonaisluku: ");
            int koko1 = int.Parse(Console.ReadLine());
            int suuurin = koko1;
            Console.WriteLine("Syötä 2. kokonaisluku: ");
            int koko2 = int.Parse(Console.ReadLine());
            if (koko2 > suuurin) { suuurin = koko2; }
            Console.WriteLine("Syötä 3. kokonaisluku: ");
            int koko3 = int.Parse(Console.ReadLine());
            if (koko3 > suuurin) { suuurin = koko3; }
            Console.WriteLine("Syötä 4. kokonaisluku: ");
            int koko4 = int.Parse(Console.ReadLine());
            if (koko4 > suuurin) { suuurin = koko4; }
            Console.WriteLine("Syötä 5. kokonaisluku: ");
            int koko5 = int.Parse(Console.ReadLine());
            if (koko5 > suuurin) { suuurin = koko5; }
            Console.WriteLine("Suurin syötetty kokonaisluku on " + suuurin);
            Console.WriteLine(" ");
            Console.WriteLine(" ");




            // Tehtävä 5: Kirjoita ohjelma, joka kysyy käyttäjältä,
            // mitä käyttäjä haluaa syöttää (kokonaisluvun, double-luvun tai merkkijonon).
            // Mikäli käyttäjä haluaa syöttää luvun, ohjelma kasvattaa lukua yhdellä.
            // Mikäli merkkijonon, ohjelma lisää loppuun *-merkin
            // ja tulostaa tämän jälkeen vastauksen konsoliin.
            // Käytä Switch komentoa


            Console.WriteLine("Tehtävä 5: ");
            Console.WriteLine("Hei!");
            Console.WriteLine("Haluatko syöttää 1:kokonaisluvun, 2:desimaaliluvun vai 3:merkkijonon?");
            Console.WriteLine("Kerro numerolla(1-3): ");
            string qq = Console.ReadLine();
            zzz:
            switch (qq)
            {
                case "1":
                    Console.WriteLine("Syötä kokonaisluku: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Syötit luvun: " + num1 + ", Kasvatin lukuasi yhdellä, se on nyt: " + (num1 + 1));
                    break;

                case "2":
                    Console.WriteLine("Syötä desimaaliluku: ");
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Syötit luvun: " + num2 + ", Kasvatin lukuasi yhdellä, se on nyt: " + (num2 + 1));
                    break;

                case "3":
                    Console.WriteLine("Kirjoita jotain: ");
                    string tecksti1 = Console.ReadLine();
                    Console.WriteLine("Kirjoitit: '" + tecksti1 + "', lisäsin sen loppuun '*'-merkin, lopputulos: " + tecksti1 + "*");
                    break;

                default:
                    Console.WriteLine("Virheellinen syöte, anna numero 1-3");
                    qq = Console.ReadLine();
                    goto zzz;

            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            // Tehtävä 6:
            // Kirjoita ohjelma, joka kasvattaa bonuspisteitä seuraavasti:
            // Jos pisteet ovat välillä 1-3, ohjelma kertoo pisteet 10:llä.
            // Mikäli pisteet ovat välillä 4-6, ohjelma kertoo pisteet 100:lla
            // ja mikäli pisteet ovat välillä 7-9 ohjelma kertoo pisteet 1000:lla.
            // Mikäli pisteitä on 0 tai yli 9, ohjelma tulostaa virheviestin.

            Console.WriteLine("Tehtävä 6: ");
            Console.WriteLine("Sinulta pyydetään numeroa 1-9, jonka perusteella ohjelma kertoo bonuspisteesi määrän. "); //ohjeet
            Console.WriteLine("Syötä numero 1-9: ");
            int bonus = int.Parse(Console.ReadLine());
        bnous:
            switch (bonus)
            {
                case 1:
                case 2:
                case 3:
                    bonus = bonus * 10;
                    Console.WriteLine("Sinulla on " + bonus + " bonuspistettä");
                    break;
                case 4:
                case 5:
                case 6:
                    bonus = bonus * 100;
                    Console.WriteLine("Sinulla on " + bonus + " bonuspistettä");
                    break;
                case 7:
                case 8:
                case 9:
                    bonus = bonus * 1000;
                    Console.WriteLine("Sinulla on " + bonus + " bonuspistettä");
                    break;
                default:
                    Console.WriteLine("Virheellinen syöttö, syötä numero 1-9.");
                    bonus = int.Parse(Console.ReadLine());
                    goto bnous;
                    break;
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            // Tehtävä 7:
            // Kirjoita ohjelma, joka muuttaa numerot (0 – 999) sanoiksi.
            // Esim. 0 -> Nolla
            // 12 -> Kaksitoista
            // 98 -> Yhdeksänkymmentä kahdeksan
            // 273 -> Kaksisataa seitsemänkymmentä kolme

            Console.WriteLine("Tehtävä 7:");
            string lopp = "Lukusi kirjaimina:  ";
            Console.WriteLine("Syötä kokonaisluku väliltä 1-999");
            string luku = Console.ReadLine();
            int pikkus = luku.Length;
            if (pikkus == 3)
            {
                lopp += sata(luku[0]);
                if (luku[1] == '1')
                {
                    lopp += teist(luku[2]);
                }
                else
                {
                    lopp += kumme(luku[1]);
                    lopp += uks(luku[2]);
                }
            }
            else if (pikkus == 2)
            {
                if(luku[0] == '1')
                {
                    lopp += teist(luku[1]);
                }
                else
                {
                    lopp += kumme(luku[0]);
                    lopp += uks(luku[1]);
                }
            }
            else
            {
                lopp += uks(luku[0]);
            }

            Console.WriteLine(lopp);
            static string sata(int nmbr)
            {
                switch(nmbr)
                {
                    case '1':
                        return "sata";
                    case '2':
                        return "kaksisataa";
                    case '3':
                        return "kolmesataa";
                    case '4':
                        return "neljäsataa";
                    case '5':
                        return "viisisataa";
                    case '6':
                        return "kuusisataa";
                    case '7':
                        return "seitsemänsataa";
                    case '8':
                        return "kahdeksansataa";
                    case '9':
                        return "yhdeksänsataa";
                    default:
                        return " ";
                }
            }

            static string kumme(int nmbr)
            {
                switch(nmbr)
                {
                    case '1':
                        return "kymmenen";
                    case '2':
                        return "kaksikymmentä";
                    case '3':
                        return "kolmekymmentä";
                    case '4':
                        return "neljäkymmentä";
                    case '5':
                        return "viisikymmentä";
                    case '6':
                        return "kuusikymmentä";
                    case '7':
                        return "seitsemänkymmentä";
                    case '8':
                        return "kahdeksankymmentä";
                    case '9':
                        return "yhdeksänkymmentä";
                    default:
                        return " ";
                }
            }

            static string uks(int nmbr)
            {
                switch (nmbr)
                {
                    case '1':
                        return "yksi";
                    case '2':
                        return "kaksi";
                    case '3':
                        return "kolme";
                    case '4':
                        return "neljä";
                    case '5':
                        return "viisi";
                    case '6':
                        return "kuusi";
                    case '7':
                        return "seitsemän";
                    case '8':
                        return "kahdeksan";
                    case '9':
                        return "yhdeksän";
                    default:
                        return " ";
                }
            }

            static string teist(int nmbr)
            {
                switch (nmbr)
                {
                    case '1':
                        return "yksitoista";
                    case '2':
                        return "kaksitoista";
                    case '3':
                        return "kolmetoista";
                    case '4':
                        return "neljätoista";
                    case '5':
                        return "viisitoista";
                    case '6':
                        return "kuusitoista";
                    case '7':
                        return "seitsemäntoista";
                    case '8':
                        return "kahdeksantoista";
                    case '9':
                        return "yhdeksäntoista";
                    default:
                        return " ";
                }
            }


        }
    }
}
