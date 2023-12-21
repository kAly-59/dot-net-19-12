string civilite = "Mme";
switch (civilite)
{
    case "M.":
        Console.WriteLine("Bonjour monsieur");
        break;
    case "Mme":
        Console.WriteLine("Bonjour madame");
        break;
    case "Mlle":
        Console.WriteLine("Bonjour mademoiselle");
        break;
    default:
        Console.WriteLine("Bonjour indéterminé");
        break;
}
if (civilite == "M.")
    Console.WriteLine("Bonjour monsieur");
else if (civilite == "Mme")
    Console.WriteLine("Bonjour madame");
else if (civilite == "Mlle")
    Console.WriteLine("Bonjour mademoiselle");
else
    Console.WriteLine("Bonjour indéterminé");


int age = 42;
switch (age)
{
    case < 0 or > 125 :
        Console.WriteLine("Age invalide");
        break;
    case < 18:
        Console.WriteLine("Vous êtes mineur");
        break;
    case 40:
        Console.WriteLine("Vous êtes quarantenaire");
        break;
    default:
        Console.WriteLine("Vous êtes majeur mais pas quarantenaire");
        break;
}
if (age < 0 || age > 125)
    Console.WriteLine("Age invalide");
else if (age < 18)
    Console.WriteLine("Vous êtes mineur");
else if (age == 40)
    Console.WriteLine("Vous êtes quarantenaire");
else
    Console.WriteLine("Vous êtes majeur mais pas quarantenaire");