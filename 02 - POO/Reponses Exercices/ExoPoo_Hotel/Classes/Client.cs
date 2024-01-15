using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_Hotel.Classes
{
    public class Clients
    {
        private static int _counter = 0;
        private int _id;
        private string _nom;
        private string _prenom;
        private string _telephone;

        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Telephone { get => _telephone; set => _telephone = value; }

        public Clients(string nom, string prenom, string telephone)
        {
            Id = ++_counter;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
        }

        public void AfficherDetailsClients()
        {
            Console.WriteLine($"Nom: {Nom}");
            Console.WriteLine($"Prenom: {Prenom}");
            Console.WriteLine($"Telephone: {Telephone}");
        }
    }
}
