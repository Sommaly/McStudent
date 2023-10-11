using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent.Classe
{
    internal class EleveTache
    {
        public int id { get; set; }
        public bool etat { get; set; }
        public int ptsRetires { get; set; }
        public EleveTache(int id,int ptsRetires)
        {
            this.id = id;
            etat = false;
            this.ptsRetires = ptsRetires;
        }
    }
}
