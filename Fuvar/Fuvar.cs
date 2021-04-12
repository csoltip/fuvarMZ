using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuvar
{
    class Fuvar : IComparable<Fuvar>
    {
        //taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja
        public int Id { get; set; }
        public string Indulas { get; set; }
        public int Idotartam { get; set; }
        public double Tavolsag { get; set; }
        public double Viteldij { get; set; }
        public double Borravalo { get; set; }
        public string FizetesiMod { get; set; }

        //a fájl egy sora: 5240;2016-12-15 23:45:00;900;2,5;10,75;2,45;bankkártya
        public Fuvar(string sor)
        {
            string[] s = sor.Split(';');
            Id = int.Parse(s[0]);
            Indulas = s[1];
            Idotartam = int.Parse(s[2]);
            Tavolsag = double.Parse(s[3]);
            Viteldij = double.Parse(s[4]);
            Borravalo = double.Parse(s[5]);
            FizetesiMod = s[6];
        }

        public int CompareTo(Fuvar other)
        {
            return this.Indulas.CompareTo(other.Indulas);
        }
    }
}
