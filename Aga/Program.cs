using Aga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Aga
{
    public class Samochod
    {
        private string marka = "Fiat";
        private string model = "126p";
        private int iloscDrzwi = 2;
        private double pojemnoscSilnika = 650;
        private double srednieSpalanie;
        public static int iloscSamochodow = 0;
        public double dlugoscTrasy = 200;
        public double cenaPaliwaL = 8.0;

        public Samochod() {
            marka = "nieznana";
            model = "nieznany";
            iloscSamochodow++;
        }
        public Samochod(string marka_, string model_, int iloscDrzwi_, double pojemnoscSilnika_, double srednieSpalanie_) {

            marka = marka_;
            model = model_;
            iloscDrzwi = iloscDrzwi_;
            pojemnoscSilnika = pojemnoscSilnika_;
            srednieSpalanie = srednieSpalanie_;
            iloscSamochodow++;
        }
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }
        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }
        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }
        public double ObliczSpalanie(double dlugoscTrasy) {

            return (srednieSpalanie * dlugoscTrasy) / 100.0;
        }
        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwaL)
        {

            return (srednieSpalanie * cenaPaliwaL);
        }
        public double cenaPaliwa(int dlugoscTrasy, double cenaPaliwa)
        {
            return cenaPaliwaL * dlugoscTrasy;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("marka:" + marka);
            Console.WriteLine("model:" + model);
            Console.WriteLine("ilość drzwi:" + iloscDrzwi);
            Console.WriteLine("średnie spalanie:" + srednieSpalanie);
            Console.WriteLine("cena paliwa za litr:" + cenaPaliwaL);
        }
        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("iloscSamochodow:" + iloscSamochodow); 
        }
    }
    
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
        Samochod.WypiszIloscSamochodow();
        Samochod s1 = new Samochod();
        s1.WypiszInfo();
        s1.Marka = "Fiat";
        s1.Model = "126p";
        s1.IloscDrzwi = 2;
        s1.PojemnoscSilnika = 650;
        s1.SrednieSpalanie = 6.0;
        s1.WypiszInfo();
        Samochod.WypiszIloscSamochodow();
        Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
        s2.WypiszInfo();
        double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
        Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);
        Samochod.WypiszIloscSamochodow();
        Console.ReadKey();

        Console.ReadLine();
        }
    }
