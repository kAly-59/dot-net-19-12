using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_SalariésAvecHeritage.Classes
{
    // Classe Commercial, hérite de Salarie
    internal class Commercial : Salarie
    {
        private double _chiffreAffaire;
        private double _commission;

        public double ChiffreAffaire { get => _chiffreAffaire; set => _chiffreAffaire = value; }
        public double Commission { get => _commission; set => _commission = value; }

        // Constructeur
        public Commercial(int matricule, int service, string categorie, string nom, double salaire, double chiffreAffaire, double commission) : base (matricule, service, categorie, nom, salaire)
        {
            ChiffreAffaire = chiffreAffaire;
            Commission = commission;
        }

        // Method
        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + (ChiffreAffaire * Commission / 100);
        }

        public override string ToString()
        {
            return $"Salarié: Nom: {Nom}, Matricule: {Matricule}, Categorie: {Categorie}, Service: {Service},  Salaire: {Salaire}, Chiffre d'affaire: {ChiffreAffaire}, Commission: {Commission}%";
        }
    }   ;
}
