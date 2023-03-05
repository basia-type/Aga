using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Aga
{
    public class Garaz
    {
        private string adres;
        private int pojemnosc = 0;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;

        public string Adres 
        { 
            get { return adres; } 
            set { adres = value; } 
        }
        public int Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }

        }
        public Garaz()
        {
            adres = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }
        public Garaz (string adres_, int pojemnosc_) 
        {
            adres = adres_;
            pojemnosc = pojemnosc_;
            samochody = new Samochod[pojemnosc];
        }
        public void WprowadzSamochod(Samochod s1)
        {
            if (liczbaSamochodow < pojemnosc)
            {
                samochody[liczbaSamochodow] = s1;
                liczbaSamochodow++;
            }
            else {
                samochody[liczbaSamochodow-1] = s1;
            }
        }
        public void WyprowadzSamochod()
        {
            if (liczbaSamochodow > 0) 
            {
                liczbaSamochodow--;
                samochody[liczbaSamochodow] = null;
            }
        }
        public void WypiszInfo() 
        {
            for (int v1 = 0; v1 < liczbaSamochodow; v1++) 
            {
                if (samochody[v1] != null) { 
                    samochody[v1].WypiszInfo();
                }
            }
            Console.WriteLine("liczbaSamochodow: " + liczbaSamochodow);
            Console.WriteLine ("pojemność: " + pojemnosc);
            Console.WriteLine("adres: " + adres);
            


        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Samochod s1 = new Samochod ("Fiat", "126p", 2, 650, 6.0);
                Samochod s2 = new Samochod ("Syrena", "105", 2, 800, 7.6);
                Garaz g1 = new Garaz();
                g1.Adres = "ul. Garażowa 1";
                g1.Pojemnosc = 1;
                Garaz g2 = new Garaz("ul. Garażowa 2", 2);
                g2.Adres = "ul. Garażowa 2";


                g1.WprowadzSamochod(s1);
                g1.WypiszInfo();
                g1.WprowadzSamochod(s2);
                g1.WypiszInfo();

                g2.WypiszInfo();
                g2.WprowadzSamochod(s2);
                g2.WprowadzSamochod(s1);
                g2.WypiszInfo();

                g2.WyprowadzSamochod();
                g2.WyprowadzSamochod();
                g2.WypiszInfo();
                g2.WyprowadzSamochod();

                Console.ReadKey();
                Console.ReadLine();

            }
        }
    }
}
