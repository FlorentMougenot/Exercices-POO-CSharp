using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes

{
    internal class Reservation<T>
    {
        private readonly List<T> _listeReservations = new List<T>();

        public int Count => _listeReservations.Count;



        public void AjouterReservation(T element)
        {
            _listeReservations.Add(element);
        }


        public T SupprimerReservation()
        {
            if (_listeReservations.Count == 0)
                throw new InvalidOperationException("Il n'y a pas de réservation.");


            var item = _listeReservations[^1];
            _listeReservations.RemoveAt(_listeReservations.Count - 1);
            return item;
        }


        public T AfficherReservations(int index)
        {
            if (index < 0 || index >= _listeReservations.Count)
                throw new ArgumentOutOfRangeException(nameof(index), "Pas de réservation a cette référence");

            return _listeReservations[index];
        }
    }
}




/*{
    internal class Reservation
    {
        private int _id;
        public enum statut
        {
            PREVU,
            ENCOURS,
            FINI,
            ANNULE
        }
        private List<Chambre> _listeChambres;
        private string _customer;

        public int Id { get => _id; set => _id = value; }
        internal List<Chambre> ListeChambres { get => _listeChambres; set => _listeChambres = value; }
        public string Customer { get => _customer; set => _customer = value; }

        public Reservation(int id, Enum statut, List<Chambre> chambres, string customer)
        {
            _id = id;
            _listeChambres = chambres;
            _customer = customer;
        }
    }
}*/
