using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    internal class Hotel
    {
        private List<Client> _listeClients;
        private List<Chambre> _listeChambres;
        private List<Reservation> _listeReservations;

        internal List<Client> ListeClients { get => _listeClients; set => _listeClients = value; }
        internal List<Chambre> ListeChambres { get => _listeChambres; set => _listeChambres = value; }
        internal List<Reservation> ListeReservations { get => _listeReservations; set => _listeReservations = value; }

        public Hotel(List<Client> listeClients, List<Chambre> listeChambres, List<Reservation> listeReservations)
        {
            _listeClients = listeClients;
            _listeChambres = listeChambres;
            _listeReservations = listeReservations;
        }
    }
}
