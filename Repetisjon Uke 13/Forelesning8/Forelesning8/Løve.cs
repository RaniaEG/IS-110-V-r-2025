using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning8
{
    // Løve klassen implmenterer IDyr interface
    internal class Løve : Dyr
    {
        // Spiser
        // Bråker
       

        public override void Spiser(string mat)
        {
            Console.WriteLine($"Løven spiser {mat}");
        }

        public override string Bråker()
        {
            return "Roar";
        }
    }
}
