using ExoPoo_CompteBancaire.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06CompteBancaire.Classes
{
    internal class ComptePayant : CompteBancaire
    {
        private readonly decimal _coutOperation;

        public ComptePayant(Client client, decimal coutOperation, decimal solde = 0) : base(client, solde)
        {
            _coutOperation = coutOperation;
        }

        public override bool Depot(decimal value)
        {
            if (_solde - _coutOperation < 0m) return false;

            _operations.Add(new Operation(value, TypeOperation.DEPOT));
            _solde += value - _coutOperation;

            return true;
        }

        public override bool Retrait(decimal value)
        {
            if (_solde - _coutOperation - value < 0m) return false;

            _operations.Add(new Operation(value, TypeOperation.RETRAIT));
            _solde -= value + _coutOperation;

            return true;
        }
    }
}
