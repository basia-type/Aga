﻿using Aga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aga
{
    internal class Program_Samochod
    {
        /*static void Main (string[] args)
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
}
internal class Program_Graz
{
    static void Main(string[] args)
    {
        Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
        Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
        Garaz g1 = new Garaz();
        g1.Adres = ("ul. Garażowa 1");
        g1.Pojemnosc = 1;
        Garaz g2 = new Garaz("ul. Garażowa 2", 2);
        g2.Adres = ("ul. Garażowa 2");


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
    }*/
        internal class Program_Osoba
        {
            static void Main(string[] args)

            {
                Osoba o = new Osoba("Adam", "Miś", "20.03.1980");
                Osoba o2 = new Student ("Michal", "Kot", "13.04.1990", 2, 1, 12345);
                //Osoba o3 = new Pilkarz("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Czestochowa");
                o.WypiszInfo();
                //o2.WypiszInfo();
                //o3.WypiszInfo();

                Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
                //Pilkarz p = new Pilkarz("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");

                //s.WypiszInfo();
                //p.WypiszInfo();

                //((Pilkarz)o3).StrzelGola();
                //p.StrzelGola();
                //p.StrzelGola();

                //o3.WypiszInfo();
                //p.WypiszInfo();

                Console.ReadKey();
            }
        }
    }
}

