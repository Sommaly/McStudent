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
        public string commentaire {  get; set; }
        public Boolean isObligatoire {  get; set; }
        public string reponse {  get; set; }
        public TP TP { get; set; }
        public Tache(int id,string nom, int points, string commentaire, Boolean isObligatoire, string reponse)
        {
            this.id = id;
            this.nom = nom;
            this.points = points;
            this.commentaire = commentaire;
            this.isObligatoire = isObligatoire;
            this.reponse = reponse;
            this.TP = null;
        }
    }
}
