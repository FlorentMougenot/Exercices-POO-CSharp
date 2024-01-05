using Exercicedecours;

/*Chaise a = new Chaise(4,"b","c");
Chaise b = new Chaise(6, "mousse", "jaune");
Chaise c = new Chaise(3, "bois mouillé", "bleue");

a.Affichage();
b.Affichage();
c.Affichage();*/

List<Chaise> listeChaises = new List<Chaise>()
{ new Chaise(), new Chaise(6, "mousse", "rose"), new Chaise (5, "adamantium", "jaune") };

foreach (Chaise Bluedabadidabada in listeChaises)
{
    Bluedabadidabada.Affichage();
}