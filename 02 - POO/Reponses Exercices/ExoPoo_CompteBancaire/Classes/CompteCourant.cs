using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_CompteBancaire.Classes
{
    internal class CompteCourant : CompteBancaire
    {
        public CompteCourant(Client client, decimal solde = 0m) : base(client, solde)
        {
        }

        public override bool Depot(decimal values)
        {
            _operations.Add(new Operation(values, TypeOperation.DEPOT));
            _solde += values;
            return true;
        }

        public override bool Retrait(decimal value)
        {
            if (_solde - value < 0) return false;

            _operations.Add(new Operation(value, TypeOperation.RETRAIT));
            _solde -= value;
            return true;
        }
    }
}
