using System;

namespace Tehtävä_1
{
    class Kirjasto
    {
        //kentät
        private string nimi;
        private string kirjailija;
        private int sivumaara;

        //metodit
        public string Nimi//Nimi kentän setteri ja getteri.
        {
           set {
                nimi = value;
                Console.WriteLine("Nimi setteri käytetty");
            }
           get
            {
                Console.WriteLine("Nimi getteri käytetty");
                return nimi;
            }
        }
        public string Kirjailija//Kirjailija kentän setteri ja getteri.
        {
            set
            {
                kirjailija = value;
                Console.WriteLine("Kirjailija setteri käytetty");
            }
            get
            {
                Console.WriteLine("Kirjailija getteri käytetty");
                return kirjailija;
            }
        }
        public int Sivumaara//Sivumäärä kentän setteri ja getteri.
        {
            set {
                sivumaara = value;
                Console.WriteLine("Sivumaara setteri käytetty");
            }
            get
            {
                Console.WriteLine("Sivumaara getteri käytetty");
                return sivumaara;
            }
        }
        public void Lainaa() {}//Lainaa metodi
        public void Palauta() { }//Palauta metodi

        public Kirjasto()//Oletuskonstruktori joka luo olion tyhjillä arvoilla.
        {
            nimi = "";
            kirjailija = "";
            sivumaara = 0;
            Console.WriteLine("Olio luotu oletuskonstruktorilla");
        }
        //Ylikuormituskonstruktori luo olion joiden arvot saadaan parametreistä.
        public Kirjasto(string u_nimi, string u_kirjailija, int u_sivumaara)//Oletuskonstruktori joka luo olion tyhjillä arvoilla.
        {
            nimi = u_nimi;
            kirjailija = u_kirjailija;
            sivumaara = u_sivumaara;
            Console.WriteLine("Olio luotu ylikuormituskonstruktorilla");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Oliotehtävä 1");
            Console.WriteLine("**************************");
            Console.WriteLine("");

            //Luodaan kolme oliota
            Kirjasto olioYksi = new Kirjasto();
            Kirjasto olioKaksi = new Kirjasto("Aapinen", "Seppo kirjailija", 333);
            Kirjasto olioKolme = new Kirjasto();

            Console.WriteLine("");

            //Määritetään ensimmäisen olion arvot setterillä
            olioYksi.Nimi = "Kirjanimi1";
            olioYksi.Sivumaara = 321;
            olioYksi.Kirjailija = "Matti Esimerkki";

            Console.WriteLine("");

            //Tulostetaan ensimmäisen olion arvot getterillä
            Console.WriteLine(olioYksi.Nimi);
            Console.WriteLine(olioYksi.Sivumaara);
            Console.WriteLine(olioYksi.Kirjailija);

            Console.WriteLine("");

            //Tulostetaan toisen olion arvot getterillä
            Console.WriteLine(olioKaksi.Nimi);
            Console.WriteLine(olioKaksi.Sivumaara);
            Console.WriteLine(olioKaksi.Kirjailija);

            Console.WriteLine("");

            //Tulostetaan kolmannen olion arvot getterillä
            Console.WriteLine(olioKolme.Nimi);
            Console.WriteLine(olioKolme.Sivumaara);
            Console.WriteLine(olioKolme.Kirjailija);
        }
    }
}
