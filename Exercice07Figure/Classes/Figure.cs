using Exercice07Figure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal abstract class Figure : IDeplacable
    {
        private Point _origine;
        public Point Origine { get => _origine; set => _origine = value; }
        public Figure(Point origine)
        {
            _origine = origine;
        }
        public void Deplacement(double x, double y)
        {
        Origine.PosX += x;
        Origine.PosY += y;
        Console.WriteLine($"Déplacement du carré par({x},{y})");
        }
    }
}
