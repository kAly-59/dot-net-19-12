Console.WriteLine("Le nombre est il divisible par ... ?");

Console.Write("Entrez un chiffre ou un nombre : ");
int chiffreOuNombre = int.Parse(Console.ReadLine()!);

Console.Write("Entrez un chiffre ou un nombre (diviseur) : ");
int chiffreOuNombreDiviseur = int.Parse(Console.ReadLine()!);

if (chiffreOuNombre % chiffreOuNombreDiviseur == 0)
{
    Console.WriteLine(chiffreOuNombre + " est divisible par " + chiffreOuNombreDiviseur);
}
else
{
    Console.WriteLine(chiffreOuNombre + " n'est pas divisible par " + chiffreOuNombreDiviseur);
}