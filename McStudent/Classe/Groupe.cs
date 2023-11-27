using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McStudent.Classe
{
    public class Groupe
    {
        public int id {  get; set; }
        public string nom {  get; set; }
        public Groupe(int id,string nom)
        {
            this.id = id;
            this.nom = nom;
        }
    }
}
