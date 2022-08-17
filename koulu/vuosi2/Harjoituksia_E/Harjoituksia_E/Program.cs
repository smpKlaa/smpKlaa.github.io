using System;

namespace Harjoituksia_E
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Harjoituksia E");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            //11.Tehtävä
            //
            //Ohjelma kysyy käyttäjän ikää ja tulostaa kehun iän kanssa.

            Console.WriteLine("---11.Ikä---");

            //Käyttäjää pyydetään syöttämään ikänsä.
            Console.Write("Syötä ikäsi: ");//Syöte tallennetaan kokonaislukuna muuttujaan.
            int ika = int.Parse(Console.ReadLine());

            //Ohjelma tulostaa tekstin jossa käyttäjän syöttänä ikä.
            Console.WriteLine("{0} - näytät ikäistäsi nuoremmalta.", ika);
            Console.WriteLine();



            //12.Tehtävä
            //
            //Ohjelma pyytää käyttäjältä 10 suuremman kokonaisluvun ja tulostaa konsoliin esimerkkitapauksessa 13 kertaa:
            //13 13 13 13 13 13 13 13 13 13 13 13 13
            //13131313131313131313131313

            Console.WriteLine("---12.Numerosarja---");

            //Käyttäjältä pyydetään kymmentä suurempi kokonaisluku.
            Console.Write("Syötä kymmentä suurempi kokonaisluku.");
            int luku = int.Parse(Console.ReadLine());//Syöte tallennetaan kokonaislukuna.

            //If-lause tarkistaa onko syötteen arvo yli 10.
            if(luku > 10)
            {
                //Jos syötetty kokonaisluku on suurempi kuin 10, For-silmukka toistuu syötteen arvon verran.
                for(int i = luku; i > 0; i--)
                {
                    //Ensimmäisessä silmukassa on for-silmukka joka tulostaa rivin kokonaislukuja
                    //jonka käyttäjä on syöttänyt, jokaisen kokonaisluvun välissä on välilyönti.
                    //Kokonaislukuja toistetaan kokonaisluvun arvon verran.
                    for (int i1 = luku; i1 > 0; i1--)
                    {
                        Console.Write("{0} ", luku);
                    }
                    Console.WriteLine();

                    //Seuraavaksi toinen sisäistetty for-silmukka toistaa saman kuin ensimmäinen, ilman välilyöntejä.
                    for (int i2 = luku; i2 > 0; i2--)
                    {
                        Console.Write( luku);
                    }
                    Console.WriteLine();
                }
            }



            //13.Tehtävä
            //
            //Ohjelma pyytää käyttäjältä sanan, jonka jalkeen ohjelma vaihtaa sanan ensimmäisen ja toisen kirjaimen paikkaa ja tulostaa sanan.

            Console.WriteLine("---13.Kirjaimien kääntäjä---");

            //Ensin käyttäjältä pyydetään sanaa.
            Console.Write("Syötä sana: ");
            string sana = Console.ReadLine();//Sana tallennetaan merkkijonona.

            //Luodaan taulukko merkkijonoja, taulukon pituus on yhtäsuuri kuin syötetyn sanan kirjainten lukumäärä.
            string[] uusisana = new string[sana.Length];

            //For-silmukka toistuu syötesanan kirjainten lukumäärän mukaan
            //lukuunottamatta ensimmäistä ja viimeistä kirjainta.

            //For-silmukassa on muuttuja 'i' jonka arvo kasvaa jokaisella silmukan toistolla.
            //'i' muuttujan alkuarvo on yksi jotta silmukka ohittaa ensimmäisen kirjaimen.
            //For-silmukka pysähtyy ennen viimeistä kirjainta.
            for (int i = 1; i < sana.Length; i++)
            {
                //Jokaisella silmukan toistolla kopioidaan yksi kirjain syötesanasta 'uusisana' tauluun.
                uusisana[i] = sana[i].ToString();
            }

            //Lopuksi syötesanan viimeinen kirjain siirretään ensimmäiseksi ja ensimmäinen viimeiseksi.
            uusisana[0] = sana[sana.Length-1].ToString();
            uusisana[sana.Length-1] = sana[0].ToString();
            
            //Lopuksi foreach lause käy taulukon läpi tulostaen jokaisen kirjaimen.
            foreach(string kirjain in uusisana)
            {
                Console.Write(kirjain);
            }
            Console.WriteLine();



            //14.Tehtävä
            //
            //Ohjelma pyytää käyttäjältä kaksi kokonaislukua jonka
            //jälkeen ohjelma tarkastaa ovatko luvut positiivisia ehtolauseen avulla.
            //Lopuksi ohjelma tulostaa vastauksen.

            Console.WriteLine("---14.Kokonaislukujen tarkastus---");

            //Pyydetään käyttäjältä kaksi kokonaislukua.
            Console.Write("Syötä ensimmäinen luku: ");
            int ensimLuku = int.Parse(Console.ReadLine());
            Console.Write("Syötä toínen luku: ");
            int toinenLuku= int.Parse(Console.ReadLine());

            //If-ehtolauseilla vertaillaan lukuja. Vastaus tulostetaan jos ehdot täsmäävät.

            //Jos kummatkin luvut ovat positiivisia.
            if(ensimLuku > 0 && toinenLuku > 0)
            {
                Console.WriteLine("Kummatkin luvut ovat positiivisia.");
            }

            //Jos kummatkin luvut ovat negatiivisia.
            else if (ensimLuku < 0 && toinenLuku < 0)
            {
               
                Console.WriteLine("Kummatkin luvut ovat negatiivisia.");
            } 
            //Jos toinen luku on positiivinen ja toinen negatiivinen
            else if ((ensimLuku < 0 && toinenLuku > 0) || (ensimLuku > 0 && toinenLuku < 0))
            {
                Console.WriteLine("Toinen luku on positiivinen ja toinen negatiivinen.");
            }
            Console.WriteLine();

            

            //15.Tehtävä
            //
            //Ohjelma pyytää käyttäjältä lausetta. Lauseen syötön jälkeen ohjelma etsii lauseen pisimmän
            //sanan ja tulostaa sen.

            Console.WriteLine("---15.Lauseen pisin sana---");
            
            //Käyttäjältä pyydetään lausetta.
            Console.Write("Syötä lause: ");
            string syoteLause = Console.ReadLine();//Lause tallennetaan merkkijonona

            //Syötetty merkkijono leikataan välilyönneistä ja sanat tallennetaan taulukkoon.
            string[] sanat = syoteLause.Split(' ');

            //Luodaan muuttuja pisimmän sanan tallentamista varten
            string pisinSana = "";
            
            //Foreach-silmukka käy läpi jokaisen merkkijonon taulukosta.
            foreach(string sana in sanat)
            {
                //If-lause vertaa pisimmän sanan pituutta uuden sanan pituuteen.
                if(pisinSana.Length < sana.Length)
                {
                    //Jos uusi sana on pidempi kuin edellinen, sana tallennetaan pisimmäksi sanaksi.
                    pisinSana = sana;
                }
            }

            //Pisin sana tulostetaan.
            Console.WriteLine(pisinSana);
            Console.WriteLine();



            //16.Tehtävä
            //
            //Ohjelma tulostaa parittomat luvut 0-99 väliltä.

            //For-silmukka käy jokaisen luvun läpi väliltä 0-100
            for (int i = 0; i < 100; i++)
            {
                //If-lauseke laskee onko luku parillinen jakamalla luvun kahdella.
                if(i % 2 == 0)
                {
                    //Jos jakojäännös on yhtäsuuri kuin 0, tulostetaan numero.
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();



            //17.Tehtävä
            //
            //Ohjelma tulostaa kolmella jaolliset luvut väliltä 0-99.

            //For-silmukka käy jokaisen numeron läpi väliltä 0-100
            for (int i = 0; i < 100; i++)
            {
                //If-lauseke laskee onko luku parillinen jakamalla luvun kolmella.
                if (i % 3 == 0)
                {
                    //Jos jakojäännös on yhtäsuuri kuin 0, tulostetaan numero.
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
