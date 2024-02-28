using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

class Program
{
    static List<Etudiant> listeEtudiants = new List<Etudiant>();
    static void Main()
    {   
        while (true)
        {
            Console.WriteLine("1. Ajouter un étudiant");
            Console.WriteLine("2. Afficher tous les étudiants");
            Console.WriteLine("3. Afficher les étudiants d'une classe");
            Console.WriteLine("4. Supprimer un étudiant");
            Console.WriteLine("5. Quitter");
            Console.Write("Choisissez une option : \n");
            string choix = Console.ReadLine()!;

            switch (choix)
            {
                case "1":
                    AjouterEtudiant();
                    break;
                case "2":
                    AfficherTousEtudiants();
                    break;
                case "3":
                    AfficherEtudiantsClasse();
                    break;
                case "4":
                    SupprimerEtudiant();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Option invalide.");
                    break;
            }
        }
    }

    static void AjouterEtudiant()
    {
        Console.Write("Nom : ");
        string nom = Console.ReadLine();
        Console.Write("Prénom : ");
        string prenom = Console.ReadLine();
        Console.Write("Numéro de classe : ");
        string numeroClasse = Console.ReadLine();
        Console.Write("Date de diplôme : ");
        string dateDiplome = Console.ReadLine();

        Etudiant nouvelEtudiant = new Etudiant(nom, prenom, numeroClasse, dateDiplome);
        listeEtudiants.Add(nouvelEtudiant);

        Console.WriteLine("Etudiant ajouté avec succès !");
        Console.WriteLine();
    }

    static void AfficherTousEtudiants()
    {
        Console.WriteLine("==Liste de tous les étudiants==");
        foreach (var etudiant in listeEtudiants)
        {
            Console.WriteLine(etudiant);
        }
    }

    static void AfficherEtudiantsClasse()
    {
        Console.Write("Entrez le numéro de classe : ");
        string numeroClasse = Console.ReadLine();

        Console.WriteLine($"Liste des étudiants de la classe {numeroClasse} :");
        foreach (var etudiant in listeEtudiants)
        {
            if (etudiant.NumeroClasse == numeroClasse)
            {
                Console.WriteLine(etudiant);
            }
        }
    }

    static void SupprimerEtudiant()
    {
    }
}

class Etudiant
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string NumeroClasse { get; set; }
    public string DateDiplome { get; set; }

    public Etudiant(string nom, string prenom, string numeroClasse, string dateDiplome)
    {
        Nom = nom;
        Prenom = prenom;
        NumeroClasse = numeroClasse;
        DateDiplome = dateDiplome;
    }

    public override string ToString()
    {
        return $"Id : {Id}\n" +
            $"Nom : {Nom}\n" +
            $"Prenom : {Prenom}\n" +
            $"Classe : {NumeroClasse}\n" +
            $"Diplômé : {DateDiplome}\n";
    }
}
