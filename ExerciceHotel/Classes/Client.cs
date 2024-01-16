using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    internal class Client<T>
    {
        private readonly List<T> _listeClients = new List<T>();

        public int Count => _listeClients.Count;

        private string _nom;
        private string _prenom;
        private string _tel;
        public string Nom { get; }
        public string Prenom { get; }
        public string Tel { get; }

        public Client(string nom, string prenom, string tel)
        {
            _nom = nom;
            _prenom = prenom;
            _tel = tel;
        }

        public override string ToString() => $"{_nom} {_prenom}, {_tel}";

        public void AjouterClient(T element01)
        {
            _listeClients.Add(element01);
        }
    }
}
/*{
   internal class Client
    {
        private int _id;
        private string _nom;
        private string _prenom;
        private string _phone;

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Phone { get => _phone; set => _phone = value; }

        public Client(int id, string nom, string prenom, string phone)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _phone = phone;
        }
    }
}*/
