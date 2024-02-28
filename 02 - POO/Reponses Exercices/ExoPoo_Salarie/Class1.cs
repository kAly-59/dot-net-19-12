using System;
using System.Collections.Generic;

class ExoPoo_Salarie
{
    // Attributs privés
    private string _matricule = "000";
    private string _service = "defaut";
    private string _categorie = "defaut";
    private string _nom = "Salarié par defaut";
    private double _salaire = 16236;
    private static int _nbEmployees = 0;

    // Propriétés publiques
    public string Matricule { get => _matricule; set => _matricule = value; }
    public string Service { get => _service; set => _service = value; }
    public string Categorie { get => _categorie; set => _categorie = value; }
    public string Nom { get => _nom; set => _nom = value; }
    public double Salaire { get => _salaire; set => _salaire = value; }
    public static int NbEmployees => _nbEmployees;

    // Constructeur par défaut
    public ExoPoo_Salarie()
    {
        _nbEmployees++;
    }

    public static void ResetNbEmployees()
    {
        _nbEmployees = 0;
    }

    // Constructeur avec des paramètres et appel au constructeur par défaut
    public ExoPoo_Salarie(string matricule, string service, string categorie, string nom, double salaire) : this()
    {
        Matricule = matricule;
        Service = service;
        Categorie = categorie;
        Nom = nom;
        Salaire = salaire;
    }

    // Method calul du totaux des salaires
    public static double CalculerTotalSalaires(List<ExoPoo_Salarie> listeDesEmployees)
    {
        double totalSalaires = 0;
        foreach (ExoPoo_Salarie employe in listeDesEmployees)
        {
            totalSalaires += employe.Salaire;
        }
        return totalSalaires;
    }

    // Méthode pour afficher les informations du salarié
    public override string ToString()
    {
        return $"Le salaire de {Nom} est de {Salaire} Euros.";
    }
}