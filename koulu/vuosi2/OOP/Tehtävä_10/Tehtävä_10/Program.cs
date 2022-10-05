using System;

namespace Tehtävä_10
{
    class Opiskelija
    {
        //Kentät
        string nimi;
        int nro;
        string osoite;
        int kursseaSuoritettu;
        static int oliolaskuri;

        //Getterit ja Setterit
        public string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }
        public int Nro
        {
            get { return nro; }
            set { nro = value; }
        }
        public string Ooite
        {
            get { return osoite; }
            set { osoite = value; }
        }
        public int KursseaSuoritettu
        {
            get { return kursseaSuoritettu; }
            set { kursseaSuoritettu = value; }
        }

        //Metodit
        public static void AddOpiskelijat(Opiskelija[] array) //AddOpiskelijat-metodi luo Opiskelija-kokoelman täyteet Opiskelija-olioita.
        {
            Console.WriteLine("System: AddOpiskelijat metodi käytetty.");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Opiskelija();
            }
        }
        public void SetTiedot(int i) //SetTiedot-metodi kysyy käyttäjältä tiedot oliolle.
        {
            Console.WriteLine("System: SetTiedot metodi käytetty.");
            Console.WriteLine();
            Console.WriteLine("Asetetaan opiskelijan nro{0} tiedot.", i);
            Console.Write("Syötä opiskelijan nimi: ");
            nimi = Console.ReadLine();
            Console.Write("Syötä opiskelijan osoite: ");
            osoite = Console.ReadLine();
            Console.Write("Suoritettujen kurssien määrä: ");
            kursseaSuoritettu = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public static void SetTiedot(Opiskelija[] array) //SetTiedot-metodi käy Opiskelija-kokoelman läpi yksi kerrallaan ja kysyy käyttäjältä tiedot oliolle.
        {
            Console.WriteLine("System: SetTiedot metodi käytetty.");
            Console.WriteLine();
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine("Asetetaan opiskelijan nro{0} tiedot.", array[j].nro);
                Console.Write("Syötä opiskelijan nimi: ");
                array[j].nimi = Console.ReadLine();
                Console.Write("Syötä opiskelijan osoite: ");
                array[j].osoite = Console.ReadLine();
                Console.Write("Suoritettujen kurssien määrä: ");
                array[j].kursseaSuoritettu = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
        public static void TulostaKaikki(Opiskelija[] array) //TulostaKaikki-metodi käy Opiskelija-kokoelman läpi ja tulostaa jokaisen olion tiedot.
        {
            Console.WriteLine("System: TulostaKaikki metodi käytetty");
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Opiskelijan {0} nimi: {1}", array[i].nro, array[i].nimi);
                Console.WriteLine("Opiskelijan {0} numero: {1}", array[i].nro, array[i].nro);
                Console.WriteLine("Opiskelijan {0} osoite: {1}", array[i].nro, array[i].osoite);
                Console.WriteLine("Opiskelijan {0} suoritttujen kurssien määrä: {1}", array[i].nro, array[i].kursseaSuoritettu);
                Console.WriteLine();
            }
        }
        public static void UusiKurssiSuoritus(Opiskelija[] array, int i) //Uusikurssisuoritus-metodi lisää olion suoritettujen kurssejen määrää yhdellä.
        {
            Console.WriteLine("System: UusiKurssisuoritus metodi käytetty");
            array[i].kursseaSuoritettu = +1;
        }
        public static void OlioLaskuri() //Oliolaskuri-metodi tulostaa luotujen olioiden määrän
        {
            Console.WriteLine("System: OlioLaskuri metodi käytetty.");
            Console.WriteLine("Olioita luotu: " + oliolaskuri);
        }

        //Konstruktorit
        public Opiskelija()
        {
            oliolaskuri++;
            nimi = "";
            nro = 0 + oliolaskuri;
            osoite = "";
            kursseaSuoritettu = 0;
        }
        public Opiskelija(string u_nimi, int u_nro, string u_osoite, int u_kursseaSuoritettu)
        {
            oliolaskuri++;
            nimi = u_nimi;
            nro = u_nro;
            osoite = u_osoite;
            kursseaSuoritettu = u_kursseaSuoritettu;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Oliotehtävä 10");
            Console.WriteLine("***************************");
            Console.WriteLine();

            Opiskelija[] Oppilaat = new Opiskelija[3]; //Luodaan Opiskelija-olio kokoelma nimeltä Oppilaat.

            Opiskelija.AddOpiskelijat(Oppilaat); //Käytetään AddOpiskelijat-metodia lisätäksemme Oppilaat-kokoelmaan Opiskelija-olioita.

            Opiskelija.SetTiedot(Oppilaat); //Käytetään SetTiedot-metodia asettaaksemme oppilaiden tiedot yksi kerrallaan.

            Opiskelija.TulostaKaikki(Oppilaat); //Käytetään TulostaKaikki-metodia tulostaaksemme Oppilaat-kokoelman olioiden tiedot.

            Opiskelija.UusiKurssiSuoritus(Oppilaat, 1); //Nostetaan Oppilas nro1 suoritettujen kurssien määrää.

            Opiskelija.TulostaKaikki(Oppilaat);

            Opiskelija.OlioLaskuri(); //Kutsutaan Oliolaskuri-metodi.
        }
    }
}
