using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicedecours02
{
    internal class Salarie
    {
        private string _matricule = "000xx";
        private string _service = "employé";
        private int _categorie = 1;
        private string _nom = "Salarié par défaut";
        private double _salaire;
        private static int _nbDeSalaries = 0;
        private static double _salaireTotal = 0;
        private double _nouveauSalaire = 50;
       
        public string Matricule { get => _matricule; set => _matricule = value; }
        public string Service { get => _service; set => _service = value; }
        public int Categorie { get => _categorie; set => _categorie = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public double Salaire { get => _salaire; set { SalaireTotal = SalaireTotal +  value - Salaire; _salaire = value; } }
        public static int NbDeSalaries => _nbDeSalaries;
        
    

        public static double SalaireTotal { get => _salaireTotal; set => _salaireTotal = value; }
        public double NouveauSalaire { get => _nouveauSalaire; set => _nouveauSalaire = value; }

        public Salarie()
        {
            Salaire = 16236;
            _nbDeSalaries++;
        }
        public Salarie(string matricule, string service, int categorie, string nom, double salaire) : this()
        {
            this.Matricule = matricule;
            this.Service = service;
            this.Categorie = categorie;
            this.Nom = nom;
            this.Salaire = salaire;
        }
        public void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire de {this.Nom} est de {this.Salaire} euros");
        }
        public static void AffichernbSalaries()
        {
            Console.WriteLine("Le nombre de salariés est : " + NbDeSalaries);
        }
        public static void AfficherTotalSalaires()
        {
            Console.WriteLine("Salaire total : " + SalaireTotal);
        }
        public void ChangementSalaires(string nom, double nouveausalaire)
        {
            Salaire = nouveausalaire;
            Console.WriteLine($"On change le salaire de {this.Nom} à {this.NouveauSalaire} euros");
        }
    }
}
