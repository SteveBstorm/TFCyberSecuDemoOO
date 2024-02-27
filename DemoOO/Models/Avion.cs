using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Models
{
    internal class Avion : Vehicule
    {
        public void SeDeplacer()
        {
            Console.WriteLine($"Je suis un avion {Couleur} et je vole");
        }
    }
}
