using System;

namespace HeiKayttaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo HeiKayttaja");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            
            //Käyttäjän nimi kysytään. Nimi tallennetaan muuttujaan.
            Console.WriteLine("Kirjoita nimesi...");
            string nimi = Console.ReadLine();

            //Tulostetaan tervehdys käyttäen käyttäjän nimeä.
            Console.WriteLine("Hei " + nimi);
        }
    }
}
