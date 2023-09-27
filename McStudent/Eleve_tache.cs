using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent
{
    internal class Eleve_tache
    {
        public Boolean etat {  get; set; }
        public int ptsRetires {  get; set; }
        public Eleve_tache(int ptsRetires)
        {
            this.etat = false;
            this.ptsRetires = ptsRetires;
        }
    }
}
