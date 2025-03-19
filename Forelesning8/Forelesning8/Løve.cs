using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning8
{
    // Løve klassen implmenterer IDyr interface
    internal class Løve : IDyr
    {
        // Spiser
        // Bråker

        public void Spiser(string mat)
        {
            Console.WriteLine($"Løven spiser {mat}");
        }

        public string Bråker()
        {
            return "Roar";
        }
    }
}
