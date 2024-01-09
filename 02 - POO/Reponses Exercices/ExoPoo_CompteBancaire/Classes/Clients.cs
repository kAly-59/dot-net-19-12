using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_CompteBancaire.Classes
{
    internal class Client
    {
        private static int _counter = 0;
        private int _id;
        private string _nom;
        private string _prenom;
        private string _numeroTel;
        private List<CompteBancaire> _comptes;

        public int Id { get => _id; }
        public string Nom { get => _nom; }
        public string Prenom { get => _prenom; }
        public string NumeroTel { get => _numeroTel; }
        public List<CompteBancaire> Comptes { get => _comptes; }

        public Client(string nom, string prenom, string numeroTel)
        {
            _id = ++_counter;
            _comptes = new();
            _nom = nom;
            _prenom = prenom;
            _numeroTel = numeroTel;
        }
    }
}
