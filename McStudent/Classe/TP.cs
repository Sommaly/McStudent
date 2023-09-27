using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent.Classe
{
    internal class TP
    {
        public string titre {  get; set; }
        public string description { get; set; }
        public DateTime dteDebut { get; set; }
        public DateTime dteFin { get; set; }
        public int note { get; set; }
        public Boolean isActif {  get; set; }

        public TP(string titre, string description, DateTime dteDebut, DateTime dteFin, int note)
        {
            this.titre = titre;
            this.description = description;
            this.dteDebut = dteDebut;
            this.dteFin = dteFin;
            this.note = note;
            this.isActif = false;
        }
    }
}
