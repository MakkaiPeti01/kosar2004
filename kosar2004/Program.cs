using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kosar2004
{
    class Program
    {
        static List<Meccs> meccsek = new List<Meccs>();
        static Dictionary<string, int> stadion = new Dictionary<string, int>();
        static void Masodik()
        {
            StreamReader olvas = new StreamReader("eredmenyek.csv");
            olvas.ReadLine();
            while (!olvas.EndOfStream)
            {
                meccsek.Add(new Meccs(olvas.ReadLine()));
            }
            olvas.Close();
        }
        static void Harmadik()
        {
            int hazai = 0;
            int idegen = 0;
            foreach (var i in meccsek)
            {
                if (i.Hazai == "Real Madrid")
                {
                    hazai++;
                }
            }
            foreach (var i in meccsek)
            {
                if (i.Idegen == "Real Madrid")
                {
                    idegen++;
                }
            }
            Console.WriteLine($"3. feladat: Real Madrid: Hazai: {hazai}, Idegen: {idegen}");
        }
        static void Negyedik()
        {
            bool dontetlen = true;
            foreach (var i in meccsek)
            {
                if (i.HPont == i.IPont)
                {
                    dontetlen = true;
                }
                else
                    dontetlen = false;
            }
            if (dontetlen)
            {
                Console.WriteLine("4. feladat: Volt döntetlen? Igen");
            }
            else
                Console.WriteLine("4. feladat: Volt döntetlen? Nem");
        }
        static void Otodik()
        {
            string nev = "";
            foreach (var i in meccsek)
            {
                if (i.Hazai.Contains("Barcelona"))
                {
                    nev = i.Hazai;
                }
            }
            Console.WriteLine("5. feladat: barcelonai csapat neve: {0}",nev);
        }
        static void Hatodik()
        {
            var nov = from n in meccsek
                      where n.Ido == "2004-11-21"
                      select n;
            Console.WriteLine("6. feladat:");
            foreach (var i in nov)
            {
                Console.WriteLine($"\t{i.Hazai}");
            }
        }
        static void Hetedik()
        {
            Console.WriteLine("7. feladat:");
            foreach (var i in meccsek)
            {
                if (!stadion.ContainsKey(i.Hely))
                {
                    stadion.Add(i.Hely, 0);
                }
            }
            foreach (var i in meccsek)
            {
                stadion[i.Hely]++;
            }
            foreach (var i in stadion)
            {
                if (i.Value > 20)
                {
                    Console.WriteLine($"\t{i.Key} {i.Value}");
                }
            }
        }
        static void Main(string[] args)
        {
            //var h = new Meccs("7up Joventut","Adecco Estudiantes",81,73,"Palacio Mun. De Deportes De Badalona","2005-04-03");
            //Console.WriteLine($"{h.Hazai} - {h.Idegen} ({h.HPont} {h.IPont})");
            Masodik();
            Harmadik();
            Negyedik();
            Otodik();
            Hatodik();
            Hetedik();
            Console.ReadKey();
        }
    }
}
