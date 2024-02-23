using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Models
{
    public class Voiture
    {
        /*
         prop => public int MyProperty{get; set;}
            !!! N'est qu'un raccourci d'écriture !!! 

         propfull =>
            private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = vale; }
            }
         

        il y a un champ privé innaccessible de l'extérieur
        rendu accessible par la propriété publique 
        au travers du get (accesseur) et du set (mutateur)
         */



        public string Couleur { get; set; }
        
        private string _modele;
        public string Modele
        {
            get { return _modele.ToUpper(); }
            set { _modele = value; }
        }

        //private int _end;

        //public int End
        //{
        //    get { return _end; }
        //    set { _end = value; }
        //}

        //private int _pv; // 100

        //public int PV
        //{
        //    get { return _pv; }
        //    set { _pv = value; }
        //}



        //private const int _prixCatalogue = 10000;
        private double _prix; //10000 //8500


        
        public double Prix
        {
            get { return _prix * 1.21; } //12100 //10285
            set
            {
                if (value < 0)
                    Console.WriteLine("Impossible de donner un prix négatif");
                _prix = value;
            }
        }

        #region Exemple OLD voir Tres old school
        //private double Prix;

        //public double GetPrix()
        //{
        //    return Prix;
        //}

        //public void SetPrix(double value)
        //{
        //    Prix = value;
        //} 
        #endregion








        public void AppliquerRemise()
        {
            _prix = _prix * 0.85;
        }

        public void ChoixCouleur(string couleur)
        {
            if(couleur == "Violet")
                Console.WriteLine("Couleur inexistante");
            Couleur = couleur;
        }

    }
}
