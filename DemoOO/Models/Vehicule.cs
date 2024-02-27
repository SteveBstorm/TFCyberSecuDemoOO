using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DemoOO.Models
{
    public class Vehicule
    {
        public string Couleur { get; set; }

        private string _modele;
        public string Modele
        {
            get { return _modele.ToUpper(); }
            set { _modele = value; }
        }

        public virtual int NbRoue { get; set; }


        public virtual void SeDeplacer()
        {
            Console.WriteLine($"Je suis un véhicule {Couleur}, je me déplace");
        }
    }
}
