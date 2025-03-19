using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning8
{
    // Elefant klassen implmenterer IDyr interface
    internal class Elefant : IDyr
    {
        // Spiser
        // Bråker

        public void Spiser(string mat)
        {
            Console.WriteLine($"Elefanten spiser {mat}");
        }

        public string Bråker()
        {
            return "Tuut";
        }


    }
}
