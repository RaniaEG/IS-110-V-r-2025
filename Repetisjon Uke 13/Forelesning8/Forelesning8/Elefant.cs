using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelesning8
{
    // Elefant klassen implmenterer IDyr interface
    internal class Elefant : Dyr
    {
        // Spiser
        // Bråker

        public override void Spiser(string mat)
        {
            Console.WriteLine($"Elefanten spiser {mat}");
        }

        public override string Bråker()
        {
            return "Tuut";
        }


    }
}
