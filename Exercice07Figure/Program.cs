using Exercice07Figure.Classes;

Point origine = new Point(2, 2);
Carre monCarre = new Carre(origine, 3);
Rectangle monRectangle = new Rectangle(origine, 5, 2);
Triangle monTriangle = new Triangle(origine, 3, 4);

monCarre.AffichageCarre();
monRectangle.AffichageRectangle();
monTriangle.AffichageTriangle();
monCarre.Deplacement(3, 3);
monCarre.AffichageCarre();