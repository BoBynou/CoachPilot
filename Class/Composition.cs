using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachPilot.Class
{
    public class Composition
    {
        public string Nom { get; }

        private Composition(string nom)
        {
            Nom = nom;
        }

        public static readonly Composition _433 = new Composition("4-3-3");
        public static readonly Composition _352 = new Composition("3-5-2");
        public static readonly Composition _442 = new Composition("4-4-2");
    }
}
