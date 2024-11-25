using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachPilot.Class
{
    public class Match
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string preDesc { get; set; }

        public string afterDesc { get; set; }

        public Match (string id, string name)
        {
            Id = id;
            Name = name;
            preDesc = string.Empty;
            afterDesc = string.Empty;
        }
    }
}
