using System;

namespace Tehtävä_6
{
    class Kulkuneuvo
    {
        //  Kentät
        public int nopeus;
        public int matkustajaLkm;
        public static int olioLaskuri;

        //Getterit ja Setterit
        public int Nopeus
        {
            get
            {
                Console.WriteLine("     System: Nopeus getteri käytetty.");
                return nopeus;
            }
            set
            {
                Console.WriteLine("     System: Nopeus setteri käytetty.");
                nopeus = value;
            }
        }
        public int MatkustajaLkm
        {
            get
            {
                Console.WriteLine("     System: MatkustajaLkm getteri käytetty.");
                return matkustajaLkm;
            }
            set
            {
                Console.WriteLine("     System: MatkustajaLkm setteri käytetty.");
                matkustajaLkm = value;
            }
        }

        //Metodit
        public static void TulostaLaskuri() //Tulostalaskuri tulostaa luotujen olioiden määrän konsoliin.
        {
            Console.WriteLine("     System: Oliolaskuri metodi käytetty");
            Console.WriteLine("Kulkuneuvo - olioiden ja lapsien lukumäärä: "+ olioLaskuri);
        }
    }

    class Lentokone : Kulkuneuvo
    {
        //  Kentät
        double polttoaine;
        double maxPaino;

        //Getterit ja Setterit
        public double Polttoaine
        {
            get
            {
                Console.WriteLine("     System: Polttoaine getteri käytetty.");
                return polttoaine;
            }
            set
            {
                Console.WriteLine("     System: Polttoaine setteri käytetty.");
                polttoaine = value;
            }
        }
        public double MaxPaino
        {
            get
            {
                Console.WriteLine("     System: MaxPaibno getteri käytetty.");
                return maxPaino;
            }
            set
            {
                Console.WriteLine("     System: MaxPaino setteri käytetty.");
                maxPaino = value;
            }
        }

        //Metodit
        public void Tankkaa(int value) //Tankkaa metodi kasvattaa olion polttoaine-kentän arvoa metodin parametrin verran.
        {
            Console.WriteLine("     System: Tankkaa metodi käytetty");
            polttoaine = + value;
        }
        public void PainoLaskuri() //Painolaskuri laskee lentokoneen painon ja vertaa sitä maksimipainoon, olettaen että matkustajan keskipaino on 100kg. Tulos tulostetaan konsoliin.
        {
            Console.WriteLine("     System: PainoLaskuri metodi käytetty");
            int paino = matkustajaLkm * 100;
            Console.WriteLine("Lentokoneen Max Paino on {0}kg, Lentokoneen tämänhetkinen paino on {1}kg, tilaa jäljellä {2}kg", maxPaino, paino, maxPaino-paino);
        }
        public void Tulostatiedot() //Tulostatiedot metodi tulostaa olion kenttien tiedot.
        {
            Console.WriteLine("     System: Lentokoneen Tulostatiedot metodi käytetty.");
            Console.WriteLine("Nopeus: " + nopeus);
            Console.WriteLine("Matkustajien lkm: " + matkustajaLkm);
            Console.WriteLine("Polttoainetta (Litraa): " + polttoaine);
            Console.WriteLine("Maxpaino: "+ maxPaino);
        }


        // Konstruktorit
        public Lentokone() //Vakiokonstruktori
        {
            Console.WriteLine("     System: Lentokone olio luotu vakiokonstruktorilla.");
            nopeus =0;
            matkustajaLkm =0;
            polttoaine =0;
            maxPaino =0;
            olioLaskuri++;
        }
        public Lentokone(int u_nopeus, int u_matkustajaLkm, double u_polttoaine, double u_maxPaino) //Ylikuormituskonstruktori
        {
            Console.WriteLine("     System: Lentokone olio luotu ylikuormituskonstruktorilla.");
            nopeus = u_nopeus;
            matkustajaLkm = u_matkustajaLkm;
            polttoaine = u_polttoaine;
            maxPaino = u_maxPaino;
            olioLaskuri++;
        }
    }

    class Laiva : Kulkuneuvo
    {
        //  Kentät
        string laivanNimi;
        int vapaatHytit;

        //Getterit ja Setterit
        public string LaivanNimi
        {
            get
            {
                Console.WriteLine("     System: LaivanNimi getteri käytetty.");
                return laivanNimi;
            }
            set
            {
                Console.WriteLine("     System: LaivanNimi setteri käytetty.");
                laivanNimi = value;
            }
        }
        public int VapaatHytit
        {
            get
            {
                Console.WriteLine("     System: VapaatHytit getteri käytetty.");
                return vapaatHytit;
            }
            set
            {
                Console.WriteLine("     System: VapaatHytit setteri käytetty.");
                vapaatHytit = value;
            }
        }
        public void NimeäLaiva(string value) //NimeäLaiva metodi muuttaa olion lainanNimi kentän arvon metodin parametrin arvoksi.
        {
            Console.WriteLine("     System: NimeäLaiva metodi käytetty");
            laivanNimi=value;
        }
        public void Hytit() //Hytit metodi laskee vapaiden hyttien määrän, tulostaa sen konsoliin ja tallehntaa sen olioon.
        {
            Console.WriteLine("     System: Hytit metodi käytetty");
            Console.WriteLine("Hyttejä yhteensä {0}, matkustajia {1}, vapaita hyttejä jäljellä {2}", vapaatHytit, matkustajaLkm, vapaatHytit - matkustajaLkm);
            vapaatHytit = vapaatHytit- matkustajaLkm;
        }
        public void Tulostatiedot() //Tulostatiedot metodi tulostaa olion kenttien arvon.
        {
            Console.WriteLine("     System: Laivan Tulostatiedot metodi käytetty.");
            Console.WriteLine("Nopeus: "+ nopeus);
            Console.WriteLine("Matkustajien lkm: "+ matkustajaLkm);
            Console.WriteLine("Laivan nimi: "+ laivanNimi);
            Console.WriteLine("Vapaita hyttejä: "+ vapaatHytit);
        }

        // Konstruktorit
        public Laiva() //Vakiokonstruktori
        {
            Console.WriteLine("     System: Laiva olio luotu vakiokonstruktorilla.");
            nopeus =0;
            matkustajaLkm =0;
            laivanNimi ="";
            vapaatHytit =0;
            olioLaskuri++;
        }
        public Laiva(int u_nopeus, int u_matkustajaLkm, string u_laivanNimi, int u_vapaatHytit) //Ylikuormituskonstruktori
        {
            Console.WriteLine("     System: Laiva olio luotu ylikuormituskonstruktorilla.");
            nopeus = u_nopeus;
            matkustajaLkm = u_matkustajaLkm;
            laivanNimi = u_laivanNimi;
            vapaatHytit = u_vapaatHytit;
            olioLaskuri++;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Oliotehtävä 6");
            Console.WriteLine("**************************");
            Console.WriteLine();

            Console.WriteLine("Luodaan Lentokone olio nimeltä Cessna172. Käytätetään vakiokonstruktoria.");

            Lentokone Cessna172 = new Lentokone();
            Console.WriteLine();

            Console.WriteLine("Tulostetaan olion Cessna172 tiedot.");
            Cessna172.Tulostatiedot();
            Console.WriteLine();

            Console.WriteLine("Annetaan oliolle arvot Setterillä.");

            Cessna172.Polttoaine = 100;
            Cessna172.MaxPaino = 400;
            Cessna172.MatkustajaLkm = 2;
            Cessna172.Nopeus = 300;
            Console.WriteLine();

            Console.WriteLine("Tulostetaan olion Cessna172 tiedot uudestaan.");
            Cessna172.Tulostatiedot();
            Console.WriteLine();

            Console.WriteLine("Nyt luodaan uusi Lentokone olio nimelta Boeing747. Käytetään ylikuormituskonstruktoria.");

            Lentokone Boeing747 =new Lentokone(900, 40, 0, 5000);
            Console.WriteLine();

            Console.WriteLine("Voimme laskea Lentokoneen matkustajien painorajoitteen.");
            Boeing747.PainoLaskuri();
            Console.WriteLine();

            Console.WriteLine("Voimme kasvattaa polttoaine kentän arvoa Tankkaa-metodilla.");
            Boeing747.Tankkaa(1000);
            Console.WriteLine();

            Console.WriteLine("Nyt tulostetaan olion Boeing747 kenttien tiedot.");
            Boeing747.Tulostatiedot();
            Console.WriteLine();

            Console.WriteLine("Luodaan nyt Laiva olio nimeltä Titanic. Käytetään vakiokonstruktoria,");

            Laiva Titanic = new Laiva();
            Console.WriteLine();

            Console.WriteLine("Voimme tallentaa laivan nimen olion nimikenttään käyttämällä NimeäLaiva-metodia.");

            Titanic.NimeäLaiva("Titanic");
            Console.WriteLine();

            Console.WriteLine("Annetaan olion muille kentille arvot setterillä.");
            Titanic.VapaatHytit = 500;
            Titanic.MatkustajaLkm = 200;
            Titanic.Nopeus = 40;
            Console.WriteLine();

            Console.WriteLine("Voimme laskea vapaiden hyttien määrän Hytit-metodilla");

            Titanic.Hytit();
            Console.WriteLine();

            Console.WriteLine("Tulostetaan nyt olion Titanic tiedot Tulostatiedot-metodilla.");
            Titanic.Tulostatiedot();

            Kulkuneuvo.TulostaLaskuri();
        }
    }
}
