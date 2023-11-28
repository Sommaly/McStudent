using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent.Classe
{
    public class Tache
    {
        public int id { get; set; }
        public string nom {  get; set; }
        public int points { get; set; }
        public Boolean isObligatoire {  get; set; }
        public TP TP { get; set; }
        public Tache(int id,string nom, int points, Boolean isObligatoire, TP TP)
        {
            this.id = id;
            this.nom = nom;
            this.points = points;
            this.isObligatoire = isObligatoire;
            this.TP = TP;
        }
    }
}
