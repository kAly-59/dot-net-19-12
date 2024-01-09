using ExoPoo_SalariésAvecHeritage.Classes;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Salarie> employees = new List<Salarie>();
        employees.Add(new Salarie(001, 12345, "DRH", "Jean Dupont", 2500));
        employees.Add(new Commercial(002, 12345, "DG", "Alice Never", 3000, 15000, 5));;

        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
            Console.WriteLine($"Salaire total : {employee.CalculerSalaire()}");
            Console.WriteLine();
        }

        Console.WriteLine("==Gestion des employées===");
        Console.WriteLine("1) Ajouter un employé");
        Console.WriteLine("2) Afficher salaire d'un employé");
        Console.WriteLine("3) Rechercher d'un employé");
        Console.WriteLine("0) Quitter");

        bool continuer = true;
        while (continuer)
        {
            Console.Write("Choississez (1, 2, 3 ou 0) : ");
            string choix = Console.ReadLine()!;
            Console.WriteLine();

            switch (choix)
            {
                case "1":
                    while (continuer)
                    {
                        Console.WriteLine("1) Ajouter un salarié");
                        Console.WriteLine("2) Ajouter un commercial");
                        Console.WriteLine("0) Retour");
                        Console.Write("Choississez (1, 2 ou 0 !!) : ");
                        string choixCase1 = Console.ReadLine()!;

                        switch (choixCase1)
                        {
                            case "1":
                                Console.WriteLine("Ajouter d'un salarié");
                                break;
                            case "2":
                                Console.WriteLine("Ajouter d'un commercial");
                                break;
                            case "0":
                                Console.WriteLine("0) Retour");
                                break;
                            default:
                                Console.WriteLine("1, 2, ou 0 !!");
                                break;
                        }

                    }

                    break;
                case "2":
                    Console.WriteLine("Affichage du salaire d'un employé");
                    break;
                case "3":
                    Console.WriteLine("Recherche d'un employé");
                    break;
                case "0":
                    Console.WriteLine("Bababye");
                    continuer = false;
                    break;
                default:
                    Console.WriteLine("1, 2, 3, ou 0 !!");
                    break;
            }
        }
    }
}
