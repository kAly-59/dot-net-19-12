using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_Pendu
{
    class Pendu
    {
        // Attributes
        private string _masque;
        private int _nbEssais;
        private string _mot;
        private List<char> _lettreUtiliser;

        // Properties
        public int NbEssais { get => _nbEssais; set => _nbEssais = value; }
        public string Mot { get => _mot; set => _mot = value; }
        public string Masque { get => _masque; set => _masque = value; }
        public List<char> LettreUtiliser { get => _lettreUtiliser; set => _lettreUtiliser = value; }

        //List de mot
        private List<string> mots = new List<string> { "PROGRAMMATION", "PENDU", "ORDINATEUR", "DEVELOPPEUR", "INTELLIGENCE", "CONSOLE", "APPLICATION" };

        // Constructor
        public Pendu(int nbEssais)
        {
            _mot = motAleatoire().ToUpper();
            _lettreUtiliser = new List<char>();
            _nbEssais = nbEssais;
        }

        // Methode
        private string motAleatoire()
        {
            Random rand = new Random();
            return mots[rand.Next(mots.Count)];
        }

        public bool TestChar(char lettre)
        {
            lettre = char.ToUpper(lettre);

            if (_lettreUtiliser.Contains(lettre))
            {
                Console.WriteLine("Lettre déjà utiliser");
                return false;
            }

            _lettreUtiliser.Add(lettre);
            bool lettreTrouver = false;

            for (int i = 0; i < _mot.Length; i++)
            {
                if (_mot[i] == lettre)
                {
                    lettreTrouver = true;
                }
            }

            if (!lettreTrouver)
            {
                _nbEssais--;
            }
            return lettreTrouver;
        }

       /* public string TestWin()
        {

        }

        public string GenererMasque()
        {

        }*/
    }



}
