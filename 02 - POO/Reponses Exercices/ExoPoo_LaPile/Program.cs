class Program
{
    static void Main()
    {
        // Test pour une pile de chaînes
        Pile<string> pileString = new Pile<string>();

        pileString.Empiler("Premier");
        pileString.Empiler("Deuxième");
        pileString.Empiler("Troisième");

        Console.WriteLine("Pile de chaînes :");

        while (true)
        {
            Console.WriteLine("1. Empiler");
            Console.WriteLine("2. Depiler");
            Console.WriteLine("3. Récupérer par index et retirer");
            Console.WriteLine("4. Quitter");

            Console.Write("Choix : ");
            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    Console.Write("Entrez une chaîne à empiler : ");
                    string chaine = Console.ReadLine();
                    pileString.Empiler(chaine);
                    break;

                case "2":
                    try
                    {
                        string elementDepile = pileString.Depiler();
                        Console.WriteLine($"Élément dépilé : {elementDepile}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "3":
                    Console.Write("Entrez l'index de l'élément à récupérer et retirer : ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        try
                        {
                            string elementRecupere = pileString.RecupererParIndex(index);
                            Console.WriteLine($"Élément récupéré et retiré : {elementRecupere}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index invalide.");
                    }
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Choix invalide. Veuillez réessayer.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
