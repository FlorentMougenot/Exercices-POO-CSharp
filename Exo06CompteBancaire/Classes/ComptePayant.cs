using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo06CompteBancaire.Classes
{
    internal class ComptePayant : CompteBancaire
    {
        private readonly decimal _fraisFixe;

        public ComptePayant(Client client, decimal fraisFixe, decimal solde = 0) : base(client, solde)
        {
            _fraisFixe = fraisFixe;
        }

        public override bool Depot(decimal value)
        {
            if (_solde - _fraisFixe < 0m) return false;
            _operations.Add(new Operation(value, TypeOperation.DEPOT));
            _solde += value - _fraisFixe;
            return true;
        }
        public override bool Retrait(decimal value)
        {
            if (_solde - _fraisFixe - value < 0m) return false;
            _operations.Add(new Operation(value, TypeOperation.RETRAIT));
            _solde -= value - _fraisFixe;
            return true;
        }

    }
}
