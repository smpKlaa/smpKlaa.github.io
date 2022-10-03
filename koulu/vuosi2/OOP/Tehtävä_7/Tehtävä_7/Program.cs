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
        public void Lämpö(double value) //Lämpö metodilla voi muokata kiukaan Lämpö kentän arvoa.
        {
            Console.WriteLine("System: Lämpö metodi käytetty;");
            Console.WriteLine();
            lämpötila = value;
        }
        public void Kosteus(double value) //Kosteus metodilla voi muokata kiukaan kosteus kentän arvoa.
        {
            Console.WriteLine("System: Kosteus metodi käytetty;");
            Console.WriteLine();
            kosteus = value;
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
            virta = false;
            lämpötila =0;
            kosteus = 0;
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

            Kiuas1.Arvot();
        }
    }
}
