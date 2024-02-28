using ConsoleApp1.Classes;
using System;

public class UI
{
    private DatabaseManager dbManager = new DatabaseManager();

    public void AfficherMenu()
    {
        Console.WriteLine("   ____                                          _           ");
        Console.WriteLine("  / ___|___  _ __ ___  _ __ ___   __ _ _ __   __| | ___  ___ ");
        Console.WriteLine(" | |   / _ \\| '_ ` _ \\| '_ ` _ \\ / _` | '_ \\ / _` |/ _ \\/ __|");
        Console.WriteLine(" | |__| (_) | | | | | | | | | | | (_| | | | | (_| |  __/\\__ \\");
        Console.WriteLine("  \\____\\___/|_| |_| |_|_| |_| |_|\\__,_|_| |_|\\__,_|\\___||___/");
        Console.WriteLine("1. Afficher les clients");
        Console.WriteLine("2. Créer un client");
        Console.WriteLine("3. Modifier un client");
        Console.WriteLine("4. Supprimer un client");
        Console.WriteLine("5. Afficher les détails d'un client");
        Console.WriteLine("6. Ajouter une commande");
        Console.WriteLine("7. Modifier une commande");
        Console.WriteLine("8. Supprimer une commande");
        Console.WriteLine("0. Quitter");
    }

    public void GestionMenu()
    {
        bool quitter = false;
        do
        {
            AfficherMenu();
            Console.Write("Choisissez une option : ");
            string choix = Console.ReadLine()!;

            switch (choix)
            {
                case "1":
                    AfficherClients();
                    break;
                case "2":
                    CreerClient();
                    break;
                case "3":
                    ModifierClient();
                    break;
                case "4":
                    SupprimerClient();
                    break;
                case "5":
                    AfficherDetailsClient();
                    break;
                case "6":
                    AjouterCommande();
                    break;
                case "7":
                    ModifierCommande();
                    break;
                case "8":
                    SupprimerCommande();
                    break;
                case "0":
                    quitter = true;
                    break;
                default:
                    Console.WriteLine("Option invalide !");
                    break;
            }
            Console.WriteLine();
        } while (!quitter);
    }

    private void AfficherClients() { }
    private void CreerClient() { }
    private void ModifierClient() { }
    private void SupprimerClient() { }
    private void AfficherDetailsClient() { }
    private void AjouterCommande() { }
    private void ModifierCommande() { }
    private void SupprimerCommande() { }
}
