using System;

namespace OOP_Testi
{
    class HenkilöNimi
    {
        public string nimi;
    }
    class Henkilö :HenkilöNimi
    {
        DateTime nyt = DateTime.Now;
        //Kentät
        int syntymaVuosi;
        int ika;

        //Metodit
        public void asetaTiedot(string u_nimi, int u_syntymaVuosi) //asetaTiedot metodi tallentaa parametrejen arvot nimi ja syntymavuosi kenttään.
        {
            Console.WriteLine("asetaTiedot metodia käytetty.");
            nimi = u_nimi;
            syntymaVuosi = u_syntymaVuosi;
        }
        public void laskeIka()
        {
            Console.WriteLine("lakseIka metodia käytetty"); //laskeIka metodi laskee henkilön iän vähentämällä syntymävuoden nykyajasta.
            ika = nyt.Year - syntymaVuosi;
        }
        public int palautaIka()
        {
            Console.WriteLine("palautaIka metodia käytetty"); //palautaTka metodi palauttaa ika kentän arvon.
            return ika;
        }
        public string palautaNimi()
        {
            Console.WriteLine("palautaNimi metodia käytetty"); //palautaNimi metodi palauttaa nimi kentän arvon.
            return nimi;
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
            Console.WriteLine("Sampo Klaavo oliotesti D");
            Console.WriteLine();

            Console.WriteLine("Luodaan olio Henk1");

            Henkilö henk1 = new Henkilö();

            Console.Write("Syötä etunimesi: ");
            string nimiSyote = Console.ReadLine();
            Console.Write("Syötä syntymävuotesi: ");
            int syntymaSyote = int.Parse(Console.ReadLine());

            henk1.asetaTiedot(nimiSyote, syntymaSyote);

            henk1.laskeIka();

            int ika = henk1.palautaIka();
            string nimi = henk1.palautaNimi();

            Console.WriteLine("{0} täytät/täytit tänä vuonna {1} vuotta", nimi, ika);
            Console.WriteLine();

            Console.WriteLine("Luodaan olio Henk2");

            Henkilö henk2 = new Henkilö("Seppo", 1980);

            henk2.laskeIka();

            ika = henk2.palautaIka();
            nimi = henk1.palautaNimi();

            Console.WriteLine("{0} täyttää/täytti tänä vuonna {1} vuotta", nimi, ika);
            Console.WriteLine();
        }
    }
}
