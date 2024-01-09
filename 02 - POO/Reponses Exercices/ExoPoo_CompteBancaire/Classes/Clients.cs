using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_CompteBancaire.Classes
{
    internal class Client
    {
        private string nom;
        private string prenom;
        private int identifiant;
        private string numeroTel;
        private List<CompteBancaire> listeComptes;

        public List<CompteBancaire> ListeComptes { get => listeComptes; set => listeComptes = value; }
        protected string Nom { get => nom; set => nom = value; }
        protected string Prenom { get => prenom; set => prenom = value; }
        protected int Identifiant { get => identifiant; set => identifiant = value; }
        protected string NumeroTel { get => numeroTel; set => numeroTel = value; }
    }
}
