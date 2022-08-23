using System;

namespace harjoitus_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Harjoitus A");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            //3.Tehtävä
            //
            //Ohjelma tulostaa tervehdyksen.
            Console.WriteLine("Hyvää päivää!");



            //4.Tehtävä
            //
            //Ohjelma tulostaa etu- ja sukinimeni.
            Console.WriteLine("Sampo Klaavo");



            //5.Tehtävä
            //
            //Ohjelma tulostaa sarjan numeroita eri riveille.
            Console.WriteLine("1\n11\n101\n1001");



            //6.Tehtävä
            //
            //Ohjelma kysyy käyttäjän nimeä ja tulostaa tervehdyksen käyttäen käyttäjän nimeä.

            //Käyttäjän nimi kysytään. Nimi tallennetaan muuttujaan.
            Console.WriteLine("Kirjoita nimesi...");
            string nimi = Console.ReadLine();

            //Tulostetaan tervehdys käyttäen käyttäjän nimeä.
            Console.WriteLine("Hei " + nimi);
        }
    }
}
