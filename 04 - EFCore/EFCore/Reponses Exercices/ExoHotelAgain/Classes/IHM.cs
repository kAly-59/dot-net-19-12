using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExoHotelAgain;

namespace ExoHotelAgain.Classes
{
    public class ApplicationIHM : IHM
    {
        private IRepository<Client> clientRepository;
        private IRepository<Chambre> chambreRepository;
        private IRepository<Reservation> reservationRepository;

        public ApplicationIHM()
        {
            clientRepository = new Repository<Client>();
            chambreRepository = new Repository<Chambre>();
            reservationRepository = new Repository<Reservation>();
        }

        public void TesterApplication()
        {
            while (true)
            {
                Console.WriteLine("1. Ajouter un client");
                Console.WriteLine("2. Afficher tous les clients");
                Console.WriteLine("3. Ajouter une chambre");
                Console.WriteLine("4. Afficher toutes les chambres");
                Console.WriteLine("5. Ajouter une réservation");
                Console.WriteLine("6. Afficher toutes les réservations");
                Console.WriteLine("0. Quitter");

                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        AjouterClient();
                        break;
                    case "2":
                        AfficherClients();
                        break;
                    case "3":
                        AjouterChambre();
                        break;
                    case "4":
                        AfficherChambres();
                        break;
                    case "5":
                        AjouterReservation();
                        break;
                    case "6":
                        AfficherReservations();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        break;
                }
            }
        }

        private void AjouterClient()
        {
            Console.WriteLine("Entrez le nom du client:");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez le prénom du client:");
            string prenom = Console.ReadLine();
            Console.WriteLine("Entrez le numéro de téléphone du client:");
            string numeroDeTelephone = Console.ReadLine();

            Client nouveauClient = new Client
            {
                Nom = nom,
                Prenom = prenom,
                NumeroDeTelephone = numeroDeTelephone
            };

            clientRepository.Add(nouveauClient);
            Console.WriteLine("Client ajouté avec succès.");
        }

        private void AfficherClients()
        {
            var clients = clientRepository.GetAll();

            Console.WriteLine("Liste des clients:");

            foreach (var client in clients)
            {
                Console.WriteLine($"ID: {client.ID}, Nom: {client.Nom}, Prénom: {client.Prenom}, Téléphone: {client.NumeroDeTelephone}");
            }
        }

        private void AjouterChambre()
        {
            Console.WriteLine("Entrez le numéro de la chambre:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le statut de la chambre (Libre/Occupé/EnNettoyage):");
            StatutChambre statut = Enum.Parse<StatutChambre>(Console.ReadLine());
            Console.WriteLine("Entrez le nombre de lits de la chambre:");
            int nombreDeLits = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le tarif de la chambre:");
            decimal tarif = decimal.Parse(Console.ReadLine());

            Chambre nouvelleChambre = new Chambre
            {
                Numero = numero,
                Statut = statut,
                NombreDeLit = nombreDeLits,
                Tarif = tarif
            };

            chambreRepository.Add(nouvelleChambre);
            Console.WriteLine("Chambre ajoutée avec succès.");
        }

        private void AfficherChambres()
        {
            var chambres = chambreRepository.GetAll();

            Console.WriteLine("Liste des chambres:");

            foreach (var chambre in chambres)
            {
                Console.WriteLine($"Numéro: {chambre.Numero}, Statut: {chambre.Statut}, Lits: {chambre.NombreDeLit}, Tarif: {chambre.Tarif}");
            }
        }

        private void AjouterReservation()
        {
            Console.WriteLine("Entrez le statut de la réservation (Prevu/EnCours/Fini/Annule):");
            string statutString = Console.ReadLine();

            if (Enum.TryParse<StatutReservation>(statutString, out var statut))
            {
                Reservation nouvelleReservation = new Reservation
                {
                    Statut = statut,
                };

                reservationRepository.Add(nouvelleReservation);
                Console.WriteLine("Réservation ajoutée avec succès.");
            }
            else
            {
                Console.WriteLine("Statut invalide. Veuillez entrer un statut valide.");
            }
        }

        private void AfficherReservations()
        {
            var reservations = reservationRepository.GetAll();

            Console.WriteLine("Liste des réservations:");

            foreach (var reservation in reservations)
            {
                Console.WriteLine($"ID: {reservation.ID}, Statut: {reservation.Statut}");
            }
        }
    }

    public interface IHM
    {
    }
}
