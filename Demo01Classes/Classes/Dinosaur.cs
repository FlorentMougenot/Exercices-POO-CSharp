using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01Classes.Classes
{
    internal class Dinosaur
    {
        public int _age = 100000;
        public int _poids = 500;
        public bool _peutVoler = false;

        public int Age { get => _age; set => _age = value; }

        public int Poids
        {
            get
            {
                Console.WriteLine("récupération du poids");
                return _poids;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("On récup 100kg");
                    _poids = 100
                            ;
                }
                else
                {
                    _poids = value;
                }
            }
        }
        public string AgePoids { get => $"{_age} {_poids}";}
    }
}
