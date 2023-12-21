using System;

Console.WriteLine("MONTANT INDEMNITER SALAIRE");

Console.Write("Merci de saisir votre dernier salaire : ");
decimal salaire = decimal.Parse(Console.ReadLine()!);
Console.Write("Merci de saisir votre age : ");
int age = int.Parse(Console.ReadLine()!);
Console.Write("Merci de saisir le nombre d'années d'ancienneté : ");
int nbaa = int.Parse(Console.ReadLine()!);

decimal prime = 0;

if ( nbaa >= 1 && nbaa <= 10)
{
   prime = (salaire / 2) * nbaa;
} 
 else if ( nbaa > 10)
{
   prime = salaire * 10;
}


if ( age >= 45 && age <= 49)
{
    prime += salaire * 2;
}
else if ( age >= 50)
{
    prime += salaire * 5;
}

Console.WriteLine($"Votre prime est de {prime} Euros");




/* ➢ La moitié du salaire d’un mois par année d’ancienneté : pour la tranche d’ancienneté
entre 1 ans et 10 ans.
➢ Au-delà de 10 ans un mois de salaire par année d’ancienneté.
➢ Une indemnité supplémentaire serait allouée aux cadres âgés de plus de 45 ans de :
− 2 mois de salaire si le cadre est âgé de 46 à 49 ans.
− 5 mois si le cadre est âgé de plus de 50 ans.*/

