Console.WriteLine("--Le grand tirage au sort--");
Console.WriteLine("1) Effectuer un tirage au sort");
Console.WriteLine("2) Voir la liste des personnes deja tirer");
Console.WriteLine("3) Voir la liste des personnes pas encore tirer");
Console.WriteLine("0) Quitter");

List<string> prenoms = new List<string>
        {
            "Emma",
            "Lucas",
            "Chloé",
            "Hugo",
            "Alice",
            "Louis",
            "Léa",
            "Gabriel",
            "Zoé",
            "Ethan",
            "Inès",
            "Raphaël",
            "Sarah",
            "Arthur",
            "Julia",
            "Jules",
            "Louise",
            "Adam",
            "Lina",
            "Nathan"
        };


bool continuer = true;
while (continuer)
{
    Console.Write("Choississez (1, 2, 3 ou 0) : ");
    string choix = Console.ReadLine()!;

    switch (choix)
    {
        case "1":
            Random rand = new Random();
            int aleatoireName = rand.Next(0, prenoms.Count);
            string prenomTas = prenoms[aleatoireName];
            prenoms.Add(prenomTas); 
            prenoms.RemoveAt(aleatoireName);
            Console.WriteLine($"Le prenom tiré au sort est : {prenomTas}");
            break;

        case "2":
            break;

        case "3":
            foreach (var prenom in prenoms)
            {
                Console.WriteLine(prenom);
            }
            break;

        case "0":
            continuer = false;
            break;
        default:
            Console.WriteLine("1, 2, 3, ou 0 !!");
            break;
    }

}
