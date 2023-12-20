Console.WriteLine("***Calcule d'interet***");

Console.Write("Entrez capital de depart (en Euro) : ");
float capitalDepart = float.Parse(Console.ReadLine());

Console.Write("Entrez le taux d'interet (en %) : ");
float tauxInteret = float.Parse(Console.ReadLine());

Console.Write("Entrez la durée de l'épargne (en années) : ");
float dureeEpargne = float.Parse(Console.ReadLine());

float tauxInteretDecimal = tauxInteret / 100;
float interets = capitalDepart * tauxInteretDecimal * dureeEpargne;
float capitalFinal = capitalDepart + interets;

Console.WriteLine("Les montants des intérêts sera de " + Math.Round(interets, 2) + " euros " + "en " + dureeEpargne + " ans");
Console.WriteLine("Le capital final sera de " + Math.Round(capitalFinal, 2) + " Euros");
