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

            Console.Write("Syötä ikäsi: ");
            int ika = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} - näytät ikäistäsi nuoremmalta.", ika);



            //12.Tehtävä
            //
            //Ohjelma pyytää käyttäjältä 10 suuremman kokonaisluvun ja tulostaa konsoliin esimerkkitapauksessa 13 kertaa:
            //13 13 13 13 13 13 13 13 13 13 13 13 13
            //13131313131313131313131313

            Console.Write("Syötä kymmentä suurempi kokonaisluku.");
            int luku = int.Parse(Console.ReadLine());

            if(luku > 10)
            {
                for(int i = luku; i > 0; i--)
                {
                    for (int i1 = luku; i1 > 0; i1--)
                    {
                        Console.Write("{0} ", luku);
                    }
                    Console.WriteLine();
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

            Console.Write("Syötä sana: ");
            string sana = Console.ReadLine();

            foreach(string kirjain in sana)
            {

            }

            char sana0 = sana[0];
            char sana1 = sana[sana.Length];
            string uusisana = sana;
            uusisana[0] = sana1;

        }
    }
}
