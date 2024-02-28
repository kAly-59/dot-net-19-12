using ExoPoo_CompteBancaire.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal class CompteEpargne : CompteBancaire
    {
        
        private float _tauxInterets;

        public float TauxInterets { get => _tauxInterets;

        public CompteEpargne(Client client, float tauxInterets, decimal solde = 0m) : base(client, solde)
        {
            _tauxInterets = tauxInterets;
        }

        public override bool Depot(decimal value)
        {
            _operations.Add(new Operation(value, TypeOperation.DEPOT));
            _solde += value;
            return true;
        }

        public override bool Retrait(decimal value)
        {
            if (_solde - value < 0) return false;

            _operations.Add(new Operation(value, TypeOperation.RETRAIT));
            _solde -= value;
            return true;
        }

        public void Epargne()
        {
            _solde += decimal.Multiply(_solde, (decimal)_tauxInterets);
        }
    }
}
