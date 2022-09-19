using System;

namespace Harjoituksia_B_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Harjoituksia B");
            Console.WriteLine("-----------------------------");
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
                        //Tämä ohjelma kysyy käyttäjältä yhtälön parametrit ja ratkaisee yhtälön ja tulostaa tuloksen
                        Console.WriteLine("---1.Tehtävä---");

                        //Ensin käyttäjälle kerrotaan tämänhetkinen yhtälö.
                        Console.WriteLine("1. Yhtälö: x = y + 3");
                        Console.Write("Anna muuttujan Y arvo: ");//Käyttäjältä kysytään muuttujien y ja x arvot.
                        int y = int.Parse(Console.ReadLine());//Käyttäjän antama arvo tallennetaan muuttujaan
                        Console.WriteLine();
                        Console.WriteLine("1. Yhtälön tulos on x = {0}", y + 3);//Yhtälön tulos tulostetaan käyttäjälle.
                        Console.WriteLine("--------------------------");
                        Console.WriteLine();
                        //Sama rakenne toistuu jokaisen tehtävän kohdalla, mutta suoritettava yhtälö muuttuu.

                        break;

                    case 2:

                        //2.Tehtävä
                        Console.WriteLine("---2.Tehtävä---");

                        Console.WriteLine("2. Yhtälö: x = y - 2");
                        Console.Write("Anna muuttujan Y arvo: ");
                        y = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("2. Yhtälön tulos on x = {0}", y - 2);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine();

                        break;

                    case 3:

                        //3.Tehtävä
                        Console.WriteLine("---3.Tehtävä---");

                        Console.WriteLine("3. Yhtälö: x = y * 5");
                        Console.Write("Anna muuttujan Y arvo: ");
                        y = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("3. Yhtälön tulos on x = {0}", y * 5);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine();

                        break;

                    case 4:

                        //4.Tehtävä
                        Console.WriteLine("---4.Tehtävä---");

                        Console.WriteLine("4. Yhtälö: x = x / y");
                        Console.Write("Anna muuttujan Y arvo: ");
                        y = int.Parse(Console.ReadLine());
                        Console.Write("Anna muuttujan X arvo: ");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("4. Yhtälön tulos on x = {0}", x / y);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine();

                        break;

                    case 5:

                        //5.Tehtävä
                        Console.WriteLine("---5.Tehtävä---");

                        Console.WriteLine("5. Yhtälö: x = x % y");
                        Console.Write("Anna muuttujan Y arvo: ");
                        y = int.Parse(Console.ReadLine());
                        Console.Write("Anna muuttujan X arvo: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("5. Yhtälön tulos on x = {0}", x % y);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine();

                        break;

                    case 6:

                        //6.Tehtävä
                        Console.WriteLine("---6.Tehtävä---");

                        Console.WriteLine("6. Yhtälö: x += y");
                        Console.Write("Anna muuttujan Y arvo: ");
                        y = int.Parse(Console.ReadLine());
                        Console.Write("Anna muuttujan X arvo: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("6. Yhtälön tulos on x = {0}", x += y);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine();

                        break;

                    case 7:

                        //7.Tehtävä
                        Console.WriteLine("---7.Tehtävä---");

                        Console.WriteLine("7. Yhtälö: x -= y");
                        Console.Write("Anna muuttujan Y arvo: ");
                        y = int.Parse(Console.ReadLine());
                        Console.Write("Anna muuttujan X arvo: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("7. Yhtälön tulos on x = {0}", x -= y);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine();

                        break;

                    case 8:

                        //8.Tehtävä
                        Console.WriteLine("---8.Tehtävä---");

                        Console.WriteLine("8. Yhtälö: x *= y * 5");
                        Console.Write("Anna muuttujan Y arvo: ");
                        y = int.Parse(Console.ReadLine());
                        Console.Write("Anna muuttujan X arvo: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("8. Yhtälön tulos on x = {0}", x *= y * 5);
                        Console.WriteLine("--------------------------");
                        Console.WriteLine();

                        break;

                    case 9:

                        //9.Tehtävä
                        Console.WriteLine("---9.Tehtävä---");

                        Console.WriteLine("9. Yhtälö: x /= y");
                        Console.Write("Anna muuttujan Y arvo: ");
                        y = int.Parse(Console.ReadLine());
                        Console.Write("Anna muuttujan X arvo: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("9. Yhtälön tulos on x = {0}", x /= y);
                        Console.WriteLine("--------------------------");
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
