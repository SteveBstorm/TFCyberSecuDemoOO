using MesClasses;
using model = DemoOO.Models;
using toto = DemoOO.Toto;

toto.Moto m;
model.Moto m1;
model.Voiture v1 = new model.Voiture();
v1.ChoixCouleur("Assiette");
//v1.Couleur = "truc";
v1.Modele = "Twingo";
v1.Prix = 10000;

Console.WriteLine($"Modele : {v1.Modele} de couleur {v1.Couleur}");
Console.WriteLine(v1.Prix);
Console.WriteLine(v1.Prix);
Console.WriteLine(v1.Prix);
v1.AppliquerRemise();
Console.WriteLine(v1.Prix);
v1.AppliquerRemise();
Console.WriteLine(v1.Prix);


model.Voiture v2 = new model.Voiture();
v2.ChoixCouleur("Vert");
v2.Modele = "FeRrAri";
Console.WriteLine($"Modele : {v2.Modele} de couleur {v2.Couleur}");


Client c1 = new Client();
//c1.Nom = "steve";