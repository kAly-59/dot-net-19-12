using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_Hotel.Classes
{
    public enum StatutReservation
    {
        Prevu, EnCours, Fini, Annule
    }

    public class Reservations
    {
        private static int _counter = 0;
        private int _id;
        private List<Reservations> _listReservation;
        private Clients _client;

        public int Id { get => _id; set => _id = value; }
        public List<Reservations> ListReservation { get => _listReservation; set => _listReservation = value; }
        internal Clients Client { get => _client; set => _client = value; }
        public StatutReservation Statut { get; set; }

        public Reservations(StatutReservation statut, List<Chambres> listReservation, Clients client)
        {
            Id = ++_counter;
            Statut = statut;
            ListReservation = new List<Reservations>();
            Client = client;
        }

        public void AfficherDetailsReservation()
        {
            Console.WriteLine($"Identifiant de la réservation: {Id}");
            Console.WriteLine($"Statut: {Statut}");
            Console.WriteLine();
            Console.WriteLine("==Détails du client==");
            Console.WriteLine($"Nom: {Client.Nom} - Prenom: {Client.Prenom}");
            Console.WriteLine($"Telephone: {Client.Telephone}");
        }
    }


}
