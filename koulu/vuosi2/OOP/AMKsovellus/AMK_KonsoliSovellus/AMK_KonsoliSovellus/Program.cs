using System;

namespace AMK_KonsoliSovellus
{
    class AMK
    {
        // Kentät
        string amkNimi;
        string amkOsoite;
        Tutkinto[] tutkinnot;

        // Getterit ja Setterit
        public string AmkNimi
        {
            get { return amkNimi; }
            set { amkNimi = value; }
        }

        public string AmkOsoite
        {
            get { return amkOsoite; }
            set { amkOsoite = value; }
        }

        public Tutkinto[] Tutkinnot
        {
            get { return tutkinnot; }
            set { tutkinnot = value; }
        }

        // Metodit

        public void LuoUusiTutkinto(string u_tutkintoNimi, string u_tutkintoTaso)
        {
            Console.WriteLine("System: LuoUusiTutkinto metodi käytetty.");

            Tutkinto[] uusiTutkinnotArray = new Tutkinto[tutkinnot.Length + 1];

            int i = 0;

            if (tutkinnot.Length > 0)
            {
                foreach (Tutkinto u in tutkinnot)
                {
                    uusiTutkinnotArray[i] = u;
                    i++;
                }
            }
            uusiTutkinnotArray[i] = new Tutkinto(u_tutkintoNimi, u_tutkintoTaso);

            Tutkinnot = uusiTutkinnotArray;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine("System: TulostaTiedot metodi käytetty.");

            Console.WriteLine("+------------------+");

            Console.WriteLine("Koulun nimi: {0}", amkNimi);
            Console.WriteLine();

            Console.WriteLine("Koulun osoite: {0}", amkOsoite);
            Console.WriteLine();

            Console.Write("Koulun tutkinnot: ");

            for (int i = 0; i < tutkinnot.Length; i++)
            {
                Console.Write(tutkinnot[i].TutkintoID);
                Console.Write(", ");
            }

            Console.WriteLine();
            Console.WriteLine("+------------------+");
        }

        // Konstruktorit
        public AMK()
        {
            Console.WriteLine("System: AMK olio luotu");

            amkNimi = "";
            amkOsoite = "";
            tutkinnot = null;
        }

        public AMK(string u_amkNimi, string u_amkOsoite, params Tutkinto[] u_tutkinnot)
        {
            Console.WriteLine("System: AMK olio luotu");

            amkNimi = u_amkNimi;
            amkOsoite = u_amkOsoite;

            if (u_tutkinnot != null)
            {
                tutkinnot = u_tutkinnot;
            }
            else
            {
                tutkinnot = null;
            }
        }
    }

    class Tutkinto
    {
        // Kentät
        string tutkintoNimi;
        string tutkintoTaso;
        static int tutkintoLaskuri;
        string tutkintoID;
        OpintoJakso[] opintojaksot;

        // Getterit ja Setterit
        public string TutkintoNimi
        {
            get { return tutkintoNimi; }
            set { tutkintoNimi = value; }
        }

        public string TutkintoTaso
        {
            get { return tutkintoTaso; }
            set { tutkintoTaso = value; }
        }

        public string TutkintoID
        {
            get { return tutkintoID; }
            set { tutkintoID = value; }
        }

        // Metodit
        public void LuoUusiOpintojakso(string u_opintojaksoNimi)
        {
            Console.WriteLine("System: LuoUusiOpintojakso metodi käytetty.");
            
            OpintoJakso[] uusiOpintojaksoArray = new OpintoJakso[opintojaksot.Length + 1];

            int i = 0;

            if (opintojaksot.Length > 0)
            {
                foreach (OpintoJakso u in opintojaksot)
                {
                    uusiOpintojaksoArray[i] = u;
                    i++;
                }
            }

            uusiOpintojaksoArray[i] = new OpintoJakso(u_opintojaksoNimi);

            opintojaksot = uusiOpintojaksoArray;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine("System: TulostaTiedot metodi käytetty.");

            Console.WriteLine("+------------------+");

            Console.WriteLine("Tutkinnon nimi: {0}", tutkintoNimi);
            Console.WriteLine();

            Console.WriteLine("Tutkinnon taso: {0}", tutkintoTaso);
            Console.WriteLine();

            Console.Write("Tutkinnon opintojaksot: ");

            for (int i = 0; i < opintojaksot.Length; i++)
            {
                Console.Write(opintojaksot[i].OpintojaksoNimi);
                Console.Write(", ");
            }

            Console.WriteLine();
            Console.WriteLine("+------------------+");
        }

        // Konstruktorit
        public Tutkinto()
        {
            Console.WriteLine("System: Tutkinto olio luotu");

            tutkintoNimi = "";
            tutkintoTaso = "";
            tutkintoLaskuri++;
            tutkintoID = tutkintoNimi + tutkintoLaskuri.ToString();
            opintojaksot = new OpintoJakso[0];
        }

        public Tutkinto(string u_tutkintoNimi, string u_tutkintoTaso, params OpintoJakso[] u_opintojaksot)
        {
            Console.WriteLine("System: Tutkinto olio luotu");

            tutkintoNimi = u_tutkintoNimi;
            tutkintoTaso = u_tutkintoTaso;
            tutkintoLaskuri++;
            tutkintoID = tutkintoNimi + tutkintoLaskuri.ToString();

            if(opintojaksot != null)
            {
                opintojaksot = u_opintojaksot;
            }
            else
            {
                opintojaksot = new OpintoJakso[0];
            }
        }
    }

    class OpintoJakso
    {
        // Kentät
        Opettaja[] opettajatArray;
        Opiskelija[] opiskelijatArray;
        string opintojaksoNimi;

        // Getterit ja Setterit
        public string OpintojaksoNimi
        {
            get { return opintojaksoNimi; }
            set { opintojaksoNimi = value; }
        }

        // Metodit

        public void LisääUusiOpiskelija(string u_opiskelijanimi, int u_opiskelijaID)
        {
            Console.WriteLine("System: LisääUusiOpiskelija metodi käytetty.");
            
            Opiskelija[] uusiOpiskelijaArray = new Opiskelija[opiskelijatArray.Length + 1];

            int i = 0;

            if (opiskelijatArray.Length > 0)
            {
                foreach (Opiskelija u in opiskelijatArray)
                {
                    uusiOpiskelijaArray[i] = u;
                    i++;
                }
            }

            else
            {
                uusiOpiskelijaArray[i] = new Opiskelija(u_opiskelijanimi);
            }

            opiskelijatArray = uusiOpiskelijaArray;
        }

        public void LisääUusiOpettaja(string u_opettajanNimi, int u_opettajanID)
        {
            Console.WriteLine("System: LisääUusiOpettaja metodi käytetty.");
            
            Opettaja[] uusiOpettajaArray = new Opettaja[opettajatArray.Length + 1];

            int i = 0;

            if (opettajatArray.Length > 0)
            {
                foreach (Opettaja u in opettajatArray)
                {
                    uusiOpettajaArray[i] = u;
                    i++;
                }
            }

            else
            {
                uusiOpettajaArray[i] = new Opettaja(u_opettajanNimi);
            }

            opettajatArray = uusiOpettajaArray;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine("System: TulostaTiedot metodi käytetty.");

            Console.WriteLine("+------------------+");

            Console.WriteLine("Opintojakson nimi: {0}", opintojaksoNimi);
            Console.WriteLine();

            Console.Write("Opintojakson opettajat: ");

            for (int i = 0; i < opettajatArray.Length; i++)
            {
                Console.Write(opettajatArray[i].OpettajaID);
                Console.Write(", ");
            }

            for (int i = 0; i < opiskelijatArray.Length; i++)
            {
                Console.Write(opiskelijatArray[i].OpiskelijaNimi);
                Console.Write(", ");
            }

            Console.WriteLine();
            Console.WriteLine("+------------------+");
        }

        // Konstruktorit
        public OpintoJakso()
        {
            Console.WriteLine("System: Opintojakso olio luotu");

            opintojaksoNimi = "";
        }

        public OpintoJakso(string u_opintojaksoNimi)
        {
            Console.WriteLine("System: Opintojakso olio luotu");

            opintojaksoNimi = u_opintojaksoNimi;
        }
    }

    class Opiskelija
    {
        // Kentät
        string opiskelijaNimi;
        string opiskelijaID;
        static int opiskelijaLaskuri;

        // Getterit ja Setterit
        public string OpiskelijaNimi
        {
            get { return opiskelijaNimi; }
            set { opiskelijaNimi = value; }
        }

        public string OpiskelijaID
        {
            get { return opiskelijaID; }
            set { opiskelijaID = value; }
        }

        public int OpiskelijaLaskuri
        {
            get { return opiskelijaLaskuri; }
        }

        // Metodit

        public void TulostaTiedot()
        {
            Console.WriteLine("System: TulostaTiedot metodi käytetty.");

            Console.WriteLine("+------------------+");

            Console.WriteLine("Opiskelijan nimi: {0}", opiskelijaNimi);
            Console.WriteLine();

            Console.Write("Opiskelijan ID: {0}", opiskelijaID);

            Console.WriteLine();
            Console.WriteLine("+------------------+");
        }

        // Konstruktorit
        public Opiskelija()
        {
            Console.WriteLine("System: Opiskelija olio luotu");

            opiskelijaLaskuri++;
            opiskelijaNimi = "";
            opiskelijaID = opiskelijaNimi + opiskelijaLaskuri.ToString();
        }

        public Opiskelija(string u_opiskelijaNimi)
        {
            Console.WriteLine("System: Opiskelija olio luotu");

            opiskelijaLaskuri++;
            opiskelijaNimi = u_opiskelijaNimi;
            opiskelijaID = opiskelijaNimi + opiskelijaLaskuri.ToString();
        }
    }
    class Opettaja
    {
        // Kentät
        string opettajaNimi;
        string opettajaID;
        static int opettajaLaskuri;


        // Getterit ja Setterit
        public string OpettajaNimi
        {
            get { return opettajaNimi; }
            set { opettajaNimi = value; }
        }

        public string OpettajaID
        {
            get { return OpettajaID; }
            set { OpettajaID = value; }
        }

        public int OpettajaLaskuri
        {
            get { return opettajaLaskuri; }
        }

        // Metodit

        public void TulostaTiedot()
        {
            Console.WriteLine("System: TulostaTiedot metodi käytetty.");

            Console.WriteLine("+------------------+");

            Console.WriteLine("Opettajan nimi: {0}", opettajaNimi);
            Console.WriteLine();

            Console.Write("Opettajan ID: {0}", opettajaID);

            Console.WriteLine();
            Console.WriteLine("+------------------+");
        }

        // Konstruktorit
        public Opettaja()
        {
            Console.WriteLine("System: Opettaja olio luotu");

            opettajaNimi = "";
            opettajaID = opettajaNimi + opettajaLaskuri.ToString();
        }

        public Opettaja(string u_opettajaNimi)
        {
            Console.WriteLine("System: Opettaja olio luotu");

            opettajaNimi = u_opettajaNimi;
            opettajaID = opettajaNimi + opettajaLaskuri.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Olioprojekti");
            Console.WriteLine("*************************");
            Console.WriteLine();

            AMK KeudaAMK = new AMK("Keuda", "Keskikatu 3");

            KeudaAMK.TulostaTiedot();

            Console.WriteLine("Luodaan Keudalle tutkinnot.");
            Console.WriteLine();

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine();
                Console.Write("Syötä {0}. Tutkinnolle nimi: ", j + 1);
                string vastaus = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Syötä {0}. Tutkinnon Taso: ", j + 1);
                string vastaus2 = Console.ReadLine();
                Console.WriteLine();

                KeudaAMK.LuoUusiTutkinto(vastaus, vastaus2);
            }

            for (int i = 0; i < KeudaAMK.Tutkinnot.Length; i++)
            {
                Console.WriteLine();

                Console.WriteLine("Luodaan Nyt {0} tutkinnolle opintojaksot.", KeudaAMK.Tutkinnot[i].TutkintoNimi);
                Console.WriteLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine();
                    Console.Write("Syötä {0}. opintojakson nimi: ", j + 1);
                    string vastaus = Console.ReadLine();
                    Console.WriteLine();

                    KeudaAMK.Tutkinnot[i].LuoUusiOpintojakso(vastaus);
                }

            }

            for (int i = 0; i < KeudaAMK.Tutkinnot.Length; i++)
            {
                Console.WriteLine();

                Console.WriteLine("Luodaan Nyt {0} tutkinnolle opintojaksot.", KeudaAMK.Tutkinnot[i].TutkintoNimi);
                Console.WriteLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine();
                    Console.Write("Syötä {0}. opintojakson nimi: ", j + 1);
                    string vastaus = Console.ReadLine();
                    Console.WriteLine();

                    KeudaAMK.Tutkinnot[i].LuoUusiOpintojakso(vastaus);
                }

            }

            for (int i = 0; i < 3; i++)
            {
                KeudaAMK.Tutkinnot[i].TulostaTiedot();
            }
        }
    }
}
