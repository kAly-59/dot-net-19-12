Console.WriteLine("La lettre est elle une voyelle ?");

Console.Write("Entrez une lettre : ");
string lettre = Console.ReadLine().ToUpper();
string voyelle = "AEIOUY";

if (voyelle.Contains(lettre) && voyelle.Length == 1)
{
    Console.WriteLine(lettre + " est une voyelle");
}
else Console.WriteLine(lettre + " n'est pas une voyelle");