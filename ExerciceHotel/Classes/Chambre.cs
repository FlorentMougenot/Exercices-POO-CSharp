using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    internal class Chambre
    {
        private int _num;
        private enum statut
        {
            LIBRE,
            OCCUPE,
            ENNETTOYAGE
        }
        private int _numLits;
        private float _price;

        public int Num { get => _num; set => _num = value; }
        public int NumLits { get => _numLits; set => _numLits = value; }
        public float Price { get => _price; set => _price = value; }

        public Chambre(int num, Enum statut, int numLits, float price)
        { 
            _num = num;
            _numLits = numLits;
            _price = price;
        }
    }
}
