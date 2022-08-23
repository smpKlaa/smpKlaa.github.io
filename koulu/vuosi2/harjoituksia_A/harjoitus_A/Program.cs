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

            //Luodaan bool muuuttuja ohjelmavalikkoa varten.
            bool toista = true;

            //While silmukka toistaa ohjelmaa niin kauan kun käyttäjä haluaa.
            while (toista == true)
            {
                //Ohjelmavalikko tulostetaan.
                Console.WriteLine("--------------------------");
                Console.WriteLine("(3)Toista 3.Tehtävä");
                Console.WriteLine("(4)Toista 4.Tehtävä");
                Console.WriteLine("(5)Toista 5.Tehtävä");
                Console.WriteLine("(6)Toista 6.Tehtävä");
                Console.WriteLine("(0)Poistu ohjelmasta");
                Console.WriteLine("--------------------------");

                //Käyttäjältä kysytään suoritettavaa ohjelmaa.
                Console.Write("Valitse toiminto: ");
                int valinta = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");
                Console.WriteLine();

                //Switch-case lause suorittaa oikean ohjelman.
                switch (valinta)
                {
                    case 3:

                        //3.Tehtävä
                        //
                        //Ohjelma tulostaa tervehdyksen.
                        Console.WriteLine("Hyvää päivää!");
                        Console.WriteLine();

                        break;

                    case 4:

                        //4.Tehtävä
                        //
                        //Ohjelma tulostaa etu- ja sukinimeni.
                        Console.WriteLine("Sampo Klaavo");
                        Console.WriteLine();

                        break;

                    case 5:

                        //5.Tehtävä
                        //
                        //Ohjelma tulostaa sarjan numeroita eri riveille.
                        Console.WriteLine("1\n11\n101\n1001");
                        Console.WriteLine();

                        break;

                    case 6:

                        //6.Tehtävä
                        //
                        //Ohjelma kysyy käyttäjän nimeä ja tulostaa tervehdyksen käyttäen käyttäjän nimeä.

                        //Käyttäjän nimi kysytään. Nimi tallennetaan muuttujaan.
                        Console.WriteLine("Kirjoita nimesi...");
                        string nimi = Console.ReadLine();
                        Console.WriteLine();

                        //Tulostetaan tervehdys käyttäen käyttäjän nimeä.
                        Console.WriteLine("Hei " + nimi);
                        Console.WriteLine();

                        break;

                    case 0:

                        Console.WriteLine("Poistutaan ohjelmasta...");
                        toista = false;
                        break;
                }
            } 
        }
    }
}
