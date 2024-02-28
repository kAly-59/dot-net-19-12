Console.WriteLine("CHEF TU VEUX QUOI ?");

Console.WriteLine("LISTE DES BREUVAGES DISPO");
Console.WriteLine("\t 1) EAU");
Console.WriteLine("\t 3) EAU GAZO");
Console.WriteLine("\t 3) COCA ZOLA");
Console.WriteLine("\t 4) FANTA");
Console.WriteLine("\t 5) SPRITE");
Console.WriteLine("\t 6) ORANGINA");
Console.WriteLine("\t 7) 7UP");

Console.Write("Veuillez saisir un nombre entre (1 à 7) : ");
var nombre = Console.ReadLine();

switch (nombre)
{
    case "1":
        Console.WriteLine($" SELECTIONNER {nombre}) \"BIG FLEAU\"");
        break;
    case "2":
        Console.WriteLine($" SELECTIONNER {nombre}) \"EAU GAZO\"");
        break;
    case "3":
        Console.WriteLine($" SELECTIONNER {nombre}) \"COCA ZOLA\"");
        break;
    case "4":
        Console.WriteLine($" SELECTIONNER {nombre}) \"FANTANYLE\"");
        break;
    case "5":
        Console.WriteLine($" SELECTIONNER {nombre}) \"SPRITE\"");
        break;
    case "6":
        Console.WriteLine($" SELECTIONNER {nombre}) \"ORANGINA\"");
        break;
    case "7":
        Console.WriteLine($" SELECTIONNER {nombre}) \"7UP\"");
        break;
    default : Console.WriteLine("BABABYE");
        break;
}
    
