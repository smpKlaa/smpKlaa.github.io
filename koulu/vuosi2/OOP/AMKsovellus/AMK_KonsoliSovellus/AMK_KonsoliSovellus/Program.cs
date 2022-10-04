using System;
using System.Runtime.InteropServices;

namespace AMK_KonsoliSovellus
{
    class AMK
    {
        //Kentät
        private string amkNimi;
        private string osoite;

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

        //Konstruktorit
        public AMK()
        {
            amkNimi = "";
            osoite = "";
        }
        public AMK(string u_amkNimi, string u_osoite)
        {
            amkNimi = u_amkNimi;
            osoite = u_osoite;
        }
    }
    class Tutkinto : AMK
    {
        //Kentät
        private string tutkintoNimi;
        private string tutkintoTaso;

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

        //Konstruktorit
        public Tutkinto()
        {
            tutkintoNimi = "";
            tutkintoTaso = "";
        }
        public Tutkinto(string u_tutkintoNimi, string u_tutkintoTaso)
        {
            tutkintoNimi = u_tutkintoNimi;
            tutkintoTaso = u_tutkintoTaso;
        }
    }
    class OpintoJakso : Tutkinto
    {
        //Kentät
        private string OpintoJaksoNimi;

        //Getterit ja Setterit
        public string opintoJaksoNimi
        {
            set { opintoJaksoNimi = value; }
            get { return opintoJaksoNimi; }
        }

        //Konstruktorit
        public OpintoJakso()
        {
            OpintoJaksoNimi = "";
        }
        public OpintoJakso(string u_opintoJaksoNimi)
        {
            OpintoJaksoNimi = u_opintoJaksoNimi;
        }
    }
    class Opettaja : OpintoJakso
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
    class Opiskelija : OpintoJakso
    {
        //Kentät
        private string opiskelijaNimi;
        static int opiskelijaLaskuri;

        //Getterit ja Setterit
        public string OpiskelijaNimi
        {
            get { return opiskelijaNimi; }
            set { opiskelijaNimi = value; }
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

            AMK KeudaKerava = new AMK("Keuda", "Keskikatu 3");
            Tutkinto TIVI = new Tutkinto("Tieto- ja viestintätekniikka", "amk");
            OpintoJakso Perustehtävät = new OpintoJakso("Perustehtävät");
            Opettaja Opettaja1 = new Opettaja("Antti Rönkkö");
            Opiskelija Opiskelija1 = new Opiskelija("Sampo Klaavo");

            Opiskelija1.AMKNimi = KeudaKerava.AMKNimi;

            Console.WriteLine(KeudaKerava.AMKNimi);
            Console.WriteLine(Opiskelija1.AMKNimi);


            Tutkinto TIVI1 = new Tutkinto("TIVI2", "YAMK");
        }
    }
}
