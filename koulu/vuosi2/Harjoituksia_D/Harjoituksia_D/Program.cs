using System;

namespace Harjoituksia_D
{
    class Program
    {
        public double 
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Harjoituksia D");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            //1.Tehtävä
            //
            //Ohjelma laskee kaksi numeroa yhteen.

            Console.WriteLine("---Yhteenlaskuohjelma---");
            Console.Write("Syötä ensimmäinen luku: ");
            double luku1 = double.Parse(Console.ReadLine());

            Console.Write("Syötä toinen luku: ");
            double luku2 = double.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}.", luku1, luku2, luku1 + luku2);
            Console.WriteLine("");

            //2.Tehtävä
            //
            //Ohjelma muuttaa annetun Celsius-asteen Fahrenheitieksi.

            Console.WriteLine("---Lämpötilamuuntaja---");
            Console.Write("Syötä lämpötila Celsius-asteena: ");
            double cels = double.Parse(Console.ReadLine());

            double fahr = cels * 1.8;
            fahr = fahr + 32;
            Console.WriteLine("{0} Celsiusta = {1} Fahrenheitiä.", cels, fahr);
            Console.WriteLine();

            //3.Tehtävä
            //
            //Ohjelma tekee kaikki neljä peruslaskutoimitusta syötetylle luvulle.
        }
    }
}
