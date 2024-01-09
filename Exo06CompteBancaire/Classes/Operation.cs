using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo06CompteBancaire.Classes
{
    internal class Operation
    {
        private int _numero;
        private decimal _montant;
        private TypeOperation _type;
        private static int _count = 0;



        public int Numero { get => _numero; }
        public decimal Montant { get => _montant; }
        public TypeOperation Type { get => _type; }


        public Operation(decimal montant, TypeOperation type)
        {
            _numero = ++_count;
            _montant = montant;
            _type = type;
        }

        public override string ToString() 
        { 
            return $"{_numero}. [{Enum.GetName(_type)}]"; 
        }
    }
}
