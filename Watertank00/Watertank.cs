using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watertank00
{
    internal class Watertank
    {
        private int _poids;
        private int _capacite;
        private int _niveau;
        int k = 0;
        int poidsrempli = 0;

        public int Poids { get => _poids; set => _poids = value; }
        public int Capacite { get => _capacite; set => _capacite = value; }
        public int Niveau { get => _niveau; set => _niveau = value; }

        public Watertank()
        {
        }
        public Watertank(int poids, int capacite, int niveau) : this()
        {
            this.Poids = poids;
            this.Capacite = capacite;
            this.Niveau = niveau;

        }
        public void AfficherPoidsRempli(int i)
        {
            poidsrempli = _poids + _niveau;
            Console.WriteLine($"Poids total de la citerne {i + 1} : {this.poidsrempli}");
        }
        public static void AfficherCadre()
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 130)));
        }
        public void AfficherQuantiteEau(int j)
        {
            Console.WriteLine($"Quantité d'eau dans la citerne {j} : {this.Niveau}");
        }
    }
}