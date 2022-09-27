using System;

namespace OOP_Testi
{
    class Henkilö
    {
        DateTime nyt = DateTime.Now;
        //Kentät
        string nimi;
        int syntymaVuosi;
        int ika;

        //Getterit ja Setterit
        public string Nimi
        {
            get
            {
                Console.WriteLine("nimi getteri käytetty");
                return nimi;
            }
            set
            {
                Console.WriteLine("nimi setteri käytetty");
                nimi = value;
            }
        }
        public int SyntymaVuosi
        {
            get
            {
                Console.WriteLine("syntymaVuosi getteri käytetty");
                return syntymaVuosi;
            }
            set
            {
                Console.WriteLine("syntymaVuosi setteri käytetty");
                syntymaVuosi = value;
            }
        }
        public int Ika
        {
            get
            {
                Console.WriteLine("Ika getteri käytetty");
                return ika;
            }
            set
            {
                Console.WriteLine("Ika setteri käytetty");
                ika = value;
            }
        }

        //Metodit
        public void laskeIka()
        {
            Console.WriteLine("lakseIka metodia käytetty"); //laskeIka metodi laskee henkilön iän vähentämällä syntymävuoden nykyajasta.
            ika = nyt.Year - syntymaVuosi;
        }

        //Konstruktorit
        public Henkilö()//Olteuskonstruktori luo olion tyhjillä kentillä.
        {
            Console.WriteLine("Oletuskonstruktoira käytetty");
            nimi = "";
            syntymaVuosi = 0;
        }
        public Henkilö(string u_nimi, int u_syntymaVuosi)//Ylikuormituskonstruktori luo olion, kenttien arvot saadaan parametreistä.
        {
            Console.WriteLine("Ylikuormitettua konstruktoria käytetty");
            nimi = u_nimi;
            syntymaVuosi = u_syntymaVuosi;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo oliotesti B");
            Console.WriteLine();

            Console.WriteLine("Luodaan olio Henk1");

            Henkilö henk1 = new Henkilö();

            Console.Write("Syötä etunimesi: ");
            string nimiSyote = Console.ReadLine();
            Console.Write("Syötä syntymävuotesi: ");
            int syntymaSyote = int.Parse(Console.ReadLine());

            henk1.Nimi = nimiSyote;
            henk1.SyntymaVuosi = syntymaSyote;

            henk1.laskeIka();

            int ika = henk1.Ika;
            string nimi = henk1.Nimi;

            Console.WriteLine("{0} täytät/täytit tänä vuonna {1} vuotta", nimi, ika);
            Console.WriteLine();

            Console.WriteLine("Luodaan olio Henk2");

            Henkilö henk2 = new Henkilö("Seppo", 1980);

            henk2.laskeIka();

            ika = henk2.Ika;
            nimi = henk1.Nimi;

            Console.WriteLine("{0} täyttää/täytti tänä vuonna {1} vuotta", nimi, ika);
            Console.WriteLine();
        }
    }
}
