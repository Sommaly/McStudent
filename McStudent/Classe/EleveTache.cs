using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent.Classe
{
    internal class EleveTache
    {
        public bool etat { get; set; }
        public int ptsRetires { get; set; }
        public EleveTache(int ptsRetires)
        {
            etat = false;
            this.ptsRetires = ptsRetires;
        }
    }
}
