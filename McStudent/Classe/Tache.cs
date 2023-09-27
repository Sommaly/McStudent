using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent.Classe
{
    internal class Tache
    {
        public string nom {  get; set; }
        public int points { get; set; }
        public string commentaire {  get; set; }
        public Boolean isObligatoire {  get; set; }
        public string reponse {  get; set; }
        public Tache(string nom, int points, string commentaire, Boolean isObligatoire, string reponse)
        {
            this.nom = nom;
            this.points = points;
            this.commentaire = commentaire;
            this.isObligatoire = isObligatoire;
            this.reponse = reponse;
        }
    }
}
