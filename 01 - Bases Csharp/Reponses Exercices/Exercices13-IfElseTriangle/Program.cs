// See https://aka.ms/new-console-template for more information
Console.WriteLine("Qu'elle est la nature du triangle ABC");

Console.Write("Entrez la longueur du segment AB : ");
decimal segAB = decimal.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du segment BC : ");
decimal segBC = decimal.Parse(Console.ReadLine());
Console.Write("Entrez la longueur du segment CA : ");
decimal segCA = decimal.Parse(Console.ReadLine());

if (segAB == segBC && segBC == segCA)
{
    Console.WriteLine("EQUILATERALE");
}
else if (segAB == segBC || segBC == segCA || segAB == segCA)
{
    Console.WriteLine("ISOCELE");
}
else
{
    Console.WriteLine("AUCUN DES 2");
}
    