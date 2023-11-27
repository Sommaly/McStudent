using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent.Classe
{
    public class Eleve
    {
        public int id {  get; set; }
        public string pseudo {  get; set; }
        public string prenom { get; set; }
        public string motdepasse { get; set; }
        public Promo promo { get; set; }
        public Groupe groupe { get; set; }

        public Dictionary<Tache, Boolean> Valider { get; set; }

        public Eleve(int id,string pseudo, string prenom, string motdepasse)
        {
            this.id = id;
            this.pseudo = pseudo;
            this.prenom = prenom;
            this.motdepasse = motdepasse;
            this.promo = null;
            this.groupe = null;
        }
    }
}
