using System;

namespace Tehtävä_9
{
    class Televisio
    {
        //Kentät
        bool virta;
        int kanava;
        int volume;

        //Metodit
        public void VirtaPäälle() //VirtaPäälle metodi asettaa virta-kentän arvon todeksi.
        {
            Console.WriteLine("System: VirtaPäälle metodi käytetty.");
            virta = true;
        }
        public void VirtaPois() //VirtaPois metodi asettaa virta-kentän arvon epätodeksi.
        {
            Console.WriteLine("System: VirtaPois metodi käytetty.");
            virta = false;
        }
        public void VolumeUp() //VolumeUp metodi kasvattaa volume-kenttää viidellä.
        {
            Console.WriteLine("System: VolumeUp metodi käytetty.");
            if (virta == true)
            {
                if (volume + 5 > 100)
                {
                    volume = 100;
                }
                else
                {
                    volume += 5;
                } 
            }
            else
            {
                Console.WriteLine("SystemERROR: Television virta on kiinni");
            }
        }
        public void VolumeDown() //VolumeDown metodi vähentää volume-kenttää viidellä.
        {
            Console.WriteLine("System: VolumeDown metodi käytetty.");
            if (virta == true)
            {
                volume -= 5;
                if (volume - 5 < 0)
                {
                    volume = 0;
                }
                else
                {
                    volume -= 5;
                } 
            }else
            {
                Console.WriteLine("SystemERROR: Television virta on kiinni");
            }
        }
        public void VolumeSet(int value) //VolumeSet metodi muuttaa volume-kentän arvot parametrin arvoksi.
        {
            Console.WriteLine("System: VolumeSet metodi käytetty.");
            if (virta == true)
            {
                if (value <= 100 && value >= 0)
                {
                    volume = value;
                }
                else
                {
                    Console.WriteLine("SystemERROR: Volume voi olla vain 0-100.");
                } 
            }
            else
            {
                Console.WriteLine("SystemERROR: Television virta on kiinni");
            }
        }
        public void VolumeMute() //VolumeMute asettaa volume-kentän arvon nollaksi.
        {
            Console.WriteLine("System: VolumeMute metodi käytetty.");
            if (virta == true)
            {
                volume = 0; 
            }
            else
            {
                Console.WriteLine("SystemERROR: Television virta on kiinni");
            }
        }
        public void KanavaAvaa(int value) //KanavaAvaa metodi muuttaa kanava-kentän arvon parametrin arvoksi.
        {
            Console.WriteLine("System: KanavaAvaa metodi käytetty.");
            if (virta == true)
            {
                kanava = value; 
            }
            else
            {
                Console.WriteLine("SystemERROR: Television virta on kiinni");
            }
        }
        public void TulostaKentät() //TulostaKentät metodi tulostaa olion kenttien arvot konsoliin.
        {
            Console.WriteLine("System: TulostaKentät metodi käytetty.");
            Console.WriteLine("Virta: {0}",virta);
            Console.WriteLine("Volume: {0}", volume);
            Console.WriteLine("Kanava: {0}", kanava);
        }

        //Konstruktorit
        public Televisio() //Vakiokonstruktori
        {
            Console.WriteLine("System: Televisio-olio luotu vakiokonstruktorilla.");
            virta = false ;
            volume = 0;
            kanava = 0;
        }
        public Televisio(bool u_virta, int u_volume, int u_kanava) //Ylikuormituskonstruktori
        {
            Console.WriteLine("System: Televisio-olio luotu ylikuormituskonstruktorilla.");
            virta = u_virta;
            volume = u_volume;
            kanava = u_kanava;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Oliotehtävä 9");
            Console.WriteLine("**************************");
            Console.WriteLine();

            Televisio Televisio1 = new Televisio();

            Televisio1.TulostaKentät();

            Televisio1.VirtaPäälle();

            Televisio1.KanavaAvaa(12);
            Televisio1.VolumeUp();
            Televisio1.TulostaKentät();

            Televisio1.VolumeDown();
            Televisio1.TulostaKentät();
            
            Televisio1.VolumeSet(60);
            Televisio1.TulostaKentät();

            Televisio1.VolumeMute();
            Televisio1.TulostaKentät();

            Televisio1.VirtaPois();

            Televisio1.VolumeMute();

            Televisio Televisio2 = new Televisio(true, 100, 10);

            Televisio2.TulostaKentät();
        }
    }
}
