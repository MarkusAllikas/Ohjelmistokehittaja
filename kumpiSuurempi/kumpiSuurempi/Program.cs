using System;

namespace kumpiSuurempi
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anna yksi luku:");
            int nro1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku:");
            int nro2 = int.Parse(Console.ReadLine());
            
            //Kesken, ifelse ei toimi.
            /*if(nro1 <= nro2)
            {
                Console.Write(nro1, nro2);
            } else
            {
                Console.Write(nro2, nro1);
            }*/
        }
    }
}
