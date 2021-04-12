using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Program
    {
        private string[] sorok;
        private List<Fuvar> fuvarok;

        public void indit()
        {
            feladat2();
            feladat3();
        }

        static void Main(string[] args)
        {
            //new Program().indit();
            
            Program prg = new Program();
            prg.indit();
            //prg.feladat2();
            //prg.feladat3();
            
            /*
            feladat2();

            //3
            int N = feladat3();

            //4 
            int fuvarDb = 0;
            double bevetel = 0;
            foreach (Fuvar fuvar in fuvarok)
            {
                if (fuvar.Id == 6185)
                {
                    fuvarDb++;
                    bevetel += fuvar.Viteldij + fuvar.Borravalo;
                }
            }
            Console.WriteLine($"4. feladat: {fuvarDb} fuvar alatt: {bevetel}$");

            //5
            Console.WriteLine("5. feladat:");
            Dictionary<string, int> fizModDb = new Dictionary<string, int>();
            foreach (Fuvar fuvar in fuvarok)
            {
                string kulcs = fuvar.FizetesiMod;
                if (fizModDb.ContainsKey(kulcs))
                {
                    fizModDb[kulcs]++;
                }
                else
                {
                    fizModDb.Add(kulcs, 1);
                }
            }
            foreach (KeyValuePair<string, int> item in fizModDb)
            {
                Console.WriteLine($"{item.Key}: {item.Value} fuvar");
            }

            //6
            double osszMerfold = 0;
            foreach (Fuvar fuvar in fuvarok)
            {
                osszMerfold += fuvar.Tavolsag;
            }
            Console.WriteLine($"6. feladat: {osszMerfold * 1.6:F2} km");

            //7
            Console.WriteLine($"7. feladat: leghoszabb fuvar:");
            int maxIdotartamInd = 0;
            for (int i = 1; i < N; i++)
            {
                if (fuvarok[i].Idotartam > fuvarok[maxIdotartamInd].Idotartam)
                {
                    maxIdotartamInd = i;
                }
            }
            Console.WriteLine($"\tfuvar hossza: {fuvarok[maxIdotartamInd].Idotartam} másodperc");
            Console.WriteLine($"\ttaxi id: {fuvarok[maxIdotartamInd].Id}");
            Console.WriteLine($"\tmegtett távolság: {fuvarok[maxIdotartamInd].Tavolsag:F1} km");//a minta szerint ez jó, de ez MPm és nem km
            Console.WriteLine($"\tviteldíj: {fuvarok[maxIdotartamInd].Viteldij} $");

            //8
            Console.WriteLine("8. feladt: \"hibak.txt\"");
            List<Fuvar> hibasFuvarok = new List<Fuvar>();
            foreach (Fuvar fuvar in fuvarok)
            {
                if (fuvar.Idotartam > 0 && fuvar.Viteldij > 0 && fuvar.Tavolsag == 0)
                {
                    hibasFuvarok.Add(fuvar);
                }
            }

            hibasFuvarok.Sort();

            List<string> hibasSorok = new List<string>();
            hibasSorok.Add(sorok[0]);
            foreach (Fuvar fuvar in hibasFuvarok)
            {
                //taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja
                string sor = "";
                sor += fuvar.Id + ";";
                sor += fuvar.Indulas + ";";
                sor += fuvar.Idotartam + ";";
                sor += fuvar.Tavolsag + ";";
                sor += fuvar.Viteldij + ";";
                sor += fuvar.Borravalo + ";";
                sor += fuvar.FizetesiMod + "";
                hibasSorok.Add(sor);
            }

            File.WriteAllLines("hibak.txt", hibasSorok, Encoding.UTF8);
            */
            Console.ReadLine();
        }

        private int feladat3()
        {
            int N = fuvarok.Count;
            Console.WriteLine($"3. feladat: {N} fuvar");
            return N;
        }

        private void feladat2()
        {
            //2
            sorok = File.ReadAllLines("fuvar.csv");
            fuvarok = new List<Fuvar>();
            foreach (string sor in sorok.Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));
            }
        }
    }
}
