using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_CompteBancaire.Classes
{
    public abstract class CompteBancaire
    {
        private decimal _solde;
        private Client _client;

        public decimal Solde { get => _solde; }
        public Client Client { get => _client; }
        public List<Operation> Operations { get => _operations; }

        protected CompteBancaire (Client client) 
        {
            _client = Client;
            _solde = 0m;
            _operation = new();
        }

        public abstract bool Depot(decimal values);
        public abstract bool Retrait(decimal values);

        public void afficherOperationSolde()
        {
            if (_operation.Count > 0)
            {
                Console.WriteLine("===Liste des operations===");
                foreach (Operation o in _operations)
                {
                    Console.WriteLine(o);
                }
            } else
            {
                Console.WriteLine("Aucune operation");
            }           
            Console.WriteLine($"Solde du compte : {Solde}");
        }
    }
}
