using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning8
{
    // Dyr klassen implementerer IDyr interface
    public abstract class Dyr : IDyr
    {
        public int alderÅr { get; set; }
        public float vektKG { get; set; }

        // Her er de metodene som ligger i IDyr interface
        // Abstrakte metoder har ikke body
        public abstract string Bråker();

        public abstract void Spiser(string mat);
       
    }
}
