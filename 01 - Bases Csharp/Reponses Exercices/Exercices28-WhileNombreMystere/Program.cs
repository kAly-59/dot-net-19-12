Console.WriteLine("Find a number !");

Random aleatoire = new Random();
int nbMystere = aleatoire.Next(1, 51);
bool trouver = false;
int nbcoup = 0;

while (!trouver)
{
    Console.Write("Saisir un nombre :  ");
    int nb = int.Parse(Console.ReadLine()!);
  
    if (nb > nbMystere)
    {
        Console.WriteLine("PLUS PETIT !");
        nbcoup++;
    }
    else if (nb < nbMystere)
    {
        Console.WriteLine("PLUS GRAND !");
        nbcoup++;
    }
    else
    {
        Console.WriteLine("C GAGNER !");
        Console.WriteLine("TEST : " + nbcoup++);
        trouver = true;
    }
}


