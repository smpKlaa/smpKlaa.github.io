using System;

namespace Tehtävä_8
{
    class Pesukone
    {
        //Kentät
        int pesuAika;
        double pesuLämpöTila;
        int pesuRPM;
        string pesuOhjelma;

        //Metodit
        public void AloitaPesu() //AloitaPesu metodi käynnistää pesun.
        {
            Console.WriteLine("System: AloitaPesu metodi käytetty.");
            Console.WriteLine("Pesu käynnistyy...");
            //*Mielikuvituspesukone Käynnistyy*
        }
        public void OmaOhjelma(int u_pesuAika, double u_pesuLämpöTila, int u_pesuRPM) //OmaOhjelma metodi antaa käyttäjän määritellä pesuohjelman atribuutit.
        {
            Console.WriteLine("System: OmaOhjelma metodi käytetty.");

            pesuAika = u_pesuAika;
            pesuLämpöTila = u_pesuLämpöTila;
            pesuRPM = u_pesuRPM;
            pesuOhjelma = "OmaPesuOhjelma";

            Console.WriteLine("Oma pesuohjelma luotu arvoilla:");
            Console.WriteLine("Pesuaika: {0}min", u_pesuAika);
            Console.WriteLine("Pesulämpötila: {0}C", u_pesuLämpöTila);
            Console.WriteLine("RPM: {0}", u_pesuRPM);
            Console.WriteLine();
        }
        public void KevytPesu()  //Rajupesu metodi asettaa pesuohjelmaksi ensimmäisen vakio-ohjelmista.
        {
            Console.WriteLine("System: KevytPesu metodi käytetty.");
            Console.WriteLine();

            pesuAika = 60;
            pesuLämpöTila = 50;
            pesuRPM = 1000;
            pesuOhjelma = "Kevytpesu";
        }
        public void RajuPesu() //Rajupesu metodi asettaa pesuohjelmaksi toisen vakio-ohjelmista.
        {
            Console.WriteLine("System: RajuPesu metodi käytetty.");
            Console.WriteLine();

            pesuAika = 120;
            pesuLämpöTila = 60;
            pesuRPM = 5000;
            pesuOhjelma = "Rajupesu";
        }
        public void TulostaOhjelma() //TulostaOhjelma metodi tulostaa valitun ohjelman tiedot konsoliin.
        {
            Console.WriteLine("System: TulostaOhjelma metodi käytetty.");

            Console.WriteLine("Valittu pesuohjelma: {0}", pesuOhjelma);
            Console.WriteLine("Pesuaika: {0}min", pesuAika);
            Console.WriteLine("Pesulämpötila: {0}C", pesuLämpöTila);
            Console.WriteLine("Pesu RPM: {0}", pesuRPM);
            Console.WriteLine();
        }

        //Konstruktorit
        public Pesukone() //Oletuskonstruktori luo olion tyhjillä kentillä.
        {
            Console.WriteLine("System: Pesukone-olio luotu.");
            pesuAika = 0;
            pesuLämpöTila = 0;
            pesuRPM = 0;
            pesuOhjelma = "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo OlioTehtävä 8");
            Console.WriteLine("**************************");
            Console.WriteLine();

            Pesukone Pesukone1 = new Pesukone();

            Pesukone1.TulostaOhjelma();
            Pesukone1.KevytPesu();
            Pesukone1.TulostaOhjelma();

            Pesukone1.RajuPesu();
            Pesukone1.TulostaOhjelma();

            Pesukone1.OmaOhjelma(50, 40, 1800);
            Pesukone1.TulostaOhjelma();

            Pesukone1.AloitaPesu();
        }
    }
}
