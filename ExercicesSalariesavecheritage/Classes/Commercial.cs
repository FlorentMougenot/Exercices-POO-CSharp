using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesSalariesavecheritage.Classes
{
    internal class Commercial : Salarie
    {
        protected double _ca;
        protected double _commission;

        public double Ca { get => _ca; set => _ca = value; }
        public double Commission { get => _commission; set => _commission = value; }

        public Commercial() : base() { }

        public Commercial(string matricule, string nom, string service, string categorie, decimal salaire, double ca, double commission) : base(matricule, nom, service, categorie, salaire)
        {
            _ca = ca;
            _commission = commission;
        }
    }
}
