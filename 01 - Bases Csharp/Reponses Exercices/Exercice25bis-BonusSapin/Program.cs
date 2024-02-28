<<<<<<< HEAD
﻿Console.WriteLine("Joyeux Noël !");
Console.Write("Entrez la hauteur du sapin : ");

int hauteur = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < hauteur; i++)
=======
﻿Console.WriteLine("--NOYEUX JOEL--");
Console.Write("SAISIR LA HAUTEUR DU SAPIN : ");
int hauteur = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= hauteur; i++)
>>>>>>> 3badff971c06200af8b1b28cb7cca7c60e119cd8
{
    for (int j = 0; j < hauteur - i; j++)
    {
        Console.Write(" ");
    }
<<<<<<< HEAD

    for (int k = 0; k < 2 * i + 1; k++)
    {
        Console.Write("@");
    }

    Console.WriteLine();
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < hauteur - 1; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("***");
}

=======
    for (int k = 0; k < 2 * i - 1; k++)
    {
        Console.Write("@"); 
    }
    Console.WriteLine(); 
}
>>>>>>> 3badff971c06200af8b1b28cb7cca7c60e119cd8
