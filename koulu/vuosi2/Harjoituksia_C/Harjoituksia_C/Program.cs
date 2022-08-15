using System;

namespace Harjoituksia_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Harjoituksia C");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            //1. Tehtävä
            //
            //Ohjelma kysyy käyttäjältä kaksi lukua ja tulostaa ne suuruusjärjestyksessä.

            //Kysytään käyttäjältä ensimmäinen luku.
            Console.Write("Anna ensimmäinen luku:");
            int ensLuku = int.Parse(Console.ReadLine());

            //Kysytään käyttäjältä toinen luku.
            Console.Write("Anna toinen luku:");
            int toinLuku = int.Parse(Console.ReadLine());

            //if lauseke vertaa lukuja
            //Jos ensimmäinen luku on pienempi kuin toinen luku, lukujen paikat vaihdetaan tulosteessa.
            if(ensLuku < toinLuku)
            {
                Console.WriteLine("{0} > {1}", toinLuku, ensLuku);
            } else//Jos ensimmäinen luku on suurempi kuin toinen luku, luvut tulostetaan annetussa järjestyksessä.
            {
                Console.WriteLine("{0} > {1}", ensLuku, toinLuku);
            }

            //2. Tehtävä
            //
            //Ohjelma etsii suurimman luvun kolmesta annetusta luvusta ja tulostaa sen.

            //Luodaan taulu luvuille.
            int[] luvut = new int[3];

            //Kysytään käyttäjältä kolme lukua ja tallennetaan luvut tauluun.
            Console.WriteLine("Anna Kolme lukua...");
            luvut[0] = int.Parse(Console.ReadLine());
            luvut[1] = int.Parse(Console.ReadLine());
            luvut[2] = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Järjestetään luvut taulu.
            Array.Sort(luvut);

            //Tulostetaan luvut forEach lauseen avulla yksitellen.

            foreach(int i in luvut)
            {
                Console.Write("{0} ", i);
            }

            //3. Tehtävä
            //
            //Ohjelma kysyy käyttäjältä kokonaisluvun (0-9) ja tulostaa sen sanana.

            Console.Write("Anna kokonaisluku");
        }
    }
}
