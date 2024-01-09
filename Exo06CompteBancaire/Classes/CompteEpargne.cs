using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo06CompteBancaire.Classes
{
    internal class CompteEpargne : CompteBancaire
    {
        private float _txInterets;

        public float TxInterets { get => _txInterets; }

        public CompteEpargne(Client client, float txInterets, decimal solde = 0m) : base(client, solde)
        {
            _txInterets = txInterets;
        }

        public override bool Depot(decimal value)
        {
            throw new NotImplementedException();
        }
        public override bool Retrait(decimal value)
        {
            throw new NotImplementedException();
        }

        public void Epargner()
        {
            _solde += decimal.Multiply(_solde, (decimal)_txInterets);
        }
    }
}
