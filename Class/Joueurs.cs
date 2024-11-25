using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachPilot.Class
{
    public class Joueurs
    {
        public string Id { get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pied { get; set; }
        public Poste Poste { get; set; }

        public Joueurs(string id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }

        public override string ToString()
        {
            return Prenom + " " + Nom;
        }
    }
}
