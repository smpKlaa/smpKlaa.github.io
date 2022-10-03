using System;

namespace Tehtävä_7
{
    class Kiuas
    {
        //Kentät
        bool virta;
        double lämpötila;
        double kosteus;

        //Metodit
        public void Päälle() //Päälle metodi asettaa virta kentän arvon trueksi.
        {
            Console.WriteLine("System: Päälle metodi käytetty;");
            Console.WriteLine();
            virta = true;
        }
        public void Kiinni() //Kiinni metodi asettaa virta kentän arvon falseksi.
        {
            Console.WriteLine("System: Kiinni metodi käytetty;");
            Console.WriteLine();
            virta = false;
        }
        public void Lämpö(double value) //Lämpö metodilla voi muokata kiukaan Lämpö kentän arvoa kiukaan ollessa päällä.
        {
            Console.WriteLine("System: Lämpö metodi käytetty;");
            Console.WriteLine();
            if (virta == true)
            {
                lämpötila = value;
            }
            else
            {
                Console.WriteLine("SystemERROR: Lämpötilaa ei voida asettaa koska kiuas on kiinni.");
                Console.WriteLine();
            }
        }
        public void Kosteus(double value) //Kosteus metodilla voi muokata kiukaan kosteus kentän arvoa kiukaan ollessa päällä.
        {
            Console.WriteLine("System: Kosteus metodi käytetty;");
            Console.WriteLine();
            if (virta == true)
            {
                kosteus = value;
            }
            else
            {
                Console.WriteLine("SystemERROR: Kosteutta ei voida asettaa koska kiuas on kiinni.");
                Console.WriteLine();
            }
        }
        public void Arvot() //Arvot metodi tulostaa olion arvot konsoliin.
        {
            Console.WriteLine("System: Arvot metodi käytetty.");
            Console.WriteLine("Virta: {0}", virta);
            Console.WriteLine("Lämpötila: {0}C", lämpötila);
            Console.WriteLine("Kosteus: {0}", kosteus);
            Console.WriteLine();
        }

        //Konstruktorit
        public Kiuas() //Vakiokonstruktori
        {
            Console.WriteLine("System: Kiuas olio luotu vakiokonstruktorilla.");
            Console.WriteLine();
            virta = false;
            lämpötila =0;
            kosteus = 0;
        }
        public Kiuas(double u_lämpötila, double u_kosteus) //Ylikuormituskonstruktori
        {
            Console.WriteLine("System: Kiuas olio luotu ylikuormituskonstruktorilla.");
            Console.WriteLine();
            virta = true;
            lämpötila = u_lämpötila;
            kosteus = u_kosteus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Oliotehtävä 7");
            Console.WriteLine("**************************");
            Console.WriteLine();

            Kiuas Kiuas1 = new Kiuas();

            Kiuas1.Arvot();

            Kiuas1.Lämpö(65);
            Kiuas1.Kosteus(100);

            Kiuas1.Päälle();
            Kiuas1.Lämpö(65);
            Kiuas1.Kosteus(100);

            Kiuas1.Arvot();

            Kiuas Kiuas2 = new Kiuas(70, 100);

            Kiuas2.Arvot();
        }
    }
}
