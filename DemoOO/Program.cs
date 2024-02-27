using DemoOO.Models;
using MesClasses;
using System.Diagnostics;
using model = DemoOO.Models;
using toto = DemoOO.Toto;

toto.Moto m;

model.Voiture v1 = new model.Voiture();
v1.ChoixCouleur("Assiette");
//v1.Couleur = "truc";
v1.Modele = "Twingo";
v1.Prix = 10000;

//Console.WriteLine($"Modele : {v1.Modele} de couleur {v1.Couleur}");
//Console.WriteLine(v1.Prix);
//Console.WriteLine(v1.Prix);
//Console.WriteLine(v1.Prix);
//v1.AppliquerRemise();
//Console.WriteLine(v1.Prix);
//v1.AppliquerRemise();
//Console.WriteLine(v1.Prix);


model.Voiture v2 = new model.Voiture();
v2.ChoixCouleur("Vert");
v2.Modele = "FeRrAri";
//Console.WriteLine($"Modele : {v2.Modele} de couleur {v2.Couleur}");


v1.SeDeplacer();
v2.SeDeplacer();

Moto m1 = new Moto();

m1.SeDeplacer();

Avion a = new Avion();
a.Couleur = "Rouge";
a.SeDeplacer();

Vehicule veh = a;
veh.SeDeplacer();

List<Vehicule> camion =  new List<Vehicule>();

camion.Add(v1);
camion.Add(v2);
camion.Add(m1);
camion.Add(a);

foreach(Vehicule v in camion)
{
    v.SeDeplacer();
}