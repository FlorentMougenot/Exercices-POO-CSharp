using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Exercice07Figure.Classes
{
    internal class Rectangle : Figure
    {
        private double _longueur;
        private double _largeur;
        public double Longueur { get => _longueur; set => _longueur = value; }
        public double Largeur { get => _largeur; set => _largeur = value; }

        public Rectangle(Point origine, double longueur, double largeur) : base(origine)
        {
            _longueur = longueur;
            _largeur = largeur;
        }

        public void AffichageRectangle()
        {
            Point b = new Point(Origine.PosX + _longueur, Origine.PosY);
            Point c = new Point(Origine.PosX + _longueur, Origine.PosY + _largeur);
            Point d = new Point(Origine.PosX, Origine.PosY + _largeur);
            Console.WriteLine($"Coordonnées du rectangle ABCD (longueur = {_longueur} et largeur = {_largeur})");
            Console.WriteLine($"A = {Origine}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");
            Console.WriteLine($"D = {d}");
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 80)));
        }
    }
}
