using System;

namespace Tehtävä_2_Varasto
{
    class Varasto
    {
        //Kentät
        private string tuotteenNimi;
        private int määrä;
        private double paino;
        private bool hyllyssä;
        public static int varastoLaskuri = 0;

        //Metodit
        public string TuotteenNimi //Tuotteennimi kentän setter & getter.
        {
            set
            {
                tuotteenNimi = value;
                Console.WriteLine("System: TuotteenNimi setteri käytetty");
            }
            get
            {
                Console.WriteLine("System: TuotteenNimi getteri käytetty");
                return tuotteenNimi;
            }
        }
        public int Määrä //Määrä kentän setter & getter.
        {
            set
            {
                määrä = value;
                Console.WriteLine("System: Määrä setteri käytetty");
            }
            get
            {
                Console.WriteLine("System: Määrä getteri käytetty");
                return määrä;
            }
        }
        public double Paino //Paino kentän setter & getter.
        {
            set
            {
                paino = value;
                Console.WriteLine("System: Paino setteri käytetty");
            }
            get
            {
                Console.WriteLine("System: Paino getteri käytetty");
                return paino;
            }
        }
        public bool Hyllyssä //Hyllyssä kentän setter & getter.
        {
            set
            {
                hyllyssä = value;
                Console.WriteLine("System: Hyllyssä setteri käytetty");
            }
            get
            {
                Console.WriteLine("System: Hyllyssä getteri käytetty");
                return hyllyssä;
            }
        }
        public void PoistaHyllysta() //PoistaHyllystä metodi muuttaa olion "hyllyssä" kentän falseksi.
        {
            hyllyssä = false;
            Console.WriteLine("System: Poistahyllystä metodi käytetty");
        }
        public void PalautaHyllyyn() //PalautaHyllyyn metodi muuttaa olion "hyllyssä" kentän trueksi.
        {
            hyllyssä = true;
            Console.WriteLine("System: Palautahyllyyn metodi käytetty");
        }
        public void Painonmuutos(double value) //Painonmuutos metodi muuttaa olion paino-kentän arvon annetun parametrin arvoksi.
        {
            paino = value;
            Console.WriteLine("System: Painonmuutos metodi käytetty");
        }
        public void Nimenmuutos(string value) //Nimenmuutos metodi muuttaa olion tuotteennimi-kentän arvon annetun parametrin arvoksi.
        {
            tuotteenNimi = value;
            Console.WriteLine("System: Nimenmuutos metodi käytetty");
        }
        public void Määränmuutos(int value) //Määränmuutos metodi muuttaa olion määrä-kentän arvon annetun parametrin arvoksi.
        {
            määrä = value;
            Console.WriteLine("System: Määränmuutos metodi käytetty");
        }
        public static void VarastoLaskuri() //VarastoLaskuri metodi tulostaa varaston olioiden määrän.
        {
            Console.WriteLine("System: Varastolaskuri metodi käytetty");
            Console.WriteLine("Varaston tuotteiden määrä: " + Varasto.varastoLaskuri);
        }
        public Varasto() //Vakiokonstrukti
        {
            tuotteenNimi = "";
            määrä = 0;
            paino = 0;
            hyllyssä = false;
            varastoLaskuri++;
            Console.WriteLine("System: Olio luotu oletuskonstruktilla");
        }
        public Varasto(string u_tuotteenNimi, int u_määrä, double u_paino, bool u_hyllyssä) //Ylikuormituskonstrukti
        {
            tuotteenNimi = u_tuotteenNimi;
            määrä = u_määrä;
            paino = u_paino;
            hyllyssä = u_hyllyssä;
            varastoLaskuri++;
            Console.WriteLine("System: Olio luotu ylikuormituskonstruktilla");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Oliotehtävä 2");
            Console.WriteLine("**************************");
            Console.WriteLine();


            Console.WriteLine("Luodaan olio 'tuote1' valiokonstruktorilla");
            Varasto tuote1 = new Varasto();
            Console.WriteLine();

            Console.WriteLine("Tulostetaan olion 'tuote1' atribuuttien arvot getterillä:");
            Console.WriteLine(tuote1.TuotteenNimi);
            Console.WriteLine(tuote1.Paino);
            Console.WriteLine(tuote1.Määrä);
            Console.WriteLine(tuote1.Hyllyssä);
            Console.WriteLine();

            Console.WriteLine("Annetaan olion 'tuote1' atribuuteille arvot:");
            tuote1.Nimenmuutos("EnsimTuote");
            tuote1.Painonmuutos(8.43);
            tuote1.Määränmuutos(5);
            tuote1.PalautaHyllyyn();
            Console.WriteLine();

            Console.WriteLine("Tulostetaan olion 'tuote1' atribuuttien arvot getterillä:");
            Console.WriteLine(tuote1.TuotteenNimi);
            Console.WriteLine(tuote1.Paino);
            Console.WriteLine(tuote1.Määrä);
            Console.WriteLine(tuote1.Hyllyssä);
            Console.WriteLine();

            Console.WriteLine("Luodaan olio 'tuote2' ylikuormituskonstruktorilla");
            Varasto tuote2 = new Varasto("ToinTuote", 8, 3.44, true);
            Console.WriteLine();

            Console.WriteLine("Tulostetaan olion 'tuote2' atribuuttien arvot getterillä:");
            Console.WriteLine(tuote2.TuotteenNimi);
            Console.WriteLine(tuote2.Paino);
            Console.WriteLine(tuote2.Määrä);
            Console.WriteLine(tuote2.Hyllyssä);
            Console.WriteLine();

            Varasto.VarastoLaskuri();
        }
    }
}
