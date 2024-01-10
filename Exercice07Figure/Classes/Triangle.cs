using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal class Triangle : Figure
    {
        private double _baseT;
        private double _hauteur;

        public double BaseT { get => _baseT; set => _baseT = value; }
        public double Hauteur { get => _hauteur; set => _hauteur = value; }

        public Triangle (Point origine, double baseT, double hauteur) : base (origine)
        {
            _baseT = baseT;
            _hauteur = hauteur;
        }
        public void AffichageTriangle()
        {
            Point b = new Point(Origine.PosX + _baseT/2, Origine.PosY - _hauteur);
            Point c = new Point(Origine.PosX - _baseT/2, Origine.PosY - _hauteur);
            Console.WriteLine($"Coordonnées du rectangle ABCD (base = {_baseT} et hauteur = {_hauteur})");
            Console.WriteLine($"A = {Origine}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 80)));
        }
    }
}
