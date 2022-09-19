using System;

namespace Harjoituksia_D
{
    class Program
    {
        //Luon metodit yksinkertaisia laskutoimituksia varten.

        //Metodi palauttaa parametrejen summan.
        static double Summa(double luku1, double luku2)
        {
            double summa = luku1 + luku2;
            return summa;
        }

        //Metodi palauttaa parametrejen erotuksen.
        static double Erotus(double luku1, double luku2)
        {
            double summa = luku1 - luku2;
            return summa;
        }

        //Metodi palauttaa parametrejen tulon.
        static double Tulo(double luku1, double luku2)
        {
            double summa = luku1 * luku2;
            return summa;
        }

        //Metodi palauttaa parametrejen osamäärän
        static double Jaa(double luku1, double luku2)
        {
            double summa = luku1 / luku2;
            return summa;
        }

        //Metodi palauttaa parametrejen jakojäännöksen
        static double Jakojäännös(double luku1, double luku2)
        {
            double summa = luku1 % luku2;
            return summa;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Harjoituksia D");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            //Luodaan bool muuuttuja ohjelmavalikkoa varten.
            bool toista = true;

            //While silmukka toistaa ohjelmaa niin kauan kun käyttäjä haluaa.
            while (toista == true)
            {
                //Ohjelmavalikko tulostetaan.
                Console.WriteLine("--------------------------");
                Console.WriteLine("(1)Toista 1.Tehtävä");
                Console.WriteLine("(2)Toista 2.Tehtävä");
                Console.WriteLine("(3)Toista 3.Tehtävä");
                Console.WriteLine("(4)Toista 4.Tehtävä");
                Console.WriteLine("(5)Toista 5.Tehtävä");
                Console.WriteLine("(6)Toista 6.Tehtävä");
                Console.WriteLine("(7)Toista 7.Tehtävä");
                Console.WriteLine("(8)Toista 8.Tehtävä");
                Console.WriteLine("(9)Toista 9.Tehtävä");
                Console.WriteLine("(10)Toista 10.Tehtävä");
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
                    case 1:

                        //1.Tehtävä
                        //
                        //Ohjelma laskee kaksi numeroa yhteen.

                        Console.WriteLine("---1.Yhteenlaskuohjelma---");

                        //Luvut ja niiden summa.
                        Console.WriteLine("3 + 8 = {0}.", Summa(3, 8));
                        Console.WriteLine();

                        break;

                    case 2:

                        //2.Tehtävä
                        //
                        //Ohjelma muuttaa annetun Celsius-asteen Fahrenheitieksi.

                        Console.WriteLine("---2.Lämpötilamuuntaja---");

                        //Muunnettavat Celsius-asteet
                        double cels = 10;

                        //Muunnetaan Celsius-asteet Fahrenheit-asteiksi.
                        double fahr = cels * 1.8;
                        fahr = fahr + 32;

                        //Tulostetaan muunnoksen tulos.
                        Console.WriteLine("{0} Celsiusta = {1} Fahrenheitiä.", cels, fahr);
                        Console.WriteLine();

                        break;

                    case 3:

                        //3.Tehtävä
                        //
                        //Ohjelma tekee kaikki neljä peruslaskutoimitusta kahdella luvulla.

                        Console.WriteLine("---3.Peruslaskutoimitukset---");

                        //Luvut joilla laskutoimitukset lasketaan
                        double luku1 = 8;
                        double luku2 = 5;

                        //Lasketaan peruslaskutoimitukset metodejen avulla käyttäen laskettavia lukuja parametreina.
                        Console.WriteLine(Summa(luku1, luku2));
                        Console.WriteLine(Erotus(luku1, luku2));
                        Console.WriteLine(Tulo(luku1, luku2));
                        Console.WriteLine(Jaa(luku1, luku2));
                        Console.WriteLine();

                        break;

                    case 4:

                        //4.Tehtävä
                        //
                        //Ohjelma palauttaa lukujen jakojäännöksen.

                        Console.WriteLine("---4.Jakojäännös---");

                        //Luvut joiden jakojäännös lasketaan.
                        luku1 = 5;
                        luku2 = 2;

                        //Tulostetaan luvut ja niiden jakojäännös.
                        Console.WriteLine("{0} ja {1} jakojäännös on {2}", luku1, luku2, Jakojäännös(luku1, luku2));
                        Console.WriteLine("");

                        break;

                    case 5:

                        //5.Tehtävä
                        //
                        //Ohjelma pyytää käyttäjän nimen tulostaa tervehdyksen käyttäen syötettyä nimeä.

                        Console.WriteLine("---5.Hei käyttäjä---");

                        //Pyydetään käyttäjän nimeä.
                        Console.Write("Mikä on nimesi: ");
                        string nimi = Console.ReadLine();

                        //Tulostetaan käyttäjän nimi tervehdyksessä.
                        Console.WriteLine("Hei {0}!", nimi);
                        Console.WriteLine("");

                        break;

                    case 6:

                        //6.Tehtävä
                        //
                        //Ohjelma laskee käyttäjän syöttämät luvut yhteen

                        Console.WriteLine("---6.Syötteen yhteenlaskuohjelma---");

                        //Kysytään käyttäjältä lukuja joiden summa lasketaan.
                        Console.Write("Syötä ensimmäinen luku: ");
                        luku1 = double.Parse(Console.ReadLine());
                        Console.Write("Syötä toinen luku: ");
                        luku2 = double.Parse(Console.ReadLine());

                        //Tulostetaan syötetyt luvut ja niiden summa.
                        Console.WriteLine("{0} + {1} = {2}.", luku1, luku2, luku1 + luku2);
                        Console.WriteLine();

                        break;

                    case 7:

                        //7.Tehtävä
                        //
                        //Ohjelma muuntaa syötetyn Celsius-asteen Fahrenteiteiksi.

                        Console.WriteLine("---7.Syötteen lämpötilamuuntaja---");

                        Console.Write("Syötä lämpötila Celsius-asteena: ");//Pyydetään käyttäjältä lämpötilaa celsius-asteina
                        cels = double.Parse(Console.ReadLine());

                        //Muunnetaan Celsius-asteet Fahrenheit-asteiksi.
                        fahr = cels * 1.8;
                        fahr = fahr + 32;

                        //Tulostetaan muunnoksen tulos.
                        Console.WriteLine("{0} Celsiusta = {1} Fahrenheitiä.", cels, fahr);
                        Console.WriteLine();

                        break;

                    case 8:

                        //8.Tehtävä
                        //
                        //Ohjelma tekee kaikki neljä peruslaskutoimitusta syötetylle luvulle.

                        Console.WriteLine("---8.Peruslaskutoimitukset---");

                        //Pyydetään käyttäjää syöttämään luvut joilla laskutoimitukset toteutetaan.
                        Console.Write("Anna ensimmäinen luku: ");
                        luku1 = double.Parse(Console.ReadLine());
                        Console.Write("Anna toinen luku: ");
                        luku2 = double.Parse(Console.ReadLine());

                        //Lasketaan peruslaskutoimitukset metodejen avulla käyttäen käyttäjän syötettä parametreina.
                        Console.WriteLine(Summa(luku1, luku2));
                        Console.WriteLine(Erotus(luku1, luku2));
                        Console.WriteLine(Tulo(luku1, luku2));
                        Console.WriteLine(Jaa(luku1, luku2));
                        Console.WriteLine();

                        break;

                    case 9:

                        //9.Tehtävä
                        //
                        //Ohjelma palauttaa syötettyjen lukujen jakojäännöksen.

                        Console.WriteLine("---9.Jakojäännös---");

                        //Pyydetään käyttäjältä lukuja joiden jakojäännös lasketaan.
                        Console.Write("Anna ensimmäinen luku: ");
                        luku1 = double.Parse(Console.ReadLine());
                        Console.Write("Anna toinen luku: ");
                        luku2 = double.Parse(Console.ReadLine());

                        //Tulostetaan käyttäjän antamat luvut ja niiden jakojäännös.
                        Console.WriteLine("{0} ja {1} jakojäännös on {2}", luku1, luku2, Jakojäännös(luku1, luku2));
                        Console.WriteLine("");

                        break;

                    case 10:

                        //10.Tehtävä
                        //
                        //Ohjelma pyytä käyttäjältä lukua ja laskee annetun luvun kertotaulun käyttäen silmukkaa.

                        Console.WriteLine("---10.Luvun kertotaulu---");

                        //Pyydetään käyttäjältä luku jonka kertotaulu lasketaan.
                        Console.Write("Syötä luku: ");
                        luku1 = double.Parse(Console.ReadLine());

                        //Tulostetaan kertotaulut For-silmukkaa käyttäen joka toistuu 10 kertaa.
                        for (int i = 1; i < 11; i++)//i-muuttuja kasvaa yhdestä kymmeneen jokaisella silmukan toistolla.
                        {
                            Console.WriteLine("{0} x {1} = {2}", luku1, i, luku1 * i);//i-muuttujan arvo toimii yhtälön kertojana.
                        }
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
