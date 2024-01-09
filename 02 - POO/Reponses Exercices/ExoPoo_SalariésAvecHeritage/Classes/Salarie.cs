using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_SalariésAvecHeritage.Classes
{
    internal class Salarie
    {
        private int _matricule;
        private int _service;
        private string _categorie;
        private string _nom;
        private double _salaire;

        public int Matricule { get => _matricule; set => _matricule = value; }
        public int Service { get => _service; set => _service = value; }
        public string Categorie { get => _categorie; set => _categorie = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public double Salaire { get => _salaire; set => _salaire = value; }

        public Salarie(int matricule, int service, string categorie, string nom, double salaire)
        {
            Matricule = matricule;
            Service = service;
            Categorie = categorie;
            Nom = nom;
            Salaire = salaire;
        }

        public virtual double CalculerSalaire()
        {
            return Salaire;
        }

        public override string ToString()
        {
            return $"Salarié: Nom: {Nom}, Matricule: {Matricule}, Categorie: {Categorie}, Service: {Service},  Salaire: {Salaire}";
        }
    }
}
