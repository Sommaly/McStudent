using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent.Classe
{
    public class Promo
    {
        public int id { get; set; }
        public string nom {  get; set; }
        public List<Eleve> Eleves { get; set; }
        public Promo(int id,string nom)
        {
            this.id = id;
            this.nom = nom;
        }
    }
}
