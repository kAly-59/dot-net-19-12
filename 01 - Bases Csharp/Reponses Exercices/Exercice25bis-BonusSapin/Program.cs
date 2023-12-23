Console.WriteLine("Joyeux Noël !");
Console.Write("Entrez la hauteur du sapin : ");

int hauteur = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < hauteur; i++)
{
    for (int j = 0; j < hauteur - i; j++)
    {
        Console.Write(" ");
    }

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

