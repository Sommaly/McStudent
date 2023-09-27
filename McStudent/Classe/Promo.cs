using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent.Classe
{
    internal class Promo
    {
        public string nom {  get; set; }
        public List<Eleve> Eleves { get; set; }
        public Promo(string nom)
        {
            this.nom = nom;
        }
    }
}
