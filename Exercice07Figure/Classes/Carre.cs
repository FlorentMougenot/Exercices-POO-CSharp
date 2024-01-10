using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal class Carre : Figure
    {
        private double _cote;
        public double Cote { get => _cote; set => _cote = value; }

        public Carre (Point origine, double cote) : base(origine)
        {
            _cote = cote;
        }
        public void AffichageCarre()
        {
            Point b = new Point(Origine.PosX + _cote, Origine.PosY);
            Point c = new Point(Origine.PosX + _cote, Origine.PosY + _cote);
            Point d = new Point(Origine.PosX, Origine.PosY + _cote);
            Console.WriteLine($"Coordonnées du carré ABCD (coté = {_cote})");
            Console.WriteLine($"A = {Origine}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");
            Console.WriteLine($"D = {d}");
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 80)));
        }
    }
}
