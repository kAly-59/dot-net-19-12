Console.WriteLine("LISTE DES CAT'S DISPO");

Console.Write("Veuillez saisir l'âge : ");
int age = int.Parse(Console.ReadLine()!);

switch (age)
{
    case <= 3:
        Console.WriteLine($"Votre enfant à {age} ans, il est cat \"Baby\"");
        break;

    case <= 6:
        Console.WriteLine($"Votre enfant à {age} ans, il est cat \"Baby\"");
        break;

    case <= 7:
        Console.WriteLine($"Votre enfant à {age} ans, il est cat \"Poussin\"");
        break;

    case <= 9:
        Console.WriteLine($"Votre enfant à {age} ans, il est cat \"Pupille\"");
        break;

    case <= 11:
        Console.WriteLine($"Votre enfant à {age} ans, il est cat \"Minime\"");
        break;

    case <= 13:
        Console.WriteLine($"Votre enfant à {age} ans, il est cat \"Cadet\"");
        break;

    default:
        Console.WriteLine("La catégorie pour cet âge n'est pas définie dans la liste.");
        break;
}
