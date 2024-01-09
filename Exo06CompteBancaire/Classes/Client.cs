using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo06CompteBancaire.Classes
{
    internal class Client
    {
        private static int _counter = 0;
        private string _prenom;
        private string _nom;
        private int _id;
        private List<CompteBancaire> _listeDesComptes;
        private string _numTel;



        public string Prenom { get => _prenom; }
        public string Nom { get => _nom; }
        public int Id { get => _id; }
        public List<CompteBancaire> ListeDesComptes { get => _listeDesComptes; }
        public string NumTel { get => _numTel; }


        public Client(string prenom, string nom, string numTel)
        {
            _prenom = prenom;
            _nom = nom;
            _id = ++_counter;
            _listeDesComptes = new List<CompteBancaire>();
            _numTel = numTel;
        }
    }
}
