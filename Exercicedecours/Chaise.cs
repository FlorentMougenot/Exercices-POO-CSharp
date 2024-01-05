using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicedecours
{
    internal class Chaise
    {
        private int _nbPieds = 4;
        private string _materiau = "plastique";
        private string _couleur = "moche";


        public int Pieds { get => _nbPieds; set => _nbPieds = value; }
        public string Materiau { get => _materiau; set => _materiau = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }

        public Chaise() { }
        public Chaise(int pieds, string mat, string couleur)
        {
            this.Pieds = pieds;
            this.Materiau = mat;
            this.Couleur = couleur;
        }
        public void Affichage()
        {
            Console.WriteLine($"Je suis une chaise, avec {this.Pieds} pieds en {this.Materiau} et de couleur {this.Couleur}");
        }
    }
}