using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicedecours04.Classes
{
    internal class GenerateurDeMots
    {
        public static  List<string> listeMots = new()
        {
            "canard",
            "pamphlet",
            "lymphocyte",
            "saltimbanque",
            "illumination",
            "castor",
            "finition"
        };
        public static string Generer()
        {
            var nombreAlea = new Random().Next(listeMots.Count);
            return listeMots[nombreAlea].ToUpper();
        }
    }
}
