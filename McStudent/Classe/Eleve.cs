using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent.Classe
{
    internal class Eleve
    {
        string pseudo;
        string prenom;
        string motdepasse;

        public Eleve(string pseudo, string prenom, string motdepasse)
        {
            this.pseudo = pseudo;
            this.prenom = prenom;
            this.motdepasse = motdepasse;
        }

        public string getPseudo()
        {
            return this.pseudo;
        }
        public string getPrenom()
        {
            return this.prenom;
        }
        public void setMdp(String nvMdp)
        {
            this.motdepasse = nvMdp;
        }
        public void setPseudo(String nvPseudo)
        {
            this.pseudo = nvPseudo;
        }
    }
}
