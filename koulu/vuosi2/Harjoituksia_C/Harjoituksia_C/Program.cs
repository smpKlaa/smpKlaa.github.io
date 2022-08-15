using System;
using System.Linq;

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
            if (ensLuku < toinLuku)
            {
                Console.WriteLine("{0} > {1}", toinLuku, ensLuku);
            } else//Jos ensimmäinen luku on suurempi kuin toinen luku, luvut tulostetaan annetussa järjestyksessä.
            {
                Console.WriteLine("{0} > {1}", ensLuku, toinLuku);
            }
            Console.WriteLine();

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

            //Tulostetaan taulun syyrin numero
            Console.WriteLine("Antamistasi luvuista suurin on {0}", luvut.Max());
            Console.WriteLine();

            //3. Tehtävä
            //
            //Ohjelma kysyy käyttäjältä kokonaisluvun (0-9) ja tulostaa sen sanana.

            //Kysytään käyttäjältä luku ja tallennetaan luku muuttujaan.
            Console.Write("Anna kokonaisluku 0-9 väliltä: ");
            int luku = int.Parse(Console.ReadLine());

            //Switch lause tarkistaa mikä luku on annettu
            switch (luku)
            {
                case 0://Jokaiselle luvulle on annettu oma case joka sisältää komennon tulostaa oikea sana.
                    Console.WriteLine("Nolla");
                    break;

                case 1:
                    Console.WriteLine("Yksi");
                    break;

                case 2:
                    Console.WriteLine("Kaksi");
                    break;

                case 3:
                    Console.WriteLine("Kolme");
                    break;

                case 4:
                    Console.WriteLine("Neljä");
                    break;

                case 5:
                    Console.WriteLine("Viisi");
                    break;

                case 6:
                    Console.WriteLine("Kuusi");
                    break;

                case 7:
                    Console.WriteLine("Seitsemän");
                    break;

                case 8:
                    Console.WriteLine("Kahdeksan");
                    break;

                case 9:
                    Console.WriteLine("Yhdeksän");
                    break;

                default://Jos syöte ei ole 0-9 tulostetaan virheilmoitus.
                    Console.WriteLine("Virhe syötteessä.");
                    break;
            }
            Console.WriteLine();

            //4. Tehtävä
            //
            //Ohjelma etsii suurimman luvun viidestä annetusta luvusta ja tulostaa sen.

            //Luodaan taulu luvuille.
            int[] luvut2 = new int[5];

            //Kysytään käyttäjältä viisi lukua
            Console.WriteLine("Anna viisi lukua...");

            //Käyttäjän syöte tallennetaan tauluun Foreach lauseen avulla.
            int j = 0;//luodaan muuttuja jonka arvo nousee joka foreach-lauseen toistolla.
            foreach (int i in luvut2)
            {
                luvut2[j] = int.Parse(Console.ReadLine());
                j++;
            }
            Console.WriteLine();

            //Tulostetaan taulun syyrin numero
            Console.WriteLine("Antamistasi luvuista suurin on {0}", luvut2.Max());
            Console.WriteLine();

            //5. Tehtävä
            //
            //kysyy käyttäjältä, mitä käyttäjä haluaa syöttää (kokonaisluvun, 
            //double-luvun tai merkkijonon). Mikäli käyttäjä haluaa syöttää luvun, ohjelma
            //kasvattaa lukua yhdellä. Mikäli merkkijonon, ohjelma lisää loppuun *-merkin ja
            //tulostaa tämän jälkeen vastauksen konsoliin. 

            //Kysytään syöttömuoto
            Console.WriteLine("Valitse syötön tyyppi:");
            Console.WriteLine("-Kokonaisluku(k)");
            Console.WriteLine("-Double-luku(d)");
            Console.WriteLine("-Merkkijono(m)");
            string syottoTapa = Console.ReadLine();//Tallennetaan valittu syöttömuoto muuttujaan.
            Console.WriteLine();

            //Verrataan muuttujan arvoa switch-lauseella ja valitaan oikea syöttömuoto.
            switch (syottoTapa)
            {
                case "k"://Jos syöttömuodoksi valitaan kokonaisluku, Kysytään käyttäjältä kokonaisluku.
                    Console.WriteLine("Kokonaisluku valittu");
                    Console.WriteLine();

                    Console.Write("Syötä kokonaisluku: ");
                    int kSyote = int.Parse(Console.ReadLine());//Syöte tallennetaan kokonaislukuna.

                    Console.WriteLine(kSyote + 1);//Annettuun kokonaislukuun lisätään yksi ja summa tulostetaan.
                    break;

                case "d"://Jos syöttömuodoksi valitaan double-luku, Kysytään käyttäjältä double-luku.
                    Console.WriteLine("Double-luku valittu");
                    Console.WriteLine();

                    Console.Write("Syötä double-luku: ");
                    double dSyote = double.Parse(Console.ReadLine());//Syöte tallennetaan doublena.

                    Console.WriteLine(dSyote + 1);//Annettuun lukuun lisätään yksi ja summa tulostetaan.
                    break;

                case "m"://Jos syöttömuodoksi valitaan merkkijono, Kysytään käyttäjältä merkkijonoa.
                    Console.WriteLine("Merkkijono valittu");
                    Console.WriteLine();

                    Console.Write("Syötä merkkijono: ");
                    string mSyote = Console.ReadLine();//Syöte tallennetaan merkkijonona

                    Console.WriteLine(mSyote + "*");//Syötettyn merkkijonon perään lisätään *-merkki ja merkkijono tulostetaan.
                    break;
            }
            Console.WriteLine();

            //6.Tehtävä
            //
            //Ohjelma kasvattaa bonuspisteitä seuraavasti: Jos pisteet ovat välillä 1-
            //3, ohjelma kertoo pisteet 10:llä.Mikäli pisteet ovat välillä 4 - 6, ohjelma kertoo pisteet
            //100:lla ja mikäli pisteet ovat välillä 7 - 9 ohjelma kertoo pisteet 1000:lla.Mikäli
            //pisteitä on 0 tai yli 9, ohjelma tulostaa virheviestin

            //Kysytään käyttäjältä pisteitä
            Console.Write("syötä pisteet :");
            int pisteetSyote = int.Parse(Console.ReadLine());//Tallennetaan käyttäjän syöte kokonaislukuna.

            //Switch lause vertaa annettua lukua ja valitsee oikean toiminnon.
            switch (pisteetSyote)
            {
                //Luvun ollessa 1-3 pisteet kerrotaan kymmenellä ja tulos tulostetaan.
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(pisteetSyote * 10);
                    break;

                //Luvun ollessa 4-6 pisteet kerrotaan sadalla ja tulos tulostetaan.
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(pisteetSyote * 100);
                    break;

                //Luvun ollessa 7-9 pisteet kerrotaan tuhannella ja tulos tulostetaan.
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(pisteetSyote * 1000);
                    break;

                //Luvun ollessa 0 tai yli 9 tulostetaan virheilmoitus.
                default:
                    Console.WriteLine("Virhe syötteessä.");
                    break;
            }
            Console.WriteLine();

            //7. Tehtävä
            //
            //Ohjelma tulostaa kokonaisluvun (0-999) sanoina.

            //Kysytään käyttäjältä kokonaislukua (0-999)
            Console.Write("Syötä kokonaisluku (0-999): ");
            string syote = Console.ReadLine();//Tallennetaan syöte merkkisarjana.

            //luodaan muuttujat
            int syoteLgt = syote.Length;//syoteLgt vähentää kirjoittamisen määrää.
            string tuloste = "";//Luodaan lopullinen tuloste tyhjänä merkkisarjana johon voidaan lisätä sanoja.

            //Luodaan boolean muuttujia suomenkielen monimutkaisuuden takia.
            bool sata = false;
            bool toista = false;
            bool kymmenen = false;

            //Käydään syöte läpi yksi numero kerrallaan.
            foreach (int numero in syote)
            {
                //valitaan numero.
                switch (numero)
                {
                    case '2':
                        tuloste = tuloste += "kaksi";
                        break;

                    case '3':
                        tuloste = tuloste += "kolme";
                        break;

                    case '4':
                        tuloste = tuloste += "neljä";
                        break;

                    case '5':
                        tuloste = tuloste += "viisi";
                        break;

                    case '6':
                        tuloste = tuloste += "kuusi";
                        break;

                    case '7':
                        tuloste = tuloste += "seitsemän";
                        break;

                    case '8':
                        tuloste = tuloste += "kahdeksan";
                        break;

                    case '9':
                        tuloste = tuloste += "yhdeksän"; ;
                        break;
                }
                //If lausekkeet tarkistavat millä paikalla numero on ja lisää sataa,sata,kymmentä tai kymmenen sanan perään.
                if (syoteLgt > 2 && numero == syote[syoteLgt - 3] && numero != '1' && sata == false)
                {
                    tuloste = tuloste += "sataa ";
                    sata = true;
                } else if (syoteLgt > 2 && numero == '1' && numero == syote[syoteLgt - 3] && sata == false)
                {
                    tuloste = "sata ";
                    sata = true;
                }
                else if (syoteLgt > 1 && syote[syoteLgt - 1] != '0' && syote[syoteLgt - 2] == '1')
                {
                    toista = true;
                    kymmenen = true;
                }else if (syoteLgt > 1 && syote[syoteLgt - 2] == '1' && numero == syote[syoteLgt - 2] && kymmenen == false)
                {
                    tuloste += "kymmenen";
                    kymmenen = true;
                }
                else if (syoteLgt > 1 && numero == syote[syoteLgt - 2] && syote[syoteLgt-2] != '0' &&  kymmenen == false)
                {
                    tuloste = tuloste += "kymmentä ";
                    kymmenen = true;
                }
            }
            //If lauseke lisää mahdollisen ykkösen.
            if (syote[syoteLgt-1] == '1')
            {
                tuloste += "yksi";
            }
            //If lauseke lisää "toista" sanan tarpeen tullen.
            if (toista)
            {
                tuloste += "toista";
            }
            //Lopullinen tuloste tulostetaan käyttäjälle.
            Console.WriteLine(tuloste);
        }
    }
}
