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
            //Tämä ohjelma kysyy käyttäjältä yhtälön parametrit ja ratkaisee yhtälön ja tulostaa tuloksen
            
            //Énsin käyttäjälle kerrotaan tämänhetkinen yhtälö.
            Console.WriteLine("1. Yhtälö: x = y + 3");
            Console.Write("Anna muuttujan Y arvo: ");//Käyttäjältä kysytään muuttujien y ja x arvot.
            int y= int.Parse(Console.ReadLine());//Käyttäjän antama arvo tallennetaan muuttujaan
            Console.WriteLine();
            Console.WriteLine("1. Yhtälön tulos on x = {0}", y + 3);//Yhtälön tulos tulostetaan käyttäjälle.
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            //Sama rakenne toistuu jokaisen yhtälön kohdalla.

            Console.WriteLine("2. Yhtälö: x = y - 2");
            Console.Write("Anna muuttujan Y arvo: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("2. Yhtälön tulos on x = {0}", y -2);
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("3. Yhtälö: x = y * 5");
            Console.Write("Anna muuttujan Y arvo: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("3. Yhtälön tulos on x = {0}", y * 5);
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("4. Yhtälö: x = x / y");
            Console.Write("Anna muuttujan Y arvo: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Anna muuttujan X arvo: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("4. Yhtälön tulos on x = {0}", x / y);
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("5. Yhtälö: x = x % y");
            Console.Write("Anna muuttujan Y arvo: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Anna muuttujan X arvo: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("5. Yhtälön tulos on x = {0}", x % y);
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("6. Yhtälö: x += y");
            Console.Write("Anna muuttujan Y arvo: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Anna muuttujan X arvo: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("6. Yhtälön tulos on x = {0}", x += y);
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("7. Yhtälö: x -= y");
            Console.Write("Anna muuttujan Y arvo: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Anna muuttujan X arvo: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("7. Yhtälön tulos on x = {0}", x -= y);
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("8. Yhtälö: x *= y * 5");
            Console.Write("Anna muuttujan Y arvo: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Anna muuttujan X arvo: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("8. Yhtälön tulos on x = {0}", x *= y * 5);
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("9. Yhtälö: x /= y");
            Console.Write("Anna muuttujan Y arvo: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Anna muuttujan X arvo: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("9. Yhtälön tulos on x = {0}", x /= y);
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }
    }
}
