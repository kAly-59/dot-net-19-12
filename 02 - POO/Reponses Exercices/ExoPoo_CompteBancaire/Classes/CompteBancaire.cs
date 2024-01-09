using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_CompteBancaire.Classes
{
    internal abstract class CompteBancaire
    {
        protected decimal _solde;
        protected Client _client;
        protected List<Operation> _operations;

        public decimal Solde { get => _solde; }
        public Client Client { get => _client; }
        public List<Operation> Operations { get => _operations; }

        protected CompteBancaire(decimal solde, Client client, List<Operation> operations)
        {
            _solde = solde;
            _client = client;
            _operations = new();
        }

        public void AfficherOperationSolde()
        {
            if (_operations.Count > 0)
            {
                Console.WriteLine("= Liste des opérations =");
                foreach (Operation operation in _operations)
                {
                    Console.WriteLine(operation);
                }
            }
            else
            {
                Console.WriteLine("Aucune opération sur ce compte.");
            }
            Console.WriteLine($"Solde du compte: {_solde}€");
        }

        public abstract bool Depot(decimal values);
        public abstract bool Retrait(decimal values);
    }
}
