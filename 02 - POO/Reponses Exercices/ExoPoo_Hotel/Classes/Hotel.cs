using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPoo_Hotel.Classes
{
    public class Hotel
    {
        private List<Clients> Clients { get; set; }
        private List<Chambres> Chambres { get; set; }
        private List<Reservations> Reservations { get; set; }

        public Hotel()
        {
            Clients = new List<Clients>();
            Chambres = new List<Chambres>();
            Reservations = new List<Reservations>();
        }

        public void AjouterClient(Clients client)
        {
            Clients.Add(client);
        }

        public void AjouterChambre(Chambres chambre)
        {
            Chambres.Add(chambre);
        }

        public void AjouterReservation(Reservations reservation)
        {
            Reservations.Add(reservation);
        }

        public void AfficherDetailsHotel()
        {
            Console.WriteLine("==Liste des clients de l'hôtel==");
            foreach (var client in Clients)
            {
                client.AfficherDetailsClients();
                Console.WriteLine();
            }

            Console.WriteLine("==Liste des chambres de l'hôtel==");
            foreach (var chambre in Chambres)
            {
                chambre.AfficherDetailsChambre();
                Console.WriteLine();
            }

            Console.WriteLine("==Liste des réservations de l'hôtel==");
            foreach (var reservation in Reservations)
            {
                reservation.AfficherDetailsReservation();
                Console.WriteLine();
            }
        }
    }
}
