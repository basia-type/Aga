using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aga
{
    public class Osoba
    {
        protected string imie = null;
        protected string nazwisko = null;
        protected string dataUrodzenia = null;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public string DataUrodzenia
        {
            get { return dataUrodzenia; }
            set { dataUrodzenia = value; }
        }
        public Osoba()
        {
            imie = "nieznany";
            nazwisko = "nieznany";
            dataUrodzenia = "nieznana";
        }
        public Osoba(string imie_, string nazwisko_, string dataUrodzenia_)
        {
            Imie = imie_;
            Nazwisko = nazwisko_;
            DataUrodzenia = dataUrodzenia_;
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine(Imie, Nazwisko, DataUrodzenia);
        }
        public class Student: Osoba
        {
            private int rok;
            private int grupa
            private int nrIndeksu;
            private List<string> oceny = new List<string>();
            Ocena s = new Ocena();
            Ocena s2 = new Ocena();

            public int Rok
            {
                get { return rok; }
                set { rok = value; }
            }
            public int Grupa
            {
                get { return grupa; }
                set { grupa = value; }
            }
            public int NrIndeksu
            {
                get { return nrIndeksu; }
                set { nrIndeksu = value; }
            }
            public Student()
            {
                rok = 0;
                grupa = 0;
                nrIndeksu = 0;
            }
            public Student(int rok_, int grupa_, int nrIndeksu_)
            {
                Rok = rok_;
                Grupa = grupa_;
                nrIndeksu = nrIndeksu_;
            }
            public override void WypiszInfo()
            {
                Console.WriteLine("rok:"+ rok, "grupa:"+ grupa, "nrIndeksu:"+ nrIndeksu);
            }
            /*public void listaOcen.Add(s)
            {
                return (s);
            }
            /*public void WypiszOceny()
            {
                foreach (string nazwaPrzedmiotu in Numbers)
                {
                    Console.Write(Number + "  ");*/
            
            public void UsunOcene(string nazwaPrzedmiotu)
            {
                Console.WriteLine("nazwaPrzedmiotu"+ nazwaPrzedmiotu);
            }
            //public void listaOcena.Clear ();

            public class Ocena: Student
            {
                private string nazwaPrzedmiotu;
                private string data;
                private double wartosc;


                public string NazwaPrzedmiotu
                {
                    get { return nazwaPrzedmiotu; }
                    set { nazwaPrzedmiotu = value; }
                }
                public string Data
                {
                    get { return data; }
                    set { data = value; }
                }
                public double Wartosc
                {
                    get { return wartosc; }
                    set { wartosc = value; }
                }
                public Ocena()
                {
                    nazwaPrzedmiotu = "nieznana";
                    data = "nieznana";
                    wartosc = 0;
                }

                public Ocena(string nazwaPrzedmoitu_, string data_, double wartosc_)

                {
                    NazwaPrzedmiotu = nazwaPrzedmoitu_;
                    Data = data_;
                    Wartosc = wartosc_;
                }
                public void WypiszInfo()
                {
                    Console.WriteLine("nazwaPrzedmiotu" + nazwaPrzedmiotu, "data" + data, "wartosc" + wartosc);
                }
                public class Pilkarz: Osoba
                {
                    private string pozycja;
                    private string klub;
                    private int liczbaGoli = 0;

                    public string Pozycja
                    {
                        get { return pozycja; }
                        set { pozycja = value; }
                    }
                    public string Klub
                    {
                        get { return klub; }
                        set { klub = value; }
                    }
                    public int LiczbaGoli
                    {
                        get { return liczbaGoli; }
                        set { liczbaGoli = value; }
                    }
                    public Pilkarz()
                    {
                        pozycja = "nieznana";
                        klub = "nieznany";
                        liczbaGoli = 0;
                    }
                    public Pilkarz(string pozycja_, string klub_, int liczbaGoli_)
                    {
                        pozycja = pozycja_;
                        klub = klub_;
                        this.liczbaGoli = liczbaGoli_;
                    }
                    public override void WypiszInfo()
                    {
                        Console.WriteLine("pozycja:" + pozycja, "klub:" + klub, "liczbaGoli:" + liczbaGoli);
                    }
                    public void StrzelGola()
                    {
                        Console.WriteLine("pozycja:" + pozycja, "klub:" + klub, "liczbaGoli:" + liczbaGoli);
                    }
                }
            }
        }


    }
}



   


