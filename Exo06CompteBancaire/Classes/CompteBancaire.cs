using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo06CompteBancaire.Classes
{
    internal abstract class CompteBancaire
    {
        protected decimal _solde;
        protected Client _client;
        protected List<Operation> _operations;



        public decimal Solde { get => _solde; set => _solde = value; }
        public Client Client { get => _client; set => _client = value; }
        public List<Operation> Operations { get => _operations; set => _operations = value; }

        public CompteBancaire(Client client)
        {
            _solde = 0m;
            _client = client;
            _operations = new();
        }

        protected CompteBancaire(Client client, decimal soldeInitial) : this(client)
        {
            _solde = soldeInitial;
        }

        public abstract bool Depot(decimal value);
        public abstract bool Retrait(decimal value);

        public void AfficherOperationSolde()
        {
            if (_operations.Count > 0)
            {
                Console.WriteLine("\n=== Liste des opérations ===");
                foreach (Operation o in _operations)
                {
                    Console.WriteLine(o);
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas d'opération sur ce compte");
            }
            Console.WriteLine($"Solde du compte : {_solde}");
        }
    }
}
}
