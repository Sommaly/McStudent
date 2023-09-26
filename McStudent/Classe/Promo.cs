using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent.Classe
{
    internal class Promo
    {
        string nom;

        public Promo(string nom)
        {
            this.nom = nom;
        }
        public string getNom()
        {
            return this.nom;
        }
    }
}
