using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachPilot.Class
{
    public class Poste
    {
        public string Nom {  get;  }
        public string Abreviation {  get; }
        private Poste(string nom, string abréviation) 
        { 
            Nom = nom;
            Abreviation = abréviation;
        }

        public static readonly Poste Gardien = new Poste("Gardien", "GK");
        public static readonly Poste Defenseur_Central = new Poste("Defenseur central", "DC");
        public static readonly Poste Defenseur_Gauche = new Poste("Defenseur gauche", "DG");
        public static readonly Poste Defenseur_Droit = new Poste("Defenseur droit", "DD");
        public static readonly Poste Milieu_Defensif = new Poste("Milieu défensif", "Mdéf");
        public static readonly Poste Milieu_Central = new Poste("Milieu central", "MC");
        public static readonly Poste Milieu_Gauche = new Poste("Milieu gauche", "MG");
        public static readonly Poste Milieu_Droit = new Poste("Milieu droit", "MD");
        public static readonly Poste Milieu_Offensif = new Poste("Milieu offensif", "MOC");
        public static readonly Poste Buteur = new Poste("Buteur", "BU");
        public static readonly Poste Attaquant_Gauche = new Poste("Attaquant gauche", "AG");
        public static readonly Poste Attaquant_Droit = new Poste("Attaquant droit", "AD");
    }
}
