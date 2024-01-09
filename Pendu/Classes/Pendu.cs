using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicedecours04.Classes
{
    internal class Pendu
    {
        private readonly string _motATrouver;
        private string _masque;
        private readonly int _nbVies;
        private int _nbTentatives;
        private readonly List<string> _lettresTestees;

        public string MotATrouver { get => _motATrouver; }
        public string Masque { get => _masque; }
        public int NbVies { get => _nbVies; }
        public int NbTentatives {  get => _nbTentatives; }
        public List<string> LettresTestees {  get => _lettresTestees; }

        public Pendu()
        {
            _motATrouver = GenerateurDeMots.Generer();
            _masque = GenererMasque();
            _lettresTestees = new();
            _nbVies = 10;
            _nbTentatives = 0;
        }
        private string GenererMasque()
        {
            string tmp = "";
            foreach (char letter in _motATrouver)
            {
                tmp += "*";
            }
            return tmp;
        }
        public int TestWin()
        {
            if (!_masque.Contains("*")) return 1;
            if (_nbTentatives >= _nbVies) return -1;
            return 0;
        }
        public void TestChar(char lettre)
        {
            string aTester = lettre.ToString().ToUpper();
            if(!_lettresTestees.Contains(aTester))
            {
                string tmpMask = "";
                bool flag = false;
                for (int i = 0; i < _motATrouver.Length; i++)
                {
                    if (_motATrouver[i].ToString() == aTester)
                    {
                        tmpMask += aTester;
                    }
                    else
                    {
                        tmpMask += _masque[i];
                    }
                }
                if (!flag) _nbTentatives++;
                _lettresTestees.Add(aTester);
                _masque = tmpMask;
            }
        }
    }
}
