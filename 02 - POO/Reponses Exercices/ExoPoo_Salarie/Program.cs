using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<ExoPoo_Salarie> listeDesEmployees = new List<ExoPoo_Salarie>
        {
            new ExoPoo_Salarie("001", "Informatique", "Dev", "Chloé", 24000),
            new ExoPoo_Salarie("002", "Informatique", "Dev", "Marc", 30000),
            new ExoPoo_Salarie("003", "Informatique", "Dev", "Milou", 26000),
            new ExoPoo_Salarie(),
        };

        foreach (ExoPoo_Salarie employee in listeDesEmployees)
        {
            Console.WriteLine(employee);
        }

        int nombreEmployes = ExoPoo_Salarie.NbEmployees;
        Console.WriteLine($"Nombre total d'employés : {nombreEmployes}");

        double totalSalaires = ExoPoo_Salarie.CalculerTotalSalaires(listeDesEmployees);
        Console.WriteLine($"Salaires total des employés : {totalSalaires} Euros.");

        listeDesEmployees[0].Salaire = 500000;
        Console.WriteLine(listeDesEmployees[0]);

        double totalSalairesModifier = ExoPoo_Salarie.CalculerTotalSalaires(listeDesEmployees);
        Console.WriteLine($"Salaires total des employés : {totalSalairesModifier} Euros.");

        int nombreEmployes2 = ExoPoo_Salarie.NbEmployees;
        Console.WriteLine($"Nombre total d'employés : {nombreEmployes2}");

        listeDesEmployees[0].Salaire = 500000;

        Console.WriteLine("Remise à zéro des Employees et des salaires.");

        // Modif Salaire
        foreach (ExoPoo_Salarie employee in listeDesEmployees)
        {
            employee.Salaire = 0;
        }

        double totalSalairesModifier2 = ExoPoo_Salarie.CalculerTotalSalaires(listeDesEmployees);
        Console.WriteLine($"Salaires total des employés : {totalSalairesModifier2} Euros.");

        // Suppression de tous les employés de la liste
        listeDesEmployees.Clear();

        // Réinitialisation du compteur d'employés
        ExoPoo_Salarie.ResetNbEmployees();

        int nombreEmployes3 = ExoPoo_Salarie.NbEmployees;
        Console.WriteLine($"Nombre total d'employés : {nombreEmployes3}");
    }
}
