using System;
using System.Collections.Generic;

namespace AMK_KonsoliSovellus
{
    class AMK //--------------------------------------------------------------------
    {
        //Kentät
        private string amkNimi = "Keuda";
        private string osoite = "Keskikatu 3";
        private List<Tutkinto> tutkinnot = new List<Tutkinto>();

        //Getterit ja Setterit
        public string AMKNimi
        {
            get { return amkNimi; }
            set { amkNimi = value; }
        }
        public string Osoite
        {
            get { return osoite; }
            set { osoite = value; }
        }
        public List<Tutkinto> Tutkinnot
        {
            get { return tutkinnot; }
        }

        //Konstruktorit
        public AMK()
        {
            amkNimi = "";
            osoite = "";
            tutkinnot = null;
        }
        public AMK(string u_amkNimi, string u_osoite, params Tutkinto[] parameter)
        {
            amkNimi = u_amkNimi;
            osoite = u_osoite;
            foreach (Tutkinto tutkinto in parameter)
            {
                tutkinnot.Add(tutkinto);
            }
        }
    }
    class Tutkinto : AMK //---------------------------------------------------------
    {
        //Kentät
        private string tutkintoNimi;
        private string tutkintoTaso;
        private List<OpintoJakso> jaksot = new List<OpintoJakso>();

        //Getterit ja Setterit
        public string TutkintoNimi
        {
            set { tutkintoNimi = value; }
            get { return tutkintoNimi; }
        }
        public string TutkintoTaso
        {
            get { return tutkintoTaso; }
            set { tutkintoTaso = value; }
        }
        public List<OpintoJakso> Jaksot
        {
            get { return jaksot; }
        }

        //Metodit
        public void AddJakso(params OpintoJakso[] parameter)
        {
            foreach (OpintoJakso jakso in parameter)
            {
                jaksot.Add(jakso);
            }
        }
        public void TutkintoTiedot()
        {
            Console.WriteLine("+--------------------+");
            Console.WriteLine("|  Tutkinnon Tiedot  |");
            Console.WriteLine("+--------------------+");
            Console.WriteLine();

            Console.WriteLine("Opintojakson nimi:");
            Console.WriteLine(" -" + tutkintoNimi);
            Console.WriteLine();

            Console.WriteLine("OpintoJaksot:");
            foreach (OpintoJakso jakso in jaksot)
            {
                Console.WriteLine(" -" + jakso.OpintoJaksoNimi);
            }
            Console.WriteLine("Jaksoja yhteensä: " + jaksot.Count);
            Console.WriteLine();

            Console.WriteLine("Tutkintotaso:");
            Console.WriteLine(tutkintoTaso);
            Console.WriteLine("+--------------------+");
            Console.WriteLine();
        }

        //Konstruktorit
        public Tutkinto()
        {
            tutkintoNimi = "";
            tutkintoTaso = "";
            jaksot = null;
        }
        public Tutkinto(string u_tutkintoNimi, string u_tutkintoTaso, params OpintoJakso[] parameter)
        {
            tutkintoNimi = u_tutkintoNimi;
            tutkintoTaso = u_tutkintoTaso;
            foreach (OpintoJakso jakso in parameter)
            {
                jaksot.Add(jakso);
            }
        }
    }
    class OpintoJakso : Tutkinto //-------------------------------------------------
    {
        //Kentät
        private string opintoJaksoNimi;
        private List<Opettaja> opettajat = new List<Opettaja>();
        private List<Opiskelija> opiskelijat = new List<Opiskelija>();

        //Getterit ja Setterit
        public string OpintoJaksoNimi
        {
            set { opintoJaksoNimi = value; }
            get { return opintoJaksoNimi; }
        }
        public List<Opettaja> Opettajat
        {
            get { return opettajat; }
        }
        public List<Opiskelija> Opiskelijat
        {
            get { return opiskelijat; }
        }

        //Metodit
        public void AddOpe(params Opettaja[] parameter)
        {
            foreach (Opettaja opettaja in parameter)
            {
                opettajat.Add(opettaja);
            }
        }
        public void AddOpiskelija(params Opiskelija[] parameter)
        {
            foreach (Opiskelija opiskelija in parameter)
            {
                opiskelijat.Add(opiskelija);
            }
        }
        public void OpintoJaksonTiedot()
        {
            Console.WriteLine("+-------------------+");
            Console.WriteLine("|Opintojakson Tiedot|");
            Console.WriteLine("+-------------------+");
            Console.WriteLine();

            Console.WriteLine("Opintojakson nimi:");
            Console.WriteLine(" -" + OpintoJaksoNimi);
            Console.WriteLine();

            Console.WriteLine("Opettajat:");
            foreach (Opettaja opettaja in opettajat)
            {
                Console.WriteLine(" -" + opettaja.OpettajaNimi);
            }
            Console.WriteLine("Opettajia yhteensä: " + opettajat.Count);
            Console.WriteLine();

            Console.WriteLine("Opiskelijat:");
            foreach (Opiskelija opiskelija in opiskelijat)
            {
                Console.WriteLine(" -" + opiskelija.OpiskelijaNimi);
            }
            Console.WriteLine("Opiskelijoita yhteensä: " + opiskelijat.Count);
            Console.WriteLine("+-------------------+");
            Console.WriteLine();
        }

        //Konstruktorit
        public OpintoJakso()
        {
            OpintoJaksoNimi = "";
            opettajat = null;
            opiskelijat = null;
        }
        public OpintoJakso(string u_opintoJaksoNimi, Opettaja[] u_opettaja, Opiskelija[] u_opiskelija)
        {
            OpintoJaksoNimi = u_opintoJaksoNimi;
            foreach (Opettaja opettaja in u_opettaja)
            {
                opettajat.Add(opettaja);
            }
            foreach (Opiskelija opiskelija in u_opiskelija)
            {
                opiskelijat.Add(opiskelija);
            }
        }
    }
    class Opettaja : OpintoJakso //-------------------------------------------------
    {
        //Kentät
        private string opettajaNimi;

        //Getterit ja Setterit
        public string OpettajaNimi
        {
            get { return opettajaNimi; }
            set { opettajaNimi = value; }
        }

        //Konstruktorit
        public Opettaja()
        {
            opettajaNimi = "";
        }
        public Opettaja(string u_opettajaNimi)
        {
            opettajaNimi = u_opettajaNimi;
        }
    }
    class Opiskelija : OpintoJakso //-----------------------------------------------
    {
        //Kentät
        private string opiskelijaNimi;
        public static int opiskelijaLaskuri { get; set; }

        //Getterit ja Setterit
        public string OpiskelijaNimi
        {
            get { return opiskelijaNimi; }
            set { opiskelijaNimi = value; }
        }

        //Metodit
        public static int OpiskelijaLaskuri()
        {
            return opiskelijaLaskuri;
        }

        //Konstruktorit
        public Opiskelija()
        {
            opiskelijaNimi = "";
            opiskelijaLaskuri++;
        }
        public Opiskelija(string u_opiskelijaNimi)
        {
            opiskelijaNimi = u_opiskelijaNimi;
            opiskelijaLaskuri++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sampo Klaavo Olioprojekti");
            Console.WriteLine("*************************");
            Console.WriteLine();

            Opettaja m0 = new Opettaja("Opettaja Jukka");
            Opettaja m1 = new Opettaja("Opettaja Pirjo");
            Opettaja m2 = new Opettaja("Opettaja Martta");

            Opiskelija o0 = new Opiskelija("Lotta Jokela");
            Opiskelija o1 = new Opiskelija("Miska Muukalainen");
            Opiskelija o2 = new Opiskelija("Jaska Jokunen");
            Opiskelija o3 = new Opiskelija("Mikko Maalainen");
            Opiskelija o4 = new Opiskelija("Jaakko Jokitie");
            Opiskelija o5 = new Opiskelija("Joonas Nieminen");
            Opiskelija o6 = new Opiskelija("Arttu Aurinkoinen");
            Opiskelija o7 = new Opiskelija("Lilja Hölmä");
            Opiskelija o8 = new Opiskelija("Konsta Alikulju");
            Opiskelija o9 = new Opiskelija("Ronja Ryövärintytär");

            OpintoJakso Matikka1 = new OpintoJakso("Matikka1", new Opettaja[] { m1 }, new Opiskelija[] { o0, o1, o2 });
            OpintoJakso Ohjelmointi1 = new OpintoJakso("Ohjelmointi", new Opettaja[] { m2, m1 }, new Opiskelija[] { o3, o4, o5 });
            OpintoJakso Englanti1 = new OpintoJakso("Englanti1", new Opettaja[] { m0, m1 }, new Opiskelija[] { o6, o7, o8 });
            OpintoJakso ÄidinKieli1 = new OpintoJakso("ÄidinKieli1", new Opettaja[] { m0 }, new Opiskelija[] { o0, o1, o2 });
            OpintoJakso ÄidinKieli2 = new OpintoJakso("ÄidinKieli2", new Opettaja[] { m2, m0 }, new Opiskelija[] { o6, o7, o8 });
            OpintoJakso Matikka2 = new OpintoJakso("Matikka2", new Opettaja[] { m1 }, new Opiskelija[] { o7, o8, o9 });

            Tutkinto Tivi = new Tutkinto("Tieto- ja Viestintätekniikka", "akm", new OpintoJakso[] { Matikka1, Ohjelmointi1, Englanti1 });
            Tutkinto Ohjl = new Tutkinto("OhjelmistoKehittäjä", "yakm", new OpintoJakso[] { Matikka2, ÄidinKieli1, ÄidinKieli2 });
            Tutkinto Ittuk = new Tutkinto("IT-Tuki", "akm", new OpintoJakso[] { Matikka1, ÄidinKieli1, Matikka2 });

            Tivi.TutkintoTiedot();
            Ohjl.TutkintoTiedot();
            Ittuk.TutkintoTiedot();

            Matikka1.OpintoJaksonTiedot();
            Matikka2.OpintoJaksonTiedot();
            ÄidinKieli1.OpintoJaksonTiedot();
            ÄidinKieli2.OpintoJaksonTiedot();
            Englanti1.OpintoJaksonTiedot();
            Ohjelmointi1.OpintoJaksonTiedot();

            Console.WriteLine("Oppilaita Yhteensä: " + Opiskelija.OpiskelijaLaskuri());

        }
    }
}
