using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice07Figure.Classes
{
    internal class Point
    {
        private double _posX = 2;
        private double _posY = 1;

        public double PosX { get => _posX; set => _posX = value; }
        public double PosY { get => _posY; set => _posY = value; }

        internal Point(double posX, double posY)
        {
            _posX = posX;
            _posY = posY;
        }

        public override string ToString()
        {
            return $"{_posX};{_posY}";
        }
    }
}
